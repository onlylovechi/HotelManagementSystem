using Hotel.DTB;
using Hotel.DTO;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.DAO
{
    public class PhieuDatPhongDAO
    {
        public static List<PHIEUDATPHONG> DS_PDP_CHOCHECKIN()
        {
            List<PHIEUDATPHONG> list = new List<PHIEUDATPHONG>();
            String query = "select * from phieudatphong pdp,khachhang kh where pdp.ngaycheckin is null and kh.makh = pdp.nguoidat";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                PHIEUDATPHONG pdp = new PHIEUDATPHONG(dr);
                list.Add(pdp);
            }    
            return list;
        }
        public static List<PHIEUDATPHONG> DS_PDP_DACHECKIN()
        {
            List<PHIEUDATPHONG> list = new List<PHIEUDATPHONG>();
            String query = "select * from phieudatphong pdp,khachhang kh where pdp.ngaycheckin is not null and kh.makh = pdp.nguoidat and pdp.mapdp not in (select mapdp from hoadon)";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                PHIEUDATPHONG pdp = new PHIEUDATPHONG(dr);
                list.Add(pdp);
            }
            return list;
        }
        public static List<PHIEUDATPHONG> listpdp()
        {
            List<PHIEUDATPHONG> list = new List<PHIEUDATPHONG>();
            String query = "select * from phieudatphong pdp,khachhang kh where kh.makh = pdp.nguoidat ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                PHIEUDATPHONG pdp = new PHIEUDATPHONG(dr);
                list.Add(pdp);
            }
            return list;
        }
        public static string GetLastId()
        {
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery("select MAPDP from PHIEUDATPHONG");
            return data.Rows[data.Rows.Count - 1]["MaPDP"].ToString();
        }
        public static int Update_Used_Room(string tinhtrang, string maph)
        {
            string query;
            if (tinhtrang == "Được sử dụng") query = "update PHONG set TRANGTHAI=N'Đang sử dụng' where MAPH='" + maph + "'";
            else query = "update PHONG set TRANGTHAI=N'Trống' where MAPH='" + maph + "'";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
        public static String TienPhong(string mapdp)
        {
            string query = "select SUM(LOAIPHONG.DONGIA*PHIEUDATPHONG.SODEMLUUTRU) " +
                            "from  PHIEUDATPHONG,CHITIETDATPHONG, PHONG, LOAIPHONG " +
                            "where PHIEUDATPHONG.MAPDP = '"+mapdp+"' and PHIEUDATPHONG.MAPDP = CHITIETDATPHONG.MAPDP " +
                            "and CHITIETDATPHONG.MAPH = PHONG.MAPH and PHONG.LOAIPH = LOAIPHONG.MALP";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt.Rows[0][0].ToString();
        }

        public static bool Insert(PhieuDatPhong phieudp)
        {
            string query = $"INSERT INTO PHIEUDATPHONG (MAPDP, NGAYDAT, NGAYDEN, SODEMLUUTRU, GHICHU, TIENDATCOC, NGUOIDAT, NGAYCHECKIN)\r\nVALUES ('{phieudp.MaDatPhong}', '{phieudp.NgayDat.ToShortDateString()}', '{phieudp.NgayDen.ToShortDateString()}', {phieudp.SoDemLT}, N'{phieudp.GhiChu}', {phieudp.TienDaTra}, '{phieudp.MaKH}', NULL)";
            MessageBox.Show(query);
            var count = DataProvider.Instance.ExecuteNonQuery(query);
            if (count > 0) return true;
            else return false;
        }
        public static String TienCoc(string mapdp)
        {
            string query = "select TIENDATCOC " +
                            "from  PHIEUDATPHONG " +
                            "where MAPDP = '"+mapdp+"'  ";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt.Rows[0][0].ToString();
        }
        public static int ghinhancheckin(PHIEUDATPHONG pdp)
        {
            string query = "update phieudatphong set GHICHU = N'" + pdp.GHICHUDB + "', TIENDATCOC = " + pdp.DATCOC + ", HTTHANHTOAN=N'" + pdp.HINHTHUCTRA + "', NGAYCHECKIN = '" + pdp.NGAYCHECK_IN + "' where mapdp='" + pdp.MAPHIEUDP + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result;
        }
        public static List<PHIEUDATPHONG> FILTER_BY_MAPHIEU(string loai,string value)
        {
            string query;
            if (loai =="CHECKIN") query = "select * from phieudatphong pdp,khachhang kh where pdp.ngaycheckin is null and kh.makh = pdp.nguoidat and pdp.MAPDP LIKE '%" + value+"%' and pdp.mapdp not in (select mapdp from hoadon)";
            else query = "select * from phieudatphong pdp,khachhang kh where pdp.ngaycheckin is not null and kh.makh = pdp.nguoidat and pdp.MAPDP LIKE '%" + value + "%' and pdp.mapdp not in (select mapdp from hoadon)";
            List<PHIEUDATPHONG> list = new List<PHIEUDATPHONG>();
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                PHIEUDATPHONG pdp = new PHIEUDATPHONG(dr);
                list.Add(pdp);
            }
            return list;
        }
        public static List<PHIEUDATPHONG> FILTER_BY_HOTEN(string loai, string value)
        {
            string query;
            if (loai == "CHECKIN") query = "select * from phieudatphong pdp,khachhang kh where pdp.ngaycheckin is null and kh.makh = pdp.nguoidat and kh.HOTEN LIKE N'%" + value + "%'  and pdp.mapdp not in (select mapdp from hoadon)";
            else query = "select * from phieudatphong pdp,khachhang kh where pdp.ngaycheckin is not null and kh.makh = pdp.nguoidat and kh.HOTEN LIKE N'%" + value + "%'  and pdp.mapdp not in (select mapdp from hoadon)";
            List<PHIEUDATPHONG> list = new List<PHIEUDATPHONG>();
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                PHIEUDATPHONG pdp = new PHIEUDATPHONG(dr);
                list.Add(pdp);
            }
            return list;
        }
        public static List<PHIEUDATPHONG> FILTER_BY_CMND(string loai, string value)
        {
            string query;
            if (loai == "CHECKIN") query = "select * from phieudatphong pdp,khachhang kh where pdp.ngaycheckin is null and kh.makh = pdp.nguoidat and  kh.CMND LIKE '%" + value + "%'  and pdp.mapdp not in (select mapdp from hoadon)";
            else query = "select * from phieudatphong pdp,khachhang kh where pdp.ngaycheckin is not null and kh.makh = pdp.nguoidat and  kh.CMND LIKE '%" + value + "%'  and pdp.mapdp not in (select mapdp from hoadon)";
            List<PHIEUDATPHONG> list = new List<PHIEUDATPHONG>();
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                PHIEUDATPHONG pdp = new PHIEUDATPHONG(dr);
                list.Add(pdp);
            }
            return list;
        }
        public static List<PHIEUDATPHONG> FILTER_BY_SDT(string loai, string value)
        {
            string query;
            if (loai == "CHECKIN") query = "select * from phieudatphong pdp,khachhang kh where pdp.ngaycheckin is null and kh.makh = pdp.nguoidat and kh.SDT LIKE '%" + value + "%' and pdp.mapdp not in (select mapdp from hoadon)";
            else query = "select * from phieudatphong pdp,khachhang kh where pdp.ngaycheckin is not null and kh.makh = pdp.nguoidat and kh.SDT LIKE '%" + value + "%' and pdp.mapdp not in (select mapdp from hoadon)";
            List<PHIEUDATPHONG> list = new List<PHIEUDATPHONG>();
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                PHIEUDATPHONG pdp = new PHIEUDATPHONG(dr);
                list.Add(pdp);
            }
            return list;
        }
    }
}
