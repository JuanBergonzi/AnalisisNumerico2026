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

            matriz = new int[n, n+1];

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
            int n = int.Parse(tbFilasCol.Text);

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
            else if (metodo == "Gauss Seidel")
            {
                int iteraciones = int.Parse(tbIteraciones.Text);
                double tolerancia = double.Parse(tbTolerancia.Text);

                resultado = matrizServices.GaussSeidel(datos, iteraciones, tolerancia);
            }

            MessageBox.Show(resultado);
        }
    }
}
