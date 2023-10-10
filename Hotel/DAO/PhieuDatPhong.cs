using Hotel.DAO;
using Hotel.DTB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.ComponentModel.Com2Interop;

namespace Hotel.DTO
{
    public class PhieuDatPhong
    {
        public string MaKH { get; set; }
        public string MaDatPhong { get; set; }
        public DateTime NgayDat { get; set; } = DateTime.Today;
        public DateTime NgayDen { get; set; } = DateTime.Today;
        public int SoDemLT { get; set; }
        public string GhiChu { get; set; }
        public float TienDaTra { get; set; }

        public PhieuDatPhong(string maKH, string maDatPhong, DateTime ngayDen, int soDemLT, string ghiChu, float tienDaTra)
        {
            MaKH = maKH;
            MaDatPhong = maDatPhong;
            NgayDen = ngayDen;
            SoDemLT = soDemLT;
            GhiChu = ghiChu;
            TienDaTra = tienDaTra;
        }

        public static string GenerateNewId()
        {
            string lastId = PhieuDatPhongDAO.GetLastId();
            var newNumber = Int32.Parse(lastId.Substring(3)) + 1;
            string newId = newNumber < 100 ? $"PDP0{newNumber}" : $"PDP{newNumber}";
            return newId;
        }

        public static bool Insert(PhieuDatPhong phieudp)
        {
            return PhieuDatPhongDAO.Insert(phieudp);
        }
    }
}
