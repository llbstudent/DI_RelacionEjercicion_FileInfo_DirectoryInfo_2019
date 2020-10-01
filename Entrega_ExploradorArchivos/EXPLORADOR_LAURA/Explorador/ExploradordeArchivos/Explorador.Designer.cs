namespace ExploradordeArchivos
{
    partial class VentanaExplorador
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaExplorador));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imgListSmall = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vISTASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iCONOSGRANDESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iCONOSPEQUEÑOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lISTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dETALLESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imgListLarge = new System.Windows.Forms.ImageList(this.components);
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(929, 415);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 24);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(929, 452);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Size = new System.Drawing.Size(929, 415);
            this.splitContainer1.SplitterDistance = 309;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imgListSmall;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(309, 415);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // imgListSmall
            // 
            this.imgListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListSmall.ImageStream")));
            this.imgListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListSmall.Images.SetKeyName(0, "Folder");
            this.imgListSmall.Images.SetKeyName(1, "File");
            this.imgListSmall.Images.SetKeyName(2, "Img");
            this.imgListSmall.Images.SetKeyName(3, "Pdf");
            this.imgListSmall.Images.SetKeyName(4, "cSharp");
            this.imgListSmall.Images.SetKeyName(5, "Default");
            this.imgListSmall.Images.SetKeyName(6, "Exe");
            this.imgListSmall.Images.SetKeyName(7, "Java");
            this.imgListSmall.Images.SetKeyName(8, "Python");
            this.imgListSmall.Images.SetKeyName(9, "Rar");
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(614, 415);
            this.listView1.SmallImageList = this.imgListSmall;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tipo";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Última Modificación";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vISTASToolStripMenuItem,
            this.sALIRToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(929, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vISTASToolStripMenuItem
            // 
            this.vISTASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iCONOSGRANDESToolStripMenuItem,
            this.iCONOSPEQUEÑOSToolStripMenuItem,
            this.lISTAToolStripMenuItem,
            this.dETALLESToolStripMenuItem});
            this.vISTASToolStripMenuItem.Name = "vISTASToolStripMenuItem";
            this.vISTASToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.vISTASToolStripMenuItem.Text = "VISTAS";
            // 
            // iCONOSGRANDESToolStripMenuItem
            // 
            this.iCONOSGRANDESToolStripMenuItem.Name = "iCONOSGRANDESToolStripMenuItem";
            this.iCONOSGRANDESToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.iCONOSGRANDESToolStripMenuItem.Text = "ICONOS GRANDES";
            this.iCONOSGRANDESToolStripMenuItem.Click += new System.EventHandler(this.iCONOSGRANDESToolStripMenuItem_Click);
            // 
            // iCONOSPEQUEÑOSToolStripMenuItem
            // 
            this.iCONOSPEQUEÑOSToolStripMenuItem.Name = "iCONOSPEQUEÑOSToolStripMenuItem";
            this.iCONOSPEQUEÑOSToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.iCONOSPEQUEÑOSToolStripMenuItem.Text = "ICONOS PEQUEÑOS";
            this.iCONOSPEQUEÑOSToolStripMenuItem.Click += new System.EventHandler(this.iCONOSPEQUEÑOSToolStripMenuItem_Click);
            // 
            // lISTAToolStripMenuItem
            // 
            this.lISTAToolStripMenuItem.Name = "lISTAToolStripMenuItem";
            this.lISTAToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.lISTAToolStripMenuItem.Text = "LISTA";
            this.lISTAToolStripMenuItem.Click += new System.EventHandler(this.lISTAToolStripMenuItem_Click);
            // 
            // dETALLESToolStripMenuItem
            // 
            this.dETALLESToolStripMenuItem.Name = "dETALLESToolStripMenuItem";
            this.dETALLESToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.dETALLESToolStripMenuItem.Text = "DETALLES";
            this.dETALLESToolStripMenuItem.Click += new System.EventHandler(this.dETALLESToolStripMenuItem_Click);
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sALIRToolStripMenuItem.Text = "SALIR";
            this.sALIRToolStripMenuItem.Click += new System.EventHandler(this.sALIRToolStripMenuItem_Click);
            // 
            // imgListLarge
            // 
            this.imgListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListLarge.ImageStream")));
            this.imgListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListLarge.Images.SetKeyName(0, "Folder");
            this.imgListLarge.Images.SetKeyName(1, "File");
            this.imgListLarge.Images.SetKeyName(2, "Img");
            this.imgListLarge.Images.SetKeyName(3, "Pdf");
            this.imgListLarge.Images.SetKeyName(4, "cSharp");
            this.imgListLarge.Images.SetKeyName(5, "Default");
            this.imgListLarge.Images.SetKeyName(6, "Exe");
            this.imgListLarge.Images.SetKeyName(7, "Java");
            this.imgListLarge.Images.SetKeyName(8, "Python");
            this.imgListLarge.Images.SetKeyName(9, "Rar");
            // 
            // VentanaExplorador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 476);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "VentanaExplorador";
            this.Text = "Explorador de Archivos";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ImageList imgListSmall;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vISTASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iCONOSGRANDESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iCONOSPEQUEÑOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lISTAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dETALLESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
        private System.Windows.Forms.ImageList imgListLarge;
    }
}

