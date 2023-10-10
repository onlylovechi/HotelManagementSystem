namespace Hotel
{
    partial class fCHECKIN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            dgvPHIEUDATPHONG = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtmadp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAttribute = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dgvPHIEUDATPHONG)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1239, 954);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(dgvPHIEUDATPHONG);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(19, 250);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1200, 704);
            this.panel6.TabIndex = 4;
            // 
            // dgvPHIEUDATPHONG
            // 
            dgvPHIEUDATPHONG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvPHIEUDATPHONG.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dgvPHIEUDATPHONG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPHIEUDATPHONG.Dock = System.Windows.Forms.DockStyle.Fill;
            dgvPHIEUDATPHONG.Location = new System.Drawing.Point(0, 0);
            dgvPHIEUDATPHONG.Name = "dgvPHIEUDATPHONG";
            dgvPHIEUDATPHONG.ReadOnly = true;
            dgvPHIEUDATPHONG.RowHeadersVisible = false;
            dgvPHIEUDATPHONG.RowHeadersWidth = 62;
            dgvPHIEUDATPHONG.RowTemplate.Height = 28;
            dgvPHIEUDATPHONG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvPHIEUDATPHONG.Size = new System.Drawing.Size(1200, 704);
            dgvPHIEUDATPHONG.TabIndex = 0;
            dgvPHIEUDATPHONG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgvPHIEUDATPHONG_CellContentClick);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1219, 250);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(20, 704);
            this.panel5.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 250);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(19, 704);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtValue);
            this.panel3.Controls.Add(this.txtmadp);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cbAttribute);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 120);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1239, 130);
            this.panel3.TabIndex = 1;
            // 
            // txtValue
            // 
            this.txtValue.BackColor = System.Drawing.SystemColors.Info;
            this.txtValue.Location = new System.Drawing.Point(384, 31);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(194, 26);
            this.txtValue.TabIndex = 7;
            // 
            // txtmadp
            // 
            this.txtmadp.AutoSize = true;
            this.txtmadp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmadp.Location = new System.Drawing.Point(244, 88);
            this.txtmadp.Name = "txtmadp";
            this.txtmadp.Size = new System.Drawing.Size(42, 25);
            this.txtmadp.TabIndex = 6;
            this.txtmadp.Text = "null";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Phiếu đang được chọn:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(808, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 55);
            this.button3.TabIndex = 4;
            this.button3.Text = "CHECK IN";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Image = global::Hotel.Properties.Resources.refresh__1_;
            this.button2.Location = new System.Drawing.Point(641, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 38);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Image = global::Hotel.Properties.Resources.search__1_;
            this.button1.Location = new System.Drawing.Point(584, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 38);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm theo:";
            // 
            // cbAttribute
            // 
            this.cbAttribute.FormattingEnabled = true;
            this.cbAttribute.Location = new System.Drawing.Point(187, 29);
            this.cbAttribute.Name = "cbAttribute";
            this.cbAttribute.Size = new System.Drawing.Size(181, 28);
            this.cbAttribute.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1239, 120);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(292, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(689, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "DANH SÁCH PHIẾU ĐẶT PHÒNG CHỜ CHECK IN";
            // 
            // fCHECKIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1239, 954);
            this.Controls.Add(this.panel1);
            this.Name = "fCHECKIN";
            this.Text = "fCHECKIN";
            this.Load += new System.EventHandler(this.fCHECKIN_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(dgvPHIEUDATPHONG)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAttribute;
        private System.Windows.Forms.Label txtmadp;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label4;
        public static System.Windows.Forms.DataGridView dgvPHIEUDATPHONG;
    }
}