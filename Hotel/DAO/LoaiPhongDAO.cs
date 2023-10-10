using Hotel.DTB;
using Hotel.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DAO
{
    internal class LoaiPhongDAO
    {
        public static List<LOAIPHONG> InfoRoom()
        {
            List<LOAIPHONG> list = new List<LOAIPHONG>();
            string query = "select LOAIPHONG.MALP, LOAIPHONG.THONGTIN,LOAIPHONG.SONGUOI, LOAIPHONG.DONGIA " +
                            "from KHACHHANG, PHIEUDATPHONG, CHITIETDATPHONG, PHONG, LOAIPHONG " +
                            "where  KHACHHANG.MAKH = 'KH001' and KHACHHANG.MAKH = PHIEUDATPHONG.NGUOIDAT " +
                            "and PHIEUDATPHONG.MAPDP = CHITIETDATPHONG.MAPDP  and CHITIETDATPHONG.MAPH = PHONG.MAPH and PHONG.LOAIPH = LOAIPHONG.MALP;";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                LOAIPHONG infRoom = new LOAIPHONG(dr);
                list.Add(infRoom);
            }
            return list;
        }
    }
}
