using Logica;
using System.Security.Cryptography.X509Certificates;
namespace FrmCalculadora
{
    public partial class Form1 : Form
    {
        CalcServices calc = new CalcServices();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string funcion = txbFuncion.Text;
            int iteraciones = int.Parse(txbIteraciones.Text);
            double tolerancia = double.Parse(txbTolerancia.Text);
            double xi = double.Parse(txbXi.Text);
            double xd = double.Parse(txbXd.Text);
            string metodo = cbxMetodo.Text;

            string resultado;

            //if (metodo == "Bisección" || metodo == "Regla Falsa")
            //{
            //    resultado = calc.MetodoCerrado(funcion, iteraciones, tolerancia, xi, xd, metodo);
            //}
            //else
            //{
            //    resultado = calc.MetodoAbierto(funcion, iteraciones, tolerancia, xi, xd, metodo);
            //}

            //txbResultado.Text = resultado;


        }
    }
}
