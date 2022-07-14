using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAO
{
    public class LoaiSanPhamDAO
    {
        DataProvider con = new DataProvider();

        Project_AppleEntities DB = new Project_AppleEntities();

        public List<LoaiSanPhamDTO> LoadLoaiSP()
        {
            List<LoaiSanPhamDTO> lst = new List<LoaiSanPhamDTO>();
            string Query = "SELECT * FROM LoaiSanPham l WHERE l.TrangThai = 'True' ORDER BY CONVERT(INT,SUBSTRING(l.MaLoai,2,LEN(l.MaLoai)))";
            SqlDataReader reader = con.getdata(Query);
            while (reader.Read())
            {
                LoaiSanPhamDTO lSP = new LoaiSanPhamDTO();
                lSP.MaLoai = reader.GetString(0);
                lSP.TenLoai = reader.GetString(1);
                lSP.TrangThai = reader.GetBoolean(2);
                lst.Add(lSP);
            }
            con.Ngatketnoi();
            return lst;
        }

        public List<LoaiSanPhamDTO> LoadLoaiSPTheoKeyWork(string value)
        {
            List<LoaiSanPhamDTO> lst = new List<LoaiSanPhamDTO>();
            string query = "SELECT * FROM LoaiSanPham l WHERE l.TrangThai = 'True' AND (l.MaLoai LIKE '{0}%' OR l.TenLoai LIKE '{1}%') ORDER BY CONVERT(INT,SUBSTRING(l.MaLoai,2,LEN(l.MaLoai)))";
            string sql = string.Format(query, value, value);
            SqlDataReader reader = con.getdata(sql);
            while (reader.Read())
            {
                LoaiSanPhamDTO lSP = new LoaiSanPhamDTO();
                lSP.MaLoai = reader.GetString(0);
                lSP.TenLoai = reader.GetString(1);
                lSP.TrangThai = reader.GetBoolean(2);
                lst.Add(lSP);
            }
            con.Ngatketnoi();
            return lst;
        }

        public string MaxMaLoai()
        {
            string Query = "SELECT MaLoai FROM LoaiSanPham GROUP BY MaLoai HAVING MAX(CONVERT(int,SUBSTRING(MaLoai, 2,LEN(MaLoai)))) >=ALL(SELECT MAX(CONVERT(int,SUBSTRING(MaLoai, 2,LEN(MaLoai))))FROM LoaiSanPham)";
            string id = Convert.ToString(con.GetMaxPNId(Query));
            return id;
        }

        //Thêm loại SP
        public bool ThemLoaiSanPhamEntities(LoaiSanPhamDTO loai)
        {
            try
            {
                LoaiSanPham l = new LoaiSanPham();
                l.MaLoai = loai.MaLoai;
                l.TenLoai = loai.TenLoai;
                l.TrangThai = true;
                DB.LoaiSanPhams.Add(l);
                DB.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Cập nhật loại SP
        public bool CapNhapLoaiEntities(LoaiSanPhamDTO Loai)
        {
            try
            {
                LoaiSanPham loai = new LoaiSanPham();
                loai = DB.LoaiSanPhams.SingleOrDefault(u => u.MaLoai == Loai.MaLoai);
                loai.TenLoai = Loai.TenLoai;
                DB.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Xóa loại SP
        public bool XoaLoaiEntities(LoaiSanPhamDTO Loai)
        {
            try
            {
                LoaiSanPham loai = new LoaiSanPham();
                loai = DB.LoaiSanPhams.SingleOrDefault(u => u.MaLoai == Loai.MaLoai);
                loai.TrangThai = false;
                DB.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
