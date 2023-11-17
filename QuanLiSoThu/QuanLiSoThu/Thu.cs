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
    public partial class Thu : Form
    {
        ProccessDatabase db = new ProccessDatabase();
        public Thu()
        {
            InitializeComponent();
        }

        private void Thu_Load(object sender, EventArgs e)
        {
            dgvThu.DataSource = db.DocBang("Select * From Thu");
        }
    }

}
