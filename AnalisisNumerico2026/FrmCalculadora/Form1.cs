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

                string tipoMetodo = cmMet.Text; // "Abierto" o "Cerrado"

                if (tipoMetodo == "Abierto")
                {
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
                }
                else if (tipoMetodo == "Cerrado")
                {
                    _calcServices.MetodoCerrado(
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
                }
                else
                {
                    MessageBox.Show("Seleccioná un tipo de método (Abierto o Cerrado)");
                    return;
                }

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

        private void cmMet_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMetodo.Items.Clear();

            string tipoMetodo = cmMet.SelectedItem?.ToString();

            if (tipoMetodo == "Cerrado")
            {
                cbMetodo.Items.Add("Bisección");
                cbMetodo.Items.Add("Regla Falsa");
            }
            else if (tipoMetodo == "Abierto")
            {
                cbMetodo.Items.Add("Tangente");
                cbMetodo.Items.Add("Secante");
            }

            // Selecciona el primero automáticamente (opcional pero recomendable)
            if (cbMetodo.Items.Count > 0)
                cbMetodo.SelectedIndex = 0;


        }
    }
}
