using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tareas_BLL.BLL_Ecuacion;
using Tareas_DAL.DAL_Ecuacion;

namespace Tareas_PL.Pantallas
{
    public partial class Frm_Ecuaciones : MetroFramework.Forms.MetroForm
    {

        public Frm_Ecuaciones()
        {
            InitializeComponent();
        }

        private void Frm_Ecuaciones_Load(object sender, EventArgs e)
        {

        }

        private void Frm_Ecuaciones_FormClosed(object sender, FormClosedEventArgs e)
        {
            Frm_Menu ObjForm = new Frm_Menu(); // Crea una instancia al Form anterior

            if (ObjForm.ShowInTaskbar == true) // Valida si el Form anterior esta minizado
            {
                ObjForm.ShowInTaskbar = false; // Cambia el valor y lo remueve de la barra de tareas

                ObjForm.Visible = true; // Hace visible el Form anterior minizado
            }
        }



        private void btn_Cerrar_Ecuaciones_Click(object sender, EventArgs e)
        {
            Frm_Menu ObjForm = new Frm_Menu();

            this.Close();

            if (ObjForm.ShowInTaskbar == true)
            {
                ObjForm.ShowInTaskbar = false;
                ObjForm.Visible = true;
            }
        }

        private void btn_Calcular_Ecuaciones_Click(object sender, EventArgs e)
        {
            try
            {
                Cls_Ecuacion_BLL Obj_Calculos_BLL = new Cls_Ecuacion_BLL();
                Cls_Ecuacion_DAL Obj_Datos_DAL = new Cls_Ecuacion_DAL();

                Obj_Datos_DAL.fvariable_a = Convert.ToSingle(txt_A.Text);
                Obj_Datos_DAL.fvariable_b = Convert.ToSingle(txt_B.Text);
                Obj_Datos_DAL.fvariable_x = Convert.ToSingle(txt_C.Text);

                Obj_Calculos_BLL.EcuacionPrimerGrado(ref Obj_Datos_DAL);

                txt_Resultado.Text = Obj_Datos_DAL.fvariable_x.ToString("F1");
            }
            catch (Exception error)
            {

                MessageBox.Show("Error" + error);

            }
        }
    }
}
