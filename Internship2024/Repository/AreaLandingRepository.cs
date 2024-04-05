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

        public List<pl_areaRow> getAllAreaRows()
        {
            SqlCommand cmd = _objTran.CreateCommand("sp_get_all_area_rows", true);
            SqlDataReader reader = cmd.ExecuteReader();
            List<pl_areaRow> result = new List<pl_areaRow>();

            while (reader.Read())
            {
                /*
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
                */

                pl_areaRow row = new pl_areaRow
                {
                    Table_pid = (long)reader["table_pid"],
                    Unique_code = reader["area_unique_code"].ToString(),
                    Name = reader["area_name"].ToString(),
                    Area_code = reader["area_code"].ToString(),
                    Description = reader["area_description"].ToString(),
                    Is_for_dispensing = (bool) reader["area_is_for_dispensing"],
                    Department_id = (long) reader["area_department_id"],
                    Department_name = reader["area_department_name"].ToString(),
                    Status = (bool) reader["area_status"],
                };

                result.Add(row);
            }
            reader.Close();

            return result;
        }
    }
}
