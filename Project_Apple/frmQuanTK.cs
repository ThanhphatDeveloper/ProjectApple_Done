using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace Project_Apple
{
    public partial class frmQuanTK : Form
    {
        TaiKhoanBUS tkBUS = new TaiKhoanBUS();
        public frmQuanTK()
        {
            InitializeComponent();
        }

        

        private void btnTaotaikhoan_Click(object sender, EventArgs e)
        {
            frmTaoTK frm = new frmTaoTK();
            frm.ShowDialog();
        }

        public void LoadTK()
        {
            dgvDStaikhoan.AutoGenerateColumns = false;
            dgvDStaikhoan.DataSource = tkBUS.LayDSTK();
        }

        private void frmQuanTK_Load(object sender, EventArgs e)
        {
            LoadTK();
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            dgvDStaikhoan.AutoGenerateColumns = false;
            dgvDStaikhoan.DataSource = tkBUS.LayDSTKTheoTuKhoa(txtTimkiem.Text);
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
