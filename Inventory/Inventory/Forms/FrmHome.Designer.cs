namespace Inventory.Forms
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnExit = new System.Windows.Forms.ToolStripButton();
            this.BtnPurchases = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnSales = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnMovements = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SstPrincipal = new System.Windows.Forms.StatusStrip();
            this.LblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.LblFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.LblBd = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.SstPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.BtnExit,
            this.BtnPurchases,
            this.toolStripSeparator1,
            this.BtnSales,
            this.toolStripSeparator4,
            this.BtnMovements,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 31);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // BtnExit
            // 
            this.BtnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnExit.Image = ((System.Drawing.Image)(resources.GetObject("BtnExit.Image")));
            this.BtnExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(68, 28);
            this.BtnExit.Text = "SALIR";
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnPurchases
            // 
            this.BtnPurchases.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPurchases.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnPurchases.Image = ((System.Drawing.Image)(resources.GetObject("BtnPurchases.Image")));
            this.BtnPurchases.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnPurchases.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnPurchases.Name = "BtnPurchases";
            this.BtnPurchases.Size = new System.Drawing.Size(92, 28);
            this.BtnPurchases.Text = "COMPRAS";
            this.BtnPurchases.Click += new System.EventHandler(this.BtnPurchases_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // BtnSales
            // 
            this.BtnSales.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSales.Image = ((System.Drawing.Image)(resources.GetObject("BtnSales.Image")));
            this.BtnSales.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnSales.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSales.Name = "BtnSales";
            this.BtnSales.Size = new System.Drawing.Size(80, 28);
            this.BtnSales.Text = "VENTAS";
            this.BtnSales.Click += new System.EventHandler(this.BtnSales_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // BtnMovements
            // 
            this.BtnMovements.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMovements.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnMovements.Image = ((System.Drawing.Image)(resources.GetObject("BtnMovements.Image")));
            this.BtnMovements.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnMovements.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMovements.Name = "BtnMovements";
            this.BtnMovements.Size = new System.Drawing.Size(120, 28);
            this.BtnMovements.Text = "MOVIMIENTOS";
            this.BtnMovements.Click += new System.EventHandler(this.BtnMovements_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // SstPrincipal
            // 
            this.SstPrincipal.AutoSize = false;
            this.SstPrincipal.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SstPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LblUser,
            this.toolStripSeparator10,
            this.LblFecha,
            this.toolStripSeparator11,
            this.LblBd});
            this.SstPrincipal.Location = new System.Drawing.Point(0, 413);
            this.SstPrincipal.Name = "SstPrincipal";
            this.SstPrincipal.Size = new System.Drawing.Size(800, 37);
            this.SstPrincipal.TabIndex = 9;
            this.SstPrincipal.Text = "statusStrip1";
            // 
            // LblUser
            // 
            this.LblUser.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUser.Image = ((System.Drawing.Image)(resources.GetObject("LblUser.Image")));
            this.LblUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(38, 32);
            this.LblUser.Text = "---";
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 37);
            // 
            // LblFecha
            // 
            this.LblFecha.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Image = ((System.Drawing.Image)(resources.GetObject("LblFecha.Image")));
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(38, 32);
            this.LblFecha.Text = "---";
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 37);
            // 
            // LblBd
            // 
            this.LblBd.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBd.Image = ((System.Drawing.Image)(resources.GetObject("LblBd.Image")));
            this.LblBd.Name = "LblBd";
            this.LblBd.Size = new System.Drawing.Size(38, 32);
            this.LblBd.Text = "---";
            // 
            // FrmHome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SstPrincipal);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "---";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmHome_FormClosed);
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.SstPrincipal.ResumeLayout(false);
            this.SstPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton BtnExit;
        private System.Windows.Forms.ToolStripButton BtnMovements;
        private System.Windows.Forms.StatusStrip SstPrincipal;
        private System.Windows.Forms.ToolStripStatusLabel LblUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripStatusLabel LblFecha;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripStatusLabel LblBd;
        private System.Windows.Forms.ToolStripButton BtnPurchases;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton BtnSales;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}