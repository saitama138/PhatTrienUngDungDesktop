using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Demo
{
	public partial class frmSinhVien : Form
	{
		QuanLySinhVien qlsv = new QuanLySinhVien();
		public frmSinhVien()
		{
			InitializeComponent();
		}

		#region Phương thức bổ trợ
		// Lấy thông tin từ controls thông tin SV
		private SinhVien GetSinhVien()
		{
			SinhVien sv = new SinhVien();
			bool gt = true;
			List<string> cn = new List<string>();
			sv.MaSo = this.mtxtMaSo.Text;
			sv.HoTen = this.txtHoTen.Text;
			sv.NgSinh = this.dtpNgSinh.Value;
			sv.DiaChi = this.txtDChi.Text;
			sv.Lop = this.cboLop.Text;
			sv.Hinh = this.txtHinh.Text;
			if(rdNam.Checked)
				gt = false;
			sv.GTinh = gt;
			for(int i = 0; i < this.clbChNganh.Items.Count; i++)
				if(clbChNganh.GetItemChecked(i))
					cn.Add(clbChNganh.Items[i].ToString());
			sv.ChNganh = cn;
			return sv;
		}

		private SinhVien GetSinhVienFromLV(ListViewItem lvitem)
		{
			SinhVien sv = new SinhVien();
			sv.MaSo = lvitem.SubItems[0].Text;
			sv.HoTen = lvitem.SubItems[1].Text;
			sv.NgSinh = DateTime.Parse(lvitem.SubItems[2].Text);
			sv.DiaChi = lvitem.SubItems[3].Text;
			sv.Lop = lvitem.SubItems[4].Text;
			sv.GTinh = false;
			if (lvitem.SubItems[5].Text == "Nam")
				sv.GTinh = true;
			List<string> cn = new List<string>();
			string[] s = lvitem.SubItems[6].Text.Split(',');
			foreach (string t in s)
				cn.Add(t);
			sv.ChNganh = cn;
			sv.Hinh = lvitem.SubItems[7].Text;
			return sv;
		}

		// Thiết lập các thông tin lên controls sinh viên
		private void ThietLapThongTin(SinhVien sv)
		{
			this.mtxtMaSo.Text = sv.MaSo;
			this.txtHoTen.Text = sv.HoTen;
			this.dtpNgSinh.Value = sv.NgSinh;
			this.txtDChi.Text = sv.DiaChi;
			this.cboLop.Text = sv.Lop;
			this.txtHinh.Text = sv.Hinh;
			this.pbHinh.ImageLocation = sv.Hinh;
			if (sv.GTinh)
				this.rdNam.Checked = true;
			else 
				this.rbNu.Checked = true;
			for (int i = 0; i < this.clbChNganh.Items.Count; i++)
				this.clbChNganh.SetItemChecked(i, false);
			foreach(string s in sv.ChNganh)
			{
				for (int i = 0; i < this.clbChNganh.Items.Count; i++)
					if (s.CompareTo(this.clbChNganh.Items[i]) == 0)
						this.clbChNganh.SetItemChecked(i, true);
			}
		}

		// Thêm sinh viên vào ListView
		private void AddStudent(SinhVien sv)
		{
			ListViewItem lvitem = new ListViewItem(sv.MaSo);
			lvitem.SubItems.Add(sv.HoTen);
			lvitem.SubItems.Add(sv.NgSinh.ToShortDateString());
			lvitem.SubItems.Add(sv.DiaChi);
			lvitem.SubItems.Add(sv.Lop);
			string gt = "Nữ";
			if (sv.GTinh)
				gt = "Nam";
			lvitem.SubItems.Add(gt);
			string cn = "";
			foreach (string s in sv.ChNganh)
				cn += s + ",";
			cn = cn.Substring(0, cn.Length - 1);
			lvitem.SubItems.Add(cn);
			lvitem.SubItems.Add(sv.Hinh);
			this.lvSinhVien.Items.Add(lvitem);
		}

		// Hiển thị các sinh viên trong qlsv trên ListView
		private void LoadListView(List<SinhVien> ds)
		{
			this.lvSinhVien.Items.Clear();
			foreach (SinhVien sv in ds)
			{
				AddStudent(sv);
			}
		}

		#endregion

		#region Các sự kiện
		// Sự kiện Load form
		private void frmSinhVien_Load(object sender, EventArgs e)
		{
			qlsv = new QuanLySinhVien();
			qlsv.DocTuFile();
			LoadListView(qlsv.DanhSach);
		}
		//  Khi chọn dòng sinh viên bên ListView
		// thực hiện gán thông tin lên các control
		private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
		{
			int count = this.lvSinhVien.SelectedItems.Count;
			if (count > 0)
			{
				ListViewItem lvitem = this.lvSinhVien.SelectedItems[0];
				SinhVien sv = GetSinhVienFromLV(lvitem);
				ThietLapThongTin(sv);
			}
		}

		// Chức năng Thêm Sv
		private void btnThem_Click(object sender, EventArgs e)
		{
			SinhVien sv = GetSinhVien();
			
			if (qlsv.Tim(sv.MaSo) != null)
				MessageBox.Show("Mã sinh viên đã tồn tại!", "Lỗi thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
			else
			{
				this.qlsv.Them(sv);
				LoadListView(qlsv.DanhSach);
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			//int count;
			//ListViewItem lvitem;
			//count = this.lvSinhVien.Items.Count - 1;
			//for (int i = count; i >= 0; i--)
			//{
			//	lvitem = this.lvSinhVien.Items[i];
			//	if (lvitem.Checked)
			//		qlsv.Xoa(lvitem);
			//}
			foreach (ListViewItem lvitem in lvSinhVien.SelectedItems)
			{
				qlsv.Xoa(GetSinhVienFromLV(lvitem));
			}
			LoadListView(qlsv.DanhSach);
			this.btnMDinh.PerformClick();
		}

		private void btnSua_Click(object sender, EventArgs e)
		 {
			SinhVien sv = GetSinhVien();
			if (qlsv.Sua(this.mtxtMaSo.Text, sv) == true)
				LoadListView(qlsv.DanhSach);
		}

		private void btnMDinh_Click(object sender, EventArgs e)
		{
			this.mtxtMaSo.Text = "";
			this.txtHoTen.Text = "";
			this.dtpNgSinh.Value = DateTime.Now;
			this.txtDChi.Text = "";
			this.cboLop.Text = this.cboLop.Items[0].ToString();
			this.txtHinh.Text = "";
			this.pbHinh.ImageLocation = "";
			this.rdNam.Checked = true;
			for (int i = 0; i < this.clbChNganh.Items.Count - 1; i++)
				this.clbChNganh.SetItemChecked(i, false);
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private int SoSanhTheoMa(object obj1, object obj2)
		{
			SinhVien sv = obj2 as SinhVien;
			return sv.MaSo.CompareTo(obj1);
		}
		private void btnBrowse_Click(object sender, EventArgs e)
		{

		}
		#endregion

	}
}
