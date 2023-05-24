using BLL;
using Models;

namespace View
{
    public partial class ÄndraHatt : Form
    {
        LagerfördHatt lagerfördHatt;
        HattController hattController;
        Form1 _parentForm;
        DataGridView dataGrid;
        public ÄndraHatt(LagerfördHatt lagerfördHatt, Form1 form1, DataGridView dataGrid)
        {
            InitializeComponent();

            _parentForm = form1;
            this.lagerfördHatt = lagerfördHatt;
            this.dataGrid = dataGrid;
            hattController = new HattController();

            FyllFormulär();
        }
        public void FyllFormulär()
        {
            tbxNamn.Text = lagerfördHatt.Namn;
            tbxPris.Text = lagerfördHatt.Pris.ToString();
            tbxMaterialkostnad.Text = lagerfördHatt.Materialkostnad.ToString();
        }

        private void btnSpara_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbxNamn.Text) || String.IsNullOrWhiteSpace(tbxPris.Text) || String.IsNullOrWhiteSpace(tbxMaterialkostnad.Text))
            {
                MessageBox.Show("Fyll i all data");
            }
            else
            {
                hattController.UppdateraLagerFördHatt(lagerfördHatt, tbxNamn.Text, double.Parse(tbxPris.Text), double.Parse(tbxMaterialkostnad.Text));
                _parentForm.FyllDataGridHatt(dataGrid);
                MessageBox.Show("Lagerfördhatt har uppdaterats");
                this.Close();
            }
        }
    }
}
