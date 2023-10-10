using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DTO
{
    internal class LOAIPHONG
    {
        private String MALP;
        private String THONGTIN;
        private String SONGUOI;
        private String DONGIA;

        public string MALP1 { get => MALP; set => MALP = value; }
        public string THONGTIN1 { get => THONGTIN; set => THONGTIN = value; }
        public string SONGUOI1 { get => SONGUOI; set => SONGUOI = value; }
        public string DONGIA1 { get => DONGIA; set => DONGIA = value; }

        public LOAIPHONG(DataRow row)
        {
            this.MALP = (string)row["MALP"].ToString();
            this.THONGTIN = (string)row["THONGTIN"].ToString();
            this.SONGUOI = (string)row["SONGUOI"].ToString();
            this.DONGIA = (string)row["DONGIA"].ToString();
        }
    }
}
