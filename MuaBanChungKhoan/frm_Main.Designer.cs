namespace MuaBanChungKhoan
{
    partial class frm_Main
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
            this.lb_LoaiLenh = new System.Windows.Forms.Label();
            this.lb_MaCK = new System.Windows.Forms.Label();
            this.lb_KhoiLuong = new System.Windows.Forms.Label();
            this.lb_Gia = new System.Windows.Forms.Label();
            this.lb_MuaBan = new System.Windows.Forms.Label();
            this.lb_Lenh = new System.Windows.Forms.Label();
            this.btn_MuaBan = new System.Windows.Forms.Button();
            this.btn_LamLai = new System.Windows.Forms.Button();
            this.cb_LoaiLenh = new System.Windows.Forms.ComboBox();
            this.cb_Lenh = new System.Windows.Forms.ComboBox();
            this.cb_MuaBan = new System.Windows.Forms.ComboBox();
            this.tb_MaCP = new System.Windows.Forms.TextBox();
            this.se_Gia = new DevExpress.XtraEditors.SpinEdit();
            this.se_KL = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.se_Gia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.se_KL.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_LoaiLenh
            // 
            this.lb_LoaiLenh.AutoSize = true;
            this.lb_LoaiLenh.Location = new System.Drawing.Point(41, 22);
            this.lb_LoaiLenh.Name = "lb_LoaiLenh";
            this.lb_LoaiLenh.Size = new System.Drawing.Size(52, 13);
            this.lb_LoaiLenh.TabIndex = 0;
            this.lb_LoaiLenh.Text = "Loại Lệnh";
            // 
            // lb_MaCK
            // 
            this.lb_MaCK.AutoSize = true;
            this.lb_MaCK.Location = new System.Drawing.Point(41, 67);
            this.lb_MaCK.Name = "lb_MaCK";
            this.lb_MaCK.Size = new System.Drawing.Size(37, 13);
            this.lb_MaCK.TabIndex = 1;
            this.lb_MaCK.Text = "Mã CP";
            // 
            // lb_KhoiLuong
            // 
            this.lb_KhoiLuong.AutoSize = true;
            this.lb_KhoiLuong.Location = new System.Drawing.Point(41, 114);
            this.lb_KhoiLuong.Name = "lb_KhoiLuong";
            this.lb_KhoiLuong.Size = new System.Drawing.Size(60, 13);
            this.lb_KhoiLuong.TabIndex = 2;
            this.lb_KhoiLuong.Text = "Khối Lượng";
            // 
            // lb_Gia
            // 
            this.lb_Gia.AutoSize = true;
            this.lb_Gia.Location = new System.Drawing.Point(41, 157);
            this.lb_Gia.Name = "lb_Gia";
            this.lb_Gia.Size = new System.Drawing.Size(22, 13);
            this.lb_Gia.TabIndex = 3;
            this.lb_Gia.Text = "Giá";
            // 
            // lb_MuaBan
            // 
            this.lb_MuaBan.AutoSize = true;
            this.lb_MuaBan.Location = new System.Drawing.Point(329, 22);
            this.lb_MuaBan.Name = "lb_MuaBan";
            this.lb_MuaBan.Size = new System.Drawing.Size(49, 13);
            this.lb_MuaBan.TabIndex = 4;
            this.lb_MuaBan.Text = "Mua/Bán";
            // 
            // lb_Lenh
            // 
            this.lb_Lenh.AutoSize = true;
            this.lb_Lenh.Location = new System.Drawing.Point(329, 67);
            this.lb_Lenh.Name = "lb_Lenh";
            this.lb_Lenh.Size = new System.Drawing.Size(30, 13);
            this.lb_Lenh.TabIndex = 5;
            this.lb_Lenh.Text = "Lệnh";
            // 
            // btn_MuaBan
            // 
            this.btn_MuaBan.BackColor = System.Drawing.Color.Yellow;
            this.btn_MuaBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MuaBan.Location = new System.Drawing.Point(171, 210);
            this.btn_MuaBan.Name = "btn_MuaBan";
            this.btn_MuaBan.Size = new System.Drawing.Size(87, 23);
            this.btn_MuaBan.TabIndex = 6;
            this.btn_MuaBan.UseVisualStyleBackColor = false;
            this.btn_MuaBan.Click += new System.EventHandler(this.btn_MuaBan_Click);
            // 
            // btn_LamLai
            // 
            this.btn_LamLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LamLai.Location = new System.Drawing.Point(332, 210);
            this.btn_LamLai.Name = "btn_LamLai";
            this.btn_LamLai.Size = new System.Drawing.Size(87, 23);
            this.btn_LamLai.TabIndex = 7;
            this.btn_LamLai.Text = "Làm Lại";
            this.btn_LamLai.UseVisualStyleBackColor = true;
            this.btn_LamLai.Click += new System.EventHandler(this.btn_LamLai_Click);
            // 
            // cb_LoaiLenh
            // 
            this.cb_LoaiLenh.Enabled = false;
            this.cb_LoaiLenh.FormattingEnabled = true;
            this.cb_LoaiLenh.Location = new System.Drawing.Point(118, 22);
            this.cb_LoaiLenh.Name = "cb_LoaiLenh";
            this.cb_LoaiLenh.Size = new System.Drawing.Size(140, 21);
            this.cb_LoaiLenh.TabIndex = 8;
            // 
            // cb_Lenh
            // 
            this.cb_Lenh.AllowDrop = true;
            this.cb_Lenh.Enabled = false;
            this.cb_Lenh.FormattingEnabled = true;
            this.cb_Lenh.Location = new System.Drawing.Point(423, 64);
            this.cb_Lenh.Name = "cb_Lenh";
            this.cb_Lenh.Size = new System.Drawing.Size(140, 21);
            this.cb_Lenh.TabIndex = 9;
            // 
            // cb_MuaBan
            // 
            this.cb_MuaBan.FormattingEnabled = true;
            this.cb_MuaBan.Location = new System.Drawing.Point(423, 22);
            this.cb_MuaBan.Name = "cb_MuaBan";
            this.cb_MuaBan.Size = new System.Drawing.Size(140, 21);
            this.cb_MuaBan.TabIndex = 10;
            this.cb_MuaBan.SelectedIndexChanged += new System.EventHandler(this.cb_MuaBan_SelectedIndexChanged);
            // 
            // tb_MaCP
            // 
            this.tb_MaCP.Location = new System.Drawing.Point(118, 67);
            this.tb_MaCP.Name = "tb_MaCP";
            this.tb_MaCP.Size = new System.Drawing.Size(140, 21);
            this.tb_MaCP.TabIndex = 11;
            // 
            // se_Gia
            // 
            this.se_Gia.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.se_Gia.Location = new System.Drawing.Point(118, 154);
            this.se_Gia.Name = "se_Gia";
            this.se_Gia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.se_Gia.Size = new System.Drawing.Size(140, 20);
            this.se_Gia.TabIndex = 16;
            // 
            // se_KL
            // 
            this.se_KL.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.se_KL.Location = new System.Drawing.Point(118, 106);
            this.se_KL.Name = "se_KL";
            this.se_KL.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.se_KL.Size = new System.Drawing.Size(140, 20);
            this.se_KL.TabIndex = 17;
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 285);
            this.Controls.Add(this.se_KL);
            this.Controls.Add(this.se_Gia);
            this.Controls.Add(this.tb_MaCP);
            this.Controls.Add(this.cb_MuaBan);
            this.Controls.Add(this.cb_Lenh);
            this.Controls.Add(this.cb_LoaiLenh);
            this.Controls.Add(this.btn_LamLai);
            this.Controls.Add(this.btn_MuaBan);
            this.Controls.Add(this.lb_Lenh);
            this.Controls.Add(this.lb_MuaBan);
            this.Controls.Add(this.lb_Gia);
            this.Controls.Add(this.lb_KhoiLuong);
            this.Controls.Add(this.lb_MaCK);
            this.Controls.Add(this.lb_LoaiLenh);
            this.Name = "frm_Main";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.se_Gia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.se_KL.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_LoaiLenh;
        private System.Windows.Forms.Label lb_MaCK;
        private System.Windows.Forms.Label lb_KhoiLuong;
        private System.Windows.Forms.Label lb_Gia;
        private System.Windows.Forms.Label lb_MuaBan;
        private System.Windows.Forms.Label lb_Lenh;
        private System.Windows.Forms.Button btn_MuaBan;
        private System.Windows.Forms.Button btn_LamLai;
        private System.Windows.Forms.ComboBox cb_LoaiLenh;
        private System.Windows.Forms.ComboBox cb_Lenh;
        private System.Windows.Forms.ComboBox cb_MuaBan;
        private System.Windows.Forms.TextBox tb_MaCP;
        private DevExpress.XtraEditors.SpinEdit se_Gia;
        private DevExpress.XtraEditors.SpinEdit se_KL;
    }
}