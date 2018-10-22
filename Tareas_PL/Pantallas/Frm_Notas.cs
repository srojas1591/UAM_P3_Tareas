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



            if (Obj_Datos_DAL.Bporcent_tarea + Obj_Datos_DAL.Bporcent_quices + Obj_Datos_DAL.Bporcent_parcial1 + Obj_Datos_DAL.Bporcent_parcial2 + Obj_Datos_DAL.Bporcent_parcial3 > 100)
            {
                MessageBox.Show("La sumatoria de los porcentajes debe ser 100");
                txt_porcent_parcial1.Text = "0";
                txt_porcent_parcial2.Text = "0";
                txt_porcent_parcial3.Text = "0";
                txt_porcent_quices.Text = "0";
                txt_porcent_tareas.Text = "0";
                errorProvider1.SetError(this.txt_porcent_parcial1, "El valor digitado no debe ser mayor a 100");
                errorProvider1.SetError(this.txt_porcent_parcial2, "El valor digitado no debe ser mayor a 100");
                errorProvider1.SetError(this.txt_porcent_parcial3, "El valor digitado no debe ser mayor a 100");
                errorProvider1.SetError(this.txt_porcent_quices, "El valor digitado no debe ser mayor a 100");
                errorProvider1.SetError(this.txt_porcent_tareas, "El valor digitado no debe ser mayor a 100");

                return;
            }else if (Obj_Datos_DAL.bquiz1 + Obj_Datos_DAL.bquiz2 + Obj_Datos_DAL.bquiz3 > 100)
            {
                MessageBox.Show("La sumatoria de los Quices debe ser 100");
                txt_quiz1.Text = "0";
                txt_quiz2.Text = "0";
                txt_quiz3.Text = "0";
                errorProvider1.SetError(this.txt_quiz1, "El valor digitado no debe ser mayor a 100");
                errorProvider1.SetError(this.txt_quiz2, "El valor digitado no debe ser mayor a 100");
                errorProvider1.SetError(this.txt_quiz3, "El valor digitado no debe ser mayor a 100");
                return;

            } else if (Obj_Datos_DAL.btarea1 + Obj_Datos_DAL.btarea2 + Obj_Datos_DAL.btarea3 + Obj_Datos_DAL.btarea4 > 100)
            {
                MessageBox.Show("La sumatoria de las Tarea debe ser 100");
                txt_tarea1.Text = "0";
                txt_tarea2.Text = "0";
                txt_tarea3.Text = "0";
                txt_tarea4.Text = "0";
                errorProvider1.SetError(this.txt_tarea1, "El valor digitado no debe ser mayor a 100");
                errorProvider1.SetError(this.txt_tarea2, "El valor digitado no debe ser mayor a 100");
                errorProvider1.SetError(this.txt_tarea3, "El valor digitado no debe ser mayor a 100");
                errorProvider1.SetError(this.txt_tarea4, "El valor digitado no debe ser mayor a 100");
                return;

            }else if (Obj_Datos_DAL.bparcial1 + Obj_Datos_DAL.bparcial2 + Obj_Datos_DAL.bparcial3 > 100)
            {
                MessageBox.Show("La sumatoria de los Examenes debe ser 100");
                txt_parcial1.Text = "0";
                txt_parcial2.Text = "0";
                txt_parcial3.Text = "0";
                errorProvider1.SetError(this.txt_parcial1, "El valor digitado no debe ser mayor a 100");
                errorProvider1.SetError(this.txt_parcial2, "El valor digitado no debe ser mayor a 100");
                errorProvider1.SetError(this.txt_parcial3, "El valor digitado no debe ser mayor a 100");
                return;
            }
            
            else
                errorProvider1.Clear();
            
            {
                

                Obj_Calculos_BLL.Quices(ref Obj_Datos_DAL);
                Obj_Calculos_BLL.Tareas(ref Obj_Datos_DAL);


                txt_nota_quices.Text = Obj_Datos_DAL.ftotalquiz.ToString("f2");
                txt_nota_tareas.Text = Obj_Datos_DAL.ftotaltarea.ToString("f2");

                txt_nota_final.Text = (Obj_Datos_DAL.ftotaltarea * Obj_Datos_DAL.Bporcent_tarea / 100 + Obj_Datos_DAL.ftotalquiz * Obj_Datos_DAL.Bporcent_quices / 100 + Obj_Datos_DAL.bparcial1 * Obj_Datos_DAL.Bporcent_parcial1 / 100 + Obj_Datos_DAL.bparcial2 * Obj_Datos_DAL.Bporcent_parcial2 / 100 + Obj_Datos_DAL.bparcial3 * Obj_Datos_DAL.Bporcent_parcial3 / 100).ToString("F2");
            }


            
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
            char c = e.KeyChar;
            if ((!char.IsDigit(c) ||
                Convert.ToInt32(txt_porcent_tareas.Text + e.KeyChar) >= 101 ||
                txt_porcent_tareas.Text == "0") && c != '\b')
                e.Handled = true;
            
        }

        private void txt_porcent_parcial1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((!char.IsDigit(c) ||
                Convert.ToInt32(txt_porcent_parcial1.Text + e.KeyChar) >= 101 ||
                txt_porcent_parcial1.Text == "0") && c != '\b')
                e.Handled = true;
            
        }

        private void txt_porcent_quices_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((!char.IsDigit(c) ||
                Convert.ToInt32(txt_porcent_quices.Text + e.KeyChar) >= 101 ||
                txt_porcent_quices.Text == "0") && c != '\b')
                e.Handled = true;
        }

        private void txt_porcent_parcial2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((!char.IsDigit(c) ||
                Convert.ToInt32(txt_porcent_parcial2.Text + e.KeyChar) >= 101 ||
                txt_porcent_parcial2.Text == "0") && c != '\b')
                e.Handled = true;
        }

        private void txt_porcent_parcial3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((!char.IsDigit(c) ||
                Convert.ToInt32(txt_porcent_parcial3.Text + e.KeyChar) >= 101 ||
                txt_porcent_parcial3.Text == "0") && c != '\b')
                e.Handled = true;
        }

        private void txt_quiz1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((!char.IsDigit(c) ||
                Convert.ToInt32(txt_quiz1.Text + e.KeyChar) >= 101 ||
                txt_quiz1.Text == "0") && c != '\b')
                e.Handled = true;
        }

        private void txt_quiz2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((!char.IsDigit(c) ||
                Convert.ToInt32(txt_quiz2.Text + e.KeyChar) >= 101 ||
                txt_quiz2.Text == "0") && c != '\b')
                e.Handled = true;
        }

        private void txt_quiz3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((!char.IsDigit(c) ||
                Convert.ToInt32(txt_quiz3.Text + e.KeyChar) >= 101 ||
                txt_quiz3.Text == "0") && c != '\b')
                e.Handled = true;
        }

        private void txt_tarea1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((!char.IsDigit(c) ||
                Convert.ToInt32(txt_tarea1.Text + e.KeyChar) >= 101 ||
                txt_tarea1.Text == "0") && c != '\b')
                e.Handled = true;
        }

        private void txt_tarea2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((!char.IsDigit(c) ||
                Convert.ToInt32(txt_tarea2.Text + e.KeyChar) >= 101 ||
                txt_tarea2.Text == "0") && c != '\b')
                e.Handled = true;
        }

        private void txt_tarea3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((!char.IsDigit(c) ||
                Convert.ToInt32(txt_tarea3.Text + e.KeyChar) >= 101 ||
                txt_tarea3.Text == "0") && c != '\b')
                e.Handled = true;
        }

        private void txt_tarea4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((!char.IsDigit(c) ||
                Convert.ToInt32(txt_tarea4.Text + e.KeyChar) >= 101 ||
                txt_tarea4.Text == "0") && c != '\b')
                e.Handled = true;
        }

        private void txt_parcial1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((!char.IsDigit(c) ||
                Convert.ToInt32(txt_parcial1.Text + e.KeyChar) >= 101 ||
                txt_parcial1.Text == "0") && c != '\b')
                e.Handled = true;
        }

        private void txt_parcial2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((!char.IsDigit(c) ||
                Convert.ToInt32(txt_parcial2.Text + e.KeyChar) >= 101 ||
                txt_parcial2.Text == "0") && c != '\b')
                e.Handled = true;
        }



        private void txt_parcial3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if ((!char.IsDigit(c) ||
                Convert.ToInt32(txt_parcial3.Text + e.KeyChar) >= 101 ||
                txt_parcial3.Text == "0") && c != '\b')
                e.Handled = true;
        }
        #endregion

        #region TextChanged
        private void txt_porcent_tareas_TextChanged(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txt_porcent_tareas.Text))
            {
                btn_MostrarNota.Enabled = false;
                lbl_Tareas.ForeColor = Color.Red;
                MessageBox.Show("No deje campos vacios", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            else
            {
                lbl_Tareas.ForeColor = Color.Black;
                btn_MostrarNota.Enabled = true;
                
            }

        }

        private void txt_porcent_quices_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_porcent_quices.Text))
            {
                btn_MostrarNota.Enabled = false;
                lbl_Quices.ForeColor = Color.Red;
                MessageBox.Show("No deje campos vacios", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lbl_Quices.ForeColor = Color.Black;
                btn_MostrarNota.Enabled = true;

            }
        }

        private void txt_porcent_parcial1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_porcent_parcial1.Text))
            {
                btn_MostrarNota.Enabled = false;
                lbl_pn1_Parcial1.ForeColor = Color.Red;
                MessageBox.Show("No deje campos vacios", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lbl_pn1_Parcial1.ForeColor = Color.Black;
                btn_MostrarNota.Enabled = true;

            }
        }

        private void txt_porcent_parcial2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_porcent_parcial2.Text))
            {
                btn_MostrarNota.Enabled = false;
                lbl_pn1_Parcial2.ForeColor = Color.Red;
                MessageBox.Show("No deje campos vacios", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lbl_pn1_Parcial2.ForeColor = Color.Black;
                btn_MostrarNota.Enabled = true;

            }
        }

        private void txt_porcent_parcial3_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_porcent_parcial3.Text))
            {
                btn_MostrarNota.Enabled = false;
                lbl_pn1_Parcial3.ForeColor = Color.Red;
                MessageBox.Show("No deje campos vacios", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lbl_pn1_Parcial3.ForeColor = Color.Black;
                btn_MostrarNota.Enabled = true;

            }
        }

        private void txt_quiz1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_quiz1.Text))
            {
                btn_MostrarNota.Enabled = false;
                lbl_quiz1.ForeColor = Color.Red;
                MessageBox.Show("No deje campos vacios", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lbl_quiz1.ForeColor = Color.Black;
                btn_MostrarNota.Enabled = true;

            }
        }

        private void txt_quiz2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_quiz2.Text))
            {
                btn_MostrarNota.Enabled = false;
                lbl_quiz2.ForeColor = Color.Red;
                MessageBox.Show("No deje campos vacios", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lbl_quiz2.ForeColor = Color.Black;
                btn_MostrarNota.Enabled = true;

            }
        }

        private void txt_quiz3_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_quiz3.Text))
            {
                btn_MostrarNota.Enabled = false;
                lbl_quiz3.ForeColor = Color.Red;
                MessageBox.Show("No deje campos vacios", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lbl_quiz3.ForeColor = Color.Black;
                btn_MostrarNota.Enabled = true;

            }
        }

        private void txt_tarea1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_tarea1.Text))
            {
                btn_MostrarNota.Enabled = false;
                lbl_Tarea1.ForeColor = Color.Red;
                MessageBox.Show("No deje campos vacios", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lbl_Tarea1.ForeColor = Color.Black;
                btn_MostrarNota.Enabled = true;

            }
        }

        private void txt_tarea2_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txt_tarea2.Text))
            {
                btn_MostrarNota.Enabled = false;
                lbl_Tarea2.ForeColor = Color.Red;
                MessageBox.Show("No deje campos vacios", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lbl_Tarea2.ForeColor = Color.Black;
                btn_MostrarNota.Enabled = true;

            }
        }

        private void txt_tarea3_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_tarea3.Text))
            {
                btn_MostrarNota.Enabled = false;
                lbl_Tarea3.ForeColor = Color.Red;
                MessageBox.Show("No deje campos vacios", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lbl_Tarea3.ForeColor = Color.Black;
                btn_MostrarNota.Enabled = true;

            }
        }

        private void txt_tarea4_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_tarea4.Text))
            {
                btn_MostrarNota.Enabled = false;
                lbl_Tarea4.ForeColor = Color.Red;
                MessageBox.Show("No deje campos vacios", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lbl_Tarea4.ForeColor = Color.Black;
                btn_MostrarNota.Enabled = true;

            }
        }

        private void txt_parcial1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_parcial1.Text))
            {
                btn_MostrarNota.Enabled = false;
                lbl_Parcial1.ForeColor = Color.Red;
                MessageBox.Show("No deje campos vacios", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lbl_Parcial1.ForeColor = Color.Black;
                btn_MostrarNota.Enabled = true;

            }
        }

        private void txt_parcial2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_parcial2.Text))
            {
                btn_MostrarNota.Enabled = false;
                lbl_Parcial2.ForeColor = Color.Red;
                MessageBox.Show("No deje campos vacios", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lbl_Parcial2.ForeColor = Color.Black;
                btn_MostrarNota.Enabled = true;

            }
        }

        private void txt_parcial3_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_parcial3.Text))
            {
                btn_MostrarNota.Enabled = false;
                lbl_Parcial3.ForeColor = Color.Red;
                MessageBox.Show("No deje campos vacios", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lbl_Parcial3.ForeColor = Color.Black;
                btn_MostrarNota.Enabled = true;

            }
        }

        #endregion

       
    }
}
