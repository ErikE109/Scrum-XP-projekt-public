using BLL;
using Models;
using System.Text.RegularExpressions;

namespace View
{
    public partial class ÄndraLösen : Form
    {

        private Personal personal;
        private PersonalController personalController;

        public ÄndraLösen(PersonalController personalController)
        {
            InitializeComponent();
            this.personalController = personalController;
            this.personal = personalController.GetCurrentUser();
        }

        private void btnAvbryt_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSpara_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxNyLös.Text) || !Regex.IsMatch(tbxNyLös.Text, "^[a-zA-Z0-9._%+-]"))
            {
                MessageBox.Show("Ange ett giltigt lösenord.");
                return;
            }

            if (!tbxUppLös.Text.Equals(tbxNyLös.Text))
            {
                MessageBox.Show("Kolla så att lösenorden är samma.");
                return;
            }

            if (personalController.bytLösenord(personal, tbxNyLös.Text))
            {
                MessageBox.Show("Lösenordet är ändrat!");
                Dispose();
            }
            else
            {
                MessageBox.Show("Kontrollera dina lösenord!");

            }

        }
    }
}
