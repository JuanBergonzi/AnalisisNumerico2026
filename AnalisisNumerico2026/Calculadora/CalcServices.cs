using Calculus;

namespace Logica
{
    public class CalcServices : ICalcServices
    {
        public void MetodoAbierto(string Funcion, int iteraciones, double tolerancia, double xi, double xd, string metodo,
            out bool converge, out double raiz, out double error, out string intervalo, out int iteracionesRealizadas)
        {
            converge = false;
            raiz = 0;
            error = 0;
            intervalo = "";
            iteracionesRealizadas = 0;

            Calculo calc = new Calculo();

            if (!calc.Sintaxis(Funcion, 'x'))
                return;

            double xr = xi;
            double xrAnterior = xi;

            for (int i = 1; i <= iteraciones; i++)
            {
                xr = CalcularXr(calc, metodo, xi, xd);

                if (double.IsNaN(xr))
                    return;

                error = Math.Abs((xr - xrAnterior) / Math.Max(Math.Abs(xr), 1e-10));

                double fxr = calc.EvaluaFx(xr);

                System.Diagnostics.Debug.WriteLine($"Iter: {i} Error: {error} Tol: {tolerancia}");

                if (Math.Abs(fxr) < tolerancia || error < tolerancia)
                {
                    converge = true;
                    raiz = xr;
                    intervalo = $"{xi} | {xd}";
                    iteracionesRealizadas = i;
                    return;
                }

                if (metodo == "Tangente")
                {
                    xi = xr;
                }
                else // Secante
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

        static double CalcularXr(Calculo calc, string metodo, double xi, double xd)
        {
            if (metodo == "Tangente")
            {
                double fxi = calc.EvaluaFx(xi);
                double derivada = calc.Dx(xi);

                if (derivada == 0 || double.IsNaN(derivada))
                    return double.NaN;

                return xi - (fxi / derivada);
            }
            else // Secante
            {
                double fxi = calc.EvaluaFx(xi);
                double fxd = calc.EvaluaFx(xd);

                double denominador = fxd - fxi;

                if (denominador == 0)
                    return double.NaN;

                return (fxd * xi - fxi * xd) / denominador;
            }
        }

        public void MetodoCerrado(string Funcion, int iteraciones, double tolerancia, double xi, double xd, string metodo,
            out bool converge, out double raiz, out double error, out string intervalo, out int iteracionesRealizadas)
        {
            converge = false;
            raiz = 0;
            error = 0;
            intervalo = "";
            iteracionesRealizadas = 0;

            Calculo calc = new Calculo();

            if (!calc.Sintaxis(Funcion, 'x'))
                return;

            double fxi = calc.EvaluaFx(xi);
            double fxd = calc.EvaluaFx(xd);

            if (fxi * fxd > 0)
                return;

            double xr = 0;

            for (int i = 1; i <= iteraciones; i++)
            {
                if (metodo == "Bisección")
                    xr = (xi + xd) / 2;
                else // Regla Falsa
                {
                    double denominador = fxd - fxi;
                    if (denominador == 0) return;

                    xr = (fxd * xi - fxi * xd) / denominador;
                }

                double fxr = calc.EvaluaFx(xr);

                error = Math.Abs(xd - xi) / 2;

                if (error < tolerancia || Math.Abs(fxr) < tolerancia)
                {
                    converge = true;
                    raiz = xr;
                    intervalo = $"{xi} | {xd}";
                    iteracionesRealizadas = i;
                    return;
                }

                if (fxi * fxr > 0)
                {
                    xi = xr;
                    fxi = fxr;
                }
                else
                {
                    xd = xr;
                    fxd = fxr;
                }
            }

            raiz = xr;
            intervalo = $"{xi} | {xd}";
            iteracionesRealizadas = iteraciones;
        }
    }
}