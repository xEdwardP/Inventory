namespace Inventory.Forms.Inventory.Movements
{
    partial class FrmMovements
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMovements));
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnClose = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DCFECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCCONCEPTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCECANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCVUNIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCVTOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCSDCANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCSDVUND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCSDCVTOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCSCANTIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCVSUND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCSVTOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            this.DgvData.AllowUserToDeleteRows = false;
            this.DgvData.AllowUserToResizeColumns = false;
            this.DgvData.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.AliceBlue;
            this.DgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DCFECHA,
            this.DCCONCEPTO,
            this.DCECANTIDAD,
            this.DCVUNIDAD,
            this.DCVTOTAL,
            this.DCSDCANTIDAD,
            this.DCSDVUND,
            this.DCSDCVTOTAL,
            this.DCSCANTIDAD,
            this.DCVSUND,
            this.DCSVTOTAL});
            this.DgvData.Location = new System.Drawing.Point(12, 65);
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DgvData.RowHeadersVisible = false;
            this.DgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvData.Size = new System.Drawing.Size(1048, 192);
            this.DgvData.TabIndex = 70;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnNew,
            this.toolStripSeparator1,
            this.BtnCancel,
            this.toolStripSeparator4,
            this.BtnClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1075, 31);
            this.toolStrip1.TabIndex = 72;
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
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.CadetBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(214, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 19);
            this.label2.TabIndex = 73;
            this.label2.Text = "ENTRADAS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.CadetBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(502, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 19);
            this.label3.TabIndex = 74;
            this.label3.Text = "SALIDAS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.CadetBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(778, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(282, 19);
            this.label4.TabIndex = 75;
            this.label4.Text = "SALDOS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DCFECHA
            // 
            this.DCFECHA.HeaderText = "FECHA";
            this.DCFECHA.Name = "DCFECHA";
            this.DCFECHA.ReadOnly = true;
            // 
            // DCCONCEPTO
            // 
            this.DCCONCEPTO.HeaderText = "CONCEPTO";
            this.DCCONCEPTO.Name = "DCCONCEPTO";
            this.DCCONCEPTO.ReadOnly = true;
            // 
            // DCECANTIDAD
            // 
            this.DCECANTIDAD.HeaderText = "CANTIDAD";
            this.DCECANTIDAD.Name = "DCECANTIDAD";
            this.DCECANTIDAD.ReadOnly = true;
            this.DCECANTIDAD.Width = 80;
            // 
            // DCVUNIDAD
            // 
            this.DCVUNIDAD.HeaderText = "VALOR UND";
            this.DCVUNIDAD.Name = "DCVUNIDAD";
            this.DCVUNIDAD.ReadOnly = true;
            // 
            // DCVTOTAL
            // 
            this.DCVTOTAL.HeaderText = "VALOR TOTAL";
            this.DCVTOTAL.Name = "DCVTOTAL";
            this.DCVTOTAL.ReadOnly = true;
            // 
            // DCSDCANTIDAD
            // 
            this.DCSDCANTIDAD.HeaderText = "CANTIDAD";
            this.DCSDCANTIDAD.Name = "DCSDCANTIDAD";
            this.DCSDCANTIDAD.ReadOnly = true;
            this.DCSDCANTIDAD.Width = 80;
            // 
            // DCSDVUND
            // 
            this.DCSDVUND.HeaderText = "VALOR UND";
            this.DCSDVUND.Name = "DCSDVUND";
            this.DCSDVUND.ReadOnly = true;
            // 
            // DCSDCVTOTAL
            // 
            this.DCSDCVTOTAL.HeaderText = "VALOR TOTAL";
            this.DCSDCVTOTAL.Name = "DCSDCVTOTAL";
            this.DCSDCVTOTAL.ReadOnly = true;
            // 
            // DCSCANTIDAD
            // 
            this.DCSCANTIDAD.HeaderText = "CANTIDAD";
            this.DCSCANTIDAD.Name = "DCSCANTIDAD";
            this.DCSCANTIDAD.ReadOnly = true;
            this.DCSCANTIDAD.Width = 80;
            // 
            // DCVSUND
            // 
            this.DCVSUND.HeaderText = "VALOR UND";
            this.DCVSUND.Name = "DCVSUND";
            this.DCVSUND.ReadOnly = true;
            // 
            // DCSVTOTAL
            // 
            this.DCSVTOTAL.HeaderText = "VALOR TOTAL";
            this.DCSVTOTAL.Name = "DCSVTOTAL";
            this.DCSVTOTAL.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Teal;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 19);
            this.label5.TabIndex = 76;
            this.label5.Text = "INVENTARIO";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMovements
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1075, 271);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.DgvData);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMovements";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "---";
            this.Load += new System.EventHandler(this.FrmMovements_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BtnCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton BtnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCFECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCCONCEPTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCECANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCVUNIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCVTOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCSDCANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCSDVUND;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCSDCVTOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCSCANTIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCVSUND;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCSVTOTAL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}