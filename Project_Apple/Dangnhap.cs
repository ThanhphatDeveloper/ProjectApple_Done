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
using DTO;
namespace Project_Apple
{
    public partial class frmDangnhap : Form
    {
        TaiKhoanBUS tkBUS = new TaiKhoanBUS();
        Thongbao mess = new Thongbao();
        public frmDangnhap()
        {
            InitializeComponent();
        }

        private void picThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsSymbol(e.KeyChar) || (e.KeyChar == (char)Keys.Space);
        }

        private void frmDangnhap_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show(mess.loginInputError, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            TaiKhoanDTO tkDTO = new TaiKhoanDTO();
            tkDTO.TenTaiKhoan = txtUser.Text;
            if (tkDTO.TenTaiKhoan == "admin")
            {
                tkDTO.MatKhau = txtPassword.Text;
            }
            else
            {
                tkDTO.MatKhau = Mahoamatkhau.Encrypt(txtPassword.Text);
            }
            TaiKhoanDTO result = tkBUS.checkQuyen(tkDTO);
            TaiKhoanDTO KQ = tkBUS.SetTrangThaiTK(tkDTO);

            string TenQuyen = null;

            if (KQ.TrangThai == false)
            {

                MessageBox.Show(mess.loginDataError, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!string.IsNullOrEmpty(result.TenTaiKhoan))
            {
                TenQuyen = result.TenQuyen;
                Dulieudangnhap.quyen = TenQuyen;
                Dulieudangnhap.tenTK = txtUser.Text;
                frmQuanLy frm = new frmQuanLy();
                frm.Show();
                Dulieudangnhap.formQuanLy = frm;
                this.Hide();
            }
            else
            {
                MessageBox.Show(mess.loginDataError, "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = null;
            }
        }
    }
}
