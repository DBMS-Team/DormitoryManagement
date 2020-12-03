using DormitoryManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryManagement.Controller
{
    public static class DistrictDAO
    {
        public static List<DistrictDTO> GetListDistrict(string id)
        {
            List<DistrictDTO> districtDTOs = new List<DistrictDTO>();
            string query = string.Format("EXEC dbo.USP_GetDistrictByIdProvince @PROVINCE_ID = '{0}'",id);
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                DistrictDTO districtDTO = new DistrictDTO(item);
                districtDTOs.Add(districtDTO);

            }
            return districtDTOs;
        }
    }
}
