using BLL;
using Models;
using System.Text.RegularExpressions;

namespace View
{
    public partial class ÄndraKundUppgifter : Form
    {
        private Kund kund;
        private KundController kundController;
        private Form1 _parentForm;
        private DataGridView dataGrid;
        public ÄndraKundUppgifter(Kund kund, Form1 _parentform, DataGridView datagrid)
        {
            InitializeComponent();
            this.kund = kund;
            kundController = new KundController();
            FyllFormulär();
            _parentForm = _parentform;
            dataGrid = datagrid;

        }

        public void FyllFormulär()
        {
            tbxNamn.Text = kund.Name;
            tbxAdress.Text = kund.Adress;
            tbxPostnummer.Text = kund.Postnummer;
            tbxOrt.Text = kund.Ort;
            tbxEpost.Text = kund.Email;
            tbxLand.Text = kund.Land;
            tbxTelefonnummer.Text = kund.TelefonNummer;
        }

        private void btnSpara_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxNamn.Text) || !Regex.IsMatch(tbxNamn.Text, "^[a-zA-ZåäöÅÄÖ]+([-'][a-zA-ZåäöÅÄÖ]+)*( [a-zA-ZåäöÅÄÖ]+([-'][a-zA-ZåäöÅÄÖ]+)*)*$"))
            {
                MessageBox.Show("Ange ett giltigt namn.");
                return;
            }

            if (String.IsNullOrEmpty(tbxAdress.Text) || String.IsNullOrEmpty(tbxPostnummer.Text) || String.IsNullOrEmpty(tbxOrt.Text) || String.IsNullOrEmpty(tbxLand.Text))
            {
                MessageBox.Show("Vänligen kontrollera adressuppgifter");
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

            if (kundController.UppdateraKund(kund, tbxNamn.Text, tbxAdress.Text, tbxPostnummer.Text, tbxOrt.Text, tbxLand.Text, tbxTelefonnummer.Text, tbxEpost.Text))
            {
                MessageBox.Show("Uppgifterna är uppdaterade!");
                _parentForm.FyllDataGridKund(dataGrid);
                this.Dispose();
            }
            else { MessageBox.Show("Kontrollera dina uppgifter!"); }

        }

        private void btnGåTillbaka_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
