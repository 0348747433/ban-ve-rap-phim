using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ban_ve_rap_phim
{
    class Phim
    {
        public int ID;
        public string TenPhim;
        //public DateTime NgayChieu;
        //public DateTime GioChieu;

        public Phim() { }

        public Phim(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.TenPhim = row["TenPhim"].ToString();
            //this.NgayChieu = (DateTime)row["NgayChieu"];
            //this.GioChieu = (DateTime)row["GioChieu"];
        }
       
    }

    
}
