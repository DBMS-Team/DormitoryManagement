﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DormitoryManagement.Model;

namespace DormitoryManagement.Controller
{
    public static class ServiceDAO
    {
        public static List<ServiceDTO> GetListService()
        {
            string query = string.Format("EXEC dbo.USP_GetListService");
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            List<ServiceDTO> listService = new List<ServiceDTO>();
            foreach (DataRow item in dataTable.Rows)
            {
                ServiceDTO temp = new ServiceDTO(item);
                listService.Add(temp);
            }
            return listService;
        }

        public static DataTable GetServicesInfo()
        {
            string query = string.Format("EXEC dbo.USP_GetServicesInfo");
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            return dataTable;
        }
    }
}
