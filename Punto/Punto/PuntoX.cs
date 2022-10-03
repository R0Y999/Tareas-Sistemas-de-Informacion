using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto
{
    public class PuntoX
    {
           decimal x;
           decimal y;
             decimal X
             {
                 get { return X;}
                 set { X = value; }
             }
        public PuntoX()
        {
            x=0;
        }
        public PuntoX(decimal x)
        {
            this.x=x;
        }
        public decimal calcularDistancia(PuntoX P)
        {
            return Math.Abs(x - P.x);
        }
        public decimal calcularDistanciaBidimencional(PuntoX I, PuntoX J, PuntoX K)
        {
             x = Convert.ToDecimal(Math.Abs(Math.Pow(Convert.ToDouble(x - I.x), 2))+(Math.Pow(Convert.ToDouble(J.x - K.x),2)));
             return Convert.ToDecimal(Math.Sqrt(Convert.ToDouble(x)));
        }
    }
}
