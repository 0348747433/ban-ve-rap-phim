using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ban_ve_rap_phim
{
    class NgayGioChieuPhim
    {
        public DateTime NgayChieuPhim;
        public TimeSpan GioChieuPhim;
        public int ID_Phim;

        public NgayGioChieuPhim() { }

        public NgayGioChieuPhim(DataRow row)
        {
            this.NgayChieuPhim = (DateTime)row["NgayChieu"];
            this.GioChieuPhim = (TimeSpan)row["TenGio"];
            this.ID_Phim = (int)row["ID_Phim"];
        }
    }
}
