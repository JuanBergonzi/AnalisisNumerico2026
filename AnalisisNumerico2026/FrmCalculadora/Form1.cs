using Logica;
namespace FrmCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ICalcServices calcServices = new CalcServices();
            string funcion = txbFuncion.Text;
            int iteraciones = int.Parse(txbIteraciones.Text);
            double tolerancia = double.Parse(txbTolerancia.Text);
            double xi = double.Parse(txbXi.Text);
            double xd = double.Parse(txbXd.Text);
            string metodo = cbMetodo.SelectedItem.ToString();
            try
            {
                calcServices.MetodoAbierto(funcion, iteraciones, tolerancia, xi, xd, metodo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
