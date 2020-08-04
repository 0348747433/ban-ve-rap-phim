using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ban_ve_rap_phim
{
	public partial class frmDangNhap : Form
	{
		public frmDangNhap()
		{
			InitializeComponent();
		}

		private void btndangnhap_Click(object sender, EventArgs e)
		{

			if (Login() == true)
			{
				frmTrangChu frm = new frmTrangChu();
				frm.ShowDialog();
			}
			else
			{
				MessageBox.Show("Dang nhap that bai ! ");
			}
		}

		private bool Login()
		{
			// Lấy tài khoản và mật khẩu mà người dùng nhập vào text box
			string input_username = txtUsername.Text;
			string input_password = txtPassword.Text;
			bool output = false;

			// Tạo câu truy vấn cơ sở dữ liệu để lấy tài khoản và mật khẩu có trong cơ sở dữ liệu
			string query = "SELECT * FROM TaiKhoan";
			DataTable dt = DataProvider.Instance.ExcuteQuery(query);

			// Lấy ra giá trị (hàng) từ data table mà chúng ta đã truy xuất
			foreach (DataRow row in dt.Rows)
			{
				Account account = new Account(row);
				if (account.Username == input_username && account.Password == input_password)
				{
					output = true;
					break;
				}
			}

			return output;
		}
	}
}
