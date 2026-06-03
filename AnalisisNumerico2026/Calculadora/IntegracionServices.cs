using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculus;

namespace Logica
{
    public class IntegracionServices : IIntegracionServices
    {
        public double CalcularIntegralTrapeciosSimple(string funcion, double xi, double xd)
        {
            Calculo calc = new Calculo();

            if (!calc.Sintaxis(funcion, 'x'))
                throw new Exception("Función inválida");

            double fxi = calc.EvaluaFx(xi);
            double fxd = calc.EvaluaFx(xd);

            return ((fxi + fxd) * (xd - xi)) / 2.0;
        }

        public double CalcularIntegralTrapeciosMultiple(string funcion, double xi, double xd, int n)
        {
            Calculo calc = new Calculo();

            if (!calc.Sintaxis(funcion, 'x'))
                throw new Exception("Función inválida");

            double h = (xd - xi) / n;

            double suma = 0;

            for (int i = 1; i < n; i++)
            {
                double x = xi + i * h;
                suma += calc.EvaluaFx(x);
            }

            return (h / 2.0) *
                   (calc.EvaluaFx(xi)
                   + 2 * suma
                   + calc.EvaluaFx(xd));
        }

        public double CalcularIntegralSimpson13Simple(string funcion, double xi, double xd)
        {
            Calculo calc = new Calculo();

            if (!calc.Sintaxis(funcion, 'x'))
                throw new Exception("Función inválida");

            double h = (xd - xi) / 2.0;

            return (h / 3.0) *
                   (calc.EvaluaFx(xi)
                   + 4 * calc.EvaluaFx(xi + h)
                   + calc.EvaluaFx(xd));
        }

        public double CalcularIntegralSimpson13Multiple(string funcion, double xi, double xd, int n)
        {
            if (n % 2 != 0)
                throw new Exception("Para Simpson 1/3 Múltiple, n debe ser par.");

            Calculo calc = new Calculo();

            if (!calc.Sintaxis(funcion, 'x'))
                throw new Exception("Función inválida");

            double h = (xd - xi) / n;

            double sumaImpares = 0;
            double sumaPares = 0;

            for (int i = 1; i < n; i++)
            {
                double x = xi + i * h;

                if (i % 2 == 0)
                    sumaPares += calc.EvaluaFx(x);
                else
                    sumaImpares += calc.EvaluaFx(x);
            }

            return (h / 3.0) *
                   (calc.EvaluaFx(xi)
                   + 4 * sumaImpares
                   + 2 * sumaPares
                   + calc.EvaluaFx(xd));
        }

        public double CalcularIntegralSimpson38(string funcion, double xi, double xd)
        {
            Calculo calc = new Calculo();

            if (!calc.Sintaxis(funcion, 'x'))
                throw new Exception("Función inválida");

            double h = (xd - xi) / 3.0;

            return (3.0 * h / 8.0) *
                   (calc.EvaluaFx(xi)
                   + 3 * calc.EvaluaFx(xi + h)
                   + 3 * calc.EvaluaFx(xi + 2 * h)
                   + calc.EvaluaFx(xd));
        }
        public double CalcularIntegralSimpsonCombinado(string funcion, double xi, double xd, int n)
        {
            Calculo calc = new Calculo();

            if (!calc.Sintaxis(funcion, 'x'))
                throw new Exception("Función inválida");

            if (n < 3)
                throw new Exception("n debe ser mayor o igual a 3.");

            // Si es par, usar Simpson 1/3 múltiple directamente
            if (n % 2 == 0)
                return CalcularIntegralSimpson13Multiple(funcion, xi, xd, n);

            double h = (xd - xi) / n;

            double resultado = 0;

            // Parte Simpson 1/3 múltiple
            int n13 = n - 3;

            if (n13 > 0)
            {
                double xFinal13 = xi + n13 * h;

                double sumaImpares = 0;
                double sumaPares = 0;

                for (int i = 1; i < n13; i++)
                {
                    double x = xi + i * h;

                    if (i % 2 == 0)
                        sumaPares += calc.EvaluaFx(x);
                    else
                        sumaImpares += calc.EvaluaFx(x);
                }

                resultado += (h / 3.0) *
                             (calc.EvaluaFx(xi)
                             + 4 * sumaImpares
                             + 2 * sumaPares
                             + calc.EvaluaFx(xFinal13));
            }

            // Parte Simpson 3/8
            double a = xi + (n - 3) * h;

            resultado += (3.0 * h / 8.0) *
                         (calc.EvaluaFx(a)
                         + 3 * calc.EvaluaFx(a + h)
                         + 3 * calc.EvaluaFx(a + 2 * h)
                         + calc.EvaluaFx(a + 3 * h));

            return resultado;
        }
    }
}
