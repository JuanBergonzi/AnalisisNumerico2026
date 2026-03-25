using Calculus;
using System.Runtime.Serialization.Formatters;

namespace Logica
{
    public class CalcServices : ICalcServices
    {
        Calculo AnalizadorDeFunciones = new Calculo();
        public void MetodoAbierto(string Funcion, int iteraciones, double tolerancia, double xi, double xd,string metodo)
        {
            if (Funcion == null || iteraciones <= 0 || tolerancia <= 0 || double.IsNaN(xi) || double.IsNaN(xd))
            {
                throw new ArgumentException("Los parámetros no pueden ser nulos o inválidos.");
            }

            if (!AnalizadorDeFunciones.Sintaxis(Funcion,'x'))
            {
                Console.WriteLine("Error: función inválida");
                return;               
            }

            double fxi = AnalizadorDeFunciones.EvaluaFx(xi);

            if (Math.Abs(fxi) < tolerancia)
            {
                Console.WriteLine($"xi es raíz: {xi}");
                return;
            }
            else if (metodo == "Secante")
            {
                double fxd = AnalizadorDeFunciones.EvaluaFx(xd);

                if (Math.Abs(fxd) < tolerancia)
                {
                    Console.WriteLine($"xd es raíz: {xd}");
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
                    xr = CalcularXr(AnalizadorDeFunciones, metodo, xi, xd, tolerancia);
                    if (double.IsNaN(xr))
                    {
                        Console.WriteLine("El metodo diverge, No encuentra la raiz");
                        break;
                    }
                    error = Math.Abs((xr - xrAnterior) / xr);
                    if (Math.Abs(AnalizadorDeFunciones.EvaluaFx(xr)) < tolerancia || error < tolerancia)
                    {
                        Console.WriteLine($"Xr es Raíz. encontrada: {xr} en la iteración {i}");
                        break;
                    }
                    else if (metodo == "Tangente")
                    {
                        xi = xr;
                    }
                    else
                    {
                        xi = xd;
                        xd = xr;
                    }
                    xrAnterior = xr;
                }
                Console.WriteLine($"Iteraciones superadas, xr encontrada: {xr}");
            }
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
            if (Funcion == null || iteraciones <= 0 || tolerancia <= 0 || double.IsNaN(xi) || double.IsNaN(xd))
            {
                throw new ArgumentException("Los parámetros no pueden ser nulos o inválidos.");
            }

            if (!AnalizadorDeFunciones.Sintaxis(Funcion, 'x'))
            {
                Console.WriteLine("Error: función inválida");
                return;
            }

            if (AnalizadorDeFunciones.EvaluaFx(xi)* AnalizadorDeFunciones.EvaluaFx(xd) > 0)
            {
                Console.WriteLine("Error: Volver a ingresar Xd, Xi");
                return;
            }
            else if (AnalizadorDeFunciones.EvaluaFx(xi) * AnalizadorDeFunciones.EvaluaFx(xd) == 0)
            {
                if (AnalizadorDeFunciones.EvaluaFx(xi) == 0)
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
                    xr = CerradoCalcularXr(AnalizadorDeFunciones, metodo, xi, xd, tolerancia);
                    error = Math.Abs((xr - xrAnterior) / xr);
                    if (Math.Abs(AnalizadorDeFunciones.EvaluaFx(xr)) < tolerancia || error < tolerancia)
                    {
                        Console.WriteLine($"Xr es Raíz. encontrada: {xr} en la iteración {i}");
                        break;
                    }
                    else if (AnalizadorDeFunciones.EvaluaFx(xi) * AnalizadorDeFunciones.EvaluaFx(xr) > 0)
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