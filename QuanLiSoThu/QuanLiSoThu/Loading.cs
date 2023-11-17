using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSoThu
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
            timer1.Start();
        }

        int start = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            start += 1;
            MyProgress.Value = start;
            lbProgress.Text = start + "%";
            MyProgress.ForeColor = Color.Red; // Màu thanh chạy
            if (MyProgress.Value == 100)
            {
                MyProgress.Value = 0;
                timer1.Stop();
                this.Hide();
                Login lg = new Login();
                lg.ShowDialog();
            }
        }
    }
}
