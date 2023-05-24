using BLL;
using Models;
using System.Text.RegularExpressions;

namespace View
{
    public partial class SkapaBeställning : Form

    {
        private PersonalController personalController;
        private KundController kundController;
        private MaterialController materialController;
        private DekorationController dekorationController;
        private BeställningController beställningController;
        private HattController hattController;
        private List<Dekoration> dekorationer;
        private List<Material> material;
        private List<int> antalDekorationer;
        private List<double> mängdTyg;
        private List<Hatt> hattar;
        private Form1 _parentForm;
        private DataGridView beställningDataGridView;
        private DataGridView startDataGridView;

        public SkapaBeställning(Form1 _parentForm, DataGridView beställningDataGridView, DataGridView startDataGridView)
        {
            InitializeComponent();

            this._parentForm = _parentForm;
            this.beställningDataGridView = beställningDataGridView;
            this.startDataGridView = startDataGridView;

            kundController = new KundController();
            personalController = new PersonalController();
            materialController = new MaterialController();
            dekorationController = new DekorationController();
            beställningController = new BeställningController();
            hattController = new HattController();
            hattar = new List<Hatt>();
            material = new List<Material>();
            dekorationer = new List<Dekoration>();
            antalDekorationer = new List<int>();
            mängdTyg = new List<double>();

            comboBox1.SelectedIndex = 1;

            cbbLagerfördHatt.DisplayMember = "Namn";
            cbbLagerfördHatt.Items.AddRange(hattController.GetAllaLagerfördaHattar().ToArray());
            cbbLagerfördHatt.SelectedIndex = 0;

            cbxLagerfördHatt.Checked = true;
            cbxSpecialHatt.Checked = false;


            cbbKund.DisplayMember = "Name";
            cbbKund.Items.AddRange(kundController.hämtaKunder().ToArray());

            cbbSkapadAv.DisplayMember = "Name";
            cbbSkapadAv.Items.AddRange(personalController.GetAll().ToArray());
            cbbSkapadAv.SelectedIndex = 0;

            cbbTyg.DisplayMember = "Typ";
            cbbTyg.Items.AddRange(materialController.hämtaMaterialer().ToArray());

            cbbDekoration.DisplayMember = "Typ";
            cbbDekoration.Items.AddRange(dekorationController.hämtaAllaDekorationer().ToArray());

            pnlHattInfo.Hide();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxSpecialHatt_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxSpecialHatt.Checked)
            {
                cbxLagerfördHatt.Enabled = true;
                cbxSpecialHatt.Enabled = false;
                cbxLagerfördHatt.Checked = false;
                cbbLagerfördHatt.Enabled = cbxLagerfördHatt.Checked;
                pnlHattInfo.Show();
            }
        }

        private void cbxLagerfördHatt_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxLagerfördHatt.Checked)
            {
                cbxLagerfördHatt.Enabled = false;
                cbxSpecialHatt.Enabled = true;
                cbxSpecialHatt.Checked = false;
                cbbLagerfördHatt.Enabled = cbxLagerfördHatt.Checked;
                pnlHattInfo.Hide();

            }

        }

        private void btnSkapa_Click(object sender, EventArgs e)
        {
            if (cbxLagerfördHatt.Checked == true || cbxSpecialHatt.Checked == true)
            {


                Kund kund = (Kund)cbbKund.SelectedItem;
                if (kund == null)
                {
                    MessageBox.Show("Välj kund");
                    return;
                }
                Personal personal = (Personal)cbbSkapadAv.SelectedItem;

                var adress = tbxAdress.Text;
                var postnummer = tbxPostNummer.Text;
                var ort = tbxOrt.Text;
                var land = tbxLand.Text;
                var beskrivning = tbxBeskrivning.Text;
                if (String.IsNullOrEmpty(adress) || String.IsNullOrEmpty(postnummer) || String.IsNullOrEmpty(ort) || String.IsNullOrEmpty(land))
                {
                    MessageBox.Show("Vänligen kontrollera adressuppgifter");
                    return;
                }

                if (postnummer.Length > 8)
                {
                    MessageBox.Show("Postnummer får bestå av max 8 tecken");
                    return;
                }
                if (!Regex.IsMatch(ort, "[a-zA-ZåäöÅÄÖ]+") || !Regex.IsMatch(land, "[a-zA-ZåäöÅÄÖ]+"))
                {
                    MessageBox.Show("Rutorna ort och land accepterar bokstäver");
                    return;
                }

                var storlek = comboBox1.Text;


                Hatt hatt = new Hatt();

                if (cbxSpecialHatt.Checked == true)
                {



                    if (material.Count == 0 && dekorationer.Count == 0)
                    {
                        MessageBox.Show("Du har varken valt några dekorationer eller tyger");
                        return;
                    }

                    if (String.IsNullOrEmpty(tbxUA.Text))
                    {
                        MessageBox.Show("Du har inte angett någon arbetstid");
                        return;
                    }
                    if (!Regex.IsMatch(tbxUA.Text, "[1-9]([0-9],[0-9]+)?"))
                    {
                        MessageBox.Show("Du kan bara ange siffor här");
                        return;
                    }
                    var tid = double.Parse(tbxUA.Text);


                    hattar.Add(hattController.SkapaSpecialhatt(hatt, tid, storlek, antalDekorationer, mängdTyg, dekorationer, material));


                    if (beställningController.SkapaBeställning(kund.Id, adress, personal.Id, beskrivning, storlek, postnummer, ort, land, hattar))
                    {
                        MessageBox.Show("Du har skapat en ny beställning");
                        beställningDataGridView.Rows.Clear();
                        startDataGridView.Rows.Clear();
                        _parentForm.FyllDataGridBeställning(beställningDataGridView);
                        _parentForm.FyllDataGridBeställning(startDataGridView);

                        GranskaBeställning granskaBeställning = new GranskaBeställning(beställningController.GetCurrentBeställning().Id, beställningDataGridView, startDataGridView, _parentForm);
                        granskaBeställning.ShowDialog();
                        Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Något gick fel");
                        this.Dispose();
                    }
                }
                if (cbxLagerfördHatt.Checked == true)
                {
                    LagerfördHatt lagerfördHatt = (LagerfördHatt)cbbLagerfördHatt.SelectedItem;

                    hattar.Add(hattController.SkapaVanligHatt(hatt, lagerfördHatt, storlek));
                    if (beställningController.SkapaBeställning(kund.Id, adress, personal.Id, beskrivning, storlek, postnummer, ort, land, hattar))
                    {
                        MessageBox.Show("Du har skapat en ny Beställning");
                        beställningDataGridView.Rows.Clear();
                        startDataGridView.Rows.Clear();
                        _parentForm.FyllDataGridBeställning(beställningDataGridView);
                        _parentForm.FyllDataGridBeställning(startDataGridView);
                        GranskaBeställning granskaBeställning = new GranskaBeställning(beställningController.GetCurrentBeställning().Id, beställningDataGridView,
                            startDataGridView, _parentForm);
                        granskaBeställning.ShowDialog();
                        Dispose();

                    }
                    else
                    {
                        MessageBox.Show("Något gick fel");
                    }
                }


            }

        }

        private void btnTAdd_Click(object sender, EventArgs e)
        {
            Material valtmaterial = (Material)cbbTyg.SelectedItem;

            lvTyg.Items.Clear();
            if (material.Contains(valtmaterial))
            {
                var index = material.IndexOf(valtmaterial);
                mängdTyg[index] = (int.Parse(tbxTygLängd.Text));
                for (int i = 0; i < material.Count; i++)
                {
                    ListViewItem newList = new ListViewItem(material[i].Typ);
                    newList.SubItems.Add(mängdTyg[i].ToString());
                    lvTyg.Items.Add(newList);

                }

            }
            else if (String.IsNullOrEmpty(tbxTygLängd.Text) || String.IsNullOrEmpty(cbbTyg.Text))
            {
                MessageBox.Show("Du har inte valt ett tyg eller lagt till tyglängd");
            }
            else
            {
                material.Add(valtmaterial);
                mängdTyg.Add(double.Parse(tbxTygLängd.Text));

                for (int i = 0; i < material.Count; i++)
                {
                    ListViewItem newList = new ListViewItem(material[i].Typ);
                    newList.SubItems.Add(mängdTyg[i].ToString());
                    lvTyg.Items.Add(newList);

                }
                btnTAdd.Text = "Uppdatera";
            }



        }
        private void cbbKund_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kund kund = (Kund)cbbKund.SelectedItem;
            tbxAdress.Text = kund.Adress;
            tbxPostNummer.Text = kund.Postnummer;
            tbxOrt.Text = kund.Ort;
            tbxLand.Text = kund.Land;

        }

        private void btnDAdd_Click(object sender, EventArgs e)
        {
            lvDekoration.Items.Clear();
            var valdDekoration = (Dekoration)cbbDekoration.SelectedItem;
            if (dekorationer.Contains(valdDekoration))
            {
                var index = dekorationer.IndexOf(valdDekoration);
                antalDekorationer[index] = (int.Parse(tbxDekoration.Text));
                for (int i = 0; i < dekorationer.Count; i++)
                {
                    ListViewItem newList = new ListViewItem(dekorationer[i].Typ);
                    newList.SubItems.Add(antalDekorationer[i].ToString());
                    lvDekoration.Items.Add(newList);

                }


            }
            else if (String.IsNullOrEmpty(tbxDekoration.Text) || String.IsNullOrEmpty(cbbDekoration.Text))
            {
                MessageBox.Show("Du har inte lagt till en dekoration eller dekorationsantal");
            }
            else
            {
                dekorationer.Add(valdDekoration);
                antalDekorationer.Add(int.Parse(tbxDekoration.Text));

                for (int i = 0; i < dekorationer.Count; i++)
                {
                    ListViewItem newList = new ListViewItem(dekorationer[i].Typ);
                    newList.SubItems.Add(antalDekorationer[i].ToString());
                    lvDekoration.Items.Add(newList);


                }
                btnDAdd.Text = "Uppdatera";
            }


        }
        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
        private void cbbDekoration_SelectedIndexChanged(object sender, EventArgs e)
        {
            var valdDekoration = (Dekoration)cbbDekoration.SelectedItem;
            if (dekorationer.Contains(valdDekoration))
            {
                int index = dekorationer.IndexOf(valdDekoration);
                tbxDekoration.Text = antalDekorationer[index].ToString();
                btnDAdd.Text = "Uppdatera";
            }
            else
            {
                tbxDekoration.Clear();
                btnDAdd.Text = "Lägg till";
            }
        }
        private void cbbTyg_SelectedIndexChanged(object sender, EventArgs e)
        {
            Material valtmaterial = (Material)cbbTyg.SelectedItem;

            if (material.Contains(valtmaterial))
            {
                int index = material.IndexOf(valtmaterial);
                tbxTygLängd.Text = mängdTyg[index].ToString();
                btnTAdd.Text = "Uppdatera";
            }
            else
            {
                tbxTygLängd.Clear();
                btnTAdd.Text = "Lägg till";
            }
        }
    }
}
