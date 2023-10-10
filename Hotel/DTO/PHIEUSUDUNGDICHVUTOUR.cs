using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DTO
{
    internal class PHIEUSUDUNGDICHVUTOUR
    {
        private String MAPDVT;
        private String MAPDP;
        private String MADVT;
        private String TGKHOIHANH;
        private String SLNGUOI;
        private String THANHTIEN;
        private String NGAYLAP;
        public string MAPDVT1 { get => MAPDVT; set => MAPDVT = value; }
        public string MAPDP1 { get => MAPDP; set => MAPDP = value; }
        public string MADVT1 { get => MADVT; set => MADVT = value; }
        public string TGKHOIHANH1 { get => TGKHOIHANH; set => TGKHOIHANH = value; }
        public string SLNGUOI1 { get => SLNGUOI; set => SLNGUOI = value; }
        public string THANHTIEN1 { get => THANHTIEN; set => THANHTIEN = value; }
        public string NGAYLAP1 { get => NGAYLAP; set => NGAYLAP = value; }

        public PHIEUSUDUNGDICHVUTOUR(DataRow row)
        {
            this.MAPDVT = (string)row["MAPDVT"].ToString();
            this.MAPDP = (string)row["MAPDP"].ToString();
            this.MADVT = (string)row["MADVT"].ToString();
            this.TGKHOIHANH = (string)row["TGKHOIHANH"].ToString();
            this.SLNGUOI = (string)row["SLNGUOI"].ToString();
            this.THANHTIEN = (string)row["THANHTIEN"].ToString();
            this.NGAYLAP = (string)row["NGAYLAP"].ToString();
        }

    }
}

