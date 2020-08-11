using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ban_ve_rap_phim
{
    class Ghe
    {
        public int ID;
        public int SoGhe;
        public string TinhTrangGhe;
        public int id_Phong;

        public Ghe() { }

        public Ghe(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.SoGhe = (int)row["SoGhe"];
            this.TinhTrangGhe = row["TinhTrangGhe"].ToString();
        }
    }
}
