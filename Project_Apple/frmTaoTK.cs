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
    public partial class frmTaoTK : Form
    {
        NhanVienBUS nvBus = new NhanVienBUS();
        PhanQuyenBUS quyenBus = new PhanQuyenBUS();
        TaiKhoanBUS tkBUS = new TaiKhoanBUS();
        ChucVuBUS cvBUS = new ChucVuBUS();
        //...
        Thongbao mess = new Thongbao();
        public frmTaoTK()
        {
            InitializeComponent();
        }

        public void loadMaNVInCombobox()
        {
            foreach (NhanVienDTO nv in nvBus.LoadDataBboBUS())
            {
                cboMaNhanvien.Items.Add(nv.MaNV);
            }
        }

        public void loadMaQuyenInCombobox()
        {
            cboPhanquyen.DataSource = quyenBus.LoadDataBUS();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                TaiKhoanDTO tk = new TaiKhoanDTO();
                tk.TenTaiKhoan = txtDangnhap.Text;
                tk.MatKhau = Mahoamatkhau.Encrypt(txtMatkhau.Text);
                //tk.MaNhanVien = cboMaNV.SelectedItem.ToString();
                tk.MaNhanVien = cboMaNhanvien.Text;
                tk.MaQuyen = cboPhanquyen.SelectedIndex + 1;
                if (string.IsNullOrEmpty(cboMaNhanvien.Text) || string.IsNullOrEmpty(txtDangnhap.Text) || string.IsNullOrEmpty(txtMatkhau.Text) || string.IsNullOrEmpty(cboPhanquyen.Text))
                {
                    MessageBox.Show(mess.emptyAccountInput, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (string.IsNullOrEmpty(txtHoten.Text))
                {
                    MessageBox.Show(mess.accountExists, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (tkBUS.ThemTaiKhoan(tk))
                {
                    MessageBox.Show(mess.createSuccess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Dulieudangnhap.formQuanLy.btnQuanLyTaiKhoan_Click(sender, e);
                }
                else
                {
                    MessageBox.Show(mess.createFail, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show(mess.accountExists, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmTaoTK_Load(object sender, EventArgs e)
        {
            loadMaNVInCombobox();
            loadMaQuyenInCombobox();
            if (cboMaNhanvien == null)
            {
                cboMaNhanvien.Enabled = false;
            }
            else
            {
                cboMaNhanvien.Enabled = true;
            }
        }

        

        private void cboMaNhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            int dem = 0;
            List<NhanVienDTO> list = nvBus.LoadDataBboBUS();
            foreach (NhanVienDTO nv in list)
            {
                if (cboMaNhanvien.Text == nv.MaNV)
                {
                    txtHoten.Text = nv.HoTenNV;
                    txtSdienthoai.Text = nv.SdtNV;
                    rtbDiachi.Text = nv.DiaChi;
                    dtpNgaySinh.EditValue = nv.NgaySinh.ToString("dd/MM/yyyy");
                    if (nv.GioiTinh == "Nam")
                    {
                        radgrpGioitinh.SelectedIndex = 0;
                    }
                    else
                    {
                        radgrpGioitinh.SelectedIndex = 1;
                    }

                }
                else
                {
                    dem++;
                }
            }
            if (dem == list.Count())
            {
                txtHoten.ResetText();
                txtSdienthoai.ResetText();
                rtbDiachi.ResetText();
                dtpNgaySinh.ResetText();
            }
        }
    }
}
