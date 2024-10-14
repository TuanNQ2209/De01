namespace De01
{
    partial class Form1
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
            this.dgvSinhvien = new System.Windows.Forms.DataGridView();
            this.dgvMaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNgaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.dtNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.btThoat = new System.Windows.Forms.Button();
            this.btKhong = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btTim = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.txtHotenSV = new System.Windows.Forms.TextBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhvien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSinhvien
            // 
            this.dgvSinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaSV,
            this.dgvHoten,
            this.dgvNgaysinh,
            this.dgvLop});
            this.dgvSinhvien.Location = new System.Drawing.Point(62, 279);
            this.dgvSinhvien.Name = "dgvSinhvien";
            this.dgvSinhvien.RowHeadersWidth = 51;
            this.dgvSinhvien.RowTemplate.Height = 24;
            this.dgvSinhvien.Size = new System.Drawing.Size(758, 204);
            this.dgvSinhvien.TabIndex = 38;
            this.dgvSinhvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhvien_CellClick);
            // 
            // dgvMaSV
            // 
            this.dgvMaSV.HeaderText = "Mã SV";
            this.dgvMaSV.MinimumWidth = 6;
            this.dgvMaSV.Name = "dgvMaSV";
            this.dgvMaSV.Width = 125;
            // 
            // dgvHoten
            // 
            this.dgvHoten.HeaderText = "Họ và tên";
            this.dgvHoten.MinimumWidth = 6;
            this.dgvHoten.Name = "dgvHoten";
            this.dgvHoten.Width = 125;
            // 
            // dgvNgaysinh
            // 
            this.dgvNgaysinh.HeaderText = "Ngày sinh";
            this.dgvNgaysinh.MinimumWidth = 6;
            this.dgvNgaysinh.Name = "dgvNgaysinh";
            this.dgvNgaysinh.Width = 125;
            // 
            // dgvLop
            // 
            this.dgvLop.HeaderText = "Lớp";
            this.dgvLop.MinimumWidth = 6;
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.Width = 125;
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(580, 107);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(203, 24);
            this.cboLop.TabIndex = 37;
            // 
            // dtNgaysinh
            // 
            this.dtNgaysinh.Location = new System.Drawing.Point(154, 97);
            this.dtNgaysinh.Name = "dtNgaysinh";
            this.dtNgaysinh.Size = new System.Drawing.Size(200, 22);
            this.dtNgaysinh.TabIndex = 36;
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(745, 211);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 23);
            this.btThoat.TabIndex = 35;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click_1);
            // 
            // btKhong
            // 
            this.btKhong.Location = new System.Drawing.Point(640, 211);
            this.btKhong.Name = "btKhong";
            this.btKhong.Size = new System.Drawing.Size(75, 23);
            this.btKhong.TabIndex = 34;
            this.btKhong.Text = "KLưu";
            this.btKhong.UseVisualStyleBackColor = true;
            this.btKhong.Click += new System.EventHandler(this.btKhong_Click);
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(528, 212);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(75, 23);
            this.btLuu.TabIndex = 33;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(424, 211);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 23);
            this.btSua.TabIndex = 32;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(321, 211);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 31;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(220, 212);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 30;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btTim
            // 
            this.btTim.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btTim.Location = new System.Drawing.Point(106, 203);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(81, 41);
            this.btTim.TabIndex = 29;
            this.btTim.Text = "Tìm ";
            this.btTim.UseVisualStyleBackColor = false;
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(-19, 212);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(119, 22);
            this.txtTim.TabIndex = 28;
            // 
            // txtHotenSV
            // 
            this.txtHotenSV.Location = new System.Drawing.Point(580, 55);
            this.txtHotenSV.Name = "txtHotenSV";
            this.txtHotenSV.Size = new System.Drawing.Size(240, 22);
            this.txtHotenSV.TabIndex = 27;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(154, 55);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(200, 22);
            this.txtMaSV.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(502, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Lớp học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Ngày sinh";
            // 
            // txtHoten
            // 
            this.txtHoten.AutoSize = true;
            this.txtHoten.Location = new System.Drawing.Point(502, 58);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(46, 16);
            this.txtHoten.TabIndex = 23;
            this.txtHoten.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Mã sinh viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 33);
            this.label1.TabIndex = 21;
            this.label1.Text = "Thông tin chi tiết";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 508);
            this.Controls.Add(this.dgvSinhvien);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.dtNgaysinh);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btKhong);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.txtHotenSV);
            this.Controls.Add(this.txtMaSV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSinhvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNgaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLop;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.DateTimePicker dtNgaysinh;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btKhong;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.TextBox txtHotenSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtHoten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

