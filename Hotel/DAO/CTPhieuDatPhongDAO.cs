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
    public class CTPhieuDatPhongDAO
    {
        public static bool Insert(CTPhieuDatPhong chitiet)
        {
            int result = DataProvider.Instance.ExecuteNonQuery($"INSERT INTO CHITIETDATPHONG (MAPDP, MAPH) VALUES ('{chitiet.MaPDP}', '{chitiet.MaPH}');");
            return result > 0;        
        }
        public static List<CTPhieuDatPhong> listPHONGDADAT(string maphieu)
        {
            List<CTPhieuDatPhong> list = new List<CTPhieuDatPhong>();
            string query = "select * from CHITIETDATPHONG where mapdp = '" + maphieu + "'";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            foreach( DataRow dr in dataTable.Rows)
            {
                CTPhieuDatPhong chitiet = new CTPhieuDatPhong(dr);
                list.Add(chitiet);
            }    
            return list;
        }
    }
}
