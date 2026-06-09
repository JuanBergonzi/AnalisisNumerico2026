using System;
using System.Collections.Generic;

namespace Logica
{
    public class RegresionServices
    {
        public void RegresionLineal(
    List<double[]> puntos,
    double tolerancia,
    out double a0,
    out double a1,
    out double r,
    out bool aceptable
)
        {
            int n = puntos.Count;

            double sumX = 0;
            double sumY = 0;
            double sumXY = 0;
            double sumX2 = 0;

            foreach (var p in puntos)
            {
                double x = p[0];
                double y = p[1];

                sumX += x;
                sumY += y;
                sumXY += x * y;
                sumX2 += x * x;
            }

            a1 = (n * sumXY - sumX * sumY) /
                 (n * sumX2 - Math.Pow(sumX, 2));

            a0 = (sumY / n) -
                 a1 * (sumX / n);

            double st = 0;
            double sr = 0;

            foreach (var p in puntos)
            {
                double x = p[0];
                double y = p[1];

                st += Math.Pow(y - (sumY / n), 2);

                sr += Math.Pow(
                    y - (a1 * x + a0),
                    2
                );
            }

            r = Math.Sqrt((st - sr) / st);

            aceptable = r >= tolerancia;
        }

        public void RegresionPolinomica(
    List<double[]> puntos,
    int grado,
    double tolerancia,
    out double[] coeficientes,
    out double r,
    out bool aceptable)
        {
            int n = grado + 1;

            double[,] matriz = new double[n, n + 1];

            for (int fila = 0; fila < n; fila++)
            {
                for (int col = 0; col < n; col++)
                {
                    double suma = 0;

                    foreach (var p in puntos)
                        suma += Math.Pow(
                            p[0],
                            fila + col
                        );

                    matriz[fila, col] = suma;
                }

                double sumaY = 0;

                foreach (var p in puntos)
                    sumaY +=
                        Math.Pow(p[0], fila)
                        * p[1];

                matriz[fila, n] = sumaY;
            }

            matriz[0, 0] = puntos.Count;

            coeficientes = ResolverGaussJordan(matriz);

            double promedioY =
                puntos.Average(p => p[1]);

            double st = 0;
            double sr = 0;

            foreach (var p in puntos)
            {
                double x = p[0];
                double y = p[1];

                double yEstimado = 0;

                for (int i = 0;
                     i < coeficientes.Length;
                     i++)
                {
                    yEstimado +=
                        coeficientes[i]
                        * Math.Pow(x, i);
                }

                st += Math.Pow(
                    y - promedioY,
                    2
                );

                sr += Math.Pow(
                    y - yEstimado,
                    2
                );
            }

            r = Math.Sqrt(
                (st - sr) / st
            );

            aceptable =
                r >= tolerancia;
        }

        private double[] ResolverGaussJordan(
    double[,] matriz)
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
                    if (k == i)
                        continue;

                    double factor =
                        matriz[k, i];

                    for (int j = 0; j < m; j++)
                        matriz[k, j] -=
                            factor *
                            matriz[i, j];
                }
            }

            double[] resultado =
                new double[n];

            for (int i = 0; i < n; i++)
                resultado[i] =
                    matriz[i, m - 1];

            return resultado;
        }
    }
}