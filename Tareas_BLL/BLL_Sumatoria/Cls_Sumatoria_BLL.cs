using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tareas_DAL.DAL_Sumatoria;

namespace Tareas_BLL.BLL_Sumatoria
{
  public  class Cls_Sumatoria_BLL
    {

        public void SumaTodo(ref Cls_Sumatoria_DAL ObjSuma_DAL)
        {
            while (ObjSuma_DAL.iNumero <= ObjSuma_DAL.iNumeroLimite)
            {
                ObjSuma_DAL.iSuma = ObjSuma_DAL.iSuma + ObjSuma_DAL.iNumero;
                ObjSuma_DAL.iNumero++;
            }
        }
        public void SumarPares(ref Cls_Sumatoria_DAL ObjSumaPares_DAL)
        {
            while (ObjSumaPares_DAL.iNumero <= ObjSumaPares_DAL.iNumeroLimite)
            {
                if ((ObjSumaPares_DAL.iNumero % 2) == 0)
                {
                    ObjSumaPares_DAL.iSuma = ObjSumaPares_DAL.iSuma + ObjSumaPares_DAL.iNumero;
                    ObjSumaPares_DAL.iNumero = ObjSumaPares_DAL.iNumero + 1;
                }
                else
                {
                    ObjSumaPares_DAL.iNumero = ObjSumaPares_DAL.iNumero + 1;
                }
            }
        }
        public void SumarImpares(ref Cls_Sumatoria_DAL ObjSumaImpares)
        {
            while (ObjSumaImpares.iNumero <= ObjSumaImpares.iNumeroLimite)
            {
                if ((ObjSumaImpares.iNumero % 2) == 1)
                {
                    ObjSumaImpares.iSuma = ObjSumaImpares.iSuma + ObjSumaImpares.iNumero;
                    ObjSumaImpares.iNumero = ObjSumaImpares.iNumero + 1;
                }
                else
                {
                    ObjSumaImpares.iNumero = ObjSumaImpares.iNumero + 1;
                }
            }
        }

    }
}
