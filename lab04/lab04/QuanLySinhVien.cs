using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
	public class QuanLySinhVien
	{
		public List<SinhVien> DS = new List<SinhVien>();
		public QuanLySinhVien()
		{
			DS = new List<SinhVien>();
		}

		//Thêm một sinh viên vào danh sách
		public SinhVien this[int index]
		{
			get { return DS[index]; }
			set { DS[index] = value; }
		}
		public void AddStd(SinhVien sv)
		{
			this.DS.Add(sv);
		}

		// Xóa sinh viên trong danh sách
		public void DeleteStd(SinhVien sv)
		{
			for (int i = 0; i < this.DS.Count; i++)
				if (this.DS[i].Id.CompareTo(sv.Id) == 0)
					this.DS.RemoveAt(i);
		}

		// Tìm một sinh viên trong danh sách thỏa điều kiện
		public SinhVien SearchStd(string svId)
		{
			SinhVien sv = null;
			sv = DS.Find(std => std.Id.CompareTo(svId) == 0);
			return sv;
		}

		// Chỉnh sửa thông tin sinh viên
		public void EditStd(string StdId, SinhVien newStd)
		{
			bool result = false;
			for (int i = 0; i < this.DS.Count; i++)
				if (this.DS[i].Id.CompareTo(StdId) == 0)
				{
					this.DS[i] = newStd;
					result = true;
					break;
				}
			if (!result)
				AddStd(newStd);
		}

		// Đọc từ file
		public void ReadFile(string fileName)
		{
			string[] s;
			string line;
			SinhVien sv;
			StreamReader sr = new StreamReader(new FileStream(fileName, FileMode.Open));
			while ((line = sr.ReadLine()) != null)
			{
				s = line.Split('*');
				sv = new SinhVien();
				sv.Id = s[0];
				if (SearchStd(sv.Id) != null)
					continue;
				sv.FullName = s[1];
				sv.Gender = s[2].CompareTo("1") == 0 ? true : false;
				sv.Birthday = DateTime.Parse(s[3]);
				sv.Class = s[4];
				sv.Phone = s[5];
				sv.Mail = s[6];
				sv.Address = s[7];
				sv.Image = s[8];

				AddStd(sv);
			}
			sr.Close();
		}

		// Lưu thông tin sinh viên
		public void SaveFile()
		{
			StreamWriter sw = new StreamWriter(new FileStream("DSSV.txt", FileMode.Open));
			foreach (SinhVien sv in this.DS)
			{
				string line = "";
				line += sv.Id + "*";
				line += sv.FullName + "*";
				if (sv.Gender)
					line += "1" + "*";
				else line += "0" + "*";
				line += sv.Birthday.ToShortDateString() + "*";
				line += sv.Class + "*";
				line += sv.Phone + "*";
				line += sv.Mail + "*";
				line += sv.Address + "*";
				line += sv.Image + "*";
				sw.WriteLine(line);

			}
			sw.Close();
		}
	}

}
