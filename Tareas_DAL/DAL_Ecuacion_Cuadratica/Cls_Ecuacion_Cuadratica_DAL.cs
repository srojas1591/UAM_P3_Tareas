using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareas_DAL.DAL_Ecuacion_Cuadratica
{
   public class Cls_Ecuacion_Cuadratica_DAL
    {
        private int _iValorA, _iValorB, _iValorC;
        private float _fSolucion1, _fSolucion2, _fValorDiscriminate;

        public int iValorA
        {
            get
            {
                return _iValorA;
            }

            set
            {
                _iValorA = value;
            }
        }

        public int iValorB
        {
            get
            {
                return _iValorB;
            }

            set
            {
                _iValorB = value;
            }
        }

        public int iValorC
        {
            get
            {
                return _iValorC;
            }

            set
            {
                _iValorC = value;
            }
        }

        public float fSolucion1
        {
            get
            {
                return _fSolucion1;
            }

            set
            {
                _fSolucion1 = value;
            }
        }

        public float fSolucion2
        {
            get
            {
                return _fSolucion2;
            }

            set
            {
                _fSolucion2 = value;
            }
        }

        public float fValorDiscriminate
        {
            get
            {
                return _fValorDiscriminate;
            }

            set
            {
                _fValorDiscriminate = value;
            }
        }
    }
}
