namespace Inventory.Forms.Inventory.Purchases
{
    partial class FrmLote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLote));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.DCIDLOTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCIDCOMPRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCPRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCVALOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCSTOCK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCFECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnClose = new System.Windows.Forms.ToolStripButton();
            this.BtnCleanSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSearch
            // 
            this.BtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearch.Image")));
            this.BtnSearch.Location = new System.Drawing.Point(860, 44);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(27, 27);
            this.BtnSearch.TabIndex = 75;
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            this.DgvData.AllowUserToDeleteRows = false;
            this.DgvData.AllowUserToResizeColumns = false;
            this.DgvData.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            this.DgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DCIDLOTE,
            this.DCIDCOMPRA,
            this.DCPRODUCTO,
            this.DCVALOR,
            this.DCSTOCK,
            this.DCFECHA});
            this.DgvData.Location = new System.Drawing.Point(32, 86);
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.RowHeadersVisible = false;
            this.DgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvData.Size = new System.Drawing.Size(888, 192);
            this.DgvData.TabIndex = 74;
            // 
            // DCIDLOTE
            // 
            this.DCIDLOTE.HeaderText = "LOTE";
            this.DCIDLOTE.Name = "DCIDLOTE";
            this.DCIDLOTE.ReadOnly = true;
            // 
            // DCIDCOMPRA
            // 
            this.DCIDCOMPRA.HeaderText = "COMPRA";
            this.DCIDCOMPRA.Name = "DCIDCOMPRA";
            this.DCIDCOMPRA.ReadOnly = true;
            this.DCIDCOMPRA.Width = 110;
            // 
            // DCPRODUCTO
            // 
            this.DCPRODUCTO.HeaderText = "PRODUCTO";
            this.DCPRODUCTO.Name = "DCPRODUCTO";
            this.DCPRODUCTO.ReadOnly = true;
            this.DCPRODUCTO.Width = 250;
            // 
            // DCVALOR
            // 
            this.DCVALOR.HeaderText = "VALOR UNT";
            this.DCVALOR.Name = "DCVALOR";
            this.DCVALOR.ReadOnly = true;
            this.DCVALOR.Width = 150;
            // 
            // DCSTOCK
            // 
            this.DCSTOCK.HeaderText = "STOCK";
            this.DCSTOCK.Name = "DCSTOCK";
            this.DCSTOCK.ReadOnly = true;
            // 
            // DCFECHA
            // 
            this.DCFECHA.HeaderText = "FECHA";
            this.DCFECHA.Name = "DCFECHA";
            this.DCFECHA.ReadOnly = true;
            this.DCFECHA.Width = 150;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(511, 44);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(343, 27);
            this.TxtSearch.TabIndex = 73;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(433, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 19);
            this.label11.TabIndex = 72;
            this.label11.Text = "BUSCAR:";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Teal;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(12, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(415, 28);
            this.label10.TabIndex = 71;
            this.label10.Text = "   LOTES O COMPRAS REGISTRADAS";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(930, 31);
            this.toolStrip1.TabIndex = 76;
            this.toolStrip1.Text = "toolStrip1";
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
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnCleanSearch
            // 
            this.BtnCleanSearch.Image = ((System.Drawing.Image)(resources.GetObject("BtnCleanSearch.Image")));
            this.BtnCleanSearch.Location = new System.Drawing.Point(893, 43);
            this.BtnCleanSearch.Name = "BtnCleanSearch";
            this.BtnCleanSearch.Size = new System.Drawing.Size(27, 27);
            this.BtnCleanSearch.TabIndex = 77;
            this.BtnCleanSearch.UseVisualStyleBackColor = true;
            this.BtnCleanSearch.Click += new System.EventHandler(this.BtnCleanSearch_Click);
            // 
            // FrmLote
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(930, 294);
            this.ControlBox = false;
            this.Controls.Add(this.BtnCleanSearch);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.DgvData);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "---";
            this.Load += new System.EventHandler(this.FrmLote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnClose;
        private System.Windows.Forms.Button BtnCleanSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCIDLOTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCIDCOMPRA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCPRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCVALOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCSTOCK;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCFECHA;
    }
}