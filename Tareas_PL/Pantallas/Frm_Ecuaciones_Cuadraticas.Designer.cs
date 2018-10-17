namespace Tareas_PL.Pantallas
{
    partial class Frm_Ecuaciones_Cuadraticas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Ecuacion_Cuadratica_A = new MetroFramework.Controls.MetroTextBox();
            this.txt_Ecuacion_Cuadratica_B = new MetroFramework.Controls.MetroTextBox();
            this.txt_Ecuacion_Cuadratica_C = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txt_Ecuacion_Cuadratica_Discriminate = new MetroFramework.Controls.MetroTextBox();
            this.txt_Ecuacion_Cuadratica_Solucion_1 = new MetroFramework.Controls.MetroTextBox();
            this.txt_Ecuacion_Cuadratica_Solucion_2 = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Ecuaciones_Cuadraticas_Calcular = new MetroFramework.Controls.MetroButton();
            this.btn_Ecuaciones_Cuadraticas_Limpiar = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txt_Ecuacion_Cuadratica_Solucion_2);
            this.groupBox1.Controls.Add(this.txt_Ecuacion_Cuadratica_Solucion_1);
            this.groupBox1.Controls.Add(this.txt_Ecuacion_Cuadratica_Discriminate);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.txt_Ecuacion_Cuadratica_C);
            this.groupBox1.Controls.Add(this.txt_Ecuacion_Cuadratica_B);
            this.groupBox1.Controls.Add(this.txt_Ecuacion_Cuadratica_A);
            this.groupBox1.Location = new System.Drawing.Point(24, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion de la Ecuacion";
            // 
            // txt_Ecuacion_Cuadratica_A
            // 
            this.txt_Ecuacion_Cuadratica_A.Location = new System.Drawing.Point(10, 51);
            this.txt_Ecuacion_Cuadratica_A.Name = "txt_Ecuacion_Cuadratica_A";
            this.txt_Ecuacion_Cuadratica_A.Size = new System.Drawing.Size(75, 23);
            this.txt_Ecuacion_Cuadratica_A.Style = MetroFramework.MetroColorStyle.Lime;
            this.txt_Ecuacion_Cuadratica_A.TabIndex = 0;
            this.txt_Ecuacion_Cuadratica_A.UseStyleColors = true;
            this.txt_Ecuacion_Cuadratica_A.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Ecuacion_Cuadratica_A_KeyPress);
            // 
            // txt_Ecuacion_Cuadratica_B
            // 
            this.txt_Ecuacion_Cuadratica_B.Location = new System.Drawing.Point(103, 51);
            this.txt_Ecuacion_Cuadratica_B.Name = "txt_Ecuacion_Cuadratica_B";
            this.txt_Ecuacion_Cuadratica_B.Size = new System.Drawing.Size(75, 23);
            this.txt_Ecuacion_Cuadratica_B.Style = MetroFramework.MetroColorStyle.Lime;
            this.txt_Ecuacion_Cuadratica_B.TabIndex = 1;
            this.txt_Ecuacion_Cuadratica_B.UseStyleColors = true;
            this.txt_Ecuacion_Cuadratica_B.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Ecuacion_Cuadratica_B_KeyPress);
            // 
            // txt_Ecuacion_Cuadratica_C
            // 
            this.txt_Ecuacion_Cuadratica_C.Location = new System.Drawing.Point(207, 51);
            this.txt_Ecuacion_Cuadratica_C.Name = "txt_Ecuacion_Cuadratica_C";
            this.txt_Ecuacion_Cuadratica_C.Size = new System.Drawing.Size(75, 23);
            this.txt_Ecuacion_Cuadratica_C.Style = MetroFramework.MetroColorStyle.Lime;
            this.txt_Ecuacion_Cuadratica_C.TabIndex = 2;
            this.txt_Ecuacion_Cuadratica_C.UseStyleColors = true;
            this.txt_Ecuacion_Cuadratica_C.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Ecuacion_Cuadratica_C_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(41, 26);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(18, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "A";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(236, 26);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(18, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "C";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(132, 26);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(17, 19);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "B";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(10, 97);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(87, 19);
            this.metroLabel4.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Discriminante";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(10, 127);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(67, 19);
            this.metroLabel5.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "Solucion 1";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(10, 157);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(69, 19);
            this.metroLabel6.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel6.TabIndex = 8;
            this.metroLabel6.Text = "Solucion 2";
            // 
            // txt_Ecuacion_Cuadratica_Discriminate
            // 
            this.txt_Ecuacion_Cuadratica_Discriminate.Enabled = false;
            this.txt_Ecuacion_Cuadratica_Discriminate.Location = new System.Drawing.Point(103, 97);
            this.txt_Ecuacion_Cuadratica_Discriminate.Name = "txt_Ecuacion_Cuadratica_Discriminate";
            this.txt_Ecuacion_Cuadratica_Discriminate.Size = new System.Drawing.Size(75, 23);
            this.txt_Ecuacion_Cuadratica_Discriminate.Style = MetroFramework.MetroColorStyle.Lime;
            this.txt_Ecuacion_Cuadratica_Discriminate.TabIndex = 4;
            this.txt_Ecuacion_Cuadratica_Discriminate.UseStyleColors = true;
            // 
            // txt_Ecuacion_Cuadratica_Solucion_1
            // 
            this.txt_Ecuacion_Cuadratica_Solucion_1.Enabled = false;
            this.txt_Ecuacion_Cuadratica_Solucion_1.Location = new System.Drawing.Point(103, 127);
            this.txt_Ecuacion_Cuadratica_Solucion_1.Name = "txt_Ecuacion_Cuadratica_Solucion_1";
            this.txt_Ecuacion_Cuadratica_Solucion_1.Size = new System.Drawing.Size(75, 23);
            this.txt_Ecuacion_Cuadratica_Solucion_1.Style = MetroFramework.MetroColorStyle.Lime;
            this.txt_Ecuacion_Cuadratica_Solucion_1.TabIndex = 5;
            this.txt_Ecuacion_Cuadratica_Solucion_1.UseStyleColors = true;
            // 
            // txt_Ecuacion_Cuadratica_Solucion_2
            // 
            this.txt_Ecuacion_Cuadratica_Solucion_2.Enabled = false;
            this.txt_Ecuacion_Cuadratica_Solucion_2.Location = new System.Drawing.Point(103, 157);
            this.txt_Ecuacion_Cuadratica_Solucion_2.Name = "txt_Ecuacion_Cuadratica_Solucion_2";
            this.txt_Ecuacion_Cuadratica_Solucion_2.Size = new System.Drawing.Size(75, 23);
            this.txt_Ecuacion_Cuadratica_Solucion_2.Style = MetroFramework.MetroColorStyle.Lime;
            this.txt_Ecuacion_Cuadratica_Solucion_2.TabIndex = 6;
            this.txt_Ecuacion_Cuadratica_Solucion_2.UseStyleColors = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Ecuaciones_Cuadraticas_Limpiar);
            this.groupBox2.Controls.Add(this.btn_Ecuaciones_Cuadraticas_Calcular);
            this.groupBox2.Location = new System.Drawing.Point(190, 90);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(108, 90);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opciones";
            // 
            // btn_Ecuaciones_Cuadraticas_Calcular
            // 
            this.btn_Ecuaciones_Cuadraticas_Calcular.Location = new System.Drawing.Point(17, 20);
            this.btn_Ecuaciones_Cuadraticas_Calcular.Name = "btn_Ecuaciones_Cuadraticas_Calcular";
            this.btn_Ecuaciones_Cuadraticas_Calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_Ecuaciones_Cuadraticas_Calcular.Style = MetroFramework.MetroColorStyle.Lime;
            this.btn_Ecuaciones_Cuadraticas_Calcular.TabIndex = 0;
            this.btn_Ecuaciones_Cuadraticas_Calcular.Text = "Calcular";
            this.btn_Ecuaciones_Cuadraticas_Calcular.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn_Ecuaciones_Cuadraticas_Calcular.Click += new System.EventHandler(this.btn_Ecuaciones_Cuadraticas_Calcular_Click);
            // 
            // btn_Ecuaciones_Cuadraticas_Limpiar
            // 
            this.btn_Ecuaciones_Cuadraticas_Limpiar.Location = new System.Drawing.Point(17, 49);
            this.btn_Ecuaciones_Cuadraticas_Limpiar.Name = "btn_Ecuaciones_Cuadraticas_Limpiar";
            this.btn_Ecuaciones_Cuadraticas_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_Ecuaciones_Cuadraticas_Limpiar.Style = MetroFramework.MetroColorStyle.Lime;
            this.btn_Ecuaciones_Cuadraticas_Limpiar.TabIndex = 1;
            this.btn_Ecuaciones_Cuadraticas_Limpiar.Text = "Limpiar";
            this.btn_Ecuaciones_Cuadraticas_Limpiar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn_Ecuaciones_Cuadraticas_Limpiar.Click += new System.EventHandler(this.btn_Ecuaciones_Cuadraticas_Limpiar_Click);
            // 
            // Frm_Ecuaciones_Cuadraticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 279);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Ecuaciones_Cuadraticas";
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Ecuaciones Cuadraticas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Ecuaciones_Cuadraticas_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Ecuaciones_Cuadraticas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton btn_Ecuaciones_Cuadraticas_Limpiar;
        private MetroFramework.Controls.MetroButton btn_Ecuaciones_Cuadraticas_Calcular;
        private MetroFramework.Controls.MetroTextBox txt_Ecuacion_Cuadratica_Solucion_2;
        private MetroFramework.Controls.MetroTextBox txt_Ecuacion_Cuadratica_Solucion_1;
        private MetroFramework.Controls.MetroTextBox txt_Ecuacion_Cuadratica_Discriminate;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txt_Ecuacion_Cuadratica_C;
        private MetroFramework.Controls.MetroTextBox txt_Ecuacion_Cuadratica_B;
        private MetroFramework.Controls.MetroTextBox txt_Ecuacion_Cuadratica_A;
    }
}