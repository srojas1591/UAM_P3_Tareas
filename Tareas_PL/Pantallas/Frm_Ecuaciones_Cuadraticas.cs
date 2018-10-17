using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tareas_DAL.DAL_Ecuacion_Cuadratica;
using Tareas_BLL.BLL_Ecuacion_Cuadratica;

namespace Tareas_PL.Pantallas
{
    public partial class Frm_Ecuaciones_Cuadraticas : MetroFramework.Forms.MetroForm
    {
        Cls_Ecuacion_Cuadratica_DAL ObjEcuacionCuadratica_DAL = new Cls_Ecuacion_Cuadratica_DAL();
        Cls_Ecuacion_Cuadratica_BLL ObjEcuacionCuadratica_BLL = new Cls_Ecuacion_Cuadratica_BLL();
        public Frm_Ecuaciones_Cuadraticas()
        {
            InitializeComponent();
        }



        private void Frm_Ecuaciones_Cuadraticas_Load(object sender, EventArgs e)
        {

        }



        private void Frm_Ecuaciones_Cuadraticas_FormClosed(object sender, FormClosedEventArgs e)
        {
            {
                Frm_Menu ObjForm = new Frm_Menu(); // Crea una instancia al Form anterior

                if (ObjForm.ShowInTaskbar == true) // Valida si el Form anterior esta minizado
                {
                    ObjForm.ShowInTaskbar = false; // Cambia el valor y lo remueve de la barra de tareas

                    ObjForm.Visible = true; // Hace visible el Form anterior minizado
                }
            }
        }

        private void btn_Ecuaciones_Cuadraticas_Calcular_Click(object sender, EventArgs e)
        {
            #region Recoleccion de Datos

            ObjEcuacionCuadratica_DAL.iValorA = Convert.ToInt16(txt_Ecuacion_Cuadratica_A.Text);
            ObjEcuacionCuadratica_DAL.iValorB = Convert.ToInt16(txt_Ecuacion_Cuadratica_B.Text);
            ObjEcuacionCuadratica_DAL.iValorC = Convert.ToInt16(txt_Ecuacion_Cuadratica_C.Text);

            ObjEcuacionCuadratica_BLL.CalculoDiscriminate(ref ObjEcuacionCuadratica_DAL);

            #endregion

            #region Calculo Ecuacion Cuadratica

            if (ObjEcuacionCuadratica_DAL.fValorDiscriminate < 0)
            {
                MessageBox.Show("La ecuacion no tiene solicion", "Ecuacion Cuadratica", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (ObjEcuacionCuadratica_DAL.fValorDiscriminate == 0)
            {
                MessageBox.Show("La ecuacion solo tiene una solicion", "Ecuacion Cuadratica", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ObjEcuacionCuadratica_BLL.CalculoSolucion(ref ObjEcuacionCuadratica_DAL);
            }
            else
            {
                MessageBox.Show("La ecuacion tiene 2 soluciones", "Ecuacion Cuadratica", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ObjEcuacionCuadratica_BLL.CalculoDosSoluciones(ref ObjEcuacionCuadratica_DAL);
            }
            #endregion

            #region Resultados

            txt_Ecuacion_Cuadratica_Discriminate.Text = Convert.ToString(ObjEcuacionCuadratica_DAL.fValorDiscriminate);
            txt_Ecuacion_Cuadratica_Solucion_1.Text = Convert.ToString(ObjEcuacionCuadratica_DAL.fSolucion1);
            txt_Ecuacion_Cuadratica_Solucion_2.Text = Convert.ToString(ObjEcuacionCuadratica_DAL.fSolucion2);

            #endregion

        }

        private void txt_Ecuacion_Cuadratica_A_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_Ecuacion_Cuadratica_B_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_Ecuacion_Cuadratica_C_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void btn_Ecuaciones_Cuadraticas_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Ecuacion_Cuadratica_A.Text = "";
            txt_Ecuacion_Cuadratica_B.Text = "";
            txt_Ecuacion_Cuadratica_C.Text = "";

            txt_Ecuacion_Cuadratica_Discriminate.Text = "";
            txt_Ecuacion_Cuadratica_Solucion_1.Text = "";
            txt_Ecuacion_Cuadratica_Solucion_2.Text = "";

        }
    }
}
