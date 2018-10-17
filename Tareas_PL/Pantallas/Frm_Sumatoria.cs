using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Tareas_DAL.DAL_Sumatoria;
using Tareas_BLL.BLL_Sumatoria;


namespace Tareas_PL.Pantallas
{
    public partial class Frm_Sumatoria : MetroFramework.Forms.MetroForm
    {
        Cls_Sumatoria_DAL ObjData = new Cls_Sumatoria_DAL();
        Cls_Sumatoria_BLL ObjFuncion = new Cls_Sumatoria_BLL();


        public Frm_Sumatoria()
        {
            InitializeComponent();
        }

        private void Frm_Sumatoria_Load(object sender, EventArgs e)
        {
            CultureInfo Culture = CultureInfo.CurrentCulture;
        }

        private void btn_Sumar_Click(object sender, EventArgs e)
        {
            ObjData.iNumeroLimite = Convert.ToInt16(txt_Numero_Limite.Text);

            if (rb_Pares.Checked == true)
            {
                ObjFuncion.SumarPares(ref ObjData);
            }
            else if (rb_Impares.Checked == true)
            {
                ObjFuncion.SumarImpares(ref ObjData);
            }
            else if (rb_Todos.Checked == true)
            {
                ObjFuncion.SumaTodo(ref ObjData);
            }
            txt_Resultado.Text = Convert.ToString(ObjData.iSuma);
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Numero_Limite.Text = "";
            txt_Resultado.Text = "";
            rb_Todos.Checked = false;
            rb_Pares.Checked = false;
            rb_Impares.Checked = false;
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Frm_Menu ObjForm = new Frm_Menu();

            this.Close();

            if (ObjForm.ShowInTaskbar == true)
            {
                ObjForm.ShowInTaskbar = false;
                ObjForm.Visible = true;
            }
        }
    }
}
