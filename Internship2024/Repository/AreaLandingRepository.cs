using Internship2024.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Internship2024.Services
{
    public class AreaLandingRepository
    {
        Internship2024DB _objTran = null;
        
        public AreaLandingRepository(Internship2024DB objTran)
        {
            _objTran = objTran;
        }

        public List<Area> getAllAreaRows()
        {
            try
            {
                SqlCommand cmd1 = _objTran.CreateCommand("select table_pid, name from pl_object where table_name = 'Department'");
                SqlDataReader reader1 = cmd1.ExecuteReader();
                Dictionary<string, string> departmentIdToNameMap = new Dictionary<string, string>();

                while(reader1.Read())
                {
                    String departmentId = reader1.GetInt64(0).ToString();
                    string departmentName = reader1.GetString(1);
                    departmentIdToNameMap.Add(departmentId, departmentName);
                }
                reader1.Close();

                SqlCommand cmd2 = _objTran.CreateCommand("sp_get_all_area_rows", true);
                SqlDataReader reader2 = cmd2.ExecuteReader();
                List<Area> result = new List<Area>();

                while (reader2.Read())
                {
                    Area row = new Area
                    {
                        UniqueCode = reader2["area_unique_code"].ToString(),
                        AreaName = reader2["area_name"].ToString(),
                        AreaCode = reader2["area_code"].ToString(),
                        Description = reader2["area_description"].ToString(),
                        IsForDispensing = reader2["area_is_for_dispensing"].ToString() == "1" ? "True" : "False",
                        DepartmentName = departmentIdToNameMap[reader2["area_department_id"].ToString()],
                        Status = reader2["area_status"].ToString() == "1" ? "Active": "Inactive",
                    };

                    result.Add(row);
                }
                return result;
            }
            catch {
                throw;
            } finally
            {
            }
        }
    }
}
