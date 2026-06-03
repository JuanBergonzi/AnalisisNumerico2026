using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface IRegresionServices
    {
        void RegresionLineal(List<double[]> puntos,double tolerancia,out double a0,out double a1,out double r,out bool aceptable);

    }
}
