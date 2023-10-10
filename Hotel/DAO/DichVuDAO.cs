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
    internal class DichVuDAO
    {
        public static List<DICHVU> listMiniBar()
        {
            List<DICHVU> list = new List<DICHVU>();
            string query = "select DICHVU.MADV,DICHVU.TENDV,DICHVU.THONGTIN,DICHVU.DONGIA " +
                "from PHIEUDATPHONG, KHACHHANG, PHIEUSUDUNGDICHVU, DICHVU " +
                "where MAKH = 'KH001' and KHACHHANG.MAKH = PHIEUDATPHONG.NGUOIDAT " +
                "and PHIEUDATPHONG.MAPDP = PHIEUSUDUNGDICHVU.MAPDP and PHIEUSUDUNGDICHVU.MADV = DICHVU.MADV"; 
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                DICHVU minibar = new DICHVU(dr);
                list.Add(minibar);
            }
            return list;
        }
        public static String TienMiniBar()
        {
            string query = "select SUM(DONGIA) AS TongTienMiniBar " +
                            "from PHIEUDATPHONG, KHACHHANG, PHIEUSUDUNGDICHVU, DICHVU " +
                            "where MAKH = 'KH001' and KHACHHANG.MAKH = PHIEUDATPHONG.NGUOIDAT and PHIEUDATPHONG.MAPDP = PHIEUSUDUNGDICHVU.MAPDP " +
                            "and PHIEUSUDUNGDICHVU.MADV = DICHVU.MADV;";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt.Rows[0][0].ToString();
        }

    }
}
