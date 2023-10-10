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
    public partial class fCHECKIN : Form
    {
        public static string txtCMND;
        public static string txtEmail;
        public static string txtFax;
        public static string txtHochieu;
        public static string txtMAKH;
        public static string txtMAPHIEU;
        public static string txtSodem;
        public static string txtThanhtoantruoc;
        public static string txtHTTT;
        public static string txtYeucau;
        public fCHECKIN()
        {
            InitializeComponent();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtmadp.Text == "null")
            {
                MessageBox.Show("Bạn chưa chọn phiếu đặt phòng!");
            }
            else if(Home.btn == "CHECKIN")
            {
                fCHECKIN_THANHCONG form = new fCHECKIN_THANHCONG();
                form.ShowDialog();
            }
            else
            {
                fCHECKOUT_HOADON form2 = new fCHECKOUT_HOADON();
                form2.ShowDialog();
            } 
                
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fCHECKIN_Load(object sender, EventArgs e)
        {
            txtMAPHIEU = "";
            cbAttribute.Items.Clear();
            cbAttribute.Items.Add("Mã phiếu");
            cbAttribute.Items.Add("Họ tên");
            cbAttribute.Items.Add("CMND");
            cbAttribute.Items.Add("SĐT");
            cbAttribute.DropDownStyle = ComboBoxStyle.DropDownList;
            if (Home.btn == "CHECKOUT")
            {
                label4.Text = "DANH SÁCH ĐẶT PHÒNG ĐÃ CHECK IN";
                List<PHIEUDATPHONG> pdp_da = PhieuDatPhongDAO.DS_PDP_DACHECKIN();
                dgvPHIEUDATPHONG.DataSource = pdp_da;
                button3.Text = "CHECK OUT";
            }
            else if (Home.btn == "CHECKIN")
            {
                List<PHIEUDATPHONG> pdp = PhieuDatPhongDAO.DS_PDP_CHOCHECKIN();
                dgvPHIEUDATPHONG.DataSource = pdp;
            }
            int x = label4.Size.Width / 2;
            int y = label4.Size.Height;
            label4.Location = new Point(panel2.Size.Width / 2 - x, panel2.Size.Height - y);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvPHIEUDATPHONG.DataSource = PHIEUDATPHONG.FILTER_WITH_ATTRIBUTE(Home.btn,cbAttribute.Text,txtValue.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Home.btn == "CHECKOUT")
            {
                List<PHIEUDATPHONG> pdp_da = PhieuDatPhongDAO.DS_PDP_DACHECKIN();
                dgvPHIEUDATPHONG.DataSource = pdp_da;
            }
            else if (Home.btn == "CHECKIN")
            {
                List<PHIEUDATPHONG> pdp = PhieuDatPhongDAO.DS_PDP_CHOCHECKIN();
                dgvPHIEUDATPHONG.DataSource = pdp;
            }
            txtmadp.Text = "null";
            txtMAPHIEU = "";
    }

        private void dgvPHIEUDATPHONG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPHIEUDATPHONG.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvPHIEUDATPHONG.CurrentRow.Selected = true;
                txtmadp.Text = dgvPHIEUDATPHONG.Rows[e.RowIndex].Cells["MAPHIEUDP"].FormattedValue.ToString();
                txtMAPHIEU  = dgvPHIEUDATPHONG.Rows[e.RowIndex].Cells["MAPHIEUDP"].FormattedValue.ToString();
                txtCMND = dgvPHIEUDATPHONG.Rows[e.RowIndex].Cells["MAPHIEUDP"].FormattedValue.ToString();
                txtMAKH = dgvPHIEUDATPHONG.Rows[e.RowIndex].Cells["MAKHACHHANG"].FormattedValue.ToString(); 
                txtSodem = dgvPHIEUDATPHONG.Rows[e.RowIndex].Cells["SODEMDAT"].FormattedValue.ToString(); 
                txtThanhtoantruoc = dgvPHIEUDATPHONG.Rows[e.RowIndex].Cells["DATCOC"].FormattedValue.ToString(); 
                txtHTTT = dgvPHIEUDATPHONG.Rows[e.RowIndex].Cells["HINHTHUCTRA"].FormattedValue.ToString();
                txtYeucau = dgvPHIEUDATPHONG.Rows[e.RowIndex].Cells["GHICHUDB"].FormattedValue.ToString(); 
            }

        }
    }
}
