using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tareas_DAL.DAL_Notas;

namespace Tareas_BLL.BLL_Notas
{
  public  class Cls_Notas_BLL
    {

        public void Quices(ref Cls_Notas_DAL Obj_Datos_Quiz_DAL)
        {

            Obj_Datos_Quiz_DAL.ftotalquiz = ((Convert.ToSingle(Obj_Datos_Quiz_DAL.bquiz1) +
                                               Convert.ToSingle(Obj_Datos_Quiz_DAL.bquiz2) +
                                               Convert.ToSingle(Obj_Datos_Quiz_DAL.bquiz3)) / 3);

        }

        public void Tareas(ref Cls_Notas_DAL Obj_Datos_Tarea_DAL)
        {

            Obj_Datos_Tarea_DAL.ftotaltarea = ((Convert.ToSingle(Obj_Datos_Tarea_DAL.btarea1) +
                                                        Convert.ToSingle(Obj_Datos_Tarea_DAL.btarea2) +
                                                        Convert.ToSingle(Obj_Datos_Tarea_DAL.btarea3) +
                                                        Convert.ToSingle(Obj_Datos_Tarea_DAL.btarea4)) / 4);
        }

        public void Examenes(ref Cls_Notas_DAL Obj_Datos_Examenes)
        {
            Obj_Datos_Examenes.fnota_examenes = (Obj_Datos_Examenes.bparcial1 * Obj_Datos_Examenes.Bporcent_parcial1)
                + (Obj_Datos_Examenes.bparcial2 * Obj_Datos_Examenes.Bporcent_parcial2)
                + (Obj_Datos_Examenes.bparcial3 * Obj_Datos_Examenes.bparcial3);


        }




        public void EcuacionPrimerGrado(ref Cls_Notas_DAL Obj_Datos_EcuacionPrimerGrado)
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
