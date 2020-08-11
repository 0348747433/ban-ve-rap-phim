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
    // CN1 : Load Seat from SQL (done)
    // CN2 : Load phim tu CSDL (done)
    // CN3 : Load gio phim tu CSDL
    // CN4 : Load phong chieu tu CSDL
    // CN5 : Chuc nang mua ve

    public partial class frmBanVe : Form
    {
        List<Ghe> DanhSachGhe = new List<Ghe>();
        public frmBanVe()
        {
            InitializeComponent();

            Load_Phim();

        }

        private void Load_Gio_Phim(string ID_From_lbID)
        {
            // Buoc 1 : Lay gio phim nhu the nao ? --> Truy van select tat ca thong tin cua bang phim va bang gio (SELECT * FROM phim , gio,....) (done)
            // Buoc 2 : Lam sao de luu tru du lieu de co the tai su dung ? --> Do du lieu vao DataTable (done)
            // Buoc 3.1 : Phat sinh van de --> Lam sao de luu tru thong tin gio phim de cac lop va ham khac co the su dung ? --> Tao ra mot lop NgayGioPhim, luu tru lop
            // Buoc 3.2 : Phat sinh van de 2 --> Lam sao de luu tru du lieu nhieu va lon cung mot luc ? --> Su dung vong lap foreach
            // Buoc 4 : Hien thi du lieu dataTable minh vua luu tru nhu the nao ? --> Hien thi tren 2 cai comboBox

            // buoc 1 : 
            string query = "SELECT * FROM Phim , ThoiGianChieu WHERE Phim.ID = ThoiGianChieu.ID_Phim";
            // buoc 2 :
            DataTable dt = DataProvider.Instance.ExcuteQuery(query); 
            // buoc 3 : 
            foreach(DataRow row in dt.Rows)
            {
                NgayGioChieuPhim ngayGioChieuPhim = new NgayGioChieuPhim(row);
                int ID = int.Parse(ID_From_lbID);
                if(ID == ngayGioChieuPhim.ID_Phim)
                {
                    cbNgayChieu.Items.Add(ngayGioChieuPhim.NgayChieuPhim);
                    cbGioChieu.Items.Add(ngayGioChieuPhim.GioChieuPhim);
                }
            }
        }

        private void Load_Phong_Phim(string ID_From_lbID)
        {
            // Buoc 1 : Lay gio phim nhu the nao ? --> Truy van select tat ca thong tin cua bang phim va bang gio (SELECT * FROM phim , gio,....) (done)
            // Buoc 2 : Lam sao de luu tru du lieu de co the tai su dung ? --> Do du lieu vao DataTable (done)
            // Buoc 3.1 : Phat sinh van de --> Lam sao de luu tru thong tin gio phim de cac lop va ham khac co the su dung ? --> Tao ra mot lop NgayGioPhim, luu tru lop
            // Buoc 3.2 : Phat sinh van de 2 --> Lam sao de luu tru du lieu nhieu va lon cung mot luc ? --> Su dung vong lap foreach
            // Buoc 4 : Hien thi du lieu dataTable minh vua luu tru nhu the nao ? --> Hien thi tren 2 cai comboBox

            // buoc 1 : 
            string query = "SELECT * FROM Phim , Phong WHERE Phim.ID = Phong.id_Phim";
            // buoc 2 :
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);
            // buoc 3 : 
            foreach (DataRow row in dt.Rows)
            {
                Phong phong = new Phong(row);
                int ID = int.Parse(ID_From_lbID);
                if (ID == phong.id_phim)
                {
                    lbSoPhong.Text = phong.SoPhong.ToString();
                    Load_Seat_From_SQL(phong);
                }
            }
            

        }

        private void Load_Phim()
        {
            DataTable dt = DataProvider.Instance.ExcuteQuery("SELECT * FROM PHIM");
            
            foreach(DataRow row in dt.Rows)
            {
                Phim phim = new Phim(row);
                cbTenPhim.Items.Add(phim.TenPhim);
            }
        }

        private void Load_Seat_From_SQL(Phong phong)
        {
            flpSeat.Controls.Clear();
            // Ghe.id_phong = phong.ID
            
            // TODO - Sua lai chuc nang load theo CSDL
            //Buoc 1 : 
            string query_select_ghe = "SELECT * FROM Ghe , Phong WHERE Ghe.id_phong = Phong.ID AND Ghe.id_phong =  "+phong.ID;
            DataTable dt_select_ghe = DataProvider.Instance.ExcuteQuery(query_select_ghe);

            List<Ghe> DanhSachGhe = new List<Ghe>();

            foreach(DataRow row in dt_select_ghe.Rows)
            {
                Ghe ghe = new Ghe(row);
                DanhSachGhe.Add(ghe);
                
            }

            foreach(Ghe ghe in DanhSachGhe)
            {
                for (int i = 0; i < ghe.SoGhe; i++)
                {
                    Button btn = new Button();
                    btn.Width = 70;
                    btn.Height = 70;
                    btn.Text = ghe.SoGhe.ToString();

                    // Kiem tra tinh trang ghe
                    if(ghe.TinhTrangGhe == "CHUA DAT")
                    {
                        btn.BackColor = Color.Pink;
                    }
                    else if(ghe.TinhTrangGhe == "DA DAT")
                    {
                        btn.BackColor = Color.Yellow;
                    }

                    flpSeat.Controls.Add(btn);

                    // Lay ra danh sach ghe 

                    btn.Click += Btn_Click;
                    break;
                }
            }
            


        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if(btn.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghe nay da dat roi", "Dat ghe");
                return;
            }
            btn.BackColor = Color.Purple;
            // lay ra cai so ghe 
            int get_seat_number = int.Parse(btn.Text);
            Ghe ghe = new Ghe();
            ghe.SoGhe = get_seat_number;
            DanhSachGhe.Add(ghe);

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void cbTenPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            // Load Phim
            DataTable dt = DataProvider.Instance.ExcuteQuery("SELECT * FROM PHIM");
            List<Phim> DanhSachPhim = new List<Phim>();
            foreach (DataRow row in dt.Rows)
            {
                Phim phim = new Phim(row);
                DanhSachPhim.Add(phim);
            }
            cbNgayChieu.Items.Clear();
            cbGioChieu.Items.Clear();
            cbGioChieu.Text = "";
            cbNgayChieu.Text = "";
            switch (cbTenPhim.SelectedItem.ToString()) /////using switch to test as to what was selected from the first combobox
            {
              
                case "GhostOfWar":
                    foreach(Phim phim in DanhSachPhim)
                    {
                        if(phim.TenPhim == "GhostOfWar")
                        {
                            lbID.Text = phim.ID.ToString();
                        }
                    }
                    Load_Gio_Phim(lbID.Text);
                    Load_Phong_Phim(lbID.Text);
                    
                    break;
                
                case "SexAndZen":
                    foreach (Phim phim in DanhSachPhim)
                    {
                        if (phim.TenPhim == "SexAndZen")
                        {
                            lbID.Text = phim.ID.ToString();
                        }
                    }
                    Load_Gio_Phim(lbID.Text);
                    Load_Phong_Phim(lbID.Text);
                  
                    break;
            }
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frmBanVe_Load(object sender, EventArgs e)
        {

        }

        private void btnMuaVe_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Ban co chac dat ghe khong ? ", "Data ghe", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                // Update Ghe
                DataTable dt = null;
                foreach (Ghe ghe in DanhSachGhe)
                {
                    dt = DataProvider.Instance.ExcuteQuery("PROC_updateTinhTrangGhe @soGhe", new object[] { ghe.SoGhe });
                }
                // Update thanh cong thi in ra message box
                MessageBox.Show("Mua ve thanh cong ! ");
                Load_Phong_Phim(lbID.Text);
            }
            return;
            
            
            
            
        }

        private void ChucNangMuaVe()
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void flpSeat_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
