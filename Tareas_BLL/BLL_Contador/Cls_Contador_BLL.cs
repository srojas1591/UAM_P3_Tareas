using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tareas_DAL.DAL_Contador;
namespace Tareas_BLL.BLL_Contador
{
public class Cls_Contador_BLL
    {
        public void Contar(ref  Cls_Contador_DAL ObjTime_DAL)
        {

            if (ObjTime_DAL.BMiliseg == 60)
            {
                ObjTime_DAL.BMiliseg = 0;
                ObjTime_DAL.BSeg++;

                if (ObjTime_DAL.BSeg == 60)
                {
                    ObjTime_DAL.BSeg = 0;
                    ObjTime_DAL.BMin++;

                }
            }

        }
    }
}
