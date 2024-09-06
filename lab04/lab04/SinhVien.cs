using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
	public class SinhVien
	{
		// Các thuộc tính của lớp Sinh Viên
		public string Id { get; set; }
		public string FullName { get; set; }
		public string Mail { get; set; }
		public string Address { get; set; }
		public string Image { get; set; }
		public DateTime Birthday { get; set; }
		public bool Gender { get; set; }
		public string Class { get; set; }
		public string Phone { get; set; }

		// Phương thức tạo lập mặc định
		public SinhVien()
		{

		}

		// Phương thức tạo lập có tham số
		public SinhVien(string id, string fullname, string mail, string address, string image, DateTime birthday, bool gender, string @class, string phone)
		{
			this.Id = id;
			this.FullName = fullname;
			this.Mail = mail;
			this.Address = address;
			this.Image = image;
			this.Birthday = birthday;
			this.Gender = gender;
			this.Class = @class;
			this.Phone = phone;
		}

	}
}
