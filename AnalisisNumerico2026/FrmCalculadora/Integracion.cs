using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Front
{
    public partial class Integracion : Form
    {
        private readonly IIntegracionServices integracionServices;
        public Integracion()
        {
            InitializeComponent();
            integracionServices = new IntegracionServices();

            cbMetodos.Items.Add("Trapecios Simple");
            cbMetodos.Items.Add("Trapecios Multiple");
            cbMetodos.Items.Add("Simpson 1/3 Simple");
            cbMetodos.Items.Add("Simpson 1/3 Multiple");
            cbMetodos.Items.Add("Simpson 3/8");
            cbMetodos.Items.Add("Simpson Combinado");

            cbMetodos.SelectedIndex = 0;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                string funcion = txtFuncion.Text;

                double xi = Convert.ToDouble(txtXi.Text);
                double xd = Convert.ToDouble(TxtXd.Text);

                double resultado = 0;

                switch (cbMetodos.Text)
                {
                    case "Trapecios Simple":
                        resultado = integracionServices
                            .CalcularIntegralTrapeciosSimple(funcion, xi, xd);
                        break;

                    case "Trapecios Multiple":
                        resultado = integracionServices
                            .CalcularIntegralTrapeciosMultiple(
                                funcion,
                                xi,
                                xd,
                                Convert.ToInt32(TxtN.Text));
                        break;

                    case "Simpson 1/3 Simple":
                        resultado = integracionServices
                            .CalcularIntegralSimpson13Simple(funcion, xi, xd);
                        break;

                    case "Simpson 1/3 Multiple":
                        resultado = integracionServices
                            .CalcularIntegralSimpson13Multiple(
                                funcion,
                                xi,
                                xd,
                                Convert.ToInt32(TxtN.Text));
                        break;

                    case "Simpson 3/8":
                        resultado = integracionServices
                            .CalcularIntegralSimpson38(funcion, xi, xd);
                        break;

                    case "Simpson Combinado":
                        resultado = integracionServices
                            .CalcularIntegralSimpsonCombinado(
                                funcion,
                                xi,
                                xd,
                                Convert.ToInt32(TxtN.Text));
                        break;
                }

                txtResultado.Text = resultado.ToString("F6");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
