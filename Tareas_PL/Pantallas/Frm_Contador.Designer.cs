namespace Tareas_PL.Pantallas
{
    partial class Frm_Contador
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Contador));
            this.txt_Tiempo = new MetroFramework.Controls.MetroTextBox();
            this.lbl_Tiempo = new MetroFramework.Controls.MetroLabel();
            this.txt_minutos = new MetroFramework.Controls.MetroTextBox();
            this.txt_Segundos = new MetroFramework.Controls.MetroTextBox();
            this.txt_Milisegundos = new MetroFramework.Controls.MetroTextBox();
            this.lbl_Minutos = new MetroFramework.Controls.MetroLabel();
            this.lbl_Segundos = new MetroFramework.Controls.MetroLabel();
            this.lbl_Milisegundos = new MetroFramework.Controls.MetroLabel();
            this.lbl_Opciones = new MetroFramework.Controls.MetroLabel();
            this.btn_Iniciar = new MetroFramework.Controls.MetroTile();
            this.btn_Detener = new MetroFramework.Controls.MetroTile();
            this.btn_Limpiar = new MetroFramework.Controls.MetroTile();
            this.btn_Salir = new MetroFramework.Controls.MetroButton();
            this.tm_Contador = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txt_Tiempo
            // 
            this.txt_Tiempo.Location = new System.Drawing.Point(46, 81);
            this.txt_Tiempo.Name = "txt_Tiempo";
            this.txt_Tiempo.Size = new System.Drawing.Size(75, 23);
            this.txt_Tiempo.TabIndex = 0;
            this.txt_Tiempo.TextChanged += new System.EventHandler(this.txt_Tiempo_TextChanged);
            this.txt_Tiempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Tiempo_KeyPress);
            // 
            // lbl_Tiempo
            // 
            this.lbl_Tiempo.AutoSize = true;
            this.lbl_Tiempo.CustomForeColor = true;
            this.lbl_Tiempo.Location = new System.Drawing.Point(46, 59);
            this.lbl_Tiempo.Name = "lbl_Tiempo";
            this.lbl_Tiempo.Size = new System.Drawing.Size(57, 19);
            this.lbl_Tiempo.Style = MetroFramework.MetroColorStyle.Teal;
            this.lbl_Tiempo.TabIndex = 1;
            this.lbl_Tiempo.Text = "Tiempo:";
            // 
            // txt_minutos
            // 
            this.txt_minutos.Enabled = false;
            this.txt_minutos.Location = new System.Drawing.Point(46, 192);
            this.txt_minutos.Name = "txt_minutos";
            this.txt_minutos.Size = new System.Drawing.Size(75, 23);
            this.txt_minutos.Style = MetroFramework.MetroColorStyle.Teal;
            this.txt_minutos.TabIndex = 2;
            // 
            // txt_Segundos
            // 
            this.txt_Segundos.Enabled = false;
            this.txt_Segundos.Location = new System.Drawing.Point(153, 192);
            this.txt_Segundos.Name = "txt_Segundos";
            this.txt_Segundos.Size = new System.Drawing.Size(75, 23);
            this.txt_Segundos.Style = MetroFramework.MetroColorStyle.Teal;
            this.txt_Segundos.TabIndex = 3;
            // 
            // txt_Milisegundos
            // 
            this.txt_Milisegundos.Enabled = false;
            this.txt_Milisegundos.Location = new System.Drawing.Point(258, 192);
            this.txt_Milisegundos.Name = "txt_Milisegundos";
            this.txt_Milisegundos.Size = new System.Drawing.Size(75, 23);
            this.txt_Milisegundos.Style = MetroFramework.MetroColorStyle.Teal;
            this.txt_Milisegundos.TabIndex = 4;
            // 
            // lbl_Minutos
            // 
            this.lbl_Minutos.AutoSize = true;
            this.lbl_Minutos.Location = new System.Drawing.Point(46, 167);
            this.lbl_Minutos.Name = "lbl_Minutos";
            this.lbl_Minutos.Size = new System.Drawing.Size(58, 19);
            this.lbl_Minutos.TabIndex = 5;
            this.lbl_Minutos.Text = "Minutos:";
            // 
            // lbl_Segundos
            // 
            this.lbl_Segundos.AutoSize = true;
            this.lbl_Segundos.Location = new System.Drawing.Point(153, 167);
            this.lbl_Segundos.Name = "lbl_Segundos";
            this.lbl_Segundos.Size = new System.Drawing.Size(69, 19);
            this.lbl_Segundos.TabIndex = 6;
            this.lbl_Segundos.Text = "Segundos:";
            // 
            // lbl_Milisegundos
            // 
            this.lbl_Milisegundos.AutoSize = true;
            this.lbl_Milisegundos.Location = new System.Drawing.Point(258, 167);
            this.lbl_Milisegundos.Name = "lbl_Milisegundos";
            this.lbl_Milisegundos.Size = new System.Drawing.Size(88, 19);
            this.lbl_Milisegundos.TabIndex = 7;
            this.lbl_Milisegundos.Text = "Milisegundos:";
            // 
            // lbl_Opciones
            // 
            this.lbl_Opciones.AutoSize = true;
            this.lbl_Opciones.Location = new System.Drawing.Point(258, 21);
            this.lbl_Opciones.Name = "lbl_Opciones";
            this.lbl_Opciones.Size = new System.Drawing.Size(67, 19);
            this.lbl_Opciones.TabIndex = 8;
            this.lbl_Opciones.Text = "Opciones:";
            // 
            // btn_Iniciar
            // 
            this.btn_Iniciar.Location = new System.Drawing.Point(258, 45);
            this.btn_Iniciar.Name = "btn_Iniciar";
            this.btn_Iniciar.Size = new System.Drawing.Size(75, 23);
            this.btn_Iniciar.Style = MetroFramework.MetroColorStyle.Teal;
            this.btn_Iniciar.TabIndex = 9;
            this.btn_Iniciar.Text = "Iniciar";
            this.btn_Iniciar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Iniciar.Click += new System.EventHandler(this.btn_Iniciar_Click);
            // 
            // btn_Detener
            // 
            this.btn_Detener.Location = new System.Drawing.Point(258, 84);
            this.btn_Detener.Name = "btn_Detener";
            this.btn_Detener.Size = new System.Drawing.Size(75, 23);
            this.btn_Detener.Style = MetroFramework.MetroColorStyle.Teal;
            this.btn_Detener.TabIndex = 10;
            this.btn_Detener.Text = "Detener";
            this.btn_Detener.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Detener.Click += new System.EventHandler(this.btn_Detener_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(258, 123);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_Limpiar.Style = MetroFramework.MetroColorStyle.Teal;
            this.btn_Limpiar.TabIndex = 11;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Location = new System.Drawing.Point(258, 221);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(75, 23);
            this.btn_Salir.TabIndex = 12;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // tm_Contador
            // 
            this.tm_Contador.Interval = 10;
            this.tm_Contador.Tick += new System.EventHandler(this.tm_Contador_Tick);
            // 
            // Frm_Contador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 258);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Detener);
            this.Controls.Add(this.btn_Iniciar);
            this.Controls.Add(this.lbl_Opciones);
            this.Controls.Add(this.lbl_Milisegundos);
            this.Controls.Add(this.lbl_Segundos);
            this.Controls.Add(this.lbl_Minutos);
            this.Controls.Add(this.txt_Milisegundos);
            this.Controls.Add(this.txt_Segundos);
            this.Controls.Add(this.txt_minutos);
            this.Controls.Add(this.lbl_Tiempo);
            this.Controls.Add(this.txt_Tiempo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Contador";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Contador";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txt_Tiempo;
        private MetroFramework.Controls.MetroLabel lbl_Tiempo;
        private MetroFramework.Controls.MetroTextBox txt_minutos;
        private MetroFramework.Controls.MetroTextBox txt_Segundos;
        private MetroFramework.Controls.MetroTextBox txt_Milisegundos;
        private MetroFramework.Controls.MetroLabel lbl_Minutos;
        private MetroFramework.Controls.MetroLabel lbl_Segundos;
        private MetroFramework.Controls.MetroLabel lbl_Milisegundos;
        private MetroFramework.Controls.MetroLabel lbl_Opciones;
        private MetroFramework.Controls.MetroTile btn_Iniciar;
        private MetroFramework.Controls.MetroTile btn_Detener;
        private MetroFramework.Controls.MetroTile btn_Limpiar;
        private MetroFramework.Controls.MetroButton btn_Salir;
        private System.Windows.Forms.Timer tm_Contador;
    }
}