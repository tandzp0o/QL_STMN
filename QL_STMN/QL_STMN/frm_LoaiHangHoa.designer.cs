﻿namespace QL_STMN
{
    partial class frm_LoaiHangHoa
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
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.dgvLoaiHH = new System.Windows.Forms.DataGridView();
            this.grnTTLHH = new System.Windows.Forms.GroupBox();
            this.txtTenLoaiHH = new System.Windows.Forms.TextBox();
            this.txtMaLoaiHH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiHH)).BeginInit();
            this.grnTTLHH.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(194, 9);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(238, 31);
            this.lblTieuDe.TabIndex = 1;
            this.lblTieuDe.Text = "LOẠI HÀNG HÓA";
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(12, 12);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(88, 28);
            this.btnTroVe.TabIndex = 2;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // dgvLoaiHH
            // 
            this.dgvLoaiHH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLoaiHH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiHH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiHH.Location = new System.Drawing.Point(12, 131);
            this.dgvLoaiHH.Name = "dgvLoaiHH";
            this.dgvLoaiHH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLoaiHH.Size = new System.Drawing.Size(464, 175);
            this.dgvLoaiHH.TabIndex = 3;
            // 
            // grnTTLHH
            // 
            this.grnTTLHH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grnTTLHH.Controls.Add(this.txtTenLoaiHH);
            this.grnTTLHH.Controls.Add(this.txtMaLoaiHH);
            this.grnTTLHH.Controls.Add(this.label2);
            this.grnTTLHH.Controls.Add(this.label1);
            this.grnTTLHH.Location = new System.Drawing.Point(12, 46);
            this.grnTTLHH.Name = "grnTTLHH";
            this.grnTTLHH.Size = new System.Drawing.Size(610, 68);
            this.grnTTLHH.TabIndex = 4;
            this.grnTTLHH.TabStop = false;
            this.grnTTLHH.Text = "Thông tin loại hàng hóa";
            // 
            // txtTenLoaiHH
            // 
            this.txtTenLoaiHH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenLoaiHH.Location = new System.Drawing.Point(412, 25);
            this.txtTenLoaiHH.Name = "txtTenLoaiHH";
            this.txtTenLoaiHH.Size = new System.Drawing.Size(191, 26);
            this.txtTenLoaiHH.TabIndex = 4;
            // 
            // txtMaLoaiHH
            // 
            this.txtMaLoaiHH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaLoaiHH.Location = new System.Drawing.Point(154, 25);
            this.txtMaLoaiHH.Name = "txtMaLoaiHH";
            this.txtMaLoaiHH.Size = new System.Drawing.Size(113, 26);
            this.txtMaLoaiHH.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên loại hàng hóa: ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã loại hàng hóa: ";
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Location = new System.Drawing.Point(503, 254);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(118, 40);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoa.Location = new System.Drawing.Point(503, 198);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(118, 40);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Location = new System.Drawing.Point(503, 142);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(118, 40);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frm_LoaiHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 326);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grnTTLHH);
            this.Controls.Add(this.dgvLoaiHH);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_LoaiHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại hàng hóa";
            this.Load += new System.EventHandler(this.frm_LoaiHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiHH)).EndInit();
            this.grnTTLHH.ResumeLayout(false);
            this.grnTTLHH.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.DataGridView dgvLoaiHH;
        private System.Windows.Forms.GroupBox grnTTLHH;
        private System.Windows.Forms.TextBox txtTenLoaiHH;
        private System.Windows.Forms.TextBox txtMaLoaiHH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
    }
}