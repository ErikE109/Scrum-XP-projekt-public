using BLL;
using System.Text.RegularExpressions;

namespace View
{
    public partial class LäggTillPersonal : Form
    {

        private PersonalController personalController;

        public LäggTillPersonal()
        {
            InitializeComponent();
            personalController = new PersonalController();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSpaNyPer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxAnvNam.Text) || !Regex.IsMatch(tbxAnvNam.Text, "^[a-zA-ZåäöÅÄÖ]+([-'][a-zA-ZåäöÅÄÖ]+)*( [a-zA-ZåäöÅÄÖ]+([-'][a-zA-ZåäöÅÄÖ]+)*)*$"))
            {
                MessageBox.Show("Ange ett giltigt namn.");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbxLös.Text) || !Regex.IsMatch(tbxLös.Text, "^[a-zA-Z0-9._%+-]"))
            {
                MessageBox.Show("Ange ett giltigt lösenord.");
                return;
            }

            if (!tbxUppLös.Text.Equals(tbxLös.Text))
            {
                MessageBox.Show("Kolla så att lösenorden är samma.");
                return;
            }

            if (personalController.SkapaPersonal(tbxAnvNam.Text, tbxLös.Text))
            {
                MessageBox.Show("Du har skapat en ny anställd!");
                Dispose();
            }
            else
            {
                MessageBox.Show("Kontrollera dina uppgifter!");

            }
        }
    }
}