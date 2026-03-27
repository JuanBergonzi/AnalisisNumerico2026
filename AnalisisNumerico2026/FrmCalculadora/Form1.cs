using Calculus;
using Logica;
namespace FrmCalculadora
{
    public partial class Form1 : Form
    {
        ICalcServices _calcServices = new CalcServices();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                bool converge;
                double raiz;
                double error;
                string intervalo;
                int iteracionesRealizadas;

                _calcServices.MetodoAbierto(
                    txbFuncion.Text,
                    int.Parse(txbIteraciones.Text),
                    double.Parse(txbTolerancia.Text),
                    double.Parse(txbXi.Text),
                    double.Parse(txbXd.Text),
                    cbMetodo.Text,
                    out converge,
                    out raiz,
                    out error,
                    out intervalo,
                    out iteracionesRealizadas
                );

                // Mostrar resultados
                txbFuncionU.Text = txbFuncion.Text;
                txbMetodoU.Text = cbMetodo.Text;
                txbIteracionesU.Text = iteracionesRealizadas.ToString();
                txbToleranciaU.Text = txbTolerancia.Text;

                txbConverge.Text = converge ? "SI" : "NO";
                txbRaiz.Text = raiz.ToString();
                txbError.Text = error.ToString();
                txbIntervaloU.Text = intervalo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
