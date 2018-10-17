using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tareas_PL.Pantallas
{
    public partial class Frm_Menu : MetroFramework.Forms.MetroForm
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void Frm_Menu_Load(object sender, EventArgs e)
        {

        }



        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Evaluacion_Click(object sender, EventArgs e)
        {
            Frm_Notas ObjForm = new Frm_Notas(); //Instancia al nuevo Form

            this.WindowState = FormWindowState.Minimized; //Minimiza la ventana del Menu, la envia a la barra de Tareas

            ObjForm.ShowDialog(); // Muestra el nuevo Form, sin permitir la edicion del anterior

        }

        private void btn_Ecuaciones_Click(object sender, EventArgs e)
        {
            Frm_Ecuaciones ObjForm = new Frm_Ecuaciones();

            this.WindowState = FormWindowState.Minimized; //Minimiza la ventana del Menu, la envia a la barra de Tareas

            ObjForm.ShowDialog(); // Muestra el nuevo Form, sin permitir la edicion del anterior

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Frm_Ecuaciones_Cuadraticas ObjForm = new Frm_Ecuaciones_Cuadraticas();

            this.WindowState = FormWindowState.Minimized;

            ObjForm.ShowDialog();
        }

        private void Frm_Sumatoria_Click(object sender, EventArgs e)
        {
            Frm_Sumatoria ObjForm = new Frm_Sumatoria();
            this.WindowState = FormWindowState.Minimized;
            ObjForm.ShowDialog();

        }
    }
}
