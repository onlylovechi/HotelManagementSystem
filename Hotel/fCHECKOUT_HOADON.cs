using Hotel.DAO;
using Hotel.DTB;
using Hotel.DTO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class fCHECKOUT_HOADON : Form
    {
        private String maPDP;
        private String thanhTien;
        public fCHECKOUT_HOADON()
        {
            InitializeComponent();
            loadIfKH();
            loadListRoom();
            loadListDVThuong();
            loadListDVTour();
            loadTongTien();
        }

        private void lbTitlePhong_Click(object sender, EventArgs e)
        {

        }

        private void lBTitle_Click(object sender, EventArgs e)
        {

        }
        void loadIfKH()
        {
            int x = lBTitle.Size.Width / 2;
            int y = lBTitle.Size.Height/2;
            KhachHang kh = KhachHang.laythongtinkhachhang(fCHECKIN.txtMAKH);
            lBTitle.Location = new Point(panel22.Size.Width / 2 - x, panel22.Size.Height / 2 - y);
            lbGetName.Text = kh.HoTen;
            lbGetCMND.Text = kh.CMND;
            lbGetSDT.Text = kh.SDT;
        }
        void loadListRoom()
        {
            int x = lbTitlePhong.Size.Width / 2;
            int y = lbTitlePhong.Size.Height / 2;
            lbTitlePhong.Location = new Point(panel3.Size.Width / 2 - x, panel3.Size.Height / 2 - y);
            List<CTPhieuDatPhong> list = CTPhieuDatPhong.XemDanhSachPhongDat(fCHECKIN.txtMAPHIEU);
            DGV_ListRoom.DataSource = list;

        }

        void loadListDVThuong()
        {
            int x = lb_TitleDVThuong.Size.Width / 2;
            int y = lb_TitleDVThuong.Size.Height/2;
            lb_TitleDVThuong.Location = new Point(panel4.Size.Width / 2 - x, panel4.Size.Height / 2 - y);
            List<PHIEUSUDUNGDICHVU> DVThuong = PhieuSuDungDichVuDAO.selectDVThuong(fCHECKIN.txtMAPHIEU);
            DGV_DVThuong.DataSource = DVThuong;
        }
        void loadListDVTour()
        {
            int x = lb_TitleDVTour.Size.Width / 2;
            int y = lb_TitleDVTour.Size.Height / 2;
            lb_TitleDVTour.Location = new Point(panel12.Size.Width / 2 - x, panel12.Size.Height / 2 - y);
            List<PHIEUSUDUNGDICHVUTOUR> DVTour = PhieuSuDungDichVuTourDAO.selectDVTour(fCHECKIN.txtMAPHIEU);
            DGV_DVTour.DataSource = DVTour;
        }


        void loadTongTien()
        {
            int x = lbTitleTongTien.Size.Width / 2;
            int y = lbTitleTongTien.Size.Height/2;
            lbTitleTongTien.Location = new Point(panel23.Size.Width / 2 - x, panel23.Size.Height / 2 - y);
            int TienDVThuong = Convert.ToInt32(loadTienDVThuong()); 
            int TienDVTour = Convert.ToInt32(loadTienDVTour());
            int TienPhong = Convert.ToInt32(loadTienPhong());
            int TienCoc = Convert.ToInt32(loadTienCoc());
             
            lbGetTongTien.Text = (TienPhong + TienDVThuong + TienDVTour - TienCoc).ToString();
            thanhTien = lbGetTongTien.Text;
        }

        String loadTienDVThuong()
        {

            DataProvider provider = new DataProvider();
            DataTable dt = new DataTable();
            string tienDVThuong = PhieuSuDungDichVuDAO.TienDVThuong(fCHECKIN.txtMAPHIEU);
            if (tienDVThuong == "") tienDVThuong = "0";
            lbGetTienDVThuong.Text = tienDVThuong;
            return tienDVThuong;
        }
        String loadTienDVTour()
        {
            DataProvider provider = new DataProvider();
            DataTable dt = new DataTable();
            string tienDVTour = PhieuSuDungDichVuTourDAO.TienDVTour(fCHECKIN.txtMAPHIEU);
            if (tienDVTour == "") tienDVTour = "0";
            lbGetTienDVTour.Text = tienDVTour;
            return tienDVTour;
        }



        String loadTienPhong()
        {
            DataProvider provider = new DataProvider();
            DataTable dt = new DataTable();
            string TienPhong = PhieuDatPhongDAO.TienPhong(fCHECKIN.txtMAPHIEU);
            if (TienPhong == "") TienPhong = "0";
            lbGetTienPhong.Text = TienPhong;
            return TienPhong;
        }
        String loadTienCoc()
        {
            DataProvider provider = new DataProvider();
            DataTable dt = new DataTable();
            string TienCoc = PhieuDatPhongDAO.TienCoc(fCHECKIN.txtMAPHIEU);
            if (TienCoc == "") TienCoc = "0";
            lbGetTienCoc.Text = TienCoc;
            return TienCoc;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //Document doc = new Document(iTextSharp.text.PageSize.A4, 10, 10, 10, 10);
            //PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream("../../HoaDon/Create.pdf", FileMode.Create));
            //doc.Open();     
            //System.Drawing.Bitmap bm = new System.Drawing.Bitmap(this.Width, this.Height);
            //iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(bm, System.Drawing.Imaging.ImageFormat.Bmp);
            //img.ScaleAbsoluteWidth(500f);
            //img.ScaleAbsoluteHeight(800f);
            //doc.Add(img);
            //doc.Close();
            //MessageBox.Show("In hoa don thanh cong");

            using (Bitmap b = new Bitmap(this.Width, this.Height))
            {
                using (Graphics g = Graphics.FromImage(b))
                {
                    g.CopyFromScreen(this.Location, new Point(0, 0), this.Size);
                }
                Document doc = new Document();
                iTextSharp.text.Image i = iTextSharp.text.Image.GetInstance(b, System.Drawing.Imaging.ImageFormat.Bmp);
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream("../../HoaDon/create.pdf", FileMode.Create));
                doc.SetPageSize(new iTextSharp.text.Rectangle(this.Size.Width + doc.LeftMargin + doc.RightMargin+10, this.Size.Height + doc.TopMargin + doc.BottomMargin+10));

                doc.Open();

                doc.Add(i);
                doc.Close();
                MessageBox.Show("In hoa don thanh cong");
            }
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            String mahd = HoaDon.GenerateNewId();
            HoaDon hd = new HoaDon(mahd, fCHECKIN.txtMAPHIEU, thanhTien, "NV001");
            if (HoaDon.taoHoaDon(hd))
            {
                MessageBox.Show("Thanh toan thanh cong");
                List<CTPhieuDatPhong> listphong = CTPhieuDatPhong.XemDanhSachPhongDat(fCHECKIN.txtMAPHIEU);
                foreach (CTPhieuDatPhong phong in listphong)
                {
                    Room.Update_Using_Room("Trống", phong.MaPH);
                }
                List<PHIEUDATPHONG> list = PhieuDatPhongDAO.DS_PDP_DACHECKIN();
                fCHECKIN.dgvPHIEUDATPHONG.DataSource = list;
            }
        }
    }
}
