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
    public partial class TinhTrangPhong : Form
    {
        public TinhTrangPhong()
        {
            InitializeComponent();
            loadRoom();
        }
        public void loadRoom()
        {
            Room.Check_Status_Room();
            List<Room> list = Room.getListRoom();
            foreach (Room room in list)
            {
                Button btn = new Button { Width = 150, Height = 100 };
                switch (room.Trangthai)
                {
                    case "Trống":
                        btn.BackColor = Color.Gray;
                        break;
                    case "Đang sử dụng":
                        btn.BackColor = Color.Green;
                        break;
                }
                btn.Text = room.Maph+"\n"+room.Trangthai;
                switch (room.Dondep)
                {
                    case 0:
                        btn.Text += "\nChưa dọn dẹp";
                        break;
                    case 1:
                        btn.Text += "\nĐã dọn dẹp";
                        break;

                }
                pnlMain.Controls.Add(btn);
            }
        }
    }
}
