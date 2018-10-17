using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tareas_DAL.DAL_Ecuacion;
using Tareas_BLL.BLL_Ecuacion;

namespace Tareas_BLL.BLL_Ecuacion
{
 public class Cls_Ecuacion_BLL
    {

        public void EcuacionPrimerGrado(ref Cls_Ecuacion_DAL Obj_Datos_EcuacionPrimerGrado)
        {
            if (Obj_Datos_EcuacionPrimerGrado.fvariable_a != 0)
            {
                Obj_Datos_EcuacionPrimerGrado.fvariable_x = ((Obj_Datos_EcuacionPrimerGrado.fvariable_x - Obj_Datos_EcuacionPrimerGrado.fvariable_b) / Obj_Datos_EcuacionPrimerGrado.fvariable_a);

            }
            else
                Obj_Datos_EcuacionPrimerGrado.fvariable_x = 0;
        }

    }
}
