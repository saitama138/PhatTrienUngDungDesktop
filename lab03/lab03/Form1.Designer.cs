namespace Lab3_Demo
{
	partial class frmSinhVien
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.gbTTSV = new System.Windows.Forms.GroupBox();
			this.btnThoat = new System.Windows.Forms.Button();
			this.btnMDinh = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.clbChNganh = new System.Windows.Forms.CheckedListBox();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.txtHinh = new System.Windows.Forms.TextBox();
			this.rdNam = new System.Windows.Forms.RadioButton();
			this.rbNu = new System.Windows.Forms.RadioButton();
			this.lbChNganh = new System.Windows.Forms.Label();
			this.lbGTinh = new System.Windows.Forms.Label();
			this.lbHinh = new System.Windows.Forms.Label();
			this.dtpNgSinh = new System.Windows.Forms.DateTimePicker();
			this.cboLop = new System.Windows.Forms.ComboBox();
			this.txtDChi = new System.Windows.Forms.TextBox();
			this.txtHoTen = new System.Windows.Forms.TextBox();
			this.lbLop = new System.Windows.Forms.Label();
			this.lbDChi = new System.Windows.Forms.Label();
			this.lbNgSinh = new System.Windows.Forms.Label();
			this.lbHoTen = new System.Windows.Forms.Label();
			this.lbMaso = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pbHinh = new System.Windows.Forms.PictureBox();
			this.mtxtMaSo = new System.Windows.Forms.MaskedTextBox();
			this.gbDSSV = new System.Windows.Forms.GroupBox();
			this.lvSinhVien = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.gbTTSV.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbHinh)).BeginInit();
			this.gbDSSV.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.gbTTSV);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.gbDSSV);
			this.splitContainer1.Size = new System.Drawing.Size(850, 450);
			this.splitContainer1.SplitterDistance = 369;
			this.splitContainer1.TabIndex = 0;
			// 
			// gbTTSV
			// 
			this.gbTTSV.Controls.Add(this.btnThoat);
			this.gbTTSV.Controls.Add(this.btnMDinh);
			this.gbTTSV.Controls.Add(this.btnSua);
			this.gbTTSV.Controls.Add(this.btnXoa);
			this.gbTTSV.Controls.Add(this.btnThem);
			this.gbTTSV.Controls.Add(this.clbChNganh);
			this.gbTTSV.Controls.Add(this.btnBrowse);
			this.gbTTSV.Controls.Add(this.txtHinh);
			this.gbTTSV.Controls.Add(this.rdNam);
			this.gbTTSV.Controls.Add(this.rbNu);
			this.gbTTSV.Controls.Add(this.lbChNganh);
			this.gbTTSV.Controls.Add(this.lbGTinh);
			this.gbTTSV.Controls.Add(this.lbHinh);
			this.gbTTSV.Controls.Add(this.dtpNgSinh);
			this.gbTTSV.Controls.Add(this.cboLop);
			this.gbTTSV.Controls.Add(this.txtDChi);
			this.gbTTSV.Controls.Add(this.txtHoTen);
			this.gbTTSV.Controls.Add(this.lbLop);
			this.gbTTSV.Controls.Add(this.lbDChi);
			this.gbTTSV.Controls.Add(this.lbNgSinh);
			this.gbTTSV.Controls.Add(this.lbHoTen);
			this.gbTTSV.Controls.Add(this.lbMaso);
			this.gbTTSV.Controls.Add(this.label1);
			this.gbTTSV.Controls.Add(this.pbHinh);
			this.gbTTSV.Controls.Add(this.mtxtMaSo);
			this.gbTTSV.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbTTSV.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbTTSV.Location = new System.Drawing.Point(0, 0);
			this.gbTTSV.Name = "gbTTSV";
			this.gbTTSV.Size = new System.Drawing.Size(369, 450);
			this.gbTTSV.TabIndex = 0;
			this.gbTTSV.TabStop = false;
			this.gbTTSV.Text = "Thông tin sinh viên";
			// 
			// btnThoat
			// 
			this.btnThoat.Location = new System.Drawing.Point(300, 415);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(57, 23);
			this.btnThoat.TabIndex = 14;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = true;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// btnMDinh
			// 
			this.btnMDinh.Location = new System.Drawing.Point(214, 415);
			this.btnMDinh.Name = "btnMDinh";
			this.btnMDinh.Size = new System.Drawing.Size(71, 23);
			this.btnMDinh.TabIndex = 14;
			this.btnMDinh.Text = "Mặc định";
			this.btnMDinh.UseVisualStyleBackColor = true;
			this.btnMDinh.Click += new System.EventHandler(this.btnMDinh_Click);
			// 
			// btnSua
			// 
			this.btnSua.Location = new System.Drawing.Point(151, 415);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(45, 23);
			this.btnSua.TabIndex = 14;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Location = new System.Drawing.Point(89, 415);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(47, 23);
			this.btnXoa.TabIndex = 14;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// btnThem
			// 
			this.btnThem.Location = new System.Drawing.Point(15, 415);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(57, 23);
			this.btnThem.TabIndex = 14;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// clbChNganh
			// 
			this.clbChNganh.CheckOnClick = true;
			this.clbChNganh.FormattingEnabled = true;
			this.clbChNganh.Items.AddRange(new object[] {
            "Mạng truyền thông",
            "Công nghệ phần mềm",
            "Khoa học máy tính",
            "Trí tuệ nhân tạo",
            "Hệ thống thông tin",
            "Tin học ứng dụng"});
			this.clbChNganh.Location = new System.Drawing.Point(108, 279);
			this.clbChNganh.Name = "clbChNganh";
			this.clbChNganh.Size = new System.Drawing.Size(165, 112);
			this.clbChNganh.TabIndex = 13;
			// 
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(329, 197);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(30, 23);
			this.btnBrowse.TabIndex = 12;
			this.btnBrowse.Text = "...";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// txtHinh
			// 
			this.txtHinh.Location = new System.Drawing.Point(108, 197);
			this.txtHinh.Name = "txtHinh";
			this.txtHinh.ReadOnly = true;
			this.txtHinh.Size = new System.Drawing.Size(206, 23);
			this.txtHinh.TabIndex = 11;
			// 
			// rdNam
			// 
			this.rdNam.AutoSize = true;
			this.rdNam.Checked = true;
			this.rdNam.Location = new System.Drawing.Point(108, 237);
			this.rdNam.Name = "rdNam";
			this.rdNam.Size = new System.Drawing.Size(52, 19);
			this.rdNam.TabIndex = 10;
			this.rdNam.TabStop = true;
			this.rdNam.Text = "Nam";
			this.rdNam.UseVisualStyleBackColor = true;
			// 
			// rbNu
			// 
			this.rbNu.AutoSize = true;
			this.rbNu.Location = new System.Drawing.Point(198, 237);
			this.rbNu.Name = "rbNu";
			this.rbNu.Size = new System.Drawing.Size(44, 19);
			this.rbNu.TabIndex = 10;
			this.rbNu.Text = "Nữ";
			this.rbNu.UseVisualStyleBackColor = true;
			// 
			// lbChNganh
			// 
			this.lbChNganh.AutoSize = true;
			this.lbChNganh.Location = new System.Drawing.Point(12, 279);
			this.lbChNganh.Name = "lbChNganh";
			this.lbChNganh.Size = new System.Drawing.Size(90, 15);
			this.lbChNganh.TabIndex = 9;
			this.lbChNganh.Text = "Chuyên ngành";
			// 
			// lbGTinh
			// 
			this.lbGTinh.AutoSize = true;
			this.lbGTinh.Location = new System.Drawing.Point(12, 239);
			this.lbGTinh.Name = "lbGTinh";
			this.lbGTinh.Size = new System.Drawing.Size(60, 15);
			this.lbGTinh.TabIndex = 9;
			this.lbGTinh.Text = "Giới tính";
			// 
			// lbHinh
			// 
			this.lbHinh.AutoSize = true;
			this.lbHinh.Location = new System.Drawing.Point(12, 200);
			this.lbHinh.Name = "lbHinh";
			this.lbHinh.Size = new System.Drawing.Size(37, 15);
			this.lbHinh.TabIndex = 8;
			this.lbHinh.Text = "Hình";
			// 
			// dtpNgSinh
			// 
			this.dtpNgSinh.CustomFormat = "dd/MM/yy";
			this.dtpNgSinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpNgSinh.Location = new System.Drawing.Point(214, 85);
			this.dtpNgSinh.Name = "dtpNgSinh";
			this.dtpNgSinh.Size = new System.Drawing.Size(100, 23);
			this.dtpNgSinh.TabIndex = 7;
			// 
			// cboLop
			// 
			this.cboLop.FormattingEnabled = true;
			this.cboLop.Items.AddRange(new object[] {
            "CTK31",
            "CTK32",
            "CTK33",
            "CTK34",
            "CTK32CD",
            "CTK33CD",
            "CTK34CD"});
			this.cboLop.Location = new System.Drawing.Point(214, 159);
			this.cboLop.Name = "cboLop";
			this.cboLop.Size = new System.Drawing.Size(121, 23);
			this.cboLop.TabIndex = 6;
			// 
			// txtDChi
			// 
			this.txtDChi.Location = new System.Drawing.Point(214, 121);
			this.txtDChi.Name = "txtDChi";
			this.txtDChi.Size = new System.Drawing.Size(150, 23);
			this.txtDChi.TabIndex = 5;
			// 
			// txtHoTen
			// 
			this.txtHoTen.Location = new System.Drawing.Point(214, 53);
			this.txtHoTen.Name = "txtHoTen";
			this.txtHoTen.Size = new System.Drawing.Size(128, 23);
			this.txtHoTen.TabIndex = 5;
			// 
			// lbLop
			// 
			this.lbLop.AutoSize = true;
			this.lbLop.Location = new System.Drawing.Point(145, 159);
			this.lbLop.Name = "lbLop";
			this.lbLop.Size = new System.Drawing.Size(29, 15);
			this.lbLop.TabIndex = 4;
			this.lbLop.Text = "Lớp";
			// 
			// lbDChi
			// 
			this.lbDChi.AutoSize = true;
			this.lbDChi.Location = new System.Drawing.Point(145, 125);
			this.lbDChi.Name = "lbDChi";
			this.lbDChi.Size = new System.Drawing.Size(48, 15);
			this.lbDChi.TabIndex = 4;
			this.lbDChi.Text = "Địa chỉ";
			// 
			// lbNgSinh
			// 
			this.lbNgSinh.AutoSize = true;
			this.lbNgSinh.Location = new System.Drawing.Point(145, 91);
			this.lbNgSinh.Name = "lbNgSinh";
			this.lbNgSinh.Size = new System.Drawing.Size(64, 15);
			this.lbNgSinh.TabIndex = 4;
			this.lbNgSinh.Text = "Ngày sinh";
			// 
			// lbHoTen
			// 
			this.lbHoTen.AutoSize = true;
			this.lbHoTen.Location = new System.Drawing.Point(145, 56);
			this.lbHoTen.Name = "lbHoTen";
			this.lbHoTen.Size = new System.Drawing.Size(46, 15);
			this.lbHoTen.TabIndex = 4;
			this.lbHoTen.Text = "Họ tên";
			// 
			// lbMaso
			// 
			this.lbMaso.AutoSize = true;
			this.lbMaso.Location = new System.Drawing.Point(145, 25);
			this.lbMaso.Name = "lbMaso";
			this.lbMaso.Size = new System.Drawing.Size(40, 15);
			this.lbMaso.TabIndex = 3;
			this.lbMaso.Text = "Mã số";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(151, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 15);
			this.label1.TabIndex = 2;
			// 
			// pbHinh
			// 
			this.pbHinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pbHinh.Location = new System.Drawing.Point(12, 22);
			this.pbHinh.Name = "pbHinh";
			this.pbHinh.Size = new System.Drawing.Size(124, 152);
			this.pbHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbHinh.TabIndex = 1;
			this.pbHinh.TabStop = false;
			// 
			// mtxtMaSo
			// 
			this.mtxtMaSo.Location = new System.Drawing.Point(214, 21);
			this.mtxtMaSo.Mask = "SV.00000";
			this.mtxtMaSo.Name = "mtxtMaSo";
			this.mtxtMaSo.Size = new System.Drawing.Size(100, 23);
			this.mtxtMaSo.TabIndex = 0;
			// 
			// gbDSSV
			// 
			this.gbDSSV.Controls.Add(this.lvSinhVien);
			this.gbDSSV.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gbDSSV.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbDSSV.Location = new System.Drawing.Point(0, 0);
			this.gbDSSV.Name = "gbDSSV";
			this.gbDSSV.Size = new System.Drawing.Size(477, 450);
			this.gbDSSV.TabIndex = 0;
			this.gbDSSV.TabStop = false;
			this.gbDSSV.Text = "Danh sách sinh viên";
			// 
			// lvSinhVien
			// 
			this.lvSinhVien.CheckBoxes = true;
			this.lvSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
			this.lvSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvSinhVien.FullRowSelect = true;
			this.lvSinhVien.GridLines = true;
			this.lvSinhVien.HideSelection = false;
			this.lvSinhVien.Location = new System.Drawing.Point(3, 19);
			this.lvSinhVien.Name = "lvSinhVien";
			this.lvSinhVien.Size = new System.Drawing.Size(471, 428);
			this.lvSinhVien.TabIndex = 0;
			this.lvSinhVien.UseCompatibleStateImageBehavior = false;
			this.lvSinhVien.View = System.Windows.Forms.View.Details;
			this.lvSinhVien.SelectedIndexChanged += new System.EventHandler(this.lvSinhVien_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "MSSV";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Họ tên";
			this.columnHeader2.Width = 150;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Ngày sinh";
			this.columnHeader3.Width = 100;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Địa chỉ";
			this.columnHeader4.Width = 200;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Lớp";
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Phái";
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Chuyên ngành";
			this.columnHeader7.Width = 500;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Hình";
			this.columnHeader8.Width = 200;
			// 
			// OpenFileDialog1
			// 
			this.OpenFileDialog1.FileName = "openFileDialog1";
			this.OpenFileDialog1.Filter = "File GIF|*.Gif|File JPEG|*.jpg";
			// 
			// frmSinhVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(850, 450);
			this.Controls.Add(this.splitContainer1);
			this.Name = "frmSinhVien";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Demo Sinh Viên";
			this.Load += new System.EventHandler(this.frmSinhVien_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.gbTTSV.ResumeLayout(false);
			this.gbTTSV.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbHinh)).EndInit();
			this.gbDSSV.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.GroupBox gbTTSV;
		private System.Windows.Forms.GroupBox gbDSSV;
		private System.Windows.Forms.OpenFileDialog OpenFileDialog1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pbHinh;
		private System.Windows.Forms.MaskedTextBox mtxtMaSo;
		private System.Windows.Forms.Label lbLop;
		private System.Windows.Forms.Label lbDChi;
		private System.Windows.Forms.Label lbNgSinh;
		private System.Windows.Forms.Label lbHoTen;
		private System.Windows.Forms.Label lbMaso;
		private System.Windows.Forms.Label lbChNganh;
		private System.Windows.Forms.Label lbGTinh;
		private System.Windows.Forms.Label lbHinh;
		private System.Windows.Forms.DateTimePicker dtpNgSinh;
		private System.Windows.Forms.ComboBox cboLop;
		private System.Windows.Forms.TextBox txtDChi;
		private System.Windows.Forms.TextBox txtHoTen;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.TextBox txtHinh;
		private System.Windows.Forms.RadioButton rdNam;
		private System.Windows.Forms.RadioButton rbNu;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.Button btnMDinh;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.CheckedListBox clbChNganh;
		private System.Windows.Forms.ListView lvSinhVien;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
	}
}

