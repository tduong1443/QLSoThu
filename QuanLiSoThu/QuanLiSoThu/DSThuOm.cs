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
    public partial class DSThuOm : Form
    {
        ProccessDatabase pd = new ProccessDatabase();
        public DSThuOm()
        {
            InitializeComponent();

            LoadDataToComboBox();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }

        private void Reset()
        {
            cbSuKien.Text = "";
        }

        private void DSThuOm_Load(object sender, EventArgs e)
        {
            Reset();
            this.reportViewer1.RefreshReport();
        }

        private void LoadDataToComboBox()
        {
            DataTable dtSK = pd.DocBang("SELECT * FROM SuKien");
            cbSuKien.DataSource = dtSK;
            cbSuKien.DisplayMember = "TenSK"; 
            cbSuKien.ValueMember = "MaSK";   
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
            //Application.Exit();
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

        private void DSThuOm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                FormBorderStyle = FormBorderStyle.None;
            else
                FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            this.dSThuTableAdapter.Fill(this.qLVuonThuDataSet2.DSThu, cbSuKien.Text);

            this.reportViewer1.RefreshReport();
        }
    }
}
