using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
	public class QuanLyGiaoVien
	{
		public List<GiaoVien> dsGiaoVien = new List<GiaoVien>();
		public GiaoVien this[int index]
		{
			get { return dsGiaoVien[index] as GiaoVien; }
			set { dsGiaoVien[index] = value; }
		}
		public QuanLyGiaoVien()
		{

		}
		public bool Them(GiaoVien gv)
		{
			if (dsGiaoVien.Find(h => String.Compare(h.MaSo, gv.MaSo) == 0) != null)
				return false;
			else dsGiaoVien.Add(gv);
			return true;
		}


	}
}
