namespace ClasesFile
{
    partial class FormPpl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbRuta = new System.Windows.Forms.TextBox();
            this.btnCrearTxt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNorton2 = new System.Windows.Forms.Button();
            this.btnNorton1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbRuta);
            this.groupBox1.Controls.Add(this.btnCrearTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnNorton2);
            this.groupBox1.Controls.Add(this.btnNorton1);
            this.groupBox1.Location = new System.Drawing.Point(33, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 513);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // tbRuta
            // 
            this.tbRuta.Location = new System.Drawing.Point(34, 204);
            this.tbRuta.Name = "tbRuta";
            this.tbRuta.Size = new System.Drawing.Size(306, 20);
            this.tbRuta.TabIndex = 4;
            // 
            // btnCrearTxt
            // 
            this.btnCrearTxt.Location = new System.Drawing.Point(34, 125);
            this.btnCrearTxt.Name = "btnCrearTxt";
            this.btnCrearTxt.Size = new System.Drawing.Size(306, 72);
            this.btnCrearTxt.TabIndex = 3;
            this.btnCrearTxt.Text = "Crear Fichero de texto";
            this.btnCrearTxt.UseVisualStyleBackColor = true;
            this.btnCrearTxt.Click += new System.EventHandler(this.btnCrearTxt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione que desea hacer:";
            // 
            // btnNorton2
            // 
            this.btnNorton2.Location = new System.Drawing.Point(34, 395);
            this.btnNorton2.Name = "btnNorton2";
            this.btnNorton2.Size = new System.Drawing.Size(306, 77);
            this.btnNorton2.TabIndex = 1;
            this.btnNorton2.Text = "ComandanteNorton 2";
            this.btnNorton2.UseVisualStyleBackColor = true;
            this.btnNorton2.Click += new System.EventHandler(this.btnNorton2_Click);
            // 
            // btnNorton1
            // 
            this.btnNorton1.Location = new System.Drawing.Point(34, 299);
            this.btnNorton1.Name = "btnNorton1";
            this.btnNorton1.Size = new System.Drawing.Size(306, 72);
            this.btnNorton1.TabIndex = 0;
            this.btnNorton1.Text = "ComandanteNorton 1";
            this.btnNorton1.UseVisualStyleBackColor = true;
            this.btnNorton1.Click += new System.EventHandler(this.btnNorton1_Click);
            // 
            // FormPpl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 617);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPpl";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNorton2;
        private System.Windows.Forms.Button btnNorton1;
        private System.Windows.Forms.Button btnCrearTxt;
        private System.Windows.Forms.TextBox tbRuta;
    }
}

