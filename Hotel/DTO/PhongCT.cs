using Hotel.DAO;
using Hotel.DTB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DTO
{
    public class PhongCT
    {
        private string maPhong;
        public string MaPhong { get => maPhong; set => maPhong = value; }

        private float donGia;
        public float DonGia { get => donGia; set => donGia = value; }

        public string LoaiPhong { get => loaiPhong; set => loaiPhong = value; }
        private string loaiPhong;

        public PhongCT(string maphong, string loaiphong, float dongia) {
            this.MaPhong = maphong;
            this.LoaiPhong = loaiphong;
            this.DonGia = dongia;
        }

        public PhongCT(DataRow row)
        {
            this.MaPhong = row["phong"].ToString();
            this.LoaiPhong = row["loaiphong"].ToString();
            this.DonGia = (float)Convert.ToDouble(row["dongia"].ToString()); 
        }

        public static PhongCT GetPhongCTById(string id)
        {
            var data = PhongCTDAO.GetById(id);
            PhongCT phongCT = new PhongCT(data.Rows[0]);
            return phongCT;
        }

        public static List<PhongCT> GetAvailableRooms(DateTime ngayden, int sodem)
        {
            DataTable data = PhongCTDAO.GetAvailableRooms(ngayden, sodem);

            List<PhongCT> rooms = new List<PhongCT>();
            foreach (DataRow row in data.Rows)
            {
                rooms.Add(GetPhongCTById(row["MaPH"].ToString()));
            }
            return rooms;
        }
    }
}
