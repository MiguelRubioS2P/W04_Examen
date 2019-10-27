namespace W05_ExamenRegistroEncontrar
{
    partial class Main
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageRegistrar = new System.Windows.Forms.TabPage();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.textBoxCContra = new System.Windows.Forms.TextBox();
            this.labelCContra = new System.Windows.Forms.Label();
            this.textBoxContra = new System.Windows.Forms.TextBox();
            this.labelContra = new System.Windows.Forms.Label();
            this.comboBoxPoblacion = new System.Windows.Forms.ComboBox();
            this.labelPoblacion = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxDni = new System.Windows.Forms.TextBox();
            this.labelDni = new System.Windows.Forms.Label();
            this.tabPageBuscar = new System.Windows.Forms.TabPage();
            this.listBoxUsuarios = new System.Windows.Forms.ListBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscador = new System.Windows.Forms.TextBox();
            this.labelBuscador = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageRegistrar.SuspendLayout();
            this.tabPageBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageRegistrar);
            this.tabControl1.Controls.Add(this.tabPageBuscar);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageRegistrar
            // 
            this.tabPageRegistrar.Controls.Add(this.buttonRegistrar);
            this.tabPageRegistrar.Controls.Add(this.textBoxCContra);
            this.tabPageRegistrar.Controls.Add(this.labelCContra);
            this.tabPageRegistrar.Controls.Add(this.textBoxContra);
            this.tabPageRegistrar.Controls.Add(this.labelContra);
            this.tabPageRegistrar.Controls.Add(this.comboBoxPoblacion);
            this.tabPageRegistrar.Controls.Add(this.labelPoblacion);
            this.tabPageRegistrar.Controls.Add(this.textBoxEmail);
            this.tabPageRegistrar.Controls.Add(this.labelEmail);
            this.tabPageRegistrar.Controls.Add(this.textBoxApellidos);
            this.tabPageRegistrar.Controls.Add(this.labelApellidos);
            this.tabPageRegistrar.Controls.Add(this.textBoxNombre);
            this.tabPageRegistrar.Controls.Add(this.labelNombre);
            this.tabPageRegistrar.Controls.Add(this.textBoxDni);
            this.tabPageRegistrar.Controls.Add(this.labelDni);
            this.tabPageRegistrar.Location = new System.Drawing.Point(4, 22);
            this.tabPageRegistrar.Name = "tabPageRegistrar";
            this.tabPageRegistrar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRegistrar.Size = new System.Drawing.Size(768, 400);
            this.tabPageRegistrar.TabIndex = 0;
            this.tabPageRegistrar.Text = "Registrar";
            this.tabPageRegistrar.UseVisualStyleBackColor = true;
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.Location = new System.Drawing.Point(389, 233);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(204, 56);
            this.buttonRegistrar.TabIndex = 14;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // textBoxCContra
            // 
            this.textBoxCContra.Location = new System.Drawing.Point(503, 98);
            this.textBoxCContra.Name = "textBoxCContra";
            this.textBoxCContra.Size = new System.Drawing.Size(100, 20);
            this.textBoxCContra.TabIndex = 13;
            this.textBoxCContra.UseSystemPasswordChar = true;
            // 
            // labelCContra
            // 
            this.labelCContra.AutoSize = true;
            this.labelCContra.Location = new System.Drawing.Point(386, 101);
            this.labelCContra.Name = "labelCContra";
            this.labelCContra.Size = new System.Drawing.Size(108, 13);
            this.labelCContra.TabIndex = 12;
            this.labelCContra.Text = "Confirmar Contraseña";
            // 
            // textBoxContra
            // 
            this.textBoxContra.Location = new System.Drawing.Point(453, 34);
            this.textBoxContra.Name = "textBoxContra";
            this.textBoxContra.Size = new System.Drawing.Size(100, 20);
            this.textBoxContra.TabIndex = 11;
            this.textBoxContra.UseSystemPasswordChar = true;
            // 
            // labelContra
            // 
            this.labelContra.AutoSize = true;
            this.labelContra.Location = new System.Drawing.Point(386, 37);
            this.labelContra.Name = "labelContra";
            this.labelContra.Size = new System.Drawing.Size(61, 13);
            this.labelContra.TabIndex = 10;
            this.labelContra.Text = "Contraseña";
            // 
            // comboBoxPoblacion
            // 
            this.comboBoxPoblacion.FormattingEnabled = true;
            this.comboBoxPoblacion.Items.AddRange(new object[] {
            "Palma",
            "Binissalem",
            "Inca",
            "Lloseta",
            "Manacor",
            "Sa Pobla"});
            this.comboBoxPoblacion.Location = new System.Drawing.Point(104, 290);
            this.comboBoxPoblacion.Name = "comboBoxPoblacion";
            this.comboBoxPoblacion.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPoblacion.TabIndex = 9;
            // 
            // labelPoblacion
            // 
            this.labelPoblacion.AutoSize = true;
            this.labelPoblacion.Location = new System.Drawing.Point(44, 293);
            this.labelPoblacion.Name = "labelPoblacion";
            this.labelPoblacion.Size = new System.Drawing.Size(54, 13);
            this.labelPoblacion.TabIndex = 8;
            this.labelPoblacion.Text = "Población";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(85, 233);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 20);
            this.textBoxEmail.TabIndex = 7;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(44, 236);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 6;
            this.labelEmail.Text = "Email";
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.Location = new System.Drawing.Point(99, 166);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(100, 20);
            this.textBoxApellidos.TabIndex = 5;
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Location = new System.Drawing.Point(44, 169);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(49, 13);
            this.labelApellidos.TabIndex = 4;
            this.labelApellidos.Text = "Apellidos";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(94, 99);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 3;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(44, 102);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre";
            // 
            // textBoxDni
            // 
            this.textBoxDni.Location = new System.Drawing.Point(76, 35);
            this.textBoxDni.Name = "textBoxDni";
            this.textBoxDni.Size = new System.Drawing.Size(100, 20);
            this.textBoxDni.TabIndex = 1;
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Location = new System.Drawing.Point(44, 38);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(26, 13);
            this.labelDni.TabIndex = 0;
            this.labelDni.Text = "DNI";
            // 
            // tabPageBuscar
            // 
            this.tabPageBuscar.Controls.Add(this.listBoxUsuarios);
            this.tabPageBuscar.Controls.Add(this.buttonBuscar);
            this.tabPageBuscar.Controls.Add(this.textBoxBuscador);
            this.tabPageBuscar.Controls.Add(this.labelBuscador);
            this.tabPageBuscar.Location = new System.Drawing.Point(4, 22);
            this.tabPageBuscar.Name = "tabPageBuscar";
            this.tabPageBuscar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBuscar.Size = new System.Drawing.Size(768, 400);
            this.tabPageBuscar.TabIndex = 1;
            this.tabPageBuscar.Text = "Buscar";
            this.tabPageBuscar.UseVisualStyleBackColor = true;
            // 
            // listBoxUsuarios
            // 
            this.listBoxUsuarios.FormattingEnabled = true;
            this.listBoxUsuarios.Location = new System.Drawing.Point(93, 175);
            this.listBoxUsuarios.Name = "listBoxUsuarios";
            this.listBoxUsuarios.Size = new System.Drawing.Size(510, 186);
            this.listBoxUsuarios.TabIndex = 3;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(528, 71);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 2;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBoxBuscador
            // 
            this.textBoxBuscador.Location = new System.Drawing.Point(93, 75);
            this.textBoxBuscador.Name = "textBoxBuscador";
            this.textBoxBuscador.Size = new System.Drawing.Size(428, 20);
            this.textBoxBuscador.TabIndex = 1;
            this.textBoxBuscador.Click += new System.EventHandler(this.textBoxBuscador_Click);
            // 
            // labelBuscador
            // 
            this.labelBuscador.AutoSize = true;
            this.labelBuscador.Location = new System.Drawing.Point(90, 39);
            this.labelBuscador.Name = "labelBuscador";
            this.labelBuscador.Size = new System.Drawing.Size(52, 13);
            this.labelBuscador.TabIndex = 0;
            this.labelBuscador.Text = "Buscador";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "Main";
            this.tabControl1.ResumeLayout(false);
            this.tabPageRegistrar.ResumeLayout(false);
            this.tabPageRegistrar.PerformLayout();
            this.tabPageBuscar.ResumeLayout(false);
            this.tabPageBuscar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageRegistrar;
        private System.Windows.Forms.TabPage tabPageBuscar;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.TextBox textBoxCContra;
        private System.Windows.Forms.Label labelCContra;
        private System.Windows.Forms.TextBox textBoxContra;
        private System.Windows.Forms.Label labelContra;
        private System.Windows.Forms.ComboBox comboBoxPoblacion;
        private System.Windows.Forms.Label labelPoblacion;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxDni;
        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.ListBox listBoxUsuarios;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxBuscador;
        private System.Windows.Forms.Label labelBuscador;
    }
}

