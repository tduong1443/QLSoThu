using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSoThu
{
    public partial class BaoCaoDSLoaiSD : Form
    {
        ProccessDatabase pd = new ProccessDatabase();
        public BaoCaoDSLoaiSD()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            LoadDataToComboBox();
        }

        private void BaoCaoDSLoaiSD_Load(object sender, EventArgs e)
        {
            Reset();
            this.reportViewer1.RefreshReport();
        }
        private void Reset()
        {
            cbSachDo.Text = cbLoai.Text = "";
        }

        private void LoadDataToComboBox()
        {
            // Lấy dữ liệu từ cơ sở dữ liệu cho ComboBox
            DataTable dtLoai = pd.DocBang("SELECT * FROM Loai");
            // Gán nguồn dữ liệu cho ComboBox
            cbLoai.DataSource = dtLoai;
            cbLoai.DisplayMember = "TenLoai"; // Hiển thị tên loài
            cbLoai.ValueMember = "MaLoai";    // Giữ giá trị mã loài
        }

        private void cbSachDo_DropDown(object sender, EventArgs e)
        {
            cbSachDo.Items.Clear();
            cbSachDo.Items.Add("Có trong sách đỏ");
            cbSachDo.Items.Add("Không trong sách đỏ");
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            this.dSTheoLoaiORSachDoTableAdapter.Fill(this.qLVuonThuDataSet1.DSTheoLoaiORSachDo, cbLoai.Text, cbSachDo.Text);
            this.reportViewer1.RefreshReport();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void brnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BaoCaoDSLoaiSD_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }
    }
}
