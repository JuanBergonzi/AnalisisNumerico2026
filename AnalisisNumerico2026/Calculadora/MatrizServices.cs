using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class MatrizServices : IMatrizServices
    {
        public string GaussJordan(double[,] matriz)
        {
            int n = matriz.GetLength(0);
            int m = matriz.GetLength(1);

            for (int i = 0; i < n; i++)
            {
                double pivote = matriz[i, i];

                for (int j = 0; j < m; j++)
                    matriz[i, j] /= pivote;

                for (int k = 0; k < n; k++)
                {
                    if (k != i)
                    {
                        double factor = matriz[k, i];

                        for (int j = 0; j < m; j++)
                            matriz[k, j] -= factor * matriz[i, j];
                    }
                }
            }

            string r = "";

            for (int i = 0; i < n; i++)
                r += "X" + (i + 1) + " = " + matriz[i, m - 1] + "\n";

            return r;
        }

        public string GaussSeidel(double[,] matriz, int iteraciones, double tolerancia)
        {
            int n = matriz.GetLength(0);
            int m = matriz.GetLength(1);

            double[] x = new double[n];
            double[] anterior = new double[n];

            for (int it = 0; it < iteraciones; it++)
            {
                Array.Copy(x, anterior, n);

                for (int i = 0; i < n; i++)
                {
                    double suma = matriz[i, m - 1];

                    for (int j = 0; j < n; j++)
                    {
                        if (j != i)
                            suma -= matriz[i, j] * x[j];
                    }

                    x[i] = suma / matriz[i, i];
                }

                double error = 0;

                for (int i = 0; i < n; i++)
                    error = Math.Max(error, Math.Abs(x[i] - anterior[i]));

                if (error < tolerancia)
                    break;
            }

            string r = "";

            for (int i = 0; i < n; i++)
                r += "X" + (i + 1) + " = " + x[i] + "\n";

            return r;
        }
    }
}
