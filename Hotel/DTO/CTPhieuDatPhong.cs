using Hotel.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.DTO
{
    public class CTPhieuDatPhong
    {
        public string MaPDP { get; set; }
        public string MaPH { get; set; }

        public CTPhieuDatPhong(string maPDP, string maPH)
        {
            MaPDP = maPDP;
            MaPH = maPH;
        }
        public CTPhieuDatPhong(DataRow dr)
        {
            MaPDP = dr["MAPDP"].ToString();
            MaPH = dr["MAPH"].ToString();
        }


        public static bool Insert(CTPhieuDatPhong chitiet)
        {
            return CTPhieuDatPhongDAO.Insert(chitiet);
        }
        public static List<CTPhieuDatPhong> XemDanhSachPhongDat(string maphieu)
        {
            return CTPhieuDatPhongDAO.listPHONGDADAT(maphieu);
        }
    }
}
