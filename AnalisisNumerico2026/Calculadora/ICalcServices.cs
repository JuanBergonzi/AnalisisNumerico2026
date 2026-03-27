using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface ICalcServices
    {
        public void MetodoAbierto(string Funcion, int iteraciones, double tolerancia, double xi, double xd, string metodo, out bool converge, out double raiz, out double error, out string intervalo, out int iteracionesRealizadas);
        public void MetodoCerrado(string Funcion, int iteraciones, double tolerancia, double xi, double xd, string metodo);
    }
}
