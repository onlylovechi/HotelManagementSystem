using Hotel.DAO;
using Hotel.DTB;
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
    public partial class fDatPhong : Form
    {
        float tongTien;
        public fDatPhong()
        {
            InitializeComponent();
        }

        private void fDatPhong_Load(object sender, EventArgs e)
        {
            TxtHoTen.Select();
            listAvailableRooms.FullRowSelect = true;
            listSelectedRooms.FullRowSelect = true;
            TxtGhiChu.AutoSize = false;
            TxtGhiChu.Size = new System.Drawing.Size(257, 60);
            Room.Check_Status_Room();
        }

        private void FilterBtn_Click(object sender, EventArgs e)
        {
            listAvailableRooms.Items.Clear();
            listSelectedRooms.Items.Clear();

            var isNumeric = int.TryParse(TxtSoDem.Text, out int n);
            if (TxtSoDem.Text.Length > 0 && isNumeric)
            {
                ShowAvailableRooms(dateTimeNgayDen.Value, Int32.Parse(TxtSoDem.Text));
            }
        }

        private void ShowAvailableRooms(DateTime ngayden, int sodem)
        {
            List<PhongCT> RoomList = new List<PhongCT>();

            RoomList = PhongCT.GetAvailableRooms(ngayden, sodem);

            foreach (PhongCT p in RoomList)
            {
                ListViewItem item = new ListViewItem(p.MaPhong);
                item.SubItems.Add(p.LoaiPhong);
                item.SubItems.Add(p.DonGia.ToString());

                listAvailableRooms.Items.Add(item);
            }
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            if (listAvailableRooms.SelectedItems.Count > 0)
            {
                var selectedRoom = listAvailableRooms.SelectedItems[0];
                listAvailableRooms.Items.Remove(selectedRoom);
                listSelectedRooms.Items.Add(selectedRoom);
                updateTotalPrice();
            }
        }

        private void UnselectBtn_Click(object sender, EventArgs e)
        {
            if (listSelectedRooms.SelectedItems.Count > 0)
            {
                var selectedRoom = listSelectedRooms.SelectedItems[0];
                listSelectedRooms.Items.Remove(selectedRoom);
                listAvailableRooms.Items.Add(selectedRoom);
                updateTotalPrice();
            }
        }

        void updateTotalPrice()
        {
            float total = 0;
            if (listAvailableRooms.Items.Count > 0)
            {
                foreach (ListViewItem item in listSelectedRooms.Items)
                {
                    total += (float)Convert.ToDouble(item.SubItems[2].Text) * Int32.Parse(TxtSoDem.Text);
                }
            }
            txtTotal.Text = total.ToString();
            TxtTienTraTruoc.Text = ((int)(total * 30 / 100)).ToString();
        }

        private void DatPhongBtn_Click(object sender, EventArgs e)
        {
            if (TxtHoTen.Text.Length == 0) MessageBox.Show("Chưa nhập tên khách hàng!!!");
            if (TxtSDT.Text.Length == 0) MessageBox.Show("Chưa nhập số điện thoại khách hàng!!!");
            if (listSelectedRooms.Items.Count == 0) MessageBox.Show("Chưa chọn phòng cần đặt !!!");

            string MaKH = "";

            KhachHang kh = KhachHang.GetCustomerByTelNum(TxtSDT.Text);
            if (kh != null)
            {
                MaKH = kh.MaKH;
            }
            else
            {
                MaKH = KhachHang.GenerateNewCustomerID();
                KhachHang newCustomer = new KhachHang(MaKH, TxtHoTen.Text, TxtEmail.Text, TxtCMND.Text, TxtSDT.Text, TxtFax.Text, TxtDiaChi.Text);
                bool insertResult = KhachHang.AddNewCustomer(newCustomer);
                if (!insertResult) MessageBox.Show("Thêm khách hàng thất bại!!!");
            }

            string MaPDP = PhieuDatPhong.GenerateNewId();
            PhieuDatPhong PhieuDatPhongMoi = new PhieuDatPhong(MaKH, MaPDP, dateTimeNgayDen.Value, Int32.Parse(TxtSoDem.Text), TxtGhiChu.Text, (float)(Convert.ToDouble(TxtTienTraTruoc.Text)));

            bool ok = PhieuDatPhong.Insert(PhieuDatPhongMoi);

            foreach (ListViewItem item in listSelectedRooms.Items)
            {
                CTPhieuDatPhong.Insert(new CTPhieuDatPhong(MaPDP, item.Text));
            }
            if (ok) MessageBox.Show("Đặt phòng thành công!");
            else MessageBox.Show("ERROR!");
        }
        private void TxtSDT_Leave(object sender, EventArgs e)
        {
            KhachHang kh = null;
            if (TxtSDT.Text.Length > 0)
            {
                kh = KhachHang.GetCustomerByTelNum(TxtSDT.Text);
            }
            if (kh != null)
            {
                TxtHoTen.Text = kh.HoTen.ToString();
                TxtDiaChi.Text = kh.DiaChi.ToString();
                TxtEmail.Text = kh.Email.ToString();
                TxtCMND.Text = kh.CMND.ToString();
                TxtFax.Text = kh.FAX.ToString();
            }
        }
    }
}
