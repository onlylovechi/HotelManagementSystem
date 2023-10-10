using Hotel.DTB;
using Hotel.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Hotel.DAO
{
    public class KhachHangDAO
    {
        //public bool CheckExistCustomerByTelNum(string telNumber)
        //{
        //    string query = $"select * from KHACHHANG where SDT = {telNumber}";
        //    int count = DataProvider.Instance.ExecuteQuery(query).Rows.Count;
        //    if (count > 0) return true;
        //    else return false;
        //}

        public static DataTable GetCustomerByTelNumber(string telNumber)
        {
            string query = $"select * from KHACHHANG where SDT = {telNumber}";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result;
        }

        //public string GetIdByTelNumber(string telNumber)
        //{
        //    string query = $"select MaKH from KHACHHANG where SDT = {telNumber}";
        //    DataTable data = DataProvider.Instance.ExecuteQuery(query);
        //    return data.Rows[0].Field<string>("MaKH");
        //}

        public static string GetLastCustomerID()
        {
            string query = "select MaKH from KHACHHANG";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            var lastIndex = data.Rows.Count - 1;
            return data.Rows[lastIndex].Field<string>("MaKH");
        }

        public static bool Insert(KhachHang kh)
        {
            string query = $"INSERT INTO KHACHHANG(MAKH, HOTEN, EMAIL, CMND, SDT, FAX, DIACHI) VALUES('{kh.MaKH}', N'{kh.HoTen}', '{kh.Email}', '{kh.CMND}', '{kh.SDT}', '{kh.FAX}', N'{kh.DiaChi}')";
            var count = DataProvider.Instance.ExecuteNonQuery(query);
            if (count > 0) return true;
            else return false;
        }
	 public static DataRow selectIfKH(string makh)
        {
            String query = "select * from KHACHHANG where MAKH = '"+makh+"'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt.Rows[0];
        }
        public static KhachHang THONGTINKHACHHANG(string makh)
        {
            String query = "select * from KHACHHANG where MAKH = '"+makh+"'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            KhachHang kh = new KhachHang(dt.Rows[0]);
            return kh;
        }
        public static int Capnhatthongtin(KhachHang kh)
        {
            string query = "update khachhang set hoten = N'"+kh.HoTen+ "', Email = '"+kh.Email+ "', CMND = '"+kh.CMND+ "', SDT = '"+kh.SDT+"', FAX ='"+kh.FAX+"'  where makh = '" + kh.MaKH + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result;
        }
    }
}
