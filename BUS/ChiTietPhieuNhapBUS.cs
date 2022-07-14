using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class ChiTietPhieuNhapBUS
    {
        ChiTietPhieuNhapDAO ctpnDAO = new ChiTietPhieuNhapDAO();
        public bool CapNhatSoLuongSpBUS(ChiTietHoaDonDTO cthd, string maSP)
        {
            return ctpnDAO.CapNhatSoLuongSpDAO(cthd, maSP);
        }
        public List<ChiTietPhieuNhapDTO> loadData(string maPN)
        {
            return ctpnDAO.loadDSPN(maPN);
        }
        public bool ThemCTPN(List<ChiTietPhieuNhapDTO> listCTPN)
        {
            return ctpnDAO.themCTPN(listCTPN);
        }
        public long TinhTongTienPN(string maPN)
        {
            return ctpnDAO.TinhTongTienPN(maPN);
        }
    }
}
