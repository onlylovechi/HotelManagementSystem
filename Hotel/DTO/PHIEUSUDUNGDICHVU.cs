using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DTO
{
    internal class PHIEUSUDUNGDICHVU
    {
        private String MAPDV;
        private String MAPDP;
        private String MADV;
        private String NOIDUNG;
        private String SOLUONG;
        private String THANHTIEN;
        private String NGAYLAP;
        private String MANGUOILAP;

        public string MAPDV1 { get => MAPDV; set => MAPDV = value; }
        public string MAPDP1 { get => MAPDP; set => MAPDP = value; }
        public string MADV1 { get => MADV; set => MADV = value; }
        public string NOIDUNG1 { get => NOIDUNG; set => NOIDUNG = value; }
        public string SOLUONG1 { get => SOLUONG; set => SOLUONG = value; }
        public string THANHTIEN1 { get => THANHTIEN; set => THANHTIEN = value; }
        public string NGAYLAP1 { get => NGAYLAP; set => NGAYLAP = value; }
        public string MANGUOILAP1 { get => MANGUOILAP; set => MANGUOILAP = value; }


        public PHIEUSUDUNGDICHVU(DataRow row)
        {
            this.MAPDV = (string)row["MAPDV"].ToString();
            this.MAPDP = (string)row["MAPDP"].ToString();
            this.MADV = (string)row["MADV"].ToString();
            this.NOIDUNG = row["NOIDUNG"].ToString();
            this.SOLUONG = row["SOLUONG"].ToString();
            this.THANHTIEN = row["THANHTIEN"].ToString();
            this.NGAYLAP = row["NGAYLAP"].ToString();
            this.MANGUOILAP = row["MANGUOILAP"].ToString();

        }

    }
}

