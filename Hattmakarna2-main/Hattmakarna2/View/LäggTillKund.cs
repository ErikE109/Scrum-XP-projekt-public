
using System.Text.RegularExpressions;
using BLL;


namespace View
{
    public partial class LäggTillKund : Form
    {
        private KundController kundController;
        private Form1 _parentForm;
        DataGridView dataGridView;

        public LäggTillKund(Form1 _parentForm, DataGridView dataGridView)
        {
            InitializeComponent();
            kundController = new KundController();
            this._parentForm = _parentForm;
            this.dataGridView = dataGridView;


        }


        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLäggTill_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxNamn.Text) || !Regex.IsMatch(tbxNamn.Text, "^[a-zA-ZåäöÅÄÖ]+([-'][a-zA-ZåäöÅÄÖ]+)*( [a-zA-ZåäöÅÄÖ]+([-'][a-zA-ZåäöÅÄÖ]+)*)*$"))
            {
                MessageBox.Show("Ange ett giltigt namn.");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbxAdress.Text) || !Regex.IsMatch(tbxAdress.Text, @"^[a-zA-ZåäöÅÄÖ]+\s+\d+(\s+[a-zA-ZåäöÅÄÖ]+)?$"))
            {
                MessageBox.Show("Ange en giltig adress.");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbxTelefonnummer.Text) || !Regex.IsMatch(tbxTelefonnummer.Text, @"^07[02369]\d{7}$"))
            {
                MessageBox.Show("Ange ett giltigt telefonnummer.");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbxEpost.Text) || !Regex.IsMatch(tbxEpost.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                MessageBox.Show("Ange en giltig e-postadress.");
                return;
            }

            if (tbxPostnummer.Text.Length > 8)

            {
                MessageBox.Show("Postnummer får bestå av max 8 tecken");
                return;
            }
            if (!Regex.IsMatch(tbxOrt.Text, "[a-zA-ZåäöÅÄÖ]+") || !Regex.IsMatch(tbxLand.Text, "[a-zA-ZåäöÅÄÖ]+"))
            {
                MessageBox.Show("Rutorna ort och land accepterar bokstäver");
            }


            if (kundController.SkapaKund(tbxNamn.Text, tbxAdress.Text, tbxPostnummer.Text, tbxOrt.Text, tbxLand.Text, tbxTelefonnummer.Text, tbxEpost.Text))
            {
                MessageBox.Show("Du har skapat en kund!");
                _parentForm.FyllDataGridKund(dataGridView);
                Dispose();
            }
            else { MessageBox.Show("Kontrollera dina uppgifter!"); }

        }
    }
}
