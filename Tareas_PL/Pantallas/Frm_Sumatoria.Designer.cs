namespace Tareas_PL.Pantallas
{
    partial class Frm_Sumatoria
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
            this.gb_Sumatoria = new System.Windows.Forms.GroupBox();
            this.lbl_Numero_Limite = new MetroFramework.Controls.MetroLabel();
            this.txt_Numero_Limite = new MetroFramework.Controls.MetroTextBox();
            this.gb_Control = new System.Windows.Forms.GroupBox();
            this.rb_Todos = new MetroFramework.Controls.MetroRadioButton();
            this.rb_Pares = new MetroFramework.Controls.MetroRadioButton();
            this.rb_Impares = new MetroFramework.Controls.MetroRadioButton();
            this.gb_Opciones = new System.Windows.Forms.GroupBox();
            this.lbl_Resultado = new MetroFramework.Controls.MetroLabel();
            this.txt_Resultado = new MetroFramework.Controls.MetroTextBox();
            this.btn_Salir = new MetroFramework.Controls.MetroTile();
            this.btn_Sumar = new MetroFramework.Controls.MetroTile();
            this.btn_Limpiar = new MetroFramework.Controls.MetroTile();
            this.gb_Sumatoria.SuspendLayout();
            this.gb_Control.SuspendLayout();
            this.gb_Opciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Sumatoria
            // 
            this.gb_Sumatoria.Controls.Add(this.txt_Resultado);
            this.gb_Sumatoria.Controls.Add(this.lbl_Resultado);
            this.gb_Sumatoria.Controls.Add(this.gb_Opciones);
            this.gb_Sumatoria.Controls.Add(this.gb_Control);
            this.gb_Sumatoria.Controls.Add(this.txt_Numero_Limite);
            this.gb_Sumatoria.Controls.Add(this.lbl_Numero_Limite);
            this.gb_Sumatoria.Location = new System.Drawing.Point(23, 63);
            this.gb_Sumatoria.Name = "gb_Sumatoria";
            this.gb_Sumatoria.Size = new System.Drawing.Size(438, 223);
            this.gb_Sumatoria.TabIndex = 0;
            this.gb_Sumatoria.TabStop = false;
            this.gb_Sumatoria.Text = "Sumatoria";
            // 
            // lbl_Numero_Limite
            // 
            this.lbl_Numero_Limite.AutoSize = true;
            this.lbl_Numero_Limite.Location = new System.Drawing.Point(7, 33);
            this.lbl_Numero_Limite.Name = "lbl_Numero_Limite";
            this.lbl_Numero_Limite.Size = new System.Drawing.Size(97, 19);
            this.lbl_Numero_Limite.Style = MetroFramework.MetroColorStyle.Silver;
            this.lbl_Numero_Limite.TabIndex = 0;
            this.lbl_Numero_Limite.Text = "Numero Limite";
            this.lbl_Numero_Limite.UseStyleColors = true;
            // 
            // txt_Numero_Limite
            // 
            this.txt_Numero_Limite.Location = new System.Drawing.Point(150, 33);
            this.txt_Numero_Limite.Name = "txt_Numero_Limite";
            this.txt_Numero_Limite.Size = new System.Drawing.Size(88, 23);
            this.txt_Numero_Limite.Style = MetroFramework.MetroColorStyle.Silver;
            this.txt_Numero_Limite.TabIndex = 1;
            this.txt_Numero_Limite.UseStyleColors = true;
            // 
            // gb_Control
            // 
            this.gb_Control.Controls.Add(this.rb_Impares);
            this.gb_Control.Controls.Add(this.rb_Pares);
            this.gb_Control.Controls.Add(this.rb_Todos);
            this.gb_Control.Location = new System.Drawing.Point(7, 62);
            this.gb_Control.Name = "gb_Control";
            this.gb_Control.Size = new System.Drawing.Size(258, 100);
            this.gb_Control.TabIndex = 2;
            this.gb_Control.TabStop = false;
            this.gb_Control.Text = "Control";
            // 
            // rb_Todos
            // 
            this.rb_Todos.AutoSize = true;
            this.rb_Todos.Location = new System.Drawing.Point(7, 43);
            this.rb_Todos.Name = "rb_Todos";
            this.rb_Todos.Size = new System.Drawing.Size(55, 15);
            this.rb_Todos.Style = MetroFramework.MetroColorStyle.Silver;
            this.rb_Todos.TabIndex = 0;
            this.rb_Todos.TabStop = true;
            this.rb_Todos.Text = "Todos";
            this.rb_Todos.UseStyleColors = true;
            this.rb_Todos.UseVisualStyleBackColor = true;
            // 
            // rb_Pares
            // 
            this.rb_Pares.AutoSize = true;
            this.rb_Pares.Location = new System.Drawing.Point(68, 43);
            this.rb_Pares.Name = "rb_Pares";
            this.rb_Pares.Size = new System.Drawing.Size(77, 15);
            this.rb_Pares.Style = MetroFramework.MetroColorStyle.Silver;
            this.rb_Pares.TabIndex = 1;
            this.rb_Pares.TabStop = true;
            this.rb_Pares.Text = "Solo Pares";
            this.rb_Pares.UseStyleColors = true;
            this.rb_Pares.UseVisualStyleBackColor = true;
            // 
            // rb_Impares
            // 
            this.rb_Impares.AutoSize = true;
            this.rb_Impares.Location = new System.Drawing.Point(151, 43);
            this.rb_Impares.Name = "rb_Impares";
            this.rb_Impares.Size = new System.Drawing.Size(91, 15);
            this.rb_Impares.Style = MetroFramework.MetroColorStyle.Silver;
            this.rb_Impares.TabIndex = 2;
            this.rb_Impares.TabStop = true;
            this.rb_Impares.Text = "Solo Impares";
            this.rb_Impares.UseStyleColors = true;
            this.rb_Impares.UseVisualStyleBackColor = true;
            // 
            // gb_Opciones
            // 
            this.gb_Opciones.Controls.Add(this.btn_Limpiar);
            this.gb_Opciones.Controls.Add(this.btn_Sumar);
            this.gb_Opciones.Location = new System.Drawing.Point(271, 33);
            this.gb_Opciones.Name = "gb_Opciones";
            this.gb_Opciones.Size = new System.Drawing.Size(153, 129);
            this.gb_Opciones.TabIndex = 3;
            this.gb_Opciones.TabStop = false;
            this.gb_Opciones.Text = "Opciones";
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Location = new System.Drawing.Point(7, 165);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(130, 19);
            this.lbl_Resultado.Style = MetroFramework.MetroColorStyle.Silver;
            this.lbl_Resultado.TabIndex = 4;
            this.lbl_Resultado.Text = "Resultado Sumatoria";
            this.lbl_Resultado.UseStyleColors = true;
            // 
            // txt_Resultado
            // 
            this.txt_Resultado.Location = new System.Drawing.Point(150, 165);
            this.txt_Resultado.Name = "txt_Resultado";
            this.txt_Resultado.Size = new System.Drawing.Size(88, 23);
            this.txt_Resultado.Style = MetroFramework.MetroColorStyle.Silver;
            this.txt_Resultado.TabIndex = 5;
            this.txt_Resultado.UseStyleColors = true;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(386, 292);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.Style = MetroFramework.MetroColorStyle.Silver;
            this.btn_Salir.TabIndex = 1;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Sumar
            // 
            this.btn_Sumar.Location = new System.Drawing.Point(17, 20);
            this.btn_Sumar.Name = "btn_Sumar";
            this.btn_Sumar.Size = new System.Drawing.Size(109, 46);
            this.btn_Sumar.Style = MetroFramework.MetroColorStyle.Silver;
            this.btn_Sumar.TabIndex = 0;
            this.btn_Sumar.Text = "Sumar";
            this.btn_Sumar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Sumar.Click += new System.EventHandler(this.btn_Sumar_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(17, 72);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(109, 43);
            this.btn_Limpiar.Style = MetroFramework.MetroColorStyle.Silver;
            this.btn_Limpiar.TabIndex = 1;
            this.btn_Limpiar.Text = "Limpíar";
            this.btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // Frm_Sumatoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 331);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.gb_Sumatoria);
            this.HelpButton = true;
            this.Name = "Frm_Sumatoria";
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "Sumatoria";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.Frm_Sumatoria_Load);
            this.gb_Sumatoria.ResumeLayout(false);
            this.gb_Sumatoria.PerformLayout();
            this.gb_Control.ResumeLayout(false);
            this.gb_Control.PerformLayout();
            this.gb_Opciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Sumatoria;
        private MetroFramework.Controls.MetroTextBox txt_Resultado;
        private MetroFramework.Controls.MetroLabel lbl_Resultado;
        private System.Windows.Forms.GroupBox gb_Opciones;
        private MetroFramework.Controls.MetroTile btn_Limpiar;
        private MetroFramework.Controls.MetroTile btn_Sumar;
        private System.Windows.Forms.GroupBox gb_Control;
        private MetroFramework.Controls.MetroRadioButton rb_Impares;
        private MetroFramework.Controls.MetroRadioButton rb_Pares;
        private MetroFramework.Controls.MetroRadioButton rb_Todos;
        private MetroFramework.Controls.MetroTextBox txt_Numero_Limite;
        private MetroFramework.Controls.MetroLabel lbl_Numero_Limite;
        private MetroFramework.Controls.MetroTile btn_Salir;
    }
}