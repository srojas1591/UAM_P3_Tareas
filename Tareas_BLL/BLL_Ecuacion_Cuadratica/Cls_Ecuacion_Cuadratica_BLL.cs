using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tareas_DAL.DAL_Ecuacion_Cuadratica;

namespace Tareas_BLL.BLL_Ecuacion_Cuadratica
{
  public  class Cls_Ecuacion_Cuadratica_BLL
    {
        public void CalculoDiscriminate(ref Cls_Ecuacion_Cuadratica_DAL ObjEcuacionCuadratica_DAL)
        {
            ObjEcuacionCuadratica_DAL.fValorDiscriminate = Convert.ToSingle(Math.Pow(-ObjEcuacionCuadratica_DAL.iValorB, 2)
                                           - 4 * (ObjEcuacionCuadratica_DAL.iValorA) * (ObjEcuacionCuadratica_DAL.iValorC));
        }
        public void CalculoSolucion(ref Cls_Ecuacion_Cuadratica_DAL ObjEcuacionCuadratica_DAL)
        {
            ObjEcuacionCuadratica_DAL.fSolucion1 = -ObjEcuacionCuadratica_DAL.iValorB / (2 * ObjEcuacionCuadratica_DAL.iValorA);
        }

        public void CalculoDosSoluciones(ref Cls_Ecuacion_Cuadratica_DAL ObjEcuacionCuadratica_DAL)
        {
            ObjEcuacionCuadratica_DAL.fSolucion1 = (((-ObjEcuacionCuadratica_DAL.iValorB - (Convert.ToSingle(Math.Sqrt(ObjEcuacionCuadratica_DAL.fValorDiscriminate))))) /
                                                   (2 * (ObjEcuacionCuadratica_DAL.iValorA)));

            ObjEcuacionCuadratica_DAL.fSolucion2 = (((-ObjEcuacionCuadratica_DAL.iValorB + (Convert.ToSingle(Math.Sqrt(ObjEcuacionCuadratica_DAL.fValorDiscriminate))))) /
                                                   (2 * (ObjEcuacionCuadratica_DAL.iValorA)));
        }
    }
}
