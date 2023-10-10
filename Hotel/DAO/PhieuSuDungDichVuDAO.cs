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
    internal class PhieuSuDungDichVuDAO
    {
        public static List<PHIEUSUDUNGDICHVU> selectDVThuong(string mapdp)
        {
            List<PHIEUSUDUNGDICHVU> list = new List<PHIEUSUDUNGDICHVU>();
            string query = "select * " +
                           "from PHIEUSUDUNGDICHVU  " +
                           "where MAPDP = '"+mapdp+"'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                PHIEUSUDUNGDICHVU DVThuong = new PHIEUSUDUNGDICHVU(dr);
                list.Add(DVThuong);
            }
            return list;
        }
        public static String TienDVThuong(string mapdp)
        {
            string query = "select SUM(THANHTIEN) " +
                           "from  PHIEUSUDUNGDICHVU " +
                           "where MAPDP = '"+mapdp+"'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt.Rows[0][0].ToString();
        }
    }
}
