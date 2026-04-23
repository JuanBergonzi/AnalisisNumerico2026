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
    public partial class Matriz : Form
    {
        private IMatrizServices matrizServices;
        public Matriz()
        {
            InitializeComponent();
            matrizServices = new MatrizServices();
        }


        int[,] matriz;



        private void Matriz_Load(object sender, EventArgs e)
        {
            cbMetodo.Items.Clear();
            cbMetodo.Items.Add("Gauss Jordan");
            cbMetodo.Items.Add("Gauss Seidel");

            panelMatriz.AutoScroll = true;
            cbMetodo.SelectedIndex = 0;
        }

        private void btnOptimizar_Click(object sender, EventArgs e)
        {
            panelMatriz.Controls.Clear();
            panelMatriz.AutoScrollMinSize = new Size(0, 0);
            panelMatriz.Refresh();

            int n = int.Parse(tbFilasCol.Text);

            matriz = new int[n, n + 1];

            int ancho = 40;
            int alto = 30;
            int espacio = 5;


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n + 1; j++)
                {
                    TextBox txt = new TextBox();

                    txt.Width = ancho;
                    txt.Height = alto;

                    int posX;
                    Label igual = new Label();
                    igual.Text = "=";
                    igual.AutoSize = true;

                    igual.Location = new Point(
                        n * (ancho + espacio) + 10,
                        i * (alto + espacio) + 5
                    );

                    panelMatriz.Controls.Add(igual);
                    if (j == n) // columna resultado separada
                        posX = j * (ancho + espacio) + 30;
                    else
                        posX = j * (ancho + espacio);

                    txt.Location = new Point(
                        posX,
                        i * (alto + espacio)
                    );

                    txt.Name = "txt_" + i + "_" + j;
                    txt.TextAlign = HorizontalAlignment.Center;

                    panelMatriz.Controls.Add(txt);
                }
            }

            panelMatriz.AutoScrollMinSize = new Size(
                (n + 1) * (ancho + espacio) + 40,
                n * (alto + espacio)
            );
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int n = (int)tbFilasCol.Value;

            double[,] datos = new double[n, n + 1];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n + 1; j++)
                {
                    TextBox txt = (TextBox)panelMatriz.Controls["txt_" + i + "_" + j];

                    double valor = 0;
                    double.TryParse(txt.Text, out valor);

                    datos[i, j] = valor;
                }
            }

            string metodo = cbMetodo.Text;
            string resultado = "";

            if (metodo == "Gauss Jordan")
            {
                resultado = matrizServices.GaussJordan(datos);
            }
            else
            {
                int iteraciones = int.Parse(tbIteraciones.Text);
                double tolerancia = double.Parse(tbTolerancia.Text);

                resultado = matrizServices.GaussSeidel(datos, iteraciones, tolerancia);
            }

            var resultadosViejos = panelMatriz.Controls
                .OfType<Label>()
                .Where(l => l.Name.StartsWith("res_"))
                .ToList();

            foreach (var l in resultadosViejos)
                panelMatriz.Controls.Remove(l);

            string[] lineas = resultado.Split('\n');

            int ancho = 40;
            int espacio = 5;

            for (int i = 0; i < n; i++)
            {
                if (i >= lineas.Length) break;

                string linea = lineas[i];
                if (string.IsNullOrWhiteSpace(linea)) continue;

                string[] partes = linea.Split('=');

                if (partes.Length == 2)
                {
                    Label lbl = new Label();

                    lbl.Name = "res_" + i;
                    lbl.Text = partes[0] + "= " + partes[1];
                    lbl.AutoSize = true;
                    lbl.Font = new Font("Segoe UI", 10, FontStyle.Bold);

                    lbl.Location = new Point(
                        n * (ancho + espacio) + 120,
                        i * (30 + espacio) + 5
                    );

                    panelMatriz.Controls.Add(lbl);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (Control c in panelMatriz.Controls)
            {
                if (c is TextBox txt)
                    txt.Text = "";
            }

            var resultados = panelMatriz.Controls
                .OfType<Label>()
                .Where(l => l.Name.StartsWith("res_"))
                .ToList();

            foreach (var l in resultados)
                panelMatriz.Controls.Remove(l);


        }

        private void btnRedondearMatriz_Click(object sender, EventArgs e)
        {
            int decimales = 2;
            int.TryParse(tbDecimalesMatriz.Text, out decimales);

            foreach (Control c in panelMatriz.Controls)
            {
                if (c is TextBox txt)
                {
                    double valor;
                    if (double.TryParse(txt.Text, out valor))
                    {
                        valor = Math.Round(valor, decimales);
                        txt.Text = valor.ToString();
                    }
                }
            }

        }

        private void btnRedondearResultados_Click(object sender, EventArgs e)
        {
            int decimales = 2;
            int.TryParse(tbDecimalesResultados.Text, out decimales);

            foreach (Control c in panelMatriz.Controls)
            {
                if (c is Label lbl && lbl.Name.StartsWith("res_"))
                {
                    string[] partes = lbl.Text.Split('=');

                    if (partes.Length == 2)
                    {
                        double valor;
                        if (double.TryParse(partes[1], out valor))
                        {
                            valor = Math.Round(valor, decimales);
                            lbl.Text = partes[0] + "= " + valor;
                        }
                    }
                }
            }

        }

        private void cbMetodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string metodo = cbMetodo.Text;

            bool esSeidel = metodo == "Gauss Seidel";

            tbIteraciones.Visible = esSeidel;
            tbTolerancia.Visible = esSeidel;
            label3.Visible = esSeidel; 
            label4.Visible = esSeidel; 

        }
    }
}
