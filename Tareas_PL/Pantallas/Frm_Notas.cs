using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tareas_BLL.BLL_Notas;
using Tareas_DAL.DAL_Notas;

namespace Tareas_PL.Pantallas
{
    public partial class Frm_Notas : MetroFramework.Forms.MetroForm
    {
        Cls_Notas_BLL Obj_Calculos_BLL = new Cls_Notas_BLL();
        Cls_Notas_DAL Obj_Datos_DAL = new Cls_Notas_DAL();
        public Frm_Notas()
        {
            InitializeComponent();
        }


        private void Frm_Notas_Load(object sender, EventArgs e)
        {

        }

        public void ErrorProviderCheck(EventArgs e)
        {
            if (string.IsNullOrEmpty(this.Text))
            {
                errorProvider1.SetError(this, "No deje campos en blanco");
            }
            errorProvider1.Clear();
        }

        private void Frm_Notas_FormClosed(object sender, FormClosedEventArgs e)
        {

            Frm_Menu ObjForm = new Frm_Menu();

            if (ObjForm.ShowInTaskbar == true)
            {
                ObjForm.ShowInTaskbar = false;
                ObjForm.Visible = true;
            }
        }

        private void btn_MostrarNota_Click(object sender, EventArgs e)
        {
            Cls_Notas_BLL Obj_Calculos_BLL = new Cls_Notas_BLL();
            Cls_Notas_DAL Obj_Datos_DAL = new Cls_Notas_DAL();


            Obj_Datos_DAL.Bporcent_parcial1 = Convert.ToByte(txt_porcent_parcial1.Text);
            Obj_Datos_DAL.Bporcent_parcial2 = Convert.ToByte(txt_porcent_parcial2.Text);
            Obj_Datos_DAL.Bporcent_parcial3 = Convert.ToByte(txt_porcent_parcial3.Text);
            Obj_Datos_DAL.Bporcent_quices = Convert.ToByte(txt_porcent_quices.Text);
            Obj_Datos_DAL.Bporcent_tarea = Convert.ToByte(txt_porcent_tareas.Text);

            Obj_Datos_DAL.bquiz1 = Convert.ToByte(txt_quiz1.Text);
            Obj_Datos_DAL.bquiz2 = Convert.ToByte(txt_quiz2.Text);
            Obj_Datos_DAL.bquiz3 = Convert.ToByte(txt_quiz3.Text);

            Obj_Datos_DAL.btarea1 = Convert.ToByte(txt_tarea1.Text);
            Obj_Datos_DAL.btarea2 = Convert.ToByte(txt_tarea2.Text);
            Obj_Datos_DAL.btarea3 = Convert.ToByte(txt_tarea3.Text);
            Obj_Datos_DAL.btarea4 = Convert.ToByte(txt_tarea4.Text);

            Obj_Datos_DAL.bparcial1 = Convert.ToByte(txt_parcial1.Text);
            Obj_Datos_DAL.bparcial2 = Convert.ToByte(txt_parcial2.Text);
            Obj_Datos_DAL.bparcial3 = Convert.ToByte(txt_parcial3.Text);

            Obj_Calculos_BLL.Quices(ref Obj_Datos_DAL);
            Obj_Calculos_BLL.Tareas(ref Obj_Datos_DAL);


            txt_nota_quices.Text = Obj_Datos_DAL.ftotalquiz.ToString("f2");
            txt_nota_tareas.Text = Obj_Datos_DAL.ftotaltarea.ToString("f2");

            txt_nota_final.Text = (Obj_Datos_DAL.ftotaltarea * Obj_Datos_DAL.Bporcent_tarea / 100 + Obj_Datos_DAL.ftotalquiz * Obj_Datos_DAL.Bporcent_quices / 100 + Obj_Datos_DAL.bparcial1 * Obj_Datos_DAL.Bporcent_parcial1 / 100 + Obj_Datos_DAL.bparcial2 * Obj_Datos_DAL.Bporcent_parcial2 / 100 + Obj_Datos_DAL.bparcial3 * Obj_Datos_DAL.Bporcent_parcial3 / 100).ToString("F2");
        }

        private void btn_CerrarVentana_Click(object sender, EventArgs e)
        {
            Frm_Menu ObjForm = new Frm_Menu();

            this.Close();

            if (ObjForm.ShowInTaskbar == true)
            {
                ObjForm.ShowInTaskbar = false;
                ObjForm.Visible = true;
            }
        }
        #region KeyPress
        private void txt_porcent_tareas_KeyPress(object sender, KeyPressEventArgs e)

        {

            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+")) e.Handled = true;

        }


        private void txt_porcent_parcial1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+")) e.Handled = true;
        }

        private void txt_porcent_quices_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+")) e.Handled = true;
        }

        private void txt_porcent_parcial2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+")) e.Handled = true;
        }

        private void txt_porcent_parcial3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+")) e.Handled = true;
        }
        #endregion

        #region TextChanged
        private void txt_porcent_tareas_TextChanged(object sender, EventArgs e)
        {


        }

        private void txt_porcent_quices_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_porcent_parcial1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_porcent_parcial2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_porcent_parcial3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_quiz1_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_quiz1.Text))
            {
                txt_quiz1.Text = "0";
            }
        }

        private void txt_quiz2_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_quiz2.Text))
            {
                txt_quiz2.Text = "0";
            }
        }

        private void txt_quiz3_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_quiz3.Text))
            {
                txt_quiz3.Text = "0";
            }
        }

        private void txt_tarea1_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_tarea1.Text))
            {
                txt_tarea1.Text = "0";
            }
        }

        private void txt_tarea2_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_tarea2.Text))
            {
                txt_tarea2.Text = "0";
            }
        }

        private void txt_tarea3_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_tarea3.Text))
            {
                txt_tarea3.Text = "0";
            }
        }

        private void txt_tarea4_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_tarea4.Text))
            {
                txt_tarea4.Text = "0";
            }
        }

        private void txt_parcial1_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_parcial1.Text))
            {
                txt_parcial1.Text = "0";
            }
        }

        private void txt_parcial2_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_parcial2.Text))
            {
                txt_parcial2.Text = "0";
            }
        }

        private void txt_parcial3_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_parcial3.Text))
            {
                txt_parcial3.Text = "0";
            }
        }

        #endregion

        private void txt_porcent_tareas_Validated(object sender, EventArgs e)
        {

        }

        private void txt_porcent_tareas_Validating(object sender, CancelEventArgs e)
        {

        }

        
    }
}
