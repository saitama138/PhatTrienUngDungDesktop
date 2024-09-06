namespace Lab04
{
	partial class frmQLSV
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
			this.components = new System.ComponentModel.Container();
			this.gbthongtinsv = new System.Windows.Forms.GroupBox();
			this.cboClass = new System.Windows.Forms.ComboBox();
			this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
			this.mtxtId = new System.Windows.Forms.MaskedTextBox();
			this.btnDefault = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnChHinh = new System.Windows.Forms.Button();
			this.dtpbirthday = new System.Windows.Forms.DateTimePicker();
			this.rbNu = new System.Windows.Forms.RadioButton();
			this.rbNam = new System.Windows.Forms.RadioButton();
			this.txtMail = new System.Windows.Forms.TextBox();
			this.txtImage = new System.Windows.Forms.TextBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtFullname = new System.Windows.Forms.TextBox();
			this.lbsdt = new System.Windows.Forms.Label();
			this.lblop = new System.Windows.Forms.Label();
			this.lbphai = new System.Windows.Forms.Label();
			this.lbngsinh = new System.Windows.Forms.Label();
			this.lbhinh = new System.Windows.Forms.Label();
			this.lbdiachi = new System.Windows.Forms.Label();
			this.lbemail = new System.Windows.Forms.Label();
			this.lbhoten = new System.Windows.Forms.Label();
			this.lbmaso = new System.Windows.Forms.Label();
			this.pbImage = new System.Windows.Forms.PictureBox();
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
			this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiReLoad = new System.Windows.Forms.ToolStripMenuItem();
			this.ofdlChHinh = new System.Windows.Forms.OpenFileDialog();
			this.gbthongtinsv.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
			this.gbDSSV.SuspendLayout();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbthongtinsv
			// 
			this.gbthongtinsv.Controls.Add(this.cboClass);
			this.gbthongtinsv.Controls.Add(this.mtbPhone);
			this.gbthongtinsv.Controls.Add(this.mtxtId);
			this.gbthongtinsv.Controls.Add(this.btnDefault);
			this.gbthongtinsv.Controls.Add(this.btnSave);
			this.gbthongtinsv.Controls.Add(this.btnExit);
			this.gbthongtinsv.Controls.Add(this.btnChHinh);
			this.gbthongtinsv.Controls.Add(this.dtpbirthday);
			this.gbthongtinsv.Controls.Add(this.rbNu);
			this.gbthongtinsv.Controls.Add(this.rbNam);
			this.gbthongtinsv.Controls.Add(this.txtMail);
			this.gbthongtinsv.Controls.Add(this.txtImage);
			this.gbthongtinsv.Controls.Add(this.txtAddress);
			this.gbthongtinsv.Controls.Add(this.txtFullname);
			this.gbthongtinsv.Controls.Add(this.lbsdt);
			this.gbthongtinsv.Controls.Add(this.lblop);
			this.gbthongtinsv.Controls.Add(this.lbphai);
			this.gbthongtinsv.Controls.Add(this.lbngsinh);
			this.gbthongtinsv.Controls.Add(this.lbhinh);
			this.gbthongtinsv.Controls.Add(this.lbdiachi);
			this.gbthongtinsv.Controls.Add(this.lbemail);
			this.gbthongtinsv.Controls.Add(this.lbhoten);
			this.gbthongtinsv.Controls.Add(this.lbmaso);
			this.gbthongtinsv.Location = new System.Drawing.Point(177, 0);
			this.gbthongtinsv.Name = "gbthongtinsv";
			this.gbthongtinsv.Size = new System.Drawing.Size(611, 215);
			this.gbthongtinsv.TabIndex = 1;
			this.gbthongtinsv.TabStop = false;
			this.gbthongtinsv.Text = "Thông tin sinh viên";
			// 
			// cboClass
			// 
			this.cboClass.FormattingEnabled = true;
			this.cboClass.Items.AddRange(new object[] {
            "CTK43",
            "CTK44",
            "CTK45",
            "CTK46"});
			this.cboClass.Location = new System.Drawing.Point(459, 81);
			this.cboClass.Name = "cboClass";
			this.cboClass.Size = new System.Drawing.Size(142, 21);
			this.cboClass.TabIndex = 7;
			// 
			// mtbPhone
			// 
			this.mtbPhone.Location = new System.Drawing.Point(459, 112);
			this.mtbPhone.Mask = "0000.000.000";
			this.mtbPhone.Name = "mtbPhone";
			this.mtbPhone.Size = new System.Drawing.Size(142, 20);
			this.mtbPhone.TabIndex = 8;
			// 
			// mtxtId
			// 
			this.mtxtId.Location = new System.Drawing.Point(92, 21);
			this.mtxtId.Mask = "0000000";
			this.mtxtId.Name = "mtxtId";
			this.mtxtId.Size = new System.Drawing.Size(241, 20);
			this.mtxtId.TabIndex = 0;
			// 
			// btnDefault
			// 
			this.btnDefault.Location = new System.Drawing.Point(326, 176);
			this.btnDefault.Name = "btnDefault";
			this.btnDefault.Size = new System.Drawing.Size(75, 23);
			this.btnDefault.TabIndex = 10;
			this.btnDefault.Text = "Mặc định";
			this.btnDefault.UseVisualStyleBackColor = true;
			this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(426, 176);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 11;
			this.btnSave.Text = "Lưu";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(526, 176);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 12;
			this.btnExit.Text = "Thoát";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnChHinh
			// 
			this.btnChHinh.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.btnChHinh.Location = new System.Drawing.Point(526, 141);
			this.btnChHinh.Name = "btnChHinh";
			this.btnChHinh.Size = new System.Drawing.Size(75, 23);
			this.btnChHinh.TabIndex = 9;
			this.btnChHinh.Text = "Chọn hình";
			this.btnChHinh.UseVisualStyleBackColor = true;
			this.btnChHinh.Click += new System.EventHandler(this.btnChHinh_Click);
			// 
			// dtpbirthday
			// 
			this.dtpbirthday.CustomFormat = "dd/MM/yyyy";
			this.dtpbirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpbirthday.Location = new System.Drawing.Point(459, 21);
			this.dtpbirthday.Name = "dtpbirthday";
			this.dtpbirthday.Size = new System.Drawing.Size(142, 20);
			this.dtpbirthday.TabIndex = 4;
			// 
			// rbNu
			// 
			this.rbNu.AutoSize = true;
			this.rbNu.Location = new System.Drawing.Point(544, 53);
			this.rbNu.Name = "rbNu";
			this.rbNu.Size = new System.Drawing.Size(39, 17);
			this.rbNu.TabIndex = 6;
			this.rbNu.Text = "Nữ";
			this.rbNu.UseVisualStyleBackColor = true;
			// 
			// rbNam
			// 
			this.rbNam.AutoSize = true;
			this.rbNam.Checked = true;
			this.rbNam.Location = new System.Drawing.Point(459, 53);
			this.rbNam.Name = "rbNam";
			this.rbNam.Size = new System.Drawing.Size(47, 17);
			this.rbNam.TabIndex = 5;
			this.rbNam.TabStop = true;
			this.rbNam.Text = "Nam";
			this.rbNam.UseVisualStyleBackColor = true;
			// 
			// txtMail
			// 
			this.txtMail.Location = new System.Drawing.Point(92, 81);
			this.txtMail.Name = "txtMail";
			this.txtMail.Size = new System.Drawing.Size(241, 20);
			this.txtMail.TabIndex = 2;
			// 
			// txtImage
			// 
			this.txtImage.Location = new System.Drawing.Point(92, 142);
			this.txtImage.Name = "txtImage";
			this.txtImage.ReadOnly = true;
			this.txtImage.Size = new System.Drawing.Size(421, 20);
			this.txtImage.TabIndex = 13;
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(92, 112);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(241, 20);
			this.txtAddress.TabIndex = 3;
			// 
			// txtFullname
			// 
			this.txtFullname.Location = new System.Drawing.Point(92, 51);
			this.txtFullname.Name = "txtFullname";
			this.txtFullname.Size = new System.Drawing.Size(241, 20);
			this.txtFullname.TabIndex = 1;
			// 
			// lbsdt
			// 
			this.lbsdt.AutoSize = true;
			this.lbsdt.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbsdt.Location = new System.Drawing.Point(351, 115);
			this.lbsdt.Name = "lbsdt";
			this.lbsdt.Size = new System.Drawing.Size(98, 15);
			this.lbsdt.TabIndex = 0;
			this.lbsdt.Text = "Số điện thoại";
			// 
			// lblop
			// 
			this.lblop.AutoSize = true;
			this.lblop.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblop.Location = new System.Drawing.Point(351, 84);
			this.lblop.Name = "lblop";
			this.lblop.Size = new System.Drawing.Size(28, 15);
			this.lblop.TabIndex = 0;
			this.lblop.Text = "Lớp";
			// 
			// lbphai
			// 
			this.lbphai.AutoSize = true;
			this.lbphai.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbphai.Location = new System.Drawing.Point(351, 54);
			this.lbphai.Name = "lbphai";
			this.lbphai.Size = new System.Drawing.Size(35, 15);
			this.lbphai.TabIndex = 0;
			this.lbphai.Text = "Phái";
			// 
			// lbngsinh
			// 
			this.lbngsinh.AutoSize = true;
			this.lbngsinh.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbngsinh.Location = new System.Drawing.Point(351, 24);
			this.lbngsinh.Name = "lbngsinh";
			this.lbngsinh.Size = new System.Drawing.Size(70, 15);
			this.lbngsinh.TabIndex = 0;
			this.lbngsinh.Text = "Ngày sinh";
			// 
			// lbhinh
			// 
			this.lbhinh.AutoSize = true;
			this.lbhinh.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbhinh.Location = new System.Drawing.Point(16, 145);
			this.lbhinh.Name = "lbhinh";
			this.lbhinh.Size = new System.Drawing.Size(35, 15);
			this.lbhinh.TabIndex = 0;
			this.lbhinh.Text = "Hình";
			// 
			// lbdiachi
			// 
			this.lbdiachi.AutoSize = true;
			this.lbdiachi.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbdiachi.Location = new System.Drawing.Point(16, 115);
			this.lbdiachi.Name = "lbdiachi";
			this.lbdiachi.Size = new System.Drawing.Size(56, 15);
			this.lbdiachi.TabIndex = 0;
			this.lbdiachi.Text = "Địa chỉ";
			// 
			// lbemail
			// 
			this.lbemail.AutoSize = true;
			this.lbemail.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbemail.Location = new System.Drawing.Point(16, 84);
			this.lbemail.Name = "lbemail";
			this.lbemail.Size = new System.Drawing.Size(42, 15);
			this.lbemail.TabIndex = 0;
			this.lbemail.Text = "Email";
			// 
			// lbhoten
			// 
			this.lbhoten.AutoSize = true;
			this.lbhoten.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbhoten.Location = new System.Drawing.Point(16, 54);
			this.lbhoten.Name = "lbhoten";
			this.lbhoten.Size = new System.Drawing.Size(70, 15);
			this.lbhoten.TabIndex = 0;
			this.lbhoten.Text = "Họ và tên";
			// 
			// lbmaso
			// 
			this.lbmaso.AutoSize = true;
			this.lbmaso.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbmaso.Location = new System.Drawing.Point(16, 24);
			this.lbmaso.Name = "lbmaso";
			this.lbmaso.Size = new System.Drawing.Size(35, 15);
			this.lbmaso.TabIndex = 0;
			this.lbmaso.Text = "MSSV";
			// 
			// pbImage
			// 
			this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pbImage.Location = new System.Drawing.Point(12, 6);
			this.pbImage.Name = "pbImage";
			this.pbImage.Size = new System.Drawing.Size(159, 209);
			this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbImage.TabIndex = 1;
			this.pbImage.TabStop = false;
			// 
			// gbDSSV
			// 
			this.gbDSSV.Controls.Add(this.lvSinhVien);
			this.gbDSSV.Location = new System.Drawing.Point(12, 221);
			this.gbDSSV.Name = "gbDSSV";
			this.gbDSSV.Size = new System.Drawing.Size(776, 207);
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
            this.columnHeader8,
            this.columnHeader9});
			this.lvSinhVien.ContextMenuStrip = this.contextMenuStrip1;
			this.lvSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvSinhVien.FullRowSelect = true;
			this.lvSinhVien.GridLines = true;
			this.lvSinhVien.HideSelection = false;
			this.lvSinhVien.Location = new System.Drawing.Point(3, 16);
			this.lvSinhVien.Name = "lvSinhVien";
			this.lvSinhVien.Size = new System.Drawing.Size(770, 188);
			this.lvSinhVien.TabIndex = 0;
			this.lvSinhVien.UseCompatibleStateImageBehavior = false;
			this.lvSinhVien.View = System.Windows.Forms.View.Details;
			this.lvSinhVien.SelectedIndexChanged += new System.EventHandler(this.lvSinhVien_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "MSSV";
			this.columnHeader1.Width = 90;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Họ và tên";
			this.columnHeader2.Width = 120;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Phái";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Ngày sinh";
			this.columnHeader4.Width = 100;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Lớp";
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Số điện thoại";
			this.columnHeader6.Width = 100;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Email";
			this.columnHeader7.Width = 140;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Địa chỉ";
			this.columnHeader8.Width = 160;
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "Hình";
			this.columnHeader9.Width = 200;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDelete,
            this.tsmiReLoad});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(162, 48);
			// 
			// tsmiDelete
			// 
			this.tsmiDelete.Name = "tsmiDelete";
			this.tsmiDelete.Size = new System.Drawing.Size(180, 22);
			this.tsmiDelete.Text = "Xóa";
			this.tsmiDelete.TextAlign = System.Drawing.ContentAlignment.TopLeft;
			this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
			// 
			// tsmiReLoad
			// 
			this.tsmiReLoad.Name = "tsmiReLoad";
			this.tsmiReLoad.Size = new System.Drawing.Size(180, 22);
			this.tsmiReLoad.Text = "Tải lại danh sách";
			this.tsmiReLoad.Click += new System.EventHandler(this.tsmiReLoad_Click);
			// 
			// ofdlChHinh
			// 
			this.ofdlChHinh.FileName = "openFileDialog1";
			// 
			// frmQLSV
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pbImage);
			this.Controls.Add(this.gbDSSV);
			this.Controls.Add(this.gbthongtinsv);
			this.Name = "frmQLSV";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản lý thông tin sinh viên khoa CNTT ";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQLSV_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.gbthongtinsv.ResumeLayout(false);
			this.gbthongtinsv.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
			this.gbDSSV.ResumeLayout(false);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox gbthongtinsv;
		private System.Windows.Forms.PictureBox pbImage;
		private System.Windows.Forms.GroupBox gbDSSV;
		private System.Windows.Forms.Label lbsdt;
		private System.Windows.Forms.Label lblop;
		private System.Windows.Forms.Label lbphai;
		private System.Windows.Forms.Label lbngsinh;
		private System.Windows.Forms.Label lbhinh;
		private System.Windows.Forms.Label lbdiachi;
		private System.Windows.Forms.Label lbemail;
		private System.Windows.Forms.Label lbhoten;
		private System.Windows.Forms.Label lbmaso;
		private System.Windows.Forms.TextBox txtMail;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.TextBox txtFullname;
		private System.Windows.Forms.ComboBox cboClass;
		private System.Windows.Forms.MaskedTextBox mtbPhone;
		private System.Windows.Forms.MaskedTextBox mtxtId;
		private System.Windows.Forms.Button btnDefault;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnChHinh;
		private System.Windows.Forms.DateTimePicker dtpbirthday;
		private System.Windows.Forms.RadioButton rbNu;
		private System.Windows.Forms.RadioButton rbNam;
		private System.Windows.Forms.TextBox txtImage;
		private System.Windows.Forms.ListView lvSinhVien;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
		private System.Windows.Forms.OpenFileDialog ofdlChHinh;
		private System.Windows.Forms.ToolStripMenuItem tsmiReLoad;
	}
}

