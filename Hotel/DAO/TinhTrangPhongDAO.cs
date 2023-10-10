using Hotel.DTB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.DAO
{
    internal class TinhTrangPhongDAO
    {
        public static DataTable get_Room_inf()
        {
            string query = "SELECT MAPH,TRANGTHAI,LOAIPH,DONDEP FROM PHONG";
            DataTable result = null;

            try
            {
                result = DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return result;
        }
    }
}
