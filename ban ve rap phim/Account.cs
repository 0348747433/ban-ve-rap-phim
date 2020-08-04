using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ban_ve_rap_phim
{
    class Account
    {
		private string username;
		private string password;

		public string Username { get => username; set => username = value; }
		public string Password { get => password; set => password = value; }

		public Account() { }

		public Account(DataRow row)
		{
			this.Username = row["TaiKhoan"].ToString();
			this.Password = row["MatKhau"].ToString();
		}
	}
}
