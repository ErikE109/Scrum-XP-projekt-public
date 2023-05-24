using BLL;


namespace View
{
    public partial class LäggTillHatt : Form
    {
        HattController hattController;
        Form1 _parentForm;
        DataGridView dataGrid;
        public LäggTillHatt(Form1 parentForm, DataGridView dataGrid)
        {
            InitializeComponent();
            hattController = new HattController();
            _parentForm = parentForm;
            this.dataGrid = dataGrid;
        }

        private void btnLäggTillHatt_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbxNamn.Text) || String.IsNullOrWhiteSpace(tbxPris.Text) || String.IsNullOrWhiteSpace(tbxMaterialkostnad.Text))
            {
                MessageBox.Show("Fyll i all data");
            }
            else
            {
                hattController.SkapaLagerFördHatt(tbxNamn.Text, double.Parse(tbxPris.Text), double.Parse(tbxMaterialkostnad.Text));
                MessageBox.Show("En ny lagerfördhatt hat skapats");
                _parentForm.FyllDataGridHatt(dataGrid);
                this.Close();
            }
        }
    }
}
