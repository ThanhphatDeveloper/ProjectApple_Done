﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace Project_Apple
{
    public partial class frmQuanLyLoaiSP : Form
    {

        LoaiSanPhamBUS loaiSPBus = new LoaiSanPhamBUS();
        List<LoaiSanPhamDTO> lst;
        Thongbao mess = new Thongbao();


        public frmQuanLyLoaiSP()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Hide();
            //Dulieudangnhap.formOpacity.Hide();
            //Dulieudangnhap.formQuanLy.Hide();
            //Dulieudangnhap.formQuanLy.Show();
            //Dulieudangnhap.formQuanLy.btnQuanLySanPham_Click();
            //Dulieudangnhap.formQuanLy.btnQuanLySanPham_Click(sender, e);
        }

        private void frmQuanLyLoaiSP_Load(object sender, EventArgs e)
        {
            dgvLoaiSP.AutoGenerateColumns = false;
            dgvLoaiSP.DataSource = loaiSPBus.LoadLoaiSP();
            lst = loaiSPBus.LoadLoaiSP();
        }

        public string PhatSinhMa()
        {
            
            string ID = loaiSPBus.MaxMaLoai();
            
            if (ID == "")
            {
                ID = "L0";
            }
            int Ma = Convert.ToInt32(ID.Substring(1));
            string MaPhatSinh = "L" + (Ma + 1);
            txtMaLoai.Text = MaPhatSinh;
            
            return MaPhatSinh;
        }

        private void btnThemLoaiMoi_Click(object sender, EventArgs e)
        {
            PhatSinhMa();
            txtTenLoai.Enabled = true;
            txtTenLoai.Focus();
            //...
            btnThem.Visible = true;
            btnThemLoaiMoi.Visible = false;
        }
        public bool KiemTraNhap()
        {
            if (string.IsNullOrEmpty(txtMaLoai.Text) || string.IsNullOrEmpty(txtTenLoai.Text))
            {
                MessageBox.Show(mess.emptyProductTypeInput, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhap())
            {
                txtTenLoai.Enabled = false;
                txtTenLoai.ResetText();
                txtMaLoai.ResetText();
                //...
                btnThem.Visible = false;
                btnThemLoaiMoi.Visible = true;
                return;
            }
            LoaiSanPhamDTO l = new LoaiSanPhamDTO();
            l.MaLoai = txtMaLoai.Text;
            l.TenLoai = txtTenLoai.Text;
            foreach (LoaiSanPhamDTO item in lst)
            {
                if (item.MaLoai == txtMaLoai.Text)
                {
                    MessageBox.Show(mess.productTypeIsExit, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTenLoai.Enabled = false;
                    txtTenLoai.ResetText();
                    txtMaLoai.ResetText();
                    //...
                    btnThem.Visible = false;
                    btnThemLoaiMoi.Visible = true;
                    return;
                }
            }
            if (loaiSPBus.ThemLoaiSanPhamEntities(l))
            {
                MessageBox.Show(mess.addProductTypeSuccess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenLoai.Enabled = false;
                txtTenLoai.ResetText();
                txtMaLoai.ResetText();
                //...
                btnThem.Visible = false;
                btnThemLoaiMoi.Visible = true;
                //...
                frmQuanLyLoaiSP_Load(sender, e);
            }
            else
            {
                MessageBox.Show(mess.addProductTypeFail, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            txtTenLoai.Enabled = true;
            txtTenLoai.Focus();
            
            btnLuuCapNhat.Visible = true;
            btnCapNhat.Visible = false;
        }

        private void btnLuuCapNhat_Click(object sender, EventArgs e)
        {
            if (!KiemTraNhap())
            {
                txtTenLoai.Enabled = false;
                txtTenLoai.ResetText();
                txtMaLoai.ResetText();
                //...
                btnLuuCapNhat.Visible = false;
                btnCapNhat.Visible = true;
                return;
            }
            //...
            LoaiSanPhamDTO l = new LoaiSanPhamDTO();
            l.MaLoai = txtMaLoai.Text;
            l.TenLoai = txtTenLoai.Text;
            foreach (LoaiSanPhamDTO item in lst)
            {
                if (item.MaLoai == txtMaLoai.Text)
                {
                    if (loaiSPBus.CapNhatSanPhamEntities(l))
                    {
                        MessageBox.Show(mess.updateProductTypeSuccess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTenLoai.Enabled = false;
                        txtTenLoai.ResetText();
                        txtMaLoai.ResetText();
                        //...
                        btnLuuCapNhat.Visible = false;
                        btnCapNhat.Visible = true;
                        //...
                        frmQuanLyLoaiSP_Load(sender, e);
                        return;
                    }
                    else
                    {
                        MessageBox.Show(mess.updateProductTypeFail, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTenLoai.Enabled = false;
                        //...
                        btnLuuCapNhat.Visible = false;
                        btnCapNhat.Visible = true;
                        return;
                    }
                }
            }
            MessageBox.Show(mess.productTypeIsNotExit, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtTenLoai.Enabled = false;
            txtTenLoai.ResetText();
            txtMaLoai.ResetText();
            //...
            btnLuuCapNhat.Visible = false;
            btnCapNhat.Visible = true;
            return;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLoai.Text))
            {
                MessageBox.Show(mess.noProductTypeData, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //...
            LoaiSanPhamDTO l = new LoaiSanPhamDTO();
            l.MaLoai = txtMaLoai.Text;
            l.TenLoai = txtTenLoai.Text;
            foreach (LoaiSanPhamDTO item in lst)
            {
                if (item.MaLoai == txtMaLoai.Text)
                {
                    if (loaiSPBus.XoaSanPhamEntities(l))
                    {
                        MessageBox.Show(mess.deleteProductTypeSuccess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTenLoai.Enabled = false;
                        txtTenLoai.ResetText();
                        txtMaLoai.ResetText();
                        frmQuanLyLoaiSP_Load(sender, e);
                        return;
                    }
                    else
                    {
                        MessageBox.Show(mess.deleteProductTypeFail, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            MessageBox.Show(mess.productTypeIsNotExit, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        private void dgvLoaiSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (dgvLoaiSP.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvLoaiSP.CurrentRow.Selected = true;
                txtMaLoai.Text = dgvLoaiSP.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenLoai.Text = dgvLoaiSP.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void txtTenLoai_KeyPress(object sender, KeyPressEventArgs e)
        {
           // e.Handled = char.IsDigit(e.KeyChar);
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            dgvLoaiSP.AutoGenerateColumns = false;
            dgvLoaiSP.DataSource = loaiSPBus.LoadLoaiSPTheoKeyWork(txtTimkiem.Text);
        }

        private void txtTenLoai_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
