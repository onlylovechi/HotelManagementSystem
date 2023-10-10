using Hotel.DTB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DTO
{
    internal class DICHVU
    {
        private String MADV;
        private String TENDV;
        private String THONGTIN;
        private String DONGIA;

        public string MADV1 { get => MADV; set => MADV = value; }
        public string TENDV1 { get => TENDV; set => TENDV = value; }
        public string THONGTIN1 { get => THONGTIN; set => THONGTIN = value; }
        public string DONGIA1 { get => DONGIA; set => DONGIA = value; }

        public DICHVU(DataRow row)
        {
            this.MADV = (string)row["MADV"].ToString();
            this.TENDV = (string)row["TENDV"].ToString();
            this.THONGTIN = (string)row["THONGTIN"].ToString();
            this.DONGIA = (string)row["DONGIA"].ToString();
        }
    }
}

