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

            cbMetodo.SelectedIndex = 0;
        }

        private void btnOptimizar_Click(object sender, EventArgs e)
        {

            int n = int.Parse(tbFilasCol.Text);

            matriz = new int[n, n];

            int size = 40;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    TextBox txt = new TextBox();
                    txt.Width = size;
                    txt.Height = size;
                    txt.Location = new Point(j * size, i * size);
                    txt.Name = "txt_" + i + "_" + j;

                    panelMatriz.Controls.Add(txt);
                }
            }
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int n = int.Parse(tbFilasCol.Text);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    TextBox txt = (TextBox)panelMatriz.Controls["txt_" + i + "_" + j];

                    int valor = 0;
                    int.TryParse(txt.Text, out valor);

                    matriz[i, j] = valor;
                }
            }

            MessageBox.Show("Matriz cargada correctamente");
        }
    }
}
