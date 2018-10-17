using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareas_DAL.DAL_Sumatoria
{
   public class Cls_Sumatoria_DAL
    {
        #region Variables
        private int _iNumeroLimite, _iNumero, _iSuma;
        #endregion

        #region GET & SET
        public int iNumero
        {
            get
            {
                return _iNumero;
            }

            set
            {
                _iNumero = value;
            }
        }

        public int iNumeroLimite
        {
            get
            {
                return _iNumeroLimite;
            }

            set
            {
                _iNumeroLimite = value;
            }
        }

        public int iSuma
        {
            get
            {
                return _iSuma;
            }

            set
            {
                _iSuma = value;
            }
        }
        #endregion
    }
}
