using Hotel.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DTO
{
    public class PHIEUDATPHONG
    {
        private string MAPDP;
        private string NGAYDAT;
        private string NGAYDEN;
        private string SODEMLUUTRU;
        private string GHICHU;
        private string TIENDATCOC;
        private string NGUOIDAT;
        private string HTTHANHTOAN;
        private string MANGUOILAP;
        private string NGAYCHECKIN;
        private string MaKH;
        private string HoTen;
        private string Email;
        private string CMND;
        private string SDT;
        private string FAX;
        private string DiaChi;

        public string MAPHIEUDP { get => MAPDP; set => MAPDP = value; }
        public string NGAYDATPHONG { get => NGAYDAT; set => NGAYDAT = value; }
        public string NGAYDENNHAN { get => NGAYDEN; set => NGAYDEN = value; }
        public string GHICHUDB { get => GHICHU; set => GHICHU = value; }
        public string DATCOC { get => TIENDATCOC; set => TIENDATCOC = value; }
        public string MAKHACHHANG { get => NGUOIDAT; set => NGUOIDAT = value; }
        public string HINHTHUCTRA { get => HTTHANHTOAN; set => HTTHANHTOAN = value; }
        public string MANVLAPPHIEU { get => MANGUOILAP; set => MANGUOILAP = value; }
        public string NGAYCHECK_IN { get => NGAYCHECKIN; set => NGAYCHECKIN = value; }
        public string SODEMDAT { get => SODEMLUUTRU; set => SODEMLUUTRU = value; }
        public string MaKH1 { get => MaKH; set => MaKH = value; }
        public string HoTen1 { get => HoTen; set => HoTen = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string CMND1 { get => CMND; set => CMND = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
        public string FAX1 { get => FAX; set => FAX = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }

        public PHIEUDATPHONG(DataRow row)
        {
            this.MAPDP = (string)row["MAPDP"].ToString();
            this.NGAYDAT = row["NGAYDAT"].ToString();
            this.NGAYDEN = row["NGAYDEN"].ToString();
            this.SODEMLUUTRU = row["SODEMLUUTRU"].ToString();
            this.GHICHU = (string)row["GHICHU"].ToString();
            this.TIENDATCOC = row["TIENDATCOC"].ToString();
            this.NGUOIDAT = (string)row["NGUOIDAT"].ToString();
            this.HTTHANHTOAN = (string)row["HTTHANHTOAN"].ToString();
            this.MANGUOILAP = (string)row["MANGUOILAP"].ToString();
            this.NGAYCHECKIN = row["NGAYCHECKIN"].ToString();
            MaKH1 = row["MaKH"].ToString();
            HoTen1 = row["HOTEN"].ToString();
            Email1 = row["EMAIL"].ToString();
            CMND1 = row["CMND"].ToString();
            SDT1 = row["SDT"].ToString();
            FAX1 = row["FAX"].ToString();
            DiaChi1 = row["DIACHI"].ToString();
        }

        public PHIEUDATPHONG(string MAPDP, string GHICHU, string TIENDATCOC, string HTTHANHTOAN, string NGAYCHECKIN)
        {
            this.MAPDP = MAPDP;
            this.GHICHU = GHICHU;
            this.TIENDATCOC = TIENDATCOC;
            this.HTTHANHTOAN = HTTHANHTOAN;
            this.NGAYCHECKIN = NGAYCHECKIN;
        }
        public static int checkin(PHIEUDATPHONG pdp)
        {
            return PhieuDatPhongDAO.ghinhancheckin(pdp);
        }
        public static List<PHIEUDATPHONG> FILTER_WITH_ATTRIBUTE(string loai, string attribute, string value)
        {
            List<PHIEUDATPHONG> list = new List<PHIEUDATPHONG>();
            
            switch (attribute)
            {
                case "Mã phiếu":
                    list = PhieuDatPhongDAO.FILTER_BY_MAPHIEU(loai,value);
                    break;
                case "Họ tên":
                    list = PhieuDatPhongDAO.FILTER_BY_HOTEN(loai,value);
                    break;
                case "CMND":
                    list = PhieuDatPhongDAO.FILTER_BY_CMND(loai,value);
                    break;
                case "SĐT":
                    list = PhieuDatPhongDAO.FILTER_BY_SDT(loai,value);
                    break;

            }
            return list;
        }
        public static List<PHIEUDATPHONG> LISTPHIEUDATPHONG()
        {
            return PhieuDatPhongDAO.listpdp();
        }
    }
}
