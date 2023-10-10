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
    internal class PhieuSuDungDichVuTourDAO
    {
        public static List<PHIEUSUDUNGDICHVUTOUR> selectDVTour(string mapdp)
        {
            List<PHIEUSUDUNGDICHVUTOUR> list = new List<PHIEUSUDUNGDICHVUTOUR>();
            string query = "select * " +
                           "from  PHIEUSUDUNGDICHVUTOUR " +
                           "where MAPDP = '"+mapdp+"'"; 
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dr in dt.Rows)
            {
                PHIEUSUDUNGDICHVUTOUR DVTour = new PHIEUSUDUNGDICHVUTOUR(dr);
                list.Add(DVTour);
            }
            return list;
        }
        public static String TienDVTour(string mapdp)
        {
            string query = "select SUM(THANHTIEN) " +
                           "from  PHIEUSUDUNGDICHVUTOUR " +
                           "where MAPDP = '" + mapdp + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt.Rows[0][0].ToString();
        }
    }
}
