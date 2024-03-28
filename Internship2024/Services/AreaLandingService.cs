using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Internship2024.Services
{

    public class AreaRow
    {
        public String UniqueCode { get; set; }
        public String AreaName { get; set; }
        public String AreaCode { get; set; }
        public String Description { get; set; }
        public String IsForDispensing { get; set; }
        public String DepartmentName { get; set; }
        public String Status { get; set; }
    }
    public class AreaLandingService
    {
        Internship2024DB objTran = null;
        
        public AreaLandingService(Internship2024DB objTran)
        {
            this.objTran = objTran;
        }

        public List<AreaRow> getAllAreas()
        {
            try
            {
                SqlCommand cmd1 = objTran.CreateCommand("select table_pid, name from pl_object where table_name = 'Department'");
                SqlDataReader reader1 = cmd1.ExecuteReader();
                Dictionary<string, string> departmentIdToNameMap = new Dictionary<string, string>();

                while(reader1.Read())
                {
                    String departmentId = reader1.GetInt64(0).ToString();
                    string departmentName = reader1.GetString(1);
                    departmentIdToNameMap.Add(departmentId, departmentName);
                }
                reader1.Close();

                SqlCommand cmd2 = objTran.CreateCommand("SELECT " +
                    "MAX(CASE WHEN column_type = 'area_unique_code' THEN data_value END) AS area_unique_code," +
                    "MAX(po.name) AS area_name," +
                    "MAX(CASE WHEN column_type = 'area_code' THEN data_value END) AS area_code," +
                    "MAX(CASE WHEN column_type = 'area_description' THEN data_value END) AS area_description," +
                    "MAX(CASE WHEN column_type = 'area_is_for_dispensing' THEN data_value END) AS area_is_for_dispensing," +
                    "MAX(CASE WHEN column_type = 'area_department_id' THEN data_value END) AS area_department_id," +
                    "MAX(CASE WHEN column_type = 'area_status' THEN data_value END) AS area_status " +
                    "FROM pl_object as po " +
                    "JOIN (" +
                    "SELECT table_pid, column_type, data_value FROM pl_string " +
                    "UNION ALL SELECT table_pid, column_type, CAST(data_value AS varchar) FROM pl_boolean " +
                    "UNION ALL SELECT table_pid, column_type, CAST(data_value AS varchar) FROM pl_integer" +
                    ") AS all_rows ON po.table_pid = all_rows.table_pid " +
                    "WHERE po.table_name = 'Area' " +
                    "GROUP BY po.table_pid;");
                SqlDataReader reader2 = cmd2.ExecuteReader();
                List<AreaRow> result = new List<AreaRow>();

                //pl_object objpl_object = new pl_object(objTran);
                //pl_objectRow[] objpl_objectRow = objpl_object.GetAsArray("table_name = 'Department'","");

                while (reader2.Read())
                {
                    AreaRow row = new AreaRow
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
