using Calculus;
using Logica;
using WMPLib;
namespace FrmCalculadora
{
    public partial class Form1 : Form
    {
        ICalcServices _calcServices = new CalcServices();
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        bool musicaActiva = false;
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

                string tipoMetodo = cmMet.Text; 
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

                txbIteracionesU.Text = iteracionesRealizadas.ToString();
                txbConverge.Text = converge ? "SI" : "NO";
                txbRaiz.Text = raiz.ToString();
                txbError.Text = error.ToString();
                txbIntervaloU.Text = intervalo;

                webView21.ExecuteScriptAsync("ggbApplet.reset()");

                webView21.ExecuteScriptAsync($"ggbApplet.evalCommand('f(x) = {txbFuncion.Text}')");

                webView21.ExecuteScriptAsync($"ggbApplet.evalCommand('A = ({raiz}, f({raiz}))')");

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

            if (cbMetodo.Items.Count > 0)
                cbMetodo.SelectedIndex = 0;


        }


        private async void Form1_Load(object sender, EventArgs e)
        {
            await webView21.EnsureCoreWebView2Async();

            string htmlPath = Path.Combine(Application.StartupPath, "geogebra.html");
            webView21.CoreWebView2.Navigate($"file:///{htmlPath}");

            player.URL = Path.Combine(Application.StartupPath, "musica.mp3");
            player.settings.setMode("loop", true);


        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            g.Clear(Color.White);

            using (Brush rojo = new SolidBrush(Color.FromArgb(200, 0, 0)))
            {
                Point[] franja =
                {
            new Point(this.Width - 200, 0),
            new Point(this.Width + 100, 0),
            new Point(100, this.Height),
            new Point(-200, this.Height)
                };

                g.FillPolygon(rojo, franja);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!musicaActiva)
            {
                player.controls.play();
                musicaActiva = true;
            }
            else
            {
                player.controls.stop();
                musicaActiva = false;
            }
        }
    }
}
