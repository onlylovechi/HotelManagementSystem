using Hotel.DAO;
using Hotel.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class fCHECKIN_THANHCONG : Form
    {
        public fCHECKIN_THANHCONG()
        {
            InitializeComponent();
        }

        private void fCHECKIN_THANHCONG_Load(object sender, EventArgs e)
        {
            KhachHang kh = KhachHang.laythongtinkhachhang(fCHECKIN.txtMAKH);
            List<CTPhieuDatPhong> list = CTPhieuDatPhong.XemDanhSachPhongDat(fCHECKIN.txtMAPHIEU);
            txtMaPhieu.Text = fCHECKIN.txtMAPHIEU;
            txtCMND.Text = kh.CMND;
            txtEmail.Text = kh.Email;
            txtFax.Text = kh.FAX;
            txtSdt.Text = kh.SDT;
            txtMaKH.Text = kh.MaKH;
            txtHoTen.Text = kh.HoTen;
            txtSodem.Text = fCHECKIN.txtSodem;
            txtYCDB.Text = fCHECKIN.txtYeucau;
            txtDatcoc.Text = fCHECKIN.txtThanhtoantruoc;
            dgvDSPHONG.DataSource = list;
            cbHTTT.Items.Clear();
            cbHTTT.Items.Add("Tiền mặt");
            cbHTTT.Items.Add("Thẻ tín dụng");
            cbHTTT.DropDownStyle = ComboBoxStyle.DropDownList;
            cbHTTT.Text = fCHECKIN.txtHTTT;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            KhachHang kh = KhachHang.laythongtinkhachhang(fCHECKIN.txtMAKH);
            kh.HoTen = txtHoTen.Text;
            kh.SDT = txtSdt.Text;
            kh.CMND = txtCMND.Text;
            kh.Email = txtEmail.Text;
            kh.FAX = txtFax.Text;
            
            if (txtDatcoc.Text != null || cbHTTT.Text != null)
            {
                string tiencoc; 
                if (txtDatcoc.Text == "") tiencoc = "0";
                else tiencoc = txtDatcoc.Text;
                PHIEUDATPHONG pdp = new PHIEUDATPHONG(txtMaPhieu.Text, txtYCDB.Text, tiencoc, cbHTTT.Text, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                if (PHIEUDATPHONG.checkin(pdp) == 1 || KhachHang.updatethongtin(kh) == 1)
                {
                    List<CTPhieuDatPhong> listphong = CTPhieuDatPhong.XemDanhSachPhongDat(fCHECKIN.txtMAPHIEU);
                    foreach (CTPhieuDatPhong phong in listphong)
                    {
                        Room.Update_Using_Room("Được sử dụng",phong.MaPH);
                    }
                    MessageBox.Show("Check in thành công!");
                    List<PHIEUDATPHONG> list = PhieuDatPhongDAO.DS_PDP_CHOCHECKIN();
                    fCHECKIN.dgvPHIEUDATPHONG.DataSource = list;
                }
                this.Dispose();


            }
            else  MessageBox.Show("Bạn chưa nhập số tiền thanh toán/chưa chọn hình thức thanh toán!"); 
                

        }

        private void dgvDSPHONG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
