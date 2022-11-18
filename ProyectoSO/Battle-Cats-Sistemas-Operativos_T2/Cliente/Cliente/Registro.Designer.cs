namespace Cliente
{
    partial class Registro
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
            this.registro_boton = new System.Windows.Forms.Button();
            this.nombre_usuario_etiqueta = new System.Windows.Forms.Label();
            this.correo_electronico_etiqueta = new System.Windows.Forms.Label();
            this.contraseña_etiqueta = new System.Windows.Forms.Label();
            this.fecha_de_nacimiento_etiqueta = new System.Windows.Forms.Label();
            this.contraseña_textbox = new System.Windows.Forms.TextBox();
            this.nombre_usuario_textbox = new System.Windows.Forms.TextBox();
            this.correo_electronico_textbox = new System.Windows.Forms.TextBox();
            this.fecha_de_nacimiento_textbox = new System.Windows.Forms.TextBox();
            this.etiqueta_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // registro_boton
            // 
            this.registro_boton.Location = new System.Drawing.Point(319, 251);
            this.registro_boton.Name = "registro_boton";
            this.registro_boton.Size = new System.Drawing.Size(75, 23);
            this.registro_boton.TabIndex = 0;
            this.registro_boton.Text = "Registro";
            this.registro_boton.UseVisualStyleBackColor = true;
            this.registro_boton.Click += new System.EventHandler(this.registro_boton_Click);
            // 
            // nombre_usuario_etiqueta
            // 
            this.nombre_usuario_etiqueta.AutoSize = true;
            this.nombre_usuario_etiqueta.Location = new System.Drawing.Point(313, 81);
            this.nombre_usuario_etiqueta.Name = "nombre_usuario_etiqueta";
            this.nombre_usuario_etiqueta.Size = new System.Drawing.Size(96, 13);
            this.nombre_usuario_etiqueta.TabIndex = 1;
            this.nombre_usuario_etiqueta.Text = "Nombre de usuario";
            this.nombre_usuario_etiqueta.Click += new System.EventHandler(this.nombre_usuario_etiqueta_Click);
            // 
            // correo_electronico_etiqueta
            // 
            this.correo_electronico_etiqueta.AutoSize = true;
            this.correo_electronico_etiqueta.Location = new System.Drawing.Point(313, 118);
            this.correo_electronico_etiqueta.Name = "correo_electronico_etiqueta";
            this.correo_electronico_etiqueta.Size = new System.Drawing.Size(93, 13);
            this.correo_electronico_etiqueta.TabIndex = 2;
            this.correo_electronico_etiqueta.Text = "Correo electrónico";
            // 
            // contraseña_etiqueta
            // 
            this.contraseña_etiqueta.AutoSize = true;
            this.contraseña_etiqueta.Location = new System.Drawing.Point(316, 157);
            this.contraseña_etiqueta.Name = "contraseña_etiqueta";
            this.contraseña_etiqueta.Size = new System.Drawing.Size(61, 13);
            this.contraseña_etiqueta.TabIndex = 3;
            this.contraseña_etiqueta.Text = "Contraseña";
            // 
            // fecha_de_nacimiento_etiqueta
            // 
            this.fecha_de_nacimiento_etiqueta.AutoSize = true;
            this.fecha_de_nacimiento_etiqueta.Location = new System.Drawing.Point(316, 196);
            this.fecha_de_nacimiento_etiqueta.Name = "fecha_de_nacimiento_etiqueta";
            this.fecha_de_nacimiento_etiqueta.Size = new System.Drawing.Size(106, 13);
            this.fecha_de_nacimiento_etiqueta.TabIndex = 4;
            this.fecha_de_nacimiento_etiqueta.Text = "Fecha de nacimiento";
            // 
            // contraseña_textbox
            // 
            this.contraseña_textbox.Location = new System.Drawing.Point(316, 173);
            this.contraseña_textbox.Name = "contraseña_textbox";
            this.contraseña_textbox.Size = new System.Drawing.Size(100, 20);
            this.contraseña_textbox.TabIndex = 5;
            // 
            // nombre_usuario_textbox
            // 
            this.nombre_usuario_textbox.Location = new System.Drawing.Point(316, 95);
            this.nombre_usuario_textbox.Name = "nombre_usuario_textbox";
            this.nombre_usuario_textbox.Size = new System.Drawing.Size(100, 20);
            this.nombre_usuario_textbox.TabIndex = 6;
            this.nombre_usuario_textbox.TextChanged += new System.EventHandler(this.nombre_usuario_textbox_TextChanged);
            // 
            // correo_electronico_textbox
            // 
            this.correo_electronico_textbox.Location = new System.Drawing.Point(316, 134);
            this.correo_electronico_textbox.Name = "correo_electronico_textbox";
            this.correo_electronico_textbox.Size = new System.Drawing.Size(100, 20);
            this.correo_electronico_textbox.TabIndex = 7;
            // 
            // fecha_de_nacimiento_textbox
            // 
            this.fecha_de_nacimiento_textbox.Location = new System.Drawing.Point(316, 212);
            this.fecha_de_nacimiento_textbox.Name = "fecha_de_nacimiento_textbox";
            this.fecha_de_nacimiento_textbox.Size = new System.Drawing.Size(100, 20);
            this.fecha_de_nacimiento_textbox.TabIndex = 8;
            // 
            // etiqueta_error
            // 
            this.etiqueta_error.AutoSize = true;
            this.etiqueta_error.Location = new System.Drawing.Point(316, 297);
            this.etiqueta_error.Name = "etiqueta_error";
            this.etiqueta_error.Size = new System.Drawing.Size(0, 13);
            this.etiqueta_error.TabIndex = 9;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.etiqueta_error);
            this.Controls.Add(this.fecha_de_nacimiento_textbox);
            this.Controls.Add(this.correo_electronico_textbox);
            this.Controls.Add(this.nombre_usuario_textbox);
            this.Controls.Add(this.contraseña_textbox);
            this.Controls.Add(this.fecha_de_nacimiento_etiqueta);
            this.Controls.Add(this.contraseña_etiqueta);
            this.Controls.Add(this.correo_electronico_etiqueta);
            this.Controls.Add(this.nombre_usuario_etiqueta);
            this.Controls.Add(this.registro_boton);
            this.Name = "Registro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registro_boton;
        private System.Windows.Forms.Label nombre_usuario_etiqueta;
        private System.Windows.Forms.Label correo_electronico_etiqueta;
        private System.Windows.Forms.Label contraseña_etiqueta;
        private System.Windows.Forms.Label fecha_de_nacimiento_etiqueta;
        private System.Windows.Forms.TextBox contraseña_textbox;
        private System.Windows.Forms.TextBox nombre_usuario_textbox;
        private System.Windows.Forms.TextBox correo_electronico_textbox;
        private System.Windows.Forms.TextBox fecha_de_nacimiento_textbox;
        private System.Windows.Forms.Label etiqueta_error;
    }
}