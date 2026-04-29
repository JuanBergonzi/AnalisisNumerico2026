using System;

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
                if (matriz[i, i] == 0)
                {
                    bool cambio = false;

                    for (int k = i + 1; k < n; k++)
                    {
                        if (matriz[k, i] != 0)
                        {
                            for (int j = 0; j < m; j++)
                            {
                                double temp = matriz[i, j];
                                matriz[i, j] = matriz[k, j];
                                matriz[k, j] = temp;
                            }
                            cambio = true;
                            break;
                        }
                    }

                    if (!cambio)
                        return "Error: no se pudo encontrar un pivote distinto de 0.";
                }

                double pivote = matriz[i, i];

                if (pivote == 0)
                    return "Error: pivote 0, no se puede continuar.";

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
                r += $"X{i + 1} = {matriz[i, m - 1]:F6}\n";

            return r;
        }

        public string GaussSeidel(double[,] matriz, int iteraciones, double tolerancia)
        {
            int n = matriz.GetLength(0);
            int m = matriz.GetLength(1);

            double[] x = new double[n];
            double[] anterior = new double[n];

            for (int i = 0; i < n; i++)
            {
                if (matriz[i, i] == 0)
                    return "Error: hay ceros en la diagonal. Reordenar el sistema o usar otro método.";
            }

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
                {
                    return ArmarResultado(x) + $"\nConvergió en {it + 1} iteraciones (error < {tolerancia})";
                }
            }

            return ArmarResultado(x) + "\nNo se alcanzó la tolerancia.";
        }

        private string ArmarResultado(double[] x)
        {
            string r = "";

            for (int i = 0; i < x.Length; i++)
                r += $"X{i + 1} = {x[i]:F6}\n";

            return r;
        }
    }
}