namespace ObtFich
{
    partial class FormObtenerFicheros
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbRuta = new System.Windows.Forms.TextBox();
            this.listBoxFicheros = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCargarFicheros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "RUTA: ";
            // 
            // tbRuta
            // 
            this.tbRuta.Location = new System.Drawing.Point(94, 22);
            this.tbRuta.Name = "tbRuta";
            this.tbRuta.Size = new System.Drawing.Size(463, 20);
            this.tbRuta.TabIndex = 1;
            // 
            // listBoxFicheros
            // 
            this.listBoxFicheros.FormattingEnabled = true;
            this.listBoxFicheros.Location = new System.Drawing.Point(39, 101);
            this.listBoxFicheros.Name = "listBoxFicheros";
            this.listBoxFicheros.Size = new System.Drawing.Size(699, 329);
            this.listBoxFicheros.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Archivos que contiene la Carpeta:";
            // 
            // btnCargarFicheros
            // 
            this.btnCargarFicheros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarFicheros.Location = new System.Drawing.Point(585, 20);
            this.btnCargarFicheros.Name = "btnCargarFicheros";
            this.btnCargarFicheros.Size = new System.Drawing.Size(153, 23);
            this.btnCargarFicheros.TabIndex = 4;
            this.btnCargarFicheros.Text = "Cargar Archivos";
            this.btnCargarFicheros.UseVisualStyleBackColor = true;
            this.btnCargarFicheros.Click += new System.EventHandler(this.btnCargarFicheros_Click);
            // 
            // FormObtenerFicheros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCargarFicheros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxFicheros);
            this.Controls.Add(this.tbRuta);
            this.Controls.Add(this.label1);
            this.Name = "FormObtenerFicheros";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OBTENER FICHEROS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRuta;
        private System.Windows.Forms.ListBox listBoxFicheros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCargarFicheros;
    }
}

