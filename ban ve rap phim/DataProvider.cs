using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ban_ve_rap_phim
{
	class DataProvider
	{
		// Kỹ thuật singleton trong design pattern để tạo một truy cập static toàn cục
		// Để có thể truy xuất cơ sở dữ liệu một lần và duy nhất, không cần phải mất công gọi lại CSDL
		private static DataProvider instance;

		public static DataProvider Instance
		{
			get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
			private set { DataProvider.instance = value; }
		}

		string connectionString = @"Data Source=DESKTOP-QQ3LNM1\SQLEXPRESS;Initial Catalog=BanVeRapPhim;Integrated Security=True";
		SqlConnection sqlconnection;

		private DataProvider() { }

		// Truy xuất CSDL và đổ vào data table
		// 2 tham số cho hàm exqute query : câu truy vấn, tham số của câu truy vấn
		public DataTable ExcuteQuery(string query, object[] parameter = null)
		{
			DataTable dt = new DataTable();

			// Dùng câu lệnh using để sau khi dùng thì connection sẽ tự động bị hủy, không bị lưu trữ
			using (sqlconnection = new SqlConnection(connectionString))
			{
				sqlconnection.Open();

				// Khởi tạo lớp sqlCommand 
				SqlCommand sqlCommand = new SqlCommand();

				// Đặt giá trị cho lớp sqlCommand có thể hiểu được câu truy vấn SELECT FROM WHERE
				sqlCommand.CommandType = CommandType.Text;

				// Gán câu truy vấn vào lớp SQL
				sqlCommand.CommandText = query;

				// Gán chuỗi kết nối vào lớp SQL
				sqlCommand.Connection = sqlconnection;

				// Phân tích và truyền tham số
				// Nếu parameter không null thì thực hiện những câu lệnh trong ngoặc
				if (parameter != null)
				{
					// Tách danh sách các parameter thành các parameter nhỏ bằng khoảng trống
					string[] listPara = query.Split(' ');
					int i = 0;

					// Với mỗi tham số trong danh sách các tham số -->
					foreach (string item in listPara)
					{
						// Nếu tham số có chứa @ (Dấu hiệu nhận biết của một tham số trong truy vấn)
						// --> Thì sẽ thêm tham số vào lớp sqlCommand
						if (item.Contains('@'))
						{
							sqlCommand.Parameters.AddWithValue(item, parameter[i]);
							i++;
						}
					}
				}

				// Lớp sqldata adapter để thực hiện cấu truy vấn
				SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

				// Đổ dữ liệu từ câu truy vấn bằng lớp SQLData Adapter vào Datatable
				adapter.Fill(dt);

				// Đóng kết nối
				sqlconnection.Close();
			}

			// Trả về data table
			return dt;
		}



	}
}
