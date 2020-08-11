using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ban_ve_rap_phim
{
    public class Phong
    {
        public int ID { get; set; }
        public int SoPhong { get; set; }
        public int id_phim { get; set; }

        public Phong() { }

        public Phong(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.SoPhong = (int)row["SoPhong"];
            this.id_phim = (int)row["id_phim"];
        }
    }
}
