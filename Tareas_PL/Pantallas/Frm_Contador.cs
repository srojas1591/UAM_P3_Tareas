using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Globalization;
using Tareas_BLL.BLL_Contador;
using Tareas_DAL.DAL_Contador;
using System.Timers;
using System.Diagnostics;

namespace Tareas_PL.Pantallas
{
    public partial class Frm_Contador : MetroFramework.Forms.MetroForm
    {
        CultureInfo culture = CultureInfo.CurrentCulture;
        Cls_Contador_BLL ObjBLL = new Cls_Contador_BLL();
        Cls_Contador_DAL ObjDAL = new Cls_Contador_DAL();
        Stopwatch Contador = new Stopwatch();


        public Frm_Contador()
        {
            InitializeComponent();
            txt_Tiempo.Text = "1";
        }


        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            tm_Contador.Enabled = true;
           
        }

        private void tm_Contador_Tick(object sender, EventArgs e)
        {
            ObjDAL.BLimit = Convert.ToByte(txt_Tiempo.Text);
            ObjDAL.BMiliseg++;
            txt_Milisegundos.Text = Convert.ToString(ObjDAL.BMiliseg);
            ObjBLL.Contar(ref ObjDAL);
            txt_Segundos.Text = Convert.ToString(ObjDAL.BSeg);
            txt_minutos.Text = Convert.ToString(ObjDAL.BMin);
            if (ObjDAL.BMin == ObjDAL.BLimit)
            {
                tm_Contador.Stop();
                ObjDAL.BMiliseg = 0;
            }
        }

        

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_Tiempo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_Tiempo_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Tiempo.Text))
            {
                btn_Iniciar.Enabled = false;
                btn_Limpiar.Enabled = false;
                btn_Detener.Enabled = false;
                lbl_Tiempo.ForeColor = Color.Red;
                MessageBox.Show("No deje campos vacios", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lbl_Tiempo.ForeColor = Color.Black;
                btn_Iniciar.Enabled = true;
                btn_Limpiar.Enabled = true;
                btn_Detener.Enabled = true;
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            Contador.Start();
            txt_Tiempo.Text = "0";
            txt_Milisegundos.Text = "";
            txt_minutos.Text = "";
            txt_Segundos.Text = "";

        
            
        }

        private void btn_Detener_Click(object sender, EventArgs e)
        {
            Contador.Stop();
            tm_Contador.Stop();
        }
    }
}

