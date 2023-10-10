using Hotel.DAO;
using Hotel.DTB;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Hotel.DTO
{
    public class KhachHang
    {
        public string MaKH { get; set; }
        public string HoTen { get; set; }
        public string Email { get; set; }
        public string CMND { get; set; }
        public string SDT { get; set; }
        public string FAX { get; set; }
        public string DiaChi { get; set; }

        public KhachHang(DataRow row) {
            MaKH = row["MaKH"].ToString();
            HoTen = row["HOTEN"].ToString();
            Email = row["EMAIL"].ToString();
            CMND = row["CMND"].ToString();
            SDT = row["SDT"].ToString();
            FAX = row["FAX"].ToString();
            DiaChi = row["DIACHI"].ToString();
        }

        public KhachHang(string maKH, string hoTen, string email, string cMND, string sDT, string fAX, string diaChi)
        {
            MaKH = maKH;
            HoTen = hoTen;
            Email = email;
            CMND = cMND;
            SDT = sDT;
            FAX = fAX;
            DiaChi = diaChi;
        }

        //public static bool CheckExistCustomerByTelNum(string telNumber)
        //{
        //    DataTable queryResult = KhachHangDAO.Instance.GetCustomerByTelNumber(telNumber);
        //    int count = queryResult.Rows.Count;
        //    if (count > 0) return true;
        //    else return false;
        //}

        public static KhachHang GetCustomerByTelNum(string telNumber)
        {
            DataTable data = KhachHangDAO.GetCustomerByTelNumber(telNumber);
            if (data.Rows.Count == 0) return null;
            KhachHang result = new KhachHang(data.Rows[0]);
            return result;
        }

        public static string GenerateNewCustomerID()
        {
            var lastId = KhachHangDAO.GetLastCustomerID();
            int newCustomerNumber = (Int32.Parse(lastId.Substring(2)) + 1);
            return newCustomerNumber < 100 ? $"KH0{newCustomerNumber}" : $"KH{newCustomerNumber}";
        }

        public static bool AddNewCustomer(KhachHang newCustomer)
        {
            return KhachHangDAO.Insert(newCustomer);
        }

        public static KhachHang laythongtinkhachhang(string makh)
        {
            return KhachHangDAO.THONGTINKHACHHANG(makh);
        }
        public static int updatethongtin(KhachHang kh)
        {
            return KhachHangDAO.Capnhatthongtin(kh);
        }

    }
}
