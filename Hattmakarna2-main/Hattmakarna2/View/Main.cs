using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Microsoft.IdentityModel.Tokens;
using Models;

namespace View
{
    public partial class Main : Form
    {
        private PersonalController personalController;
        public Main()
        {
            InitializeComponent();
            personalController = new PersonalController();
        }

        private void btnLoggaIn_Click(object sender, EventArgs e)
        {
            string användarnamn = tbxAnvändarnamn.Text;
            string lösenord = tbxLösenord.Text;
            if (personalController.Login(användarnamn, lösenord))
            {
                this.Hide();
                Form1 form1 = new Form1(personalController);
                form1.ShowDialog();
                this.Dispose();
            }
            else if (tbxAnvändarnamn.Text.IsNullOrEmpty() || tbxLösenord.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Fyll i båda rutorna för att logga in");
            }

            else
            {
                MessageBox.Show("Fel användarnamn eller lösenord");
            }


        }
    }
}
