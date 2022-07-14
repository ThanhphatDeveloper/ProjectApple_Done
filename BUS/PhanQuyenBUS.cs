using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class PhanQuyenBUS
    {
        PhanQuyenDAO quyenDAO = new PhanQuyenDAO();
        public List<PhanQuyenDTO> LoadDataBUS()
        {
            return quyenDAO.LoadDataDAO();
        }

    }
}
