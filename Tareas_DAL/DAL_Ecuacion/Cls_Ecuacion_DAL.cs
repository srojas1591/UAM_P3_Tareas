using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareas_DAL.DAL_Ecuacion
{
    public class Cls_Ecuacion_DAL
    {
        //Variables para Ecuacion de Primer Grado
        private float _fvariable_a, _fvariable_b, _fvariable_x;
        public float fvariable_a
        {
            get
            {
                return _fvariable_a;
            }

            set
            {
                _fvariable_a = value;
            }
        }

        public float fvariable_b
        {
            get
            {
                return _fvariable_b;
            }

            set
            {
                _fvariable_b = value;
            }
        }

        public float fvariable_x
        {
            get
            {
                return _fvariable_x;
            }

            set
            {
                _fvariable_x = value;
            }
        }
    }
}
