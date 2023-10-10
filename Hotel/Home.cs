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
    public partial class Home : Form
    {
        public static string btn;
        public Home()
        {
            InitializeComponent();
            callForm(new TinhTrangPhong());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            callForm(new fDatPhong());
        }
        void callForm(Form childForm)
        {
            if (activeform != null)
                activeform.Close();
            activeform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelCallForm.Controls.Add(childForm);
            panelCallForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private Form activeform = null;
        private Button currentButton;
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = ColorTranslator.FromHtml("#FFFFFF");
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(46, 51, 73);
                    
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            callForm(new TinhTrangPhong());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btn = "CHECKIN";
            ActivateButton(sender);
            callForm(new fCHECKIN());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btn = "CHECKOUT";
            ActivateButton(sender);
            callForm(new fCHECKIN());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }
    
}
