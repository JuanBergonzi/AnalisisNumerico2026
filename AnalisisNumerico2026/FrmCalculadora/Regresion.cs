using Logica;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Front
{
    public partial class Regresion: Form
    {
        private RegresionServices regresionServices;

        public Regresion()
        {
            InitializeComponent();
            regresionServices = new RegresionServices();
        }

        private async void Regresion_Load(object sender,EventArgs e)
        {
            await webView21.EnsureCoreWebView2Async();

            string htmlPath =
                Path.Combine(
                    Application.StartupPath,
                    "geogebra.html"
                );

            webView21.CoreWebView2.Navigate($"file:///{htmlPath}");
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            panelPuntos.Controls.Clear();

            int cantidad = (int)tbCantidadPuntos.Value;

            int ancho = 70;
            int alto = 25;
            int espacio = 10;

            Label lblX = new Label();
            lblX.Text = "X";
            lblX.Location = new Point(20, 10);

            Label lblY = new Label();
            lblY.Text = "Y";
            lblY.Location = new Point(120, 10);

            panelPuntos.Controls.Add(lblX);
            panelPuntos.Controls.Add(lblY);

            for (int i = 0; i < cantidad; i++)
            {
                TextBox txtX = new TextBox();
                txtX.Name = $"txtX_{i}";
                txtX.Size = new Size(ancho, alto);
                txtX.Location = new Point(
                    20,
                    40 + i * (alto + espacio)
                );

                TextBox txtY = new TextBox();
                txtY.Name = $"txtY_{i}";
                txtY.Size = new Size(ancho, alto);
                txtY.Location = new Point(
                    120,
                    40 + i * (alto + espacio)
                );

                panelPuntos.Controls.Add(txtX);
                panelPuntos.Controls.Add(txtY);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad = (int)tbCantidadPuntos.Value;

                List<double[]> puntos =
                    new List<double[]>();

                for (int i = 0; i < cantidad; i++)
                {
                    TextBox txtX =
                        (TextBox)panelPuntos.Controls[$"txtX_{i}"];

                    TextBox txtY =
                        (TextBox)panelPuntos.Controls[$"txtY_{i}"];

                    puntos.Add(new double[]
                    {
                double.Parse(txtX.Text),
                double.Parse(txtY.Text)
                    });
                }

                double a0;
                double a1;
                double r;
                bool aceptable;

                regresionServices.RegresionLineal(
                    puntos,
                    double.Parse(tbTolerancia.Text),
                    out a0,
                    out a1,
                    out r,
                    out aceptable
                );

                lblFuncion.Text =
                    $"y = {a1:F6}x + {a0:F6}";

                lblR.Text =
                    r.ToString("F6");

                lblAceptable.Text =
                    aceptable ? "SI" : "NO";

                webView21.ExecuteScriptAsync(
                    "ggbApplet.reset()"
                );

                for (int i = 0; i < puntos.Count; i++)
                {
                    webView21.ExecuteScriptAsync(
                        $"ggbApplet.evalCommand('P{i}=({puntos[i][0]},{puntos[i][1]})')"
                    );
                }

                string pendiente =
                    a1.ToString(CultureInfo.InvariantCulture);

                string ordenada =
                    a0.ToString(CultureInfo.InvariantCulture);

                webView21.ExecuteScriptAsync(
                    $"ggbApplet.evalCommand('f(x)={pendiente}*x+({ordenada})')"
                                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control c in panelPuntos.Controls)
            {
                if (c is TextBox txt)
                    txt.Text = "";
            }

            lblFuncion.Text = "";
            lblR.Text = "";
            lblAceptable.Text = "";
        }

        private void btnRedondear_Click(object sender, EventArgs e)
        {
            int decimales = 2;

            int.TryParse(
                tbDecimales.Text,
                out decimales
            );

            foreach (Control c in panelPuntos.Controls)
            {
                if (c is TextBox txt)
                {
                    if (double.TryParse(
                        txt.Text,
                        out double valor))
                    {
                        txt.Text =
                            Math.Round(
                                valor,
                                decimales
                            ).ToString();
                    }
                }
            }
        }
    }
}