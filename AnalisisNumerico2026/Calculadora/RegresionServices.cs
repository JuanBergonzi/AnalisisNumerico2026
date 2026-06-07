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
    }
}