using BLL;
using Models;
namespace View
{
    public partial class Form1 : Form
    {

        private BeställningController beställningController;
        private Beställning valdBeställning;
        private Kund kund;
        private LagerfördHatt lagerfördHatt;
        private KundController kundController;
        private MaterialController materialController;
        private DekorationController dekorationController;
        private PersonalController personalController;
        private HattController hattController;

        public Form1(PersonalController personalController)
        {
            InitializeComponent();
            beställningController = new BeställningController();
            kundController = new KundController();
            materialController = new MaterialController();
            dekorationController = new DekorationController();
            this.personalController = personalController;
            hattController = new HattController();
            FyllDataGridBeställning(dataGridBeställning);
            FyllDataGridBeställning(dataGridStart);
            FyllDataGridKund(dataGridKund);
            FyllDataGridHatt(dataGridHatt);
            FyllDataGridMaterial(dataGridMaterial);
            FyllDataGridDekoration(dataGridDekoration);
            DataGridInställningar();

            dataGridBeställning.ClearSelection();

        }

        public void DataGridInställningar()
        {
            dataGridBeställning.DefaultCellStyle.ForeColor = Color.Black;
            dataGridStart.DefaultCellStyle.ForeColor = Color.Black;
            dataGridKund.DefaultCellStyle.ForeColor = Color.Black;
            dataGridHatt.DefaultCellStyle.ForeColor = Color.Black;
            dataGridMaterial.DefaultCellStyle.ForeColor = Color.Black;
            dataGridDekoration.DefaultCellStyle.ForeColor = Color.Black;

        }

        public void FyllDataGridBeställning(DataGridView datagrid)
        {
            List<Beställning> beställningar = beställningController.GetAll().ToList();
            datagrid.Rows.Clear();

            foreach (Beställning beställning in beställningar)
            {
                var beställningsdata = beställningController.FormateraGridDataBeställning(beställning);
                datagrid.Rows.Add(beställningsdata);
            }

            dataGridStart.Sort(dataGridStart.Columns["Datum"], System.ComponentModel.ListSortDirection.Descending);
        }

        public void FyllDataGridKund(DataGridView datagrid)
        {
            List<Kund> kunder = kundController.hämtaKunder().ToList();
            datagrid.Rows.Clear();

            foreach (Kund kund in kunder)
            {
                var kunddata = kundController.FormateraGridDataKund(kund);
                datagrid.Rows.Add(kunddata);
            }
        }

        public void FyllDataGridHatt(DataGridView datagrid)
        {
            List<LagerfördHatt> hattar = hattController.GetAllaLagerfördaHattar().ToList();
            datagrid.Rows.Clear();

            foreach (LagerfördHatt hatt in hattar)
            {
                var hattData = hattController.FormateraGridDataHatt(hatt);
                datagrid.Rows.Add(hattData);
            }
        }

        public void FyllDataGridMaterial(DataGridView datagrid)
        {
            List<Material> materiallista = materialController.hämtaMaterialer().ToList();
            datagrid.Rows.Clear();

            foreach (Material material in materiallista)
            {
                var materialdata = materialController.FormateraGridDataMaterial(material);
                datagrid.Rows.Add(materialdata);
            }
        }

        public void FyllDataGridDekoration(DataGridView datagrid)
        {
            List<Dekoration> dekorationlista = dekorationController.hämtaAllaDekorationer().ToList();
            datagrid.Rows.Clear();

            foreach (Dekoration dekoration in dekorationlista)
            {
                var dekodata = dekorationController.FormateraGridDataDekoration(dekoration);
                datagrid.Rows.Add(dekodata);
            }
        }

        public void SetValdBeställning()
        {
            if (dataGridBeställning.CurrentRow != null)
            {
                string beställning = dataGridBeställning.CurrentRow.Cells[0].Value.ToString();
                valdBeställning = beställningController.GranskaBeställning(Int32.Parse(beställning));
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
            btnStart.Font = new Font(btnStart.Font, FontStyle.Bold);
            clearBoldFont(btnStart);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            FyllDataGridBeställning(dataGridStart);
            tabControl1.SelectedIndex = 0;
            btnStart.Font = new Font(btnStart.Font, FontStyle.Bold);
            clearBoldFont(btnStart);
        }

        private void btnBeställningar_Click(object sender, EventArgs e)
        {
            FyllDataGridBeställning(dataGridBeställning);
            tabControl1.SelectedIndex = 1;
            btnBeställningar.Font = new Font(btnBeställningar.Font, FontStyle.Bold);
            clearBoldFont(btnBeställningar);
        }

        private void btnHattar_Click(object sender, EventArgs e)
        {

            tabControl1.SelectedIndex = 3;
            btnHattar.Font = new Font(btnHattar.Font, FontStyle.Bold);
            clearBoldFont(btnHattar);
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            FyllDataGridMaterial(dataGridMaterial);
            FyllDataGridDekoration(dataGridDekoration);
            tabControl1.SelectedIndex = 4;
            btnMaterial.Font = new Font(btnMaterial.Font, FontStyle.Bold);
            clearBoldFont(btnMaterial);
        }

        private void btnKunder_Click(object sender, EventArgs e)
        {
            FyllDataGridKund(dataGridKund);
            tabControl1.SelectedIndex = 2;
            btnKunder.Font = new Font(btnKunder.Font, FontStyle.Bold);
            clearBoldFont(btnKunder);
        }

        private void btnStatistik_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 5;
            btnStatistik.Font = new Font(btnStatistik.Font, FontStyle.Bold);
            clearBoldFont(btnStatistik);
        }

        private void clearBoldFont(Button btn)
        {
            foreach (Control button in this.Controls)
            {
                if (button.GetType() == typeof(Button) && !button.Name.Equals(btn.Name))
                {
                    button.Font = new Font(button.Font, FontStyle.Regular);
                }
            }
        }

        private void btnKundÄndra_Click(object sender, EventArgs e)
        {
            string kunddata = dataGridKund.CurrentRow.Cells[0].Value.ToString();
            kund = kundController.hämtaEnKund(Int32.Parse(kunddata));
            ÄndraKundUppgifter ändraKund = new ÄndraKundUppgifter(kund, this, dataGridKund);
            ändraKund.ShowDialog();
        }

        private void btnStartSkapa_Click(object sender, EventArgs e)
        {
            SkapaBeställning skapaBeställning = new SkapaBeställning(this, dataGridBeställning, dataGridStart);
            skapaBeställning.ShowDialog();
        }

        private void btnBeställningLäggtill_Click(object sender, EventArgs e)
        {
            SkapaBeställning skapaBeställning = new SkapaBeställning(this, dataGridBeställning, dataGridStart);
            skapaBeställning.ShowDialog();
        }

        private void btnKundLäggtill_Click(object sender, EventArgs e)
        {
            LäggTillKund läggTillKund = new LäggTillKund(this, dataGridKund);
            läggTillKund.ShowDialog();
        }

        private void btnBeställningÄndra_Click(object sender, EventArgs e)
        {
            GranskaBeställning granskaBeställning = new GranskaBeställning(valdBeställning.Id, dataGridBeställning, dataGridStart, this);
            granskaBeställning.ShowDialog();
        }


        private void btnLäggTillHatt_Click(object sender, EventArgs e)
        {
            LäggTillHatt läggTillHatt = new LäggTillHatt(this, dataGridHatt);
            läggTillHatt.ShowDialog();
        }

        private void btnändraHatt_Click(object sender, EventArgs e)
        {
            string hattData = dataGridHatt.CurrentRow.Cells[0].Value.ToString();
            lagerfördHatt = hattController.GetEnLagerfördHatt(Int32.Parse(hattData));

            ÄndraHatt ändraHatt = new ÄndraHatt(lagerfördHatt, this, dataGridHatt);
            ändraHatt.ShowDialog();
        }

        private void dataGridBeställning_SelectionChanged(object sender, EventArgs e)
        {
            SetValdBeställning();
        }

        private void btnSökBeställning_Click(object sender, EventArgs e)
        {
            string sokStrang = tbxSökBeställning.Text;

            var searchResult = beställningController.SökBeställning(sokStrang);
            dataGridBeställning.Rows.Clear();


            foreach (var beställning in searchResult)
            {
                var kundnamn = kundController.hämtaEnKund(beställning.KundID).Name;
                // var item = new ListViewItem(best�llning.LeveransAdress);
                dataGridBeställning.Rows.Add(beställning.Id, kundnamn, beställning.SkapadDatum, beställning.LeveransAdress, beställning.Status);
            }

        }

        private void btnKundSök_Click(object sender, EventArgs e)
        {


            string sokStrang = tbxSökKund.Text;

            var searchResult = kundController.SökEfterKund(sokStrang);
            dataGridKund.Rows.Clear();

            foreach (var kund in searchResult)
            {

                dataGridKund.Rows.Add(kund.Id, kund.Name, kund.Adress, kund.TelefonNummer, kund.Email);
            }

        }

        private void btnHittaStatistik(object sender, EventArgs e)
        {

            beställningController.HittaBeställningarFrånDatum(dtpFromDate.Value, dtpToDate.Value);
            beställningController.SparaStatistik();



        }


        private void cbbOrderStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbOrderStatus.SelectedItem.Equals("--Alla--"))
            {
                FyllDataGridBeställning(dataGridBeställning);
            }
            else
            {
                var griddata = beställningController.BeställningEfterOrderstatus(cbbOrderStatus.SelectedItem.ToString());
                dataGridBeställning.Rows.Clear();
                foreach (Beställning beställning in griddata)
                {
                    dataGridBeställning.Rows.Add(beställning.Id, beställning.KundID, beställning.SkapadDatum, beställning.LeveransAdress, beställning.Status);
                }
            }
        }

        private void btnPersonalRegistrera_Click(object sender, EventArgs e)
        {
            LäggTillPersonal läggTillPersonal = new LäggTillPersonal();
            läggTillPersonal.ShowDialog();
        }




        private void btnLoggaUt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.ShowDialog();
            this.Dispose();
        }

        private void btnPersonalÄndra_Click(object sender, EventArgs e)
        {
            ÄndraLösen ändraLösen = new ÄndraLösen(personalController);
            ändraLösen.ShowDialog();
        }
    }
}