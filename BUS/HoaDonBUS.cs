using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class HoaDonBUS
    {
        HoaDonDAO hdDAO = new HoaDonDAO();
        //...
        public List<HoaDonDTO> LoadDataBUS()
        {
            return hdDAO.LoadDataDAO();
        }

        public bool ThemHoaDonBUS(HoaDonDTO hd)
        {
            return hdDAO.ThemHoaDonDAO(hd);
        }

        public Int64 DemTongHDBUS()
        {
            return hdDAO.DemTongHoaDonDAO();
        }
        public List<HoaDonDTO> TimKiemNhanhBUS(string value)
        {
            return hdDAO.TimKiemNhanhDAO(value);
        }
    }
}
