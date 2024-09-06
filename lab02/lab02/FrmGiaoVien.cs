using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
	public partial class FrmGiaoVien : Form
	{
		public FrmGiaoVien()
		{
			InitializeComponent();
		}

		public QuanLyGiaoVien dsGV = new QuanLyGiaoVien();
		private void FrmGiaoVien_Load(object sender, EventArgs e)
		{
			string lienhe = "http://it.dlu.edu.vn/e-learning/Default.aspx";
			this.linklbLienHe.Links.Add(0, lienhe.Length, lienhe);
			this.cboMaSo.SelectedItem = this.cboMaSo.Items[0];
		}
		private void btnChon_Click(object sender, EventArgs e)
		{
			int i = this.lbDSMHoc.SelectedItems.Count-1;
			while (i>=0)
			{
				this.lbMHDay.Items.Add(lbDSMHoc.SelectedItems[i]);
				this.lbDSMHoc.Items.Remove(lbDSMHoc.SelectedItems[i]);
				i--;
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			int i = this.lbMHDay.SelectedItems.Count - 1;
			while (i >= 0)
			{
				this.lbDSMHoc.Items.Add(lbMHDay.SelectedItems[i]);
				this.lbMHDay.Items.Remove(lbMHDay.SelectedItems[i]);
				i--;
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Reset();
		}
		private void Reset()
		{
			this.cboMaSo.Text = "";
			this.txtHoTen.Text = "";
			this.txtDiaChi.Text = "";
			this.mtbSDT.Text = "";
			this.dtpNgSinh.Value = DateTime.UtcNow;
			this.rdNam.Checked = true;
			//Bỏ chọn chklbNgoaiNgu
			for (int i = 0; i < chklbNgoaiNgu.Items.Count - 1; i++)
				chklbNgoaiNgu.SetItemChecked(i, false);
			//Chuyển các môn từ lbMonHocDay sang lbDanhMucMH
			foreach (object ob in this.lbMHDay.Items)
				this.lbDSMHoc.Items.Add(ob);
			this.lbMHDay.Items.Clear();
			this.lbDSMHoc.Text = "";

		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
			
		}

		private void linklbLienHe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			string s = e.Link.LinkData.ToString();
			Process.Start(s);
		}
		private void btnLuu_Click(object sender, EventArgs e)
		{
			frmTBGiaoVien frm = new frmTBGiaoVien();
			frm.SetText(GetGiaoVien().ToString());
			frm.ShowDialog();
		}

		public GiaoVien GetGiaoVien()
		{
			string gt = "Nam";
			if (rdNu.Checked)
				gt = "Nữ";
			GiaoVien gv = new GiaoVien();	
			gv.MaSo = this.cboMaSo.Text;
			gv.GTinh = gt;
			gv.HoTen = this.txtHoTen.Text;
			gv.NgSinh = this.dtpNgSinh.Value;
			gv.Mail = this.txtDiaChi.Text;
			gv.SDT = this.mtbSDT.Text;
			//Lấy thông tin ngoại ngữ
			string ngoaingu = "";
			for (int i = 0; i < chklbNgoaiNgu.Items.Count-1; i++)
				if(chklbNgoaiNgu.GetItemChecked(i))
					ngoaingu += chklbNgoaiNgu.Items[i] + ";";
			gv.NgNgu = ngoaingu.Split(';');
			//Lấy thông tin danh sách môn học
			DanhMucMonHoc mh = new DanhMucMonHoc();
			foreach (object ob in lbMHDay.Items)
				mh.them(new MonHoc(ob.ToString() + "\n"));
			gv.dsMHoc = mh;

			return gv;
		}

		private void btThem_Click(object sender, EventArgs e)
		{			
			if (dsGV.Them(GetGiaoVien()))
				MessageBox.Show("Them thanh cong!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			else MessageBox.Show("Ma giao vien da ton tai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void btTim_Click(object sender, EventArgs e)
		{
			TimKiem timKiem = new TimKiem(dsGV.dsGiaoVien);
			timKiem.ShowDialog();
		}
	}
}
