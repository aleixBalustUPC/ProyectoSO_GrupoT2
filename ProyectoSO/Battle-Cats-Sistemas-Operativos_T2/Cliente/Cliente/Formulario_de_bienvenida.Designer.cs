namespace Cliente
{
    partial class Formulario_de_bienvenida
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
            this.texto_bienvenida = new System.Windows.Forms.Label();
            this.consultar_partidas_dia = new System.Windows.Forms.Button();
            this.victorias_button = new System.Windows.Forms.Button();
            this.tiempo_medio_button = new System.Windows.Forms.Button();
            this.dia_textbox = new System.Windows.Forms.TextBox();
            this.etiqueta_dia = new System.Windows.Forms.Label();
            this.usuarios_grid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Conectar_Button = new System.Windows.Forms.Button();
            this.Desconectar_Button = new System.Windows.Forms.Button();
            this.Conectados_Grid_View = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.usuarios_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Conectados_Grid_View)).BeginInit();
            this.SuspendLayout();
            // 
            // texto_bienvenida
            // 
            this.texto_bienvenida.AutoSize = true;
            this.texto_bienvenida.Location = new System.Drawing.Point(419, 16);
            this.texto_bienvenida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.texto_bienvenida.Name = "texto_bienvenida";
            this.texto_bienvenida.Size = new System.Drawing.Size(90, 17);
            this.texto_bienvenida.TabIndex = 0;
            this.texto_bienvenida.Text = "Bienvenido/a";
            this.texto_bienvenida.Click += new System.EventHandler(this.texto_bienvenida_Click);
            // 
            // consultar_partidas_dia
            // 
            this.consultar_partidas_dia.Location = new System.Drawing.Point(53, 52);
            this.consultar_partidas_dia.Margin = new System.Windows.Forms.Padding(4);
            this.consultar_partidas_dia.Name = "consultar_partidas_dia";
            this.consultar_partidas_dia.Size = new System.Drawing.Size(225, 75);
            this.consultar_partidas_dia.TabIndex = 1;
            this.consultar_partidas_dia.Text = "Consultar número de partidas jugadas en X día.";
            this.consultar_partidas_dia.UseVisualStyleBackColor = true;
            this.consultar_partidas_dia.Click += new System.EventHandler(this.consultar_partidas_dia_Click);
            // 
            // victorias_button
            // 
            this.victorias_button.Location = new System.Drawing.Point(53, 161);
            this.victorias_button.Margin = new System.Windows.Forms.Padding(4);
            this.victorias_button.Name = "victorias_button";
            this.victorias_button.Size = new System.Drawing.Size(225, 64);
            this.victorias_button.TabIndex = 2;
            this.victorias_button.Text = "Número de victorias de un jugador";
            this.victorias_button.UseVisualStyleBackColor = true;
            this.victorias_button.Click += new System.EventHandler(this.victorias_button_Click);
            // 
            // tiempo_medio_button
            // 
            this.tiempo_medio_button.Location = new System.Drawing.Point(53, 254);
            this.tiempo_medio_button.Margin = new System.Windows.Forms.Padding(4);
            this.tiempo_medio_button.Name = "tiempo_medio_button";
            this.tiempo_medio_button.Size = new System.Drawing.Size(225, 75);
            this.tiempo_medio_button.TabIndex = 3;
            this.tiempo_medio_button.Text = "Tiempo medio de partidas de un jugador";
            this.tiempo_medio_button.UseVisualStyleBackColor = true;
            this.tiempo_medio_button.Click += new System.EventHandler(this.tiempo_medio_button_Click);
            // 
            // dia_textbox
            // 
            this.dia_textbox.Location = new System.Drawing.Point(349, 118);
            this.dia_textbox.Margin = new System.Windows.Forms.Padding(4);
            this.dia_textbox.Name = "dia_textbox";
            this.dia_textbox.Size = new System.Drawing.Size(337, 22);
            this.dia_textbox.TabIndex = 4;
            // 
            // etiqueta_dia
            // 
            this.etiqueta_dia.AutoSize = true;
            this.etiqueta_dia.Location = new System.Drawing.Point(355, 97);
            this.etiqueta_dia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.etiqueta_dia.Name = "etiqueta_dia";
            this.etiqueta_dia.Size = new System.Drawing.Size(279, 17);
            this.etiqueta_dia.TabIndex = 5;
            this.etiqueta_dia.Text = "Escribe un día en el formato \"aaaa-mm-dd\"";
            // 
            // usuarios_grid
            // 
            this.usuarios_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuarios_grid.Location = new System.Drawing.Point(343, 152);
            this.usuarios_grid.Margin = new System.Windows.Forms.Padding(4);
            this.usuarios_grid.Name = "usuarios_grid";
            this.usuarios_grid.RowHeadersWidth = 51;
            this.usuarios_grid.Size = new System.Drawing.Size(339, 209);
            this.usuarios_grid.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(746, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "          LISTA DE CONECTADOS";
            // 
            // Conectar_Button
            // 
            this.Conectar_Button.Location = new System.Drawing.Point(53, 423);
            this.Conectar_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Conectar_Button.Name = "Conectar_Button";
            this.Conectar_Button.Size = new System.Drawing.Size(225, 75);
            this.Conectar_Button.TabIndex = 14;
            this.Conectar_Button.Text = "Conectar";
            this.Conectar_Button.UseVisualStyleBackColor = true;
            this.Conectar_Button.Click += new System.EventHandler(this.Conectar_Button_Click);
            // 
            // Desconectar_Button
            // 
            this.Desconectar_Button.Location = new System.Drawing.Point(305, 423);
            this.Desconectar_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Desconectar_Button.Name = "Desconectar_Button";
            this.Desconectar_Button.Size = new System.Drawing.Size(225, 75);
            this.Desconectar_Button.TabIndex = 13;
            this.Desconectar_Button.Text = "Desconectar";
            this.Desconectar_Button.UseVisualStyleBackColor = true;
            this.Desconectar_Button.Click += new System.EventHandler(this.Desconectar_Button_Click);
            // 
            // Conectados_Grid_View
            // 
            this.Conectados_Grid_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Conectados_Grid_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username});
            this.Conectados_Grid_View.Location = new System.Drawing.Point(769, 152);
            this.Conectados_Grid_View.Name = "Conectados_Grid_View";
            this.Conectados_Grid_View.RowHeadersWidth = 51;
            this.Conectados_Grid_View.RowTemplate.Height = 24;
            this.Conectados_Grid_View.Size = new System.Drawing.Size(209, 209);
            this.Conectados_Grid_View.TabIndex = 15;
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.Width = 125;
            // 
            // Formulario_de_bienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Conectados_Grid_View);
            this.Controls.Add(this.Desconectar_Button);
            this.Controls.Add(this.Conectar_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usuarios_grid);
            this.Controls.Add(this.etiqueta_dia);
            this.Controls.Add(this.dia_textbox);
            this.Controls.Add(this.tiempo_medio_button);
            this.Controls.Add(this.victorias_button);
            this.Controls.Add(this.consultar_partidas_dia);
            this.Controls.Add(this.texto_bienvenida);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Formulario_de_bienvenida";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Formulario_de_bienvenida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarios_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Conectados_Grid_View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label texto_bienvenida;
        private System.Windows.Forms.Button consultar_partidas_dia;
        private System.Windows.Forms.Button victorias_button;
        private System.Windows.Forms.Button tiempo_medio_button;
        private System.Windows.Forms.TextBox dia_textbox;
        private System.Windows.Forms.Label etiqueta_dia;
        private System.Windows.Forms.DataGridView usuarios_grid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Conectar_Button;
        private System.Windows.Forms.Button Desconectar_Button;
        private System.Windows.Forms.DataGridView Conectados_Grid_View;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
    }
}