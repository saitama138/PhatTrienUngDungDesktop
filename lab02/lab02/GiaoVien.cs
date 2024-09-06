using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
	public class GiaoVien
	{
		public string MaSo { get; set; }
		public string HoTen{ get; set; }
		public DateTime NgSinh;
		public DanhMucMonHoc dsMHoc;
		public string GTinh;
		public string[] NgNgu;
		public string SDT;
		public string Mail;

		public GiaoVien()
		{ 
		dsMHoc = new DanhMucMonHoc();
			NgNgu = new string[10];
		}
		public GiaoVien(string maso, string hoten, DateTime ngsinh, DanhMucMonHoc ds, string gt, string[] nn, string sdt, string mail)
		{
			this.MaSo = maso;
			this.HoTen = hoten;
			this.NgSinh = ngsinh;
			this.dsMHoc = ds;
			this.GTinh = gt;
			this.NgNgu = nn;
			this.SDT = sdt;
			this.Mail = mail;
		}

		public override string ToString()
		{
			string s = "Mã số: " + MaSo + "\n"
				+ "Họ tên: " + HoTen + "\n"
				+ "Ngày sinh: " + NgSinh + "\n"
				+ "Giới tính: " + GTinh + "\n"
				+ "Số ĐT: " + SDT + "\n"
				+ "Mail: " + Mail + "\n";
			string sngoaingu = "Ngoại ngữ: ";
			foreach (string t in NgNgu)
				sngoaingu += t + ";";
			string dsmhoc = "Danh sách môn dạy: ";
			foreach (MonHoc mh in dsMHoc.ds)
				dsmhoc += mh + ";";
			s += "\n" + sngoaingu + "\n" + dsmhoc;
			return s;
		}

	}
}
