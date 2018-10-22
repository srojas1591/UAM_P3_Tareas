using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareas_DAL.DAL_Contador
{
   public class Cls_Contador_DAL
    {
        private byte _bMin, _bSeg, _bMiliseg, _bLimit;

        public byte BLimit
        {
            get
            {
                return _bLimit;
            }

            set
            {
                _bLimit = value;
            }
        }

        public byte BMiliseg
        {
            get
            {
                return _bMiliseg;
            }

            set
            {
                _bMiliseg = value;
            }
        }

        public byte BMin
        {
            get
            {
                return _bMin;
            }

            set
            {
                _bMin = value;
            }
        }

        public byte BSeg
        {
            get
            {
                return _bSeg;
            }

            set
            {
                _bSeg = value;
            }
        }
    }
}
