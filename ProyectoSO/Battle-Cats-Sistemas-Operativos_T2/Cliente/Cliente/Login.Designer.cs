namespace Cliente
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.inicio_de_sesion = new System.Windows.Forms.Button();
            this.nombre_usuario = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.etiqueta_usuario = new System.Windows.Forms.Label();
            this.etiqueta_contraseña = new System.Windows.Forms.Label();
            this.etiqueta_mensaje_de_error = new System.Windows.Forms.Label();
            this.registro = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // inicio_de_sesion
            // 
            this.inicio_de_sesion.Location = new System.Drawing.Point(308, 264);
            this.inicio_de_sesion.Name = "inicio_de_sesion";
            this.inicio_de_sesion.Size = new System.Drawing.Size(127, 28);
            this.inicio_de_sesion.TabIndex = 0;
            this.inicio_de_sesion.Text = "Inicio de sesión";
            this.inicio_de_sesion.UseVisualStyleBackColor = true;
            this.inicio_de_sesion.Click += new System.EventHandler(this.inicio_de_sesion_Click);
            // 
            // nombre_usuario
            // 
            this.nombre_usuario.Location = new System.Drawing.Point(321, 158);
            this.nombre_usuario.Name = "nombre_usuario";
            this.nombre_usuario.Size = new System.Drawing.Size(100, 20);
            this.nombre_usuario.TabIndex = 1;
            this.nombre_usuario.TextChanged += new System.EventHandler(this.nombre_usuario_TextChanged);
            // 
            // contraseña
            // 
            this.contraseña.Location = new System.Drawing.Point(321, 207);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(100, 20);
            this.contraseña.TabIndex = 2;
            // 
            // etiqueta_usuario
            // 
            this.etiqueta_usuario.AutoSize = true;
            this.etiqueta_usuario.Location = new System.Drawing.Point(321, 139);
            this.etiqueta_usuario.Name = "etiqueta_usuario";
            this.etiqueta_usuario.Size = new System.Drawing.Size(96, 13);
            this.etiqueta_usuario.TabIndex = 3;
            this.etiqueta_usuario.Text = "Nombre de usuario";
            // 
            // etiqueta_contraseña
            // 
            this.etiqueta_contraseña.AutoSize = true;
            this.etiqueta_contraseña.Location = new System.Drawing.Point(321, 185);
            this.etiqueta_contraseña.Name = "etiqueta_contraseña";
            this.etiqueta_contraseña.Size = new System.Drawing.Size(61, 13);
            this.etiqueta_contraseña.TabIndex = 4;
            this.etiqueta_contraseña.Text = "Contraseña";
            // 
            // etiqueta_mensaje_de_error
            // 
            this.etiqueta_mensaje_de_error.AutoSize = true;
            this.etiqueta_mensaje_de_error.Location = new System.Drawing.Point(291, 236);
            this.etiqueta_mensaje_de_error.Name = "etiqueta_mensaje_de_error";
            this.etiqueta_mensaje_de_error.Size = new System.Drawing.Size(0, 13);
            this.etiqueta_mensaje_de_error.TabIndex = 5;
            // 
            // registro
            // 
            this.registro.AutoSize = true;
            this.registro.Location = new System.Drawing.Point(274, 316);
            this.registro.Name = "registro";
            this.registro.Size = new System.Drawing.Size(187, 13);
            this.registro.TabIndex = 6;
            this.registro.TabStop = true;
            this.registro.Text = "¿Aún no estás registrado? Pulse aquí.";
            this.registro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registro_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registro);
            this.Controls.Add(this.etiqueta_mensaje_de_error);
            this.Controls.Add(this.etiqueta_contraseña);
            this.Controls.Add(this.etiqueta_usuario);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.nombre_usuario);
            this.Controls.Add(this.inicio_de_sesion);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inicio_de_sesion;
        private System.Windows.Forms.TextBox nombre_usuario;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.Label etiqueta_usuario;
        private System.Windows.Forms.Label etiqueta_contraseña;
        private System.Windows.Forms.Label etiqueta_mensaje_de_error;
        private System.Windows.Forms.LinkLabel registro;
    }
}

