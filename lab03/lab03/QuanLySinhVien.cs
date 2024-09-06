using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Demo
{
	public class QuanLySinhVien
	{
		public List<SinhVien> DanhSach = new List<SinhVien>();
		public bool result = false;

		// Thêm một sinh viên vào danh sách
		public void Them(SinhVien sv)
		{
			DanhSach.Add(sv);
		}

		public SinhVien this[int index]
		{
			get { return this.DanhSach[index]; }
			set { DanhSach[index] = value; }
		}

		public void Xoa(SinhVien sv)
		{
			for (int i = 0; i < this.DanhSach.Count; i++)
				if (DanhSach[i].MaSo.CompareTo(sv.MaSo) == 0)
					DanhSach.RemoveAt(i);
		}

		public SinhVien Tim(string svId)
		{
			SinhVien sv = null;
			sv = DanhSach.Find(std => std.MaSo.CompareTo(svId) == 0);
			return sv;
		}

		public bool Sua(string stdID, SinhVien newStd)
		{
			for (int i = 0; i < DanhSach.Count; i ++)
				if (DanhSach[i].MaSo.CompareTo(stdID) == 0)
				{
					DanhSach[i] = newStd;
					return true;
				}
			return false;
		}


		// Hàm đọc danh sách sinh viên từ tập tin txt
		public void DocTuFile()
		{
			string filename = "DanhSachSV.txt", t;
			string[] s;
			SinhVien sv;
			StreamReader sr = new StreamReader(new FileStream(filename, FileMode.Open));
			while ((t = sr.ReadLine()) != null)
			{
				s = t.Split('*');
				sv = new SinhVien();
				sv.MaSo = s[0];
				sv.HoTen = s[1];
				sv.NgSinh = DateTime.Parse(s[2]);
				sv.DiaChi = s[3];
				sv.Lop = s[4];
				sv.Hinh = s[5];
				sv.GTinh = false;
				if (s[6] == "1")
					sv.GTinh = true;
				string[] cn = s[7].Split(',');
				foreach (string c in cn)
					sv.ChNganh.Add(c);
				Them(sv);
			}
		}
	}
}

