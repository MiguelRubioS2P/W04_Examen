namespace W04_Examen
{
    partial class AutorBuscador
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelBuscador = new System.Windows.Forms.Label();
            this.labelListaAutores = new System.Windows.Forms.Label();
            this.buttonBuscador = new System.Windows.Forms.Button();
            this.listBoxAutores = new System.Windows.Forms.ListBox();
            this.buttonIrLibros = new System.Windows.Forms.Button();
            this.textBoxBuscador = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(182, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(392, 46);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "PAU CASESNOVES";
            // 
            // labelBuscador
            // 
            this.labelBuscador.AutoSize = true;
            this.labelBuscador.Location = new System.Drawing.Point(48, 65);
            this.labelBuscador.Name = "labelBuscador";
            this.labelBuscador.Size = new System.Drawing.Size(55, 13);
            this.labelBuscador.TabIndex = 1;
            this.labelBuscador.Text = "Buscador:";
            // 
            // labelListaAutores
            // 
            this.labelListaAutores.AutoSize = true;
            this.labelListaAutores.Location = new System.Drawing.Point(48, 204);
            this.labelListaAutores.Name = "labelListaAutores";
            this.labelListaAutores.Size = new System.Drawing.Size(82, 13);
            this.labelListaAutores.TabIndex = 2;
            this.labelListaAutores.Text = "Lista de autores";
            // 
            // buttonBuscador
            // 
            this.buttonBuscador.Location = new System.Drawing.Point(657, 97);
            this.buttonBuscador.Name = "buttonBuscador";
            this.buttonBuscador.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscador.TabIndex = 3;
            this.buttonBuscador.Text = "Buscar";
            this.buttonBuscador.UseVisualStyleBackColor = true;
            this.buttonBuscador.Click += new System.EventHandler(this.buttonBuscador_Click);
            // 
            // listBoxAutores
            // 
            this.listBoxAutores.FormattingEnabled = true;
            this.listBoxAutores.Location = new System.Drawing.Point(51, 233);
            this.listBoxAutores.Name = "listBoxAutores";
            this.listBoxAutores.Size = new System.Drawing.Size(508, 173);
            this.listBoxAutores.TabIndex = 4;
            // 
            // buttonIrLibros
            // 
            this.buttonIrLibros.Location = new System.Drawing.Point(594, 272);
            this.buttonIrLibros.Name = "buttonIrLibros";
            this.buttonIrLibros.Size = new System.Drawing.Size(138, 67);
            this.buttonIrLibros.TabIndex = 5;
            this.buttonIrLibros.Text = "Ir a libros";
            this.buttonIrLibros.UseVisualStyleBackColor = true;
            this.buttonIrLibros.Click += new System.EventHandler(this.buttonIrLibros_Click);
            // 
            // textBoxBuscador
            // 
            this.textBoxBuscador.Location = new System.Drawing.Point(51, 100);
            this.textBoxBuscador.Name = "textBoxBuscador";
            this.textBoxBuscador.Size = new System.Drawing.Size(508, 20);
            this.textBoxBuscador.TabIndex = 6;
            // 
            // AutorBuscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxBuscador);
            this.Controls.Add(this.buttonIrLibros);
            this.Controls.Add(this.listBoxAutores);
            this.Controls.Add(this.buttonBuscador);
            this.Controls.Add(this.labelListaAutores);
            this.Controls.Add(this.labelBuscador);
            this.Controls.Add(this.labelTitulo);
            this.Name = "AutorBuscador";
            this.Text = "AutorBuscador";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AutorBuscador_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelBuscador;
        private System.Windows.Forms.Label labelListaAutores;
        private System.Windows.Forms.Button buttonBuscador;
        private System.Windows.Forms.ListBox listBoxAutores;
        private System.Windows.Forms.Button buttonIrLibros;
        private System.Windows.Forms.TextBox textBoxBuscador;
    }
}