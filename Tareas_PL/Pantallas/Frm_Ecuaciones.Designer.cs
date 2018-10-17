namespace Tareas_PL.Pantallas
{
    partial class Frm_Ecuaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Ecuaciones));
            this.lbl_A = new MetroFramework.Controls.MetroLabel();
            this.lbl_B = new MetroFramework.Controls.MetroLabel();
            this.lbl_C = new MetroFramework.Controls.MetroLabel();
            this.txt_A = new MetroFramework.Controls.MetroTextBox();
            this.txt_B = new MetroFramework.Controls.MetroTextBox();
            this.txt_C = new MetroFramework.Controls.MetroTextBox();
            this.lbl_Resultado = new MetroFramework.Controls.MetroLabel();
            this.txt_Resultado = new MetroFramework.Controls.MetroTextBox();
            this.btn_Cerrar_Ecuaciones = new MetroFramework.Controls.MetroTile();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Calcular_Ecuaciones = new MetroFramework.Controls.MetroTile();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_A
            // 
            this.lbl_A.AutoSize = true;
            this.lbl_A.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_A.Location = new System.Drawing.Point(26, 21);
            this.lbl_A.Name = "lbl_A";
            this.lbl_A.Size = new System.Drawing.Size(19, 19);
            this.lbl_A.TabIndex = 2;
            this.lbl_A.Text = "A";
            // 
            // lbl_B
            // 
            this.lbl_B.AutoSize = true;
            this.lbl_B.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_B.Location = new System.Drawing.Point(98, 21);
            this.lbl_B.Name = "lbl_B";
            this.lbl_B.Size = new System.Drawing.Size(18, 19);
            this.lbl_B.TabIndex = 3;
            this.lbl_B.Text = "B";
            // 
            // lbl_C
            // 
            this.lbl_C.AutoSize = true;
            this.lbl_C.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_C.Location = new System.Drawing.Point(167, 21);
            this.lbl_C.Name = "lbl_C";
            this.lbl_C.Size = new System.Drawing.Size(18, 19);
            this.lbl_C.TabIndex = 4;
            this.lbl_C.Text = "C";
            // 
            // txt_A
            // 
            this.txt_A.Location = new System.Drawing.Point(16, 53);
            this.txt_A.Name = "txt_A";
            this.txt_A.Size = new System.Drawing.Size(39, 23);
            this.txt_A.Style = MetroFramework.MetroColorStyle.Orange;
            this.txt_A.TabIndex = 5;
            this.txt_A.UseStyleColors = true;
            // 
            // txt_B
            // 
            this.txt_B.Location = new System.Drawing.Point(86, 53);
            this.txt_B.Name = "txt_B";
            this.txt_B.Size = new System.Drawing.Size(39, 23);
            this.txt_B.Style = MetroFramework.MetroColorStyle.Orange;
            this.txt_B.TabIndex = 6;
            this.txt_B.UseStyleColors = true;
            // 
            // txt_C
            // 
            this.txt_C.Location = new System.Drawing.Point(157, 53);
            this.txt_C.Name = "txt_C";
            this.txt_C.Size = new System.Drawing.Size(39, 23);
            this.txt_C.Style = MetroFramework.MetroColorStyle.Orange;
            this.txt_C.TabIndex = 7;
            this.txt_C.UseStyleColors = true;
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_Resultado.Location = new System.Drawing.Point(6, 98);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(75, 19);
            this.lbl_Resultado.TabIndex = 9;
            this.lbl_Resultado.Text = "Resultado";
            // 
            // txt_Resultado
            // 
            this.txt_Resultado.Enabled = false;
            this.txt_Resultado.Location = new System.Drawing.Point(89, 98);
            this.txt_Resultado.Name = "txt_Resultado";
            this.txt_Resultado.Size = new System.Drawing.Size(107, 23);
            this.txt_Resultado.Style = MetroFramework.MetroColorStyle.Orange;
            this.txt_Resultado.TabIndex = 10;
            this.txt_Resultado.UseStyleColors = true;
            // 
            // btn_Cerrar_Ecuaciones
            // 
            this.btn_Cerrar_Ecuaciones.Location = new System.Drawing.Point(130, 210);
            this.btn_Cerrar_Ecuaciones.Name = "btn_Cerrar_Ecuaciones";
            this.btn_Cerrar_Ecuaciones.Size = new System.Drawing.Size(89, 20);
            this.btn_Cerrar_Ecuaciones.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_Cerrar_Ecuaciones.TabIndex = 1;
            this.btn_Cerrar_Ecuaciones.Text = "Cerrar";
            this.btn_Cerrar_Ecuaciones.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Cerrar_Ecuaciones.Click += new System.EventHandler(this.btn_Cerrar_Ecuaciones_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Calcular_Ecuaciones);
            this.groupBox1.Controls.Add(this.txt_Resultado);
            this.groupBox1.Controls.Add(this.lbl_C);
            this.groupBox1.Controls.Add(this.lbl_Resultado);
            this.groupBox1.Controls.Add(this.lbl_A);
            this.groupBox1.Controls.Add(this.lbl_B);
            this.groupBox1.Controls.Add(this.txt_C);
            this.groupBox1.Controls.Add(this.txt_A);
            this.groupBox1.Controls.Add(this.txt_B);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 135);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informacion de la Ecuacion";
            // 
            // btn_Calcular_Ecuaciones
            // 
            this.btn_Calcular_Ecuaciones.Location = new System.Drawing.Point(227, 37);
            this.btn_Calcular_Ecuaciones.Name = "btn_Calcular_Ecuaciones";
            this.btn_Calcular_Ecuaciones.Size = new System.Drawing.Size(75, 68);
            this.btn_Calcular_Ecuaciones.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_Calcular_Ecuaciones.TabIndex = 11;
            this.btn_Calcular_Ecuaciones.Text = "Calcular";
            this.btn_Calcular_Ecuaciones.TileImage = global::Tareas_PL.Properties.Resources.process;
            this.btn_Calcular_Ecuaciones.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Calcular_Ecuaciones.UseTileImage = true;
            this.btn_Calcular_Ecuaciones.Click += new System.EventHandler(this.btn_Calcular_Ecuaciones_Click);
            // 
            // Frm_Ecuaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(360, 253);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Cerrar_Ecuaciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Ecuaciones";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Ecuaciones Primer Grado";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Ecuaciones_FormClosed);
            this.Load += new System.EventHandler(this.Frm_Ecuaciones_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLabel lbl_A;
        private MetroFramework.Controls.MetroLabel lbl_C;
        private MetroFramework.Controls.MetroLabel lbl_B;
        private MetroFramework.Controls.MetroTextBox txt_A;
        private MetroFramework.Controls.MetroTextBox txt_B;
        private MetroFramework.Controls.MetroTextBox txt_C;
        private MetroFramework.Controls.MetroLabel lbl_Resultado;
        private MetroFramework.Controls.MetroTextBox txt_Resultado;
        private MetroFramework.Controls.MetroTile btn_Cerrar_Ecuaciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTile btn_Calcular_Ecuaciones;
    }
}