using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLiSoThu
{
    public partial class Login : Form
    {
        private List<Image> imagePaths;
        private int currentIndex = 0;
        private Timer timer;
        ProccessDatabase pd = new ProccessDatabase();
        public static string tenNV;
        public Login()
        {
            InitializeComponent();
            LoadImagePaths(); // Khởi tạo danh sách đường dẫn hình ảnh

            // Khởi tạo Timer
            timer = new Timer();
            timer.Interval = 3000; // Đặt khoảng thời gian giữa các frame (đơn vị là mili giây)
            timer.Tick += timer1_Tick;
            timer.Start();
        }

        private void LoadImagePaths()
        {
            imagePaths = new List<Image>
            {
                Properties.Resources.zoo,
                Properties.Resources.zoopet,
                Properties.Resources.pet
            };
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Nạp hình ảnh từ đường dẫn và thay đổi hình ảnh của PictureBox
            Zoopb.Image = imagePaths[currentIndex];

            // Di chuyển đến hình ảnh tiếp theo trong danh sách
            currentIndex = (currentIndex + 1) % imagePaths.Count;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            pd.KetNoi();

            string tenDN = txtTenDN.Text;
            string matKhau = txtMatKhau.Text;

            string query = "SELECT * FROM NhanVien WHERE TenDN = @TenDN AND MatKhau = @MatKhau";

            DataTable dt = pd.LayDuLieu(query, new SqlParameter("@TenDN", tenDN), new SqlParameter("@MatKhau", matKhau));

            // Kiểm tra kết quả truy vấn
            if (dt.Rows.Count > 0)
            {
                tenNV = dt.Rows[0]["TenNV"].ToString();
                
                // Đăng nhập thành công, chuyển đến Form1 và truyền tên nhân viên
                Form1 fm = new Form1();
                fm.ShowDialog();
                this.Close();
            }
            else
            {
                // Đăng nhập thất bại
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Thông báo");
            }
        }

    }
}
