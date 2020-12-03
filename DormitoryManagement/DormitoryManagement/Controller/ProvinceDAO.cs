using DormitoryManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryManagement.Controller
{
    public class ProvinceDAO
    {
        public static List<ProvinceDTO> GetListProvince()
        {
            List<ProvinceDTO> provinceDTOs = new List<ProvinceDTO>();
            string query = string.Format("EXEC dbo.USP_GetListProvince");
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                ProvinceDTO provinceDTO = new ProvinceDTO(item);
                provinceDTOs.Add(provinceDTO);

            }
            return provinceDTOs;
        }
    }
}
