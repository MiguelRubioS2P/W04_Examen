namespace W04_Examen
{
    partial class LibrosBuscador
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.listBoxLibros = new System.Windows.Forms.ListBox();
            this.labelTituloListBox = new System.Windows.Forms.Label();
            this.textBoxBuscador = new System.Windows.Forms.TextBox();
            this.labelBuscador = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.buttonIrAutores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(181, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(392, 46);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "PAU CASESNOVES";
            // 
            // listBoxLibros
            // 
            this.listBoxLibros.FormattingEnabled = true;
            this.listBoxLibros.Location = new System.Drawing.Point(64, 187);
            this.listBoxLibros.Name = "listBoxLibros";
            this.listBoxLibros.Size = new System.Drawing.Size(509, 251);
            this.listBoxLibros.TabIndex = 1;
            this.listBoxLibros.DoubleClick += new System.EventHandler(this.listBoxLibros_DoubleClick);
            // 
            // labelTituloListBox
            // 
            this.labelTituloListBox.AutoSize = true;
            this.labelTituloListBox.Location = new System.Drawing.Point(61, 162);
            this.labelTituloListBox.Name = "labelTituloListBox";
            this.labelTituloListBox.Size = new System.Drawing.Size(74, 13);
            this.labelTituloListBox.TabIndex = 2;
            this.labelTituloListBox.Text = "Lista de libros:";
            // 
            // textBoxBuscador
            // 
            this.textBoxBuscador.Location = new System.Drawing.Point(64, 112);
            this.textBoxBuscador.Name = "textBoxBuscador";
            this.textBoxBuscador.Size = new System.Drawing.Size(509, 20);
            this.textBoxBuscador.TabIndex = 3;
            // 
            // labelBuscador
            // 
            this.labelBuscador.AutoSize = true;
            this.labelBuscador.Location = new System.Drawing.Point(64, 78);
            this.labelBuscador.Name = "labelBuscador";
            this.labelBuscador.Size = new System.Drawing.Size(55, 13);
            this.labelBuscador.TabIndex = 4;
            this.labelBuscador.Text = "Buscador:";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(616, 110);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 5;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // buttonIrAutores
            // 
            this.buttonIrAutores.Location = new System.Drawing.Point(616, 376);
            this.buttonIrAutores.Name = "buttonIrAutores";
            this.buttonIrAutores.Size = new System.Drawing.Size(111, 62);
            this.buttonIrAutores.TabIndex = 6;
            this.buttonIrAutores.Text = "Ir a Autores";
            this.buttonIrAutores.UseVisualStyleBackColor = true;
            this.buttonIrAutores.Click += new System.EventHandler(this.buttonIrAutores_Click);
            // 
            // LibrosBuscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonIrAutores);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.labelBuscador);
            this.Controls.Add(this.textBoxBuscador);
            this.Controls.Add(this.labelTituloListBox);
            this.Controls.Add(this.listBoxLibros);
            this.Controls.Add(this.labelTitulo);
            this.Name = "LibrosBuscador";
            this.Text = "LibrosBuscador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.ListBox listBoxLibros;
        private System.Windows.Forms.Label labelTituloListBox;
        private System.Windows.Forms.TextBox textBoxBuscador;
        private System.Windows.Forms.Label labelBuscador;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button buttonIrAutores;
    }
}

