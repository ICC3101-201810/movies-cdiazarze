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
            this.panelAfterButton = new System.Windows.Forms.Panel();
            this.listAfterButton = new System.Windows.Forms.ListBox();
            this.labelList = new System.Windows.Forms.Label();
            this.buttonBackSearch = new System.Windows.Forms.Button();
            this.panelProfile = new System.Windows.Forms.Panel();
            this.backListAfterButton = new System.Windows.Forms.Button();
            this.listProfile = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listProfileLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.a1 = new System.Windows.Forms.Label();
            this.a2 = new System.Windows.Forms.Label();
            this.a3 = new System.Windows.Forms.Label();
            this.va1 = new System.Windows.Forms.Label();
            this.va2 = new System.Windows.Forms.Label();
            this.va3 = new System.Windows.Forms.Label();
            this.a4 = new System.Windows.Forms.Label();
            this.a5 = new System.Windows.Forms.Label();
            this.a6 = new System.Windows.Forms.Label();
            this.va4 = new System.Windows.Forms.Label();
            this.va5 = new System.Windows.Forms.Label();
            this.va6 = new System.Windows.Forms.Label();
            this.panelSearch.SuspendLayout();
            this.panelAfterButton.SuspendLayout();
            this.panelProfile.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.buttonEstudio.Click += new System.EventHandler(this.buttonEstudio_Click);
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
            this.buttonProductores.Click += new System.EventHandler(this.buttonProductores_Click);
            // 
            // buttonDirectores
            // 
            this.buttonDirectores.Location = new System.Drawing.Point(399, 630);
            this.buttonDirectores.Name = "buttonDirectores";
            this.buttonDirectores.Size = new System.Drawing.Size(146, 41);
            this.buttonDirectores.TabIndex = 4;
            this.buttonDirectores.Text = "Directores";
            this.buttonDirectores.UseVisualStyleBackColor = true;
            this.buttonDirectores.Click += new System.EventHandler(this.buttonDirectores_Click);
            // 
            // buttonActores
            // 
            this.buttonActores.Location = new System.Drawing.Point(247, 630);
            this.buttonActores.Name = "buttonActores";
            this.buttonActores.Size = new System.Drawing.Size(146, 41);
            this.buttonActores.TabIndex = 3;
            this.buttonActores.Text = "Actores";
            this.buttonActores.UseVisualStyleBackColor = true;
            this.buttonActores.Click += new System.EventHandler(this.buttonActores_Click);
            // 
            // buttonPeliculas
            // 
            this.buttonPeliculas.Location = new System.Drawing.Point(95, 630);
            this.buttonPeliculas.Name = "buttonPeliculas";
            this.buttonPeliculas.Size = new System.Drawing.Size(146, 41);
            this.buttonPeliculas.TabIndex = 2;
            this.buttonPeliculas.Text = "Peliculas";
            this.buttonPeliculas.UseVisualStyleBackColor = true;
            this.buttonPeliculas.Click += new System.EventHandler(this.buttonPeliculas_Click);
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
            // panelAfterButton
            // 
            this.panelAfterButton.Controls.Add(this.buttonBackSearch);
            this.panelAfterButton.Controls.Add(this.listAfterButton);
            this.panelAfterButton.Controls.Add(this.labelList);
            this.panelAfterButton.Location = new System.Drawing.Point(1019, 0);
            this.panelAfterButton.Margin = new System.Windows.Forms.Padding(4);
            this.panelAfterButton.Name = "panelAfterButton";
            this.panelAfterButton.Size = new System.Drawing.Size(993, 708);
            this.panelAfterButton.TabIndex = 1;
            // 
            // listAfterButton
            // 
            this.listAfterButton.Font = new System.Drawing.Font("Calibri", 10F);
            this.listAfterButton.FormattingEnabled = true;
            this.listAfterButton.HorizontalScrollbar = true;
            this.listAfterButton.ItemHeight = 21;
            this.listAfterButton.Location = new System.Drawing.Point(15, 44);
            this.listAfterButton.Name = "listAfterButton";
            this.listAfterButton.Size = new System.Drawing.Size(956, 571);
            this.listAfterButton.TabIndex = 6;
            this.listAfterButton.SelectedIndexChanged += new System.EventHandler(this.listAfterButton_SelectedIndexChanged);
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.Location = new System.Drawing.Point(11, 17);
            this.labelList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(65, 24);
            this.labelList.TabIndex = 1;
            this.labelList.Text = "Search";
            // 
            // buttonBackSearch
            // 
            this.buttonBackSearch.Location = new System.Drawing.Point(15, 630);
            this.buttonBackSearch.Name = "buttonBackSearch";
            this.buttonBackSearch.Size = new System.Drawing.Size(146, 41);
            this.buttonBackSearch.TabIndex = 7;
            this.buttonBackSearch.Text = "Volver";
            this.buttonBackSearch.UseVisualStyleBackColor = true;
            this.buttonBackSearch.Click += new System.EventHandler(this.buttonBackSearch_Click);
            // 
            // panelProfile
            // 
            this.panelProfile.Controls.Add(this.tableLayoutPanel1);
            this.panelProfile.Controls.Add(this.listProfileLabel);
            this.panelProfile.Controls.Add(this.backListAfterButton);
            this.panelProfile.Controls.Add(this.listProfile);
            this.panelProfile.Controls.Add(this.label2);
            this.panelProfile.Location = new System.Drawing.Point(2040, 0);
            this.panelProfile.Margin = new System.Windows.Forms.Padding(4);
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Size = new System.Drawing.Size(993, 708);
            this.panelProfile.TabIndex = 8;
            // 
            // backListAfterButton
            // 
            this.backListAfterButton.Location = new System.Drawing.Point(15, 630);
            this.backListAfterButton.Name = "backListAfterButton";
            this.backListAfterButton.Size = new System.Drawing.Size(146, 41);
            this.backListAfterButton.TabIndex = 7;
            this.backListAfterButton.Text = "Volver";
            this.backListAfterButton.UseVisualStyleBackColor = true;
            this.backListAfterButton.Click += new System.EventHandler(this.backListAfterButton_Click);
            // 
            // listProfile
            // 
            this.listProfile.Font = new System.Drawing.Font("Calibri", 10F);
            this.listProfile.FormattingEnabled = true;
            this.listProfile.HorizontalScrollbar = true;
            this.listProfile.ItemHeight = 21;
            this.listProfile.Location = new System.Drawing.Point(15, 401);
            this.listProfile.Name = "listProfile";
            this.listProfile.Size = new System.Drawing.Size(956, 214);
            this.listProfile.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Informacion";
            // 
            // listProfileLabel
            // 
            this.listProfileLabel.AutoSize = true;
            this.listProfileLabel.Location = new System.Drawing.Point(11, 364);
            this.listProfileLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.listProfileLabel.Name = "listProfileLabel";
            this.listProfileLabel.Size = new System.Drawing.Size(332, 24);
            this.listProfileLabel.TabIndex = 8;
            this.listProfileLabel.Text = "Personas que trabajaron en la pelicula";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.Controls.Add(this.va1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.a1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.a2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.a3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.va2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.va3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.a4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.a5, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.a6, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.va4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.va5, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.va6, 4, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 47);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(956, 295);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // a1
            // 
            this.a1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.a1.AutoSize = true;
            this.a1.Location = new System.Drawing.Point(3, 37);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(61, 24);
            this.a1.TabIndex = 0;
            this.a1.Text = "label4";
            // 
            // a2
            // 
            this.a2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.a2.AutoSize = true;
            this.a2.Location = new System.Drawing.Point(3, 135);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(61, 24);
            this.a2.TabIndex = 1;
            this.a2.Text = "label4";
            // 
            // a3
            // 
            this.a3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.a3.AutoSize = true;
            this.a3.Location = new System.Drawing.Point(3, 233);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(61, 24);
            this.a3.TabIndex = 2;
            this.a3.Text = "label4";
            // 
            // va1
            // 
            this.va1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.va1.AutoSize = true;
            this.va1.Location = new System.Drawing.Point(146, 37);
            this.va1.Name = "va1";
            this.va1.Size = new System.Drawing.Size(61, 24);
            this.va1.TabIndex = 3;
            this.va1.Text = "label4";
            // 
            // va2
            // 
            this.va2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.va2.AutoSize = true;
            this.va2.Location = new System.Drawing.Point(146, 135);
            this.va2.Name = "va2";
            this.va2.Size = new System.Drawing.Size(61, 24);
            this.va2.TabIndex = 4;
            this.va2.Text = "label4";
            // 
            // va3
            // 
            this.va3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.va3.AutoSize = true;
            this.va3.Location = new System.Drawing.Point(146, 233);
            this.va3.Name = "va3";
            this.va3.Size = new System.Drawing.Size(61, 24);
            this.va3.TabIndex = 5;
            this.va3.Text = "label4";
            // 
            // a4
            // 
            this.a4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.a4.AutoSize = true;
            this.a4.Location = new System.Drawing.Point(499, 37);
            this.a4.Name = "a4";
            this.a4.Size = new System.Drawing.Size(61, 24);
            this.a4.TabIndex = 6;
            this.a4.Text = "label4";
            // 
            // a5
            // 
            this.a5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.a5.AutoSize = true;
            this.a5.Location = new System.Drawing.Point(499, 135);
            this.a5.Name = "a5";
            this.a5.Size = new System.Drawing.Size(61, 24);
            this.a5.TabIndex = 7;
            this.a5.Text = "label4";
            // 
            // a6
            // 
            this.a6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.a6.AutoSize = true;
            this.a6.Location = new System.Drawing.Point(499, 233);
            this.a6.Name = "a6";
            this.a6.Size = new System.Drawing.Size(61, 24);
            this.a6.TabIndex = 8;
            this.a6.Text = "label4";
            // 
            // va4
            // 
            this.va4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.va4.AutoSize = true;
            this.va4.Location = new System.Drawing.Point(642, 37);
            this.va4.Name = "va4";
            this.va4.Size = new System.Drawing.Size(61, 24);
            this.va4.TabIndex = 9;
            this.va4.Text = "label4";
            // 
            // va5
            // 
            this.va5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.va5.AutoSize = true;
            this.va5.Location = new System.Drawing.Point(642, 135);
            this.va5.Name = "va5";
            this.va5.Size = new System.Drawing.Size(61, 24);
            this.va5.TabIndex = 10;
            this.va5.Text = "label4";
            // 
            // va6
            // 
            this.va6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.va6.AutoSize = true;
            this.va6.Location = new System.Drawing.Point(642, 233);
            this.va6.Name = "va6";
            this.va6.Size = new System.Drawing.Size(61, 24);
            this.va6.TabIndex = 11;
            this.va6.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3204, 721);
            this.Controls.Add(this.panelProfile);
            this.Controls.Add(this.panelAfterButton);
            this.Controls.Add(this.panelSearch);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            this.panelAfterButton.ResumeLayout(false);
            this.panelAfterButton.PerformLayout();
            this.panelProfile.ResumeLayout(false);
            this.panelProfile.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.Panel panelAfterButton;
        private System.Windows.Forms.ListBox listAfterButton;
        private System.Windows.Forms.Label labelList;
        private System.Windows.Forms.Button buttonBackSearch;
        private System.Windows.Forms.Panel panelProfile;
        private System.Windows.Forms.Button backListAfterButton;
        private System.Windows.Forms.ListBox listProfile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label listProfileLabel;
        private System.Windows.Forms.Label a1;
        private System.Windows.Forms.Label a2;
        private System.Windows.Forms.Label a3;
        private System.Windows.Forms.Label va1;
        private System.Windows.Forms.Label va2;
        private System.Windows.Forms.Label va3;
        private System.Windows.Forms.Label a4;
        private System.Windows.Forms.Label a5;
        private System.Windows.Forms.Label a6;
        private System.Windows.Forms.Label va4;
        private System.Windows.Forms.Label va5;
        private System.Windows.Forms.Label va6;
    }
}

