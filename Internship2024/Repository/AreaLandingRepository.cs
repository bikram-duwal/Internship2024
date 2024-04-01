using Internship2024.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Internship2024.Repository
{
    public class AreaLandingRepository: IAreaLandingRepository
    {
        Internship2024DB _objTran = null;
        
        public AreaLandingRepository(Internship2024DB objTran)
        {
            _objTran = objTran;
        }

        public List<Area> getAllAreaRows()
        {
                SqlCommand cmd = _objTran.CreateCommand("sp_get_all_area_rows", true);
                SqlDataReader reader = cmd.ExecuteReader();
                List<Area> result = new List<Area>();

                while (reader.Read())
                {
                    Area row = new Area
                    {
                        UniqueCode = reader["area_unique_code"].ToString(),
                        AreaName = reader["area_name"].ToString(),
                        AreaCode = reader["area_code"].ToString(),
                        Description = reader["area_description"].ToString(),
                        IsForDispensing = reader["area_is_for_dispensing"].ToString() == "1" ? "True" : "False",
                        DepartmentName = reader["area_department_name"].ToString(),
                        Status = reader["area_status"].ToString() == "1" ? "Active": "Inactive",
                    };

                    result.Add(row);
                }
                return result;
        }
    }
}
