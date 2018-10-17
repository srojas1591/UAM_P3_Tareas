using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tareas_DAL.DAL_Notas
{
   public class Cls_Notas_DAL
    {
        private byte _bporcent_tarea, _bporcent_quices, _bporcent_parcial1,
                            _bporcent_parcial2, _bporcent_parcial3;

        private byte _bquiz1;
        private byte _bquiz2;
        private byte _bquiz3;
        private float _ftotaltarea, _ftotalquiz;
        private byte _btarea1;
        private byte _btarea2;
        private byte _btarea3;
        private byte _btarea4;
        private byte _bparcial1;
        private byte _bparcial2;
        private byte _bparcial3;
        private float _fnota_examenes;
        private float _fnota_final;
        //Variables para Ecuacion de Primer Grado
        private float _fvariable_a, _fvariable_b, _fvariable_x;

        public byte bquiz1
        {
            get
            {
                return _bquiz1;
            }

            set
            {
                _bquiz1 = value;
            }
        }

        public byte bquiz2
        {
            get
            {
                return _bquiz2;
            }

            set
            {
                _bquiz2 = value;
            }
        }

        public byte bquiz3
        {
            get
            {
                return _bquiz3;
            }

            set
            {
                _bquiz3 = value;
            }
        }

        public float ftotaltarea
        {
            get
            {
                return _ftotaltarea;
            }

            set
            {
                _ftotaltarea = value;
            }
        }

        public byte btarea1
        {
            get
            {
                return _btarea1;
            }

            set
            {
                _btarea1 = value;
            }
        }

        public byte btarea2
        {
            get
            {
                return _btarea2;
            }

            set
            {
                _btarea2 = value;
            }
        }

        public byte btarea3
        {
            get
            {
                return _btarea3;
            }

            set
            {
                _btarea3 = value;
            }
        }

        public byte btarea4
        {
            get
            {
                return _btarea4;
            }

            set
            {
                _btarea4 = value;
            }
        }

        public byte bparcial1
        {
            get
            {
                return _bparcial1;
            }

            set
            {
                _bparcial1 = value;
            }
        }

        public byte bparcial2
        {
            get
            {
                return _bparcial2;
            }

            set
            {
                _bparcial2 = value;
            }
        }

        public byte bparcial3
        {
            get
            {
                return _bparcial3;
            }

            set
            {
                _bparcial3 = value;
            }
        }

        public float fnota_final
        {
            get
            {
                return _fnota_final;
            }

            set
            {
                _fnota_final = value;
            }
        }

        public float fnota_examenes
        {
            get
            {
                return _fnota_examenes;
            }

            set
            {
                _fnota_examenes = value;
            }
        }

        public byte Bporcent_tarea
        {
            get
            {
                return _bporcent_tarea;
            }

            set
            {
                _bporcent_tarea = value;
            }
        }

        public byte Bporcent_quices
        {
            get
            {
                return _bporcent_quices;
            }

            set
            {
                _bporcent_quices = value;
            }
        }

        public byte Bporcent_parcial1
        {
            get
            {
                return _bporcent_parcial1;
            }

            set
            {
                _bporcent_parcial1 = value;
            }
        }

        public byte Bporcent_parcial2
        {
            get
            {
                return _bporcent_parcial2;
            }

            set
            {
                _bporcent_parcial2 = value;
            }
        }

        public byte Bporcent_parcial3
        {
            get
            {
                return _bporcent_parcial3;
            }

            set
            {
                _bporcent_parcial3 = value;
            }
        }

        public float ftotalquiz
        {
            get
            {
                return _ftotalquiz;
            }

            set
            {
                _ftotalquiz = value;
            }
        }

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
