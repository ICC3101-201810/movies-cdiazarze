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
            this.panelSearch = new System.Windows.Forms.Panel();
            this.buttonEstudio = new System.Windows.Forms.Button();
            this.listResultado = new System.Windows.Forms.ListBox();
            this.buttonProductores = new System.Windows.Forms.Button();
            this.buttonDirectores = new System.Windows.Forms.Button();
            this.buttonActores = new System.Windows.Forms.Button();
            this.buttonPeliculas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.panelSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.buttonEstudio);
            this.panelSearch.Controls.Add(this.listResultado);
            this.panelSearch.Controls.Add(this.buttonProductores);
            this.panelSearch.Controls.Add(this.buttonDirectores);
            this.panelSearch.Controls.Add(this.buttonActores);
            this.panelSearch.Controls.Add(this.buttonPeliculas);
            this.panelSearch.Controls.Add(this.label1);
            this.panelSearch.Controls.Add(this.searchBox);
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Margin = new System.Windows.Forms.Padding(4);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(993, 708);
            this.panelSearch.TabIndex = 0;
            // 
            // buttonEstudio
            // 
            this.buttonEstudio.Location = new System.Drawing.Point(704, 630);
            this.buttonEstudio.Name = "buttonEstudio";
            this.buttonEstudio.Size = new System.Drawing.Size(146, 41);
            this.buttonEstudio.TabIndex = 7;
            this.buttonEstudio.Text = "Estudios";
            this.buttonEstudio.UseVisualStyleBackColor = true;
            // 
            // listResultado
            // 
            this.listResultado.Font = new System.Drawing.Font("Calibri", 10F);
            this.listResultado.FormattingEnabled = true;
            this.listResultado.HorizontalScrollbar = true;
            this.listResultado.ItemHeight = 21;
            this.listResultado.Location = new System.Drawing.Point(15, 86);
            this.listResultado.Name = "listResultado";
            this.listResultado.Size = new System.Drawing.Size(956, 529);
            this.listResultado.TabIndex = 6;
            // 
            // buttonProductores
            // 
            this.buttonProductores.Location = new System.Drawing.Point(551, 630);
            this.buttonProductores.Name = "buttonProductores";
            this.buttonProductores.Size = new System.Drawing.Size(146, 41);
            this.buttonProductores.TabIndex = 5;
            this.buttonProductores.Text = "Productores";
            this.buttonProductores.UseVisualStyleBackColor = true;
            // 
            // buttonDirectores
            // 
            this.buttonDirectores.Location = new System.Drawing.Point(399, 630);
            this.buttonDirectores.Name = "buttonDirectores";
            this.buttonDirectores.Size = new System.Drawing.Size(146, 41);
            this.buttonDirectores.TabIndex = 4;
            this.buttonDirectores.Text = "Directores";
            this.buttonDirectores.UseVisualStyleBackColor = true;
            // 
            // buttonActores
            // 
            this.buttonActores.Location = new System.Drawing.Point(247, 630);
            this.buttonActores.Name = "buttonActores";
            this.buttonActores.Size = new System.Drawing.Size(146, 41);
            this.buttonActores.TabIndex = 3;
            this.buttonActores.Text = "Actores";
            this.buttonActores.UseVisualStyleBackColor = true;
            // 
            // buttonPeliculas
            // 
            this.buttonPeliculas.Location = new System.Drawing.Point(95, 630);
            this.buttonPeliculas.Name = "buttonPeliculas";
            this.buttonPeliculas.Size = new System.Drawing.Size(146, 41);
            this.buttonPeliculas.TabIndex = 2;
            this.buttonPeliculas.Text = "Peliculas";
            this.buttonPeliculas.UseVisualStyleBackColor = true;
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
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(15, 47);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(956, 32);
            this.searchBox.TabIndex = 0;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.panelSearch);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSearch;
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

