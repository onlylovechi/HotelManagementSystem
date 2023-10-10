using Hotel.DTB;
using Hotel.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.DAO
{
    public class PhongCTDAO
    {
        public static DataTable GetById(string id)
        {
            string query = "Select p.MaPH phong, lp.thongtin loaiphong, lp.DONGIA dongia from PHONG p, LOAIPHONG lp where p.LOAIPH = lp.MALP and p.MAPH = \'"+id+"\'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public static DataTable GetAvailableRooms(DateTime ngayden, int sodem)
        {
            string checkinDate = ngayden.ToShortDateString();
            string checkoutDate = ngayden.AddDays(sodem).ToShortDateString();

            string query = "select MaPH \r\n" +
                "from PHONG where TRANGTHAI=N'Trống' \r\n" +
                "except\r\n" +
                "(select MaPH from CHITIETDATPHONG where MAPDP in\r\n" +
                "(select booked.MAPDP \r\n" +
                "from (select MaPDP, NGAYDEN, DATEADD(DAY, SODEMLUUTRU, NGAYDEN) as NgayDi from phieudatphong  ) booked\r\n" +
                $"where (booked.NGAYDEN >= '{checkinDate}' and booked.NGAYDEN <= '{checkoutDate}') OR (booked.NGAYDI >= '{checkinDate}' and booked.NGAYDI <= '{checkoutDate}') OR (booked.NGAYDEN <= '{checkinDate}' and booked.NGAYDI >= '{checkoutDate}') ))";
            return DataProvider.Instance.ExecuteQuery(query);   
        } 
    }
}
