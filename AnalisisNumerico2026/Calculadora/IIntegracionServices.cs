using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface IIntegracionServices
    {
        double CalcularIntegralTrapeciosSimple(string funcion, double xi, double xd);
        double CalcularIntegralTrapeciosMultiple(string funcion, double xi, double xd, int n);
        double CalcularIntegralSimpson13Simple(string funcion, double xi, double xd);
        double CalcularIntegralSimpson13Multiple(string funcion, double xi, double xd, int n);
        double CalcularIntegralSimpson38(string funcion, double xi, double xd);
        double CalcularIntegralSimpsonCombinado(string funcion, double xi, double xd, int n);
    }
}
