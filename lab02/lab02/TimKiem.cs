using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
	public partial class TimKiem : Form
	{
		public List<GiaoVien> dsGV = new List<GiaoVien>();	

		public TimKiem(List<GiaoVien> dsGVien)
		{
			InitializeComponent();
			dsGV = dsGVien;
		}

		private void btOK_Click(object sender, EventArgs e)
		{
			List<GiaoVien> gV =new List<GiaoVien>();
			if (this.rdmaGV.Checked)
			if (this.rdHoTen.Checked)
				gV = this.dsGV.FindAll(x => x.HoTen.Contains(this.txtTimKiem.Text));
				gV = this.dsGV.FindAll(x => x.MaSo.Contains(this.txtTimKiem.Text));
			if (this.rdSDT.Checked)
				gV = this.dsGV.FindAll(x => x.SDT.Contains(this.txtTimKiem.Text));
			if(gV != null)
			{
				string st = "";
				foreach(GiaoVien g in gV)
				{
					st += g.ToString() + "\n" ;

				}
				frmTBGiaoVien frmTB = new frmTBGiaoVien();
				frmTB.SetText(st);
				frmTB.ShowDialog();
			}

		}
	}
}
