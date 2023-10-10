using Hotel.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DTO
{
    internal class HoaDon
    {
        private String MaHD;
        private String NgayLap;
        private String MaPDP;
        private String ThanhTien;
        private String MaNguoiLap;

        public HoaDon(string maHD,  string maPDP, string thanhTien, string maNguoiLap)
        {
            MaHD = maHD;
            NgayLap = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            MaPDP = maPDP;
            ThanhTien = thanhTien;
            MaNguoiLap = maNguoiLap;
        }

        public string MAHD { get => MaHD; set => MaHD = value; }
        public string NGAYLAP { get => NgayLap; set => NgayLap = value; }
        public string MAPDP { get => MaPDP; set => MaPDP = value; }
        public string THANHTIEN { get => ThanhTien; set => ThanhTien = value; }
        public string MANGUOILAP { get => MaNguoiLap; set => MaNguoiLap = value; }
        public static string GenerateNewId()
        {
            string lastId = HoaDonDAO.GetLastId();
            var newNumber = Int32.Parse(lastId.Substring(3)) + 1;
            string newId = newNumber < 100 ? $"PDP0{newNumber}" : $"PDP{newNumber}";
            return newId;
        }
        public static bool taoHoaDon(HoaDon hd)
        {
            return HoaDonDAO.Insert(hd);
        }
    }
}
