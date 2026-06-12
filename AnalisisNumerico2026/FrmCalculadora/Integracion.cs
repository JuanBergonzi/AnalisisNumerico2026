using Logica;
using System;
using System.Globalization;
using System.IO;
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

            Load += Integracion_Load;
        }

        private async void Integracion_Load(object sender, EventArgs e)
        {
            await webView21.EnsureCoreWebView2Async();

            string htmlPath =
                Path.Combine(
                    Application.StartupPath,
                    "geogebra.html"
                );

            webView21.CoreWebView2.Navigate(
                $"file:///{htmlPath}"
            );
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
                            .CalcularIntegralTrapeciosSimple(
                                funcion,
                                xi,
                                xd
                            );
                        break;

                    case "Trapecios Multiple":
                        resultado = integracionServices
                            .CalcularIntegralTrapeciosMultiple(
                                funcion,
                                xi,
                                xd,
                                Convert.ToInt32(TxtN.Text)
                            );
                        break;

                    case "Simpson 1/3 Simple":
                        resultado = integracionServices
                            .CalcularIntegralSimpson13Simple(
                                funcion,
                                xi,
                                xd
                            );
                        break;

                    case "Simpson 1/3 Multiple":
                        resultado = integracionServices
                            .CalcularIntegralSimpson13Multiple(
                                funcion,
                                xi,
                                xd,
                                Convert.ToInt32(TxtN.Text)
                            );
                        break;

                    case "Simpson 3/8":
                        resultado = integracionServices
                            .CalcularIntegralSimpson38(
                                funcion,
                                xi,
                                xd
                            );
                        break;

                    case "Simpson Combinado":
                        resultado = integracionServices
                            .CalcularIntegralSimpsonCombinado(
                                funcion,
                                xi,
                                xd,
                                Convert.ToInt32(TxtN.Text)
                            );
                        break;
                }

                txtResultado.Text = resultado.ToString("F6");

                DibujarEnGeoGebra(funcion, xi, xd);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DibujarEnGeoGebra(
            string funcion,
            double xi,
            double xd)
        {
            try
            {
                string funcionGeoGebra = funcion
                    .Replace(",", ".");

                string xiStr =
                    xi.ToString(
                        CultureInfo.InvariantCulture
                    );

                string xdStr =
                    xd.ToString(
                        CultureInfo.InvariantCulture
                    );

                webView21.ExecuteScriptAsync(
                    "ggbApplet.reset()"
                );

                webView21.ExecuteScriptAsync(
                    $"ggbApplet.evalCommand('f(x)={funcionGeoGebra}')"
                );

                webView21.ExecuteScriptAsync(
                    $"ggbApplet.evalCommand('A=({xiStr},0)')"
                );

                webView21.ExecuteScriptAsync(
                    $"ggbApplet.evalCommand('B=({xdStr},0)')"
                );

                webView21.ExecuteScriptAsync(
                    $"ggbApplet.evalCommand('Integral(f,{xiStr},{xdStr})')"
                );

                webView21.ExecuteScriptAsync(
                    "ggbApplet.setAxesVisible(true,true)"
                );

                webView21.ExecuteScriptAsync(
                    "ggbApplet.setGridVisible(true)"
                );
            }
            catch
            {
            }
        }
    }
}