using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
	public partial class frmQLSV : Form
	{
		public bool changed = false;
		public frmQLSV()
		{
			InitializeComponent();
		}

		public QuanLySinhVien qlsv = new QuanLySinhVien();
		public static QuanLySinhVien ql = new QuanLySinhVien();

		public SinhVien GetSVFromLV(ListViewItem lvitem)
		{
			SinhVien sv = new SinhVien();
			sv.Id = lvitem.SubItems[0].Text;
			sv.FullName = lvitem.SubItems[1].Text;
			if (lvitem.SubItems[2].Text.CompareTo("Nam") == 0)
				sv.Gender = true;
			else sv.Gender = false;
			sv.Birthday = DateTime.Parse(lvitem.SubItems[3].Text);
			sv.Class = lvitem.SubItems[4].Text;
			sv.Phone = lvitem.SubItems[5].Text;
			sv.Mail = lvitem.SubItems[6].Text;
			sv.Address = lvitem.SubItems[7].Text;
			sv.Image = lvitem.SubItems[8].Text;
			return sv;
		}

		public SinhVien GetSinhVien()
		{
			SinhVien sinhVien = new SinhVien();
			sinhVien.Id = mtxtId.Text;
			sinhVien.FullName = txtFullname.Text;
			sinhVien.Mail = txtMail.Text;
			sinhVien.Address = txtAddress.Text;
			sinhVien.Birthday = dtpbirthday.Value;
			sinhVien.Gender = true;
			if (rbNu.Checked == true)
				sinhVien.Gender = false;
			sinhVien.Class = cboClass.Text;
			sinhVien.Phone = mtbPhone.Text;
			sinhVien.Image = txtImage.Text;
			return sinhVien;
		}

		// Thêm sinh viên vào ListView
		private void AddStudent(SinhVien sv)
		{
			ListViewItem lvitem = new ListViewItem(sv.Id);
			lvitem.SubItems.Add(sv.FullName);
			string gender = "Nữ";
			if (sv.Gender)
				gender = "Nam";
			lvitem.SubItems.Add(gender);
			lvitem.SubItems.Add(sv.Birthday.ToShortDateString());
			lvitem.SubItems.Add(sv.Class);
			lvitem.SubItems.Add(sv.Phone);
			lvitem.SubItems.Add(sv.Mail);
			lvitem.SubItems.Add(sv.Address);
			lvitem.SubItems.Add(sv.Image);
			this.lvSinhVien.Items.Add(lvitem);
		}

		//Hiển thị thông tin sinh viên lên các ô thông tin
		public void ShowImformation(SinhVien sv)
		{
			this.mtxtId.Text = sv.Id;
			this.txtFullname.Text = sv.FullName;
			this.txtMail.Text = sv.Mail;
			this.txtAddress.Text = sv.Address;
			this.dtpbirthday.Value = sv.Birthday;
			if (sv.Gender)
				this.rbNam.Checked = true;
			else this.rbNu.Checked = true;
			this.cboClass.Text = sv.Class;
			this.mtbPhone.Text = sv.Phone;
			this.txtImage.Text = sv.Image;
			this.pbImage.ImageLocation = sv.Image;
		}

		// 
		public void LoadListView(List<SinhVien> lvSV)
		{
			this.lvSinhVien.Items.Clear();
			if (lvSV != null)
				foreach (SinhVien sv in qlsv.DS)
					AddStudent(sv);
		}

		// Hiển thị ds thông tin trong ListView
		private void Form1_Load(object sender, EventArgs e)
		{
			qlsv.ReadFile("DSSV.txt");
			LoadListView(ql.DS);
		}

		#region
		// Sự kiện chọn hình ảnh
		private void btnChHinh_Click(object sender, EventArgs e)
		{
			if (this.ofdlChHinh.ShowDialog() == DialogResult.OK)
			{
				pbImage.ImageLocation = ofdlChHinh.FileName;
				txtImage.Text = ofdlChHinh.FileName;
			}
		}

		// Mặc định
		private void btnDefault_Click(object sender, EventArgs e)
		{
			this.mtxtId.Text = "";
			this.txtFullname.Text = "";
			this.txtMail.Text = "";
			this.txtAddress.Text = "";
			this.dtpbirthday.Value = DateTime.Now;
			this.rbNam.Checked = true;
			this.cboClass.Text = "";
			//this.cboClass.Items[0].ToString();
			this.mtbPhone.Text = "";
			this.pbImage.ImageLocation = "";
		}

		// Lưu thông tin
		private void btnSave_Click(object sender, EventArgs e)
		{
			SinhVien sv = GetSinhVien();
			// Kiểm tra xem MSSV có khác rỗng hay ko
			// Nếu khác rỗng thì thêm vào ds
			if (sv.Id.CompareTo("") != 0)
			{
				qlsv.EditStd(sv.Id, sv);
				LoadListView(ql.DS);
			}
			// Còn nếu MSSV rỗng thì xuất ra thông báo cho người dùng biết ko đc bỏ trống MSSV
			else
				MessageBox.Show("Không được để trống MSSV!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
			changed = true;
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Xóa sinh viên
		private void tsmiDelete_Click(object sender, EventArgs e)
		{
			foreach (ListViewItem lvitem in lvSinhVien.SelectedItems)
			{
				qlsv.DeleteStd(GetSVFromLV(lvitem));
			}
			LoadListView(ql.DS);
			changed = true;
		}

		// Sự kiện lấy thông tin của ListView - hiển thị lên các ô thông tin
		private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
		{
			SinhVien sv = null;
			if (this.lvSinhVien.SelectedItems.Count > 0)
			{
				sv = GetSVFromLV(this.lvSinhVien.SelectedItems[0]);
				ShowImformation(sv);
			}
		}

		// Tải lại danh sách sinh viên
		private void tsmiReLoad_Click(object sender, EventArgs e)
		{
			qlsv.ReadFile("DSSV.txt");
			LoadListView(ql.DS);
		}

		private void frmQLSV_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (changed == true)
			{
				DialogResult mBox = MessageBox.Show("Lưu thay đổi không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
				if (mBox == DialogResult.Yes)
					qlsv.SaveFile();
				else
					e.Cancel = true;
			}
		}
		#endregion
	}
}
