namespace movies
{
    partial class Form1
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
            this.panelInicio = new System.Windows.Forms.Panel();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPeliculas = new System.Windows.Forms.Button();
            this.buttonActores = new System.Windows.Forms.Button();
            this.buttonDirectores = new System.Windows.Forms.Button();
            this.buttonProductores = new System.Windows.Forms.Button();
            this.listResultado = new System.Windows.Forms.ListBox();
            this.buttonEstudio = new System.Windows.Forms.Button();
            this.panelInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInicio
            // 
            this.panelInicio.Controls.Add(this.buttonEstudio);
            this.panelInicio.Controls.Add(this.listResultado);
            this.panelInicio.Controls.Add(this.buttonProductores);
            this.panelInicio.Controls.Add(this.buttonDirectores);
            this.panelInicio.Controls.Add(this.buttonActores);
            this.panelInicio.Controls.Add(this.buttonPeliculas);
            this.panelInicio.Controls.Add(this.label1);
            this.panelInicio.Controls.Add(this.searchBox);
            this.panelInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInicio.Location = new System.Drawing.Point(0, 0);
            this.panelInicio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelInicio.Name = "panelInicio";
            this.panelInicio.Size = new System.Drawing.Size(782, 553);
            this.panelInicio.TabIndex = 0;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(15, 47);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(741, 32);
            this.searchBox.TabIndex = 0;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // buttonPeliculas
            // 
            this.buttonPeliculas.Location = new System.Drawing.Point(15, 475);
            this.buttonPeliculas.Name = "buttonPeliculas";
            this.buttonPeliculas.Size = new System.Drawing.Size(146, 41);
            this.buttonPeliculas.TabIndex = 2;
            this.buttonPeliculas.Text = "Peliculas";
            this.buttonPeliculas.UseVisualStyleBackColor = true;
            // 
            // buttonActores
            // 
            this.buttonActores.Location = new System.Drawing.Point(167, 475);
            this.buttonActores.Name = "buttonActores";
            this.buttonActores.Size = new System.Drawing.Size(146, 41);
            this.buttonActores.TabIndex = 3;
            this.buttonActores.Text = "Actores";
            this.buttonActores.UseVisualStyleBackColor = true;
            // 
            // buttonDirectores
            // 
            this.buttonDirectores.Location = new System.Drawing.Point(319, 475);
            this.buttonDirectores.Name = "buttonDirectores";
            this.buttonDirectores.Size = new System.Drawing.Size(146, 41);
            this.buttonDirectores.TabIndex = 4;
            this.buttonDirectores.Text = "Directores";
            this.buttonDirectores.UseVisualStyleBackColor = true;
            // 
            // buttonProductores
            // 
            this.buttonProductores.Location = new System.Drawing.Point(471, 475);
            this.buttonProductores.Name = "buttonProductores";
            this.buttonProductores.Size = new System.Drawing.Size(146, 41);
            this.buttonProductores.TabIndex = 5;
            this.buttonProductores.Text = "Productores";
            this.buttonProductores.UseVisualStyleBackColor = true;
            // 
            // listResultado
            // 
            this.listResultado.FormattingEnabled = true;
            this.listResultado.ItemHeight = 24;
            this.listResultado.Location = new System.Drawing.Point(15, 86);
            this.listResultado.Name = "listResultado";
            this.listResultado.Size = new System.Drawing.Size(741, 364);
            this.listResultado.TabIndex = 6;
            // 
            // buttonEstudio
            // 
            this.buttonEstudio.Location = new System.Drawing.Point(624, 475);
            this.buttonEstudio.Name = "buttonEstudio";
            this.buttonEstudio.Size = new System.Drawing.Size(146, 41);
            this.buttonEstudio.TabIndex = 7;
            this.buttonEstudio.Text = "Estudios";
            this.buttonEstudio.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.panelInicio);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelInicio.ResumeLayout(false);
            this.panelInicio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInicio;
        private System.Windows.Forms.Button buttonEstudio;
        private System.Windows.Forms.ListBox listResultado;
        private System.Windows.Forms.Button buttonProductores;
        private System.Windows.Forms.Button buttonDirectores;
        private System.Windows.Forms.Button buttonActores;
        private System.Windows.Forms.Button buttonPeliculas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBox;
    }
}

