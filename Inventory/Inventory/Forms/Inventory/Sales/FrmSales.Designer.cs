namespace Inventory.Forms.Inventory.Sales
{
    partial class FrmSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSales));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnClose = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtClient = new System.Windows.Forms.TextBox();
            this.TxtRTN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblNFact = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtQuantity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.DCOIDLOTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCRTN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCPRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCVALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCCANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCFECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CmbProduct = new System.Windows.Forms.ComboBox();
            this.GbInventory = new System.Windows.Forms.GroupBox();
            this.RbAverageCost = new System.Windows.Forms.RadioButton();
            this.RbUEPS = new System.Windows.Forms.RadioButton();
            this.RbPEPS = new System.Windows.Forms.RadioButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.GbInventory.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnNew,
            this.toolStripSeparator1,
            this.BtnSave,
            this.toolStripSeparator2,
            this.BtnCancel,
            this.toolStripSeparator4,
            this.BtnDelete,
            this.toolStripSeparator5,
            this.BtnClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(826, 31);
            this.toolStrip1.TabIndex = 47;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnNew
            // 
            this.BtnNew.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNew.Image = ((System.Drawing.Image)(resources.GetObject("BtnNew.Image")));
            this.BtnNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(76, 28);
            this.BtnNew.Text = "NUEVO";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(94, 28);
            this.BtnSave.Text = "GUARDAR";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Image = ((System.Drawing.Image)(resources.GetObject("BtnCancel.Image")));
            this.BtnCancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(94, 28);
            this.BtnCancel.Text = "CANCELAR";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("BtnDelete.Image")));
            this.BtnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(91, 28);
            this.BtnDelete.Text = "ELIMINAR";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // BtnClose
            // 
            this.BtnClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.BtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(68, 28);
            this.BtnClose.Text = "SALIR";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-4, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 28);
            this.label1.TabIndex = 48;
            this.label1.Text = "   DATOS GENERALES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 49;
            this.label2.Text = "CLIENTE:";
            // 
            // TxtClient
            // 
            this.TxtClient.Location = new System.Drawing.Point(90, 82);
            this.TxtClient.Name = "TxtClient";
            this.TxtClient.Size = new System.Drawing.Size(413, 27);
            this.TxtClient.TabIndex = 50;
            // 
            // TxtRTN
            // 
            this.TxtRTN.Location = new System.Drawing.Point(90, 115);
            this.TxtRTN.Name = "TxtRTN";
            this.TxtRTN.Size = new System.Drawing.Size(413, 27);
            this.TxtRTN.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 51;
            this.label3.Text = "RTN:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(184, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 28);
            this.label4.TabIndex = 53;
            this.label4.Text = "FECHA:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblDate
            // 
            this.LblDate.BackColor = System.Drawing.Color.CadetBlue;
            this.LblDate.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDate.ForeColor = System.Drawing.Color.White;
            this.LblDate.Location = new System.Drawing.Point(263, 44);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(128, 28);
            this.LblDate.TabIndex = 54;
            this.LblDate.Text = "---";
            this.LblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblNFact
            // 
            this.LblNFact.BackColor = System.Drawing.Color.CadetBlue;
            this.LblNFact.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNFact.ForeColor = System.Drawing.Color.White;
            this.LblNFact.Location = new System.Drawing.Point(509, 44);
            this.LblNFact.Name = "LblNFact";
            this.LblNFact.Size = new System.Drawing.Size(303, 28);
            this.LblNFact.TabIndex = 56;
            this.LblNFact.Text = "---";
            this.LblNFact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Teal;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(397, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 28);
            this.label7.TabIndex = 55;
            this.label7.Text = "FACTURA N°:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Teal;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(-4, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(261, 28);
            this.label8.TabIndex = 57;
            this.label8.Text = "   PRODUCTOS";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtQuantity
            // 
            this.TxtQuantity.Location = new System.Drawing.Point(625, 198);
            this.TxtQuantity.Name = "TxtQuantity";
            this.TxtQuantity.Size = new System.Drawing.Size(187, 27);
            this.TxtQuantity.TabIndex = 61;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(527, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 19);
            this.label9.TabIndex = 60;
            this.label9.Text = "CANTIDAD:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 19);
            this.label10.TabIndex = 58;
            this.label10.Text = "PRODUCTO:";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Teal;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(-4, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(261, 28);
            this.label11.TabIndex = 62;
            this.label11.Text = "   VENTAS REGISTRADAS";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            this.DgvData.AllowUserToDeleteRows = false;
            this.DgvData.AllowUserToResizeColumns = false;
            this.DgvData.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            this.DgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DCOIDLOTE,
            this.DCRTN,
            this.DCPRODUCTO,
            this.DCVALOR,
            this.DCCANTIDAD,
            this.DCFECHA});
            this.DgvData.Location = new System.Drawing.Point(16, 305);
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.RowHeadersVisible = false;
            this.DgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvData.Size = new System.Drawing.Size(796, 192);
            this.DgvData.TabIndex = 70;
            // 
            // DCOIDLOTE
            // 
            this.DCOIDLOTE.HeaderText = "ID";
            this.DCOIDLOTE.Name = "DCOIDLOTE";
            this.DCOIDLOTE.ReadOnly = true;
            // 
            // DCRTN
            // 
            this.DCRTN.HeaderText = "RTN";
            this.DCRTN.Name = "DCRTN";
            this.DCRTN.ReadOnly = true;
            // 
            // DCPRODUCTO
            // 
            this.DCPRODUCTO.HeaderText = "PRODUCTO";
            this.DCPRODUCTO.Name = "DCPRODUCTO";
            this.DCPRODUCTO.ReadOnly = true;
            this.DCPRODUCTO.Width = 220;
            // 
            // DCVALOR
            // 
            this.DCVALOR.HeaderText = "VALOR UNT";
            this.DCVALOR.Name = "DCVALOR";
            this.DCVALOR.ReadOnly = true;
            this.DCVALOR.Width = 150;
            // 
            // DCCANTIDAD
            // 
            this.DCCANTIDAD.HeaderText = "CANTIDAD";
            this.DCCANTIDAD.Name = "DCCANTIDAD";
            this.DCCANTIDAD.ReadOnly = true;
            // 
            // DCFECHA
            // 
            this.DCFECHA.HeaderText = "FECHA";
            this.DCFECHA.Name = "DCFECHA";
            this.DCFECHA.ReadOnly = true;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(785, 263);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(27, 27);
            this.BtnSearch.TabIndex = 73;
            this.BtnSearch.Text = "+";
            this.BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(341, 263);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(438, 27);
            this.TxtSearch.TabIndex = 72;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(263, 266);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 19);
            this.label12.TabIndex = 71;
            this.label12.Text = "BUSCAR:";
            // 
            // CmbProduct
            // 
            this.CmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbProduct.FormattingEnabled = true;
            this.CmbProduct.Location = new System.Drawing.Point(112, 198);
            this.CmbProduct.Name = "CmbProduct";
            this.CmbProduct.Size = new System.Drawing.Size(409, 27);
            this.CmbProduct.TabIndex = 74;
            // 
            // GbInventory
            // 
            this.GbInventory.BackColor = System.Drawing.Color.CadetBlue;
            this.GbInventory.Controls.Add(this.RbAverageCost);
            this.GbInventory.Controls.Add(this.RbUEPS);
            this.GbInventory.Controls.Add(this.RbPEPS);
            this.GbInventory.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbInventory.ForeColor = System.Drawing.Color.White;
            this.GbInventory.Location = new System.Drawing.Point(512, 82);
            this.GbInventory.Name = "GbInventory";
            this.GbInventory.Size = new System.Drawing.Size(300, 71);
            this.GbInventory.TabIndex = 75;
            this.GbInventory.TabStop = false;
            this.GbInventory.Text = "INVENTARIO:";
            // 
            // RbAverageCost
            // 
            this.RbAverageCost.AutoSize = true;
            this.RbAverageCost.Checked = true;
            this.RbAverageCost.Location = new System.Drawing.Point(101, 45);
            this.RbAverageCost.Name = "RbAverageCost";
            this.RbAverageCost.Size = new System.Drawing.Size(127, 20);
            this.RbAverageCost.TabIndex = 2;
            this.RbAverageCost.TabStop = true;
            this.RbAverageCost.Text = "COSTO PROMEDIO";
            this.RbAverageCost.UseVisualStyleBackColor = true;
            // 
            // RbUEPS
            // 
            this.RbUEPS.AutoSize = true;
            this.RbUEPS.Location = new System.Drawing.Point(158, 19);
            this.RbUEPS.Name = "RbUEPS";
            this.RbUEPS.Size = new System.Drawing.Size(52, 20);
            this.RbUEPS.TabIndex = 1;
            this.RbUEPS.Text = "UEPS";
            this.RbUEPS.UseVisualStyleBackColor = true;
            // 
            // RbPEPS
            // 
            this.RbPEPS.AutoSize = true;
            this.RbPEPS.Location = new System.Drawing.Point(101, 19);
            this.RbPEPS.Name = "RbPEPS";
            this.RbPEPS.Size = new System.Drawing.Size(51, 20);
            this.RbPEPS.TabIndex = 0;
            this.RbPEPS.Text = "PEPS";
            this.RbPEPS.UseVisualStyleBackColor = true;
            // 
            // FrmSales
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(826, 507);
            this.ControlBox = false;
            this.Controls.Add(this.GbInventory);
            this.Controls.Add(this.CmbProduct);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DgvData);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TxtQuantity);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LblNFact);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtRTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "---";
            this.Load += new System.EventHandler(this.FrmSales_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.GbInventory.ResumeLayout(false);
            this.GbInventory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BtnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton BtnCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton BtnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton BtnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtClient;
        private System.Windows.Forms.TextBox TxtRTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblNFact;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtQuantity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCOIDLOTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCRTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCPRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCVALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCCANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCFECHA;
        private System.Windows.Forms.ComboBox CmbProduct;
        private System.Windows.Forms.GroupBox GbInventory;
        private System.Windows.Forms.RadioButton RbAverageCost;
        private System.Windows.Forms.RadioButton RbUEPS;
        private System.Windows.Forms.RadioButton RbPEPS;
    }
}