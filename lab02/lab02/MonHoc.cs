using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
	public class MonHoc
	{
		public int Id { get; set; }	
		public string tenMN { get; set; }
		public int SoTC { get; set; }
		public MonHoc()
		{

		}
		public MonHoc(string ten)
		{
			this.tenMN = ten;
		}
		public MonHoc(int id, string ten, int tc)
		{
			this.Id = id;
			this.tenMN = ten;
			this.SoTC = tc;
		}
		public override string ToString()
		{
			return tenMN;
		}
	}
}
