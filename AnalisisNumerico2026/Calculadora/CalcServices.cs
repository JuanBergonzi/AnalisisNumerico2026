using Calculus;
using System.Runtime.Serialization.Formatters;

namespace Logica
{
    public class CalcServices : ICalcServices
    {
        public void MetodoAbierto(string Funcion, int iteraciones, double tolerancia, double xi, double xd, string metodo, out bool converge, out double raiz, out double error, out string intervalo, out int iteracionesRealizadas)
        {
            converge = false;
            raiz = 0;
            error = 0;
            intervalo = "";
            iteracionesRealizadas = 0;

            double xr = 0;
            double xrAnterior = 0;

            Calculo calc = new Calculo();
            if (!calc.Sintaxis(Funcion, 'x'))
                return;

            for (int i = 1; i <= iteraciones; i++)
            {
                xr = CalcularXr(calc, metodo, xi, xd, tolerancia);

                if (xr != 0)
                    error = Math.Abs((xr - xrAnterior) / xr);

                if (Math.Abs(calc.EvaluaFx(xr)) < tolerancia || error < tolerancia)
                {
                    converge = true;
                    raiz = xr;
                    intervalo = $"{xi} | {xd}";
                    iteracionesRealizadas = i;
                    return;
                }

                if (metodo == "Tangente")
                    xi = xr;
                else
                {
                    xi = xd;
                    xd = xr;
                }

                xrAnterior = xr;
            }

            raiz = xr;
            intervalo = $"{xi} | {xd}";
            iteracionesRealizadas = iteraciones;
        }

        static double CalcularXr(Calculo calc, string metodo, double xi, double xd, double tolerancia)
    {
        if (metodo == "Tangente") // Newton-Raphson
        {
            double derivada = calc.Dx(xi);

            if (Math.Abs(derivada) < tolerancia || double.IsNaN(derivada))
            {
                Console.WriteLine("Derivada inválida → diverge");
                return double.NaN;
            }

            return xi - (calc.EvaluaFx(xi) / derivada);
        }
        else // Secante
        {
            double fxi = calc.EvaluaFx(xi);
            double fxd = calc.EvaluaFx(xd);

            double denominador = fxd - fxi;

            if (denominador == 0)
            {
                Console.WriteLine("División por cero → diverge");
                return double.NaN;
            }

            return (fxd * xi - fxi * xd) / denominador;
        }
    }
        static double CerradoCalcularXr(Calculo calc, string metodo, double xi, double xd, double tolerancia)
        {
            if (metodo == "Bisección")
            {
                return (xi + xd) / 2;
            }
            else if (metodo == "Regla Falsa")
            {
                double fxi = calc.EvaluaFx(xi);
                double fxd = calc.EvaluaFx(xd);
                double denominador = fxd - fxi;
                if (denominador == 0)
                {
                    Console.WriteLine("División por cero → diverge");
                    return double.NaN;
                }
                return (fxd * xi - fxi * xd) / denominador;
            }
            else
            {
                throw new ArgumentException("Método cerrado no reconocido.");
            }
        }

        public void MetodoCerrado(string Funcion, int iteraciones, double tolerancia, double xi, double xd, string metodo)
        {
            Calculo calc = new Calculo();

            if (Funcion == null || iteraciones <= 0 || tolerancia <= 0 || double.IsNaN(xi) || double.IsNaN(xd))
            {
                throw new ArgumentException("Los parámetros no pueden ser nulos o inválidos.");
            }

            if (!calc.Sintaxis(Funcion, 'x'))
            {
                Console.WriteLine("Error: función inválida");
                return;
            }

            if (calc.EvaluaFx(xi)* calc.EvaluaFx(xd) > 0)
            {
                Console.WriteLine("Error: Volver a ingresar Xd, Xi");
                return;
            }
            else if (calc.EvaluaFx(xi) * calc.EvaluaFx(xd) == 0)
            {
                if (calc.EvaluaFx(xi) == 0)
                {
                    Console.WriteLine("Xi es raiz");
                    return;
                }
                else
                {
                    Console.WriteLine("Xd es raiz");
                    return;
                }
            }
            else
            {
                double xr = 0;
                double xrAnterior = 0;
                double error = 0;
                for (int i = 1; i <= iteraciones; i++)
                {
                    xr = CerradoCalcularXr(calc, metodo, xi, xd, tolerancia);
                    if (xr != 0)
                        error = Math.Abs((xr - xrAnterior) / xr);
                    if (Math.Abs(calc.EvaluaFx(xr)) < tolerancia || error < tolerancia)
                    {
                        Console.WriteLine($"Xr es Raíz. encontrada: {xr} en la iteración {i}");
                        break;
                    }
                    else if (calc.EvaluaFx(xi) * calc.EvaluaFx(xr) > 0)
                    {
                        xi = xr;
                    }
                    else
                    {
                        xd = xr;
                    }
                    xrAnterior = xr;
                }
                Console.WriteLine($"Iteraciones superadas, xr encontrada: {xr}");
            }
        }
    }
}