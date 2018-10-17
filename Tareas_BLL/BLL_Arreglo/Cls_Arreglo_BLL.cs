using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tareas_DAL.DAL_Arreglo;

namespace Tareas_BLL.BLL_Arreglo
{
  public  class Cls_Arreglo_BLL
    {
        public void LlenarVector(ref Cls_Arreglo_DAL ObjVec_DAL)
        {
            int[] Vector = new int[ObjVec_DAL.iTamVec];
            Random rnd = new Random();
            for (int i = 0; i < ObjVec_DAL.iLimitVec; i++)
            {
                Vector[i] = rnd.Next(0, Convert.ToInt32(ObjVec_DAL.iLimitVec));
            }
        }
    }
}
