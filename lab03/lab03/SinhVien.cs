using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Demo
{
	public class SinhVien
	{
		public string MaSo { get; set; }
		public string HoTen { get; set; }
		public DateTime NgSinh { get; set; }
		public string DiaChi { get; set; }
		public string Lop { get; set;}
		public string Hinh { get; set; }
		public bool GTinh { get; set; }
		public List<string> ChNganh { get; set; }

		public SinhVien()
		{
			ChNganh = new List<string>();
		}

		public SinhVien(string ms, string ht, DateTime ngay, string dc, string lop, string hinh, bool gt, List<string>cn)
		{
			this.MaSo = ms;
			this.HoTen = ht;
			this.NgSinh = ngay;
			this.DiaChi = dc;
			this.Lop = lop;	
			this.Hinh = hinh;
			this.GTinh = gt;
			this.ChNganh = cn;
		}
	}
}
