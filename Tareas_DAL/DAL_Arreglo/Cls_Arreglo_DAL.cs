using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareas_DAL.DAL_Arreglo
{
  public  class Cls_Arreglo_DAL
    {
        private int _iLimitVec, _iTamVec;

        public int iLimitVec
        {
            get
            {
                return _iLimitVec;
            }

            set
            {
                _iLimitVec = value;
            }
        }

        public int iTamVec
        {
            get
            {
                return _iTamVec;
            }

            set
            {
                _iTamVec = value;
            }
        }
    }
}
