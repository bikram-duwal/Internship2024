using Internship2024.EditModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Internship2024.EditModel
{
    public class AreaEditRepository : IAreaEditRepository
    {
       
        Internship2024DB _objTran;
        pl_areaRow objAreaRow;
       
        public AreaEditRepository(Internship2024DB objTran)
        {
            _objTran = objTran;
        }

        public void UpdateArea(pl_areaRow objAreaRow)
        {
            try
            {
                _objTran.BeginTransaction();
                pl_area objArea = new pl_area(_objTran);
                pl_areaRow objpl_AreaRow = objArea.GetRow($"table_pid={objAreaRow.Table_pid}");
                objpl_AreaRow.Description = objAreaRow.Description;
                objpl_AreaRow.Name = objAreaRow.Name;
                objpl_AreaRow.Unique_code = objAreaRow.Unique_code;
                objpl_AreaRow.Area_code = objAreaRow.Area_code;
                objpl_AreaRow.Status = objAreaRow.Status;
                objpl_AreaRow.Is_for_dispensing = objAreaRow.Is_for_dispensing;
                objpl_AreaRow.Department_id = objAreaRow.Department_id;

                objArea.Update(objpl_AreaRow);

                pl_object objpl_object = new pl_object(_objTran);
                pl_objectRow objpl_objectRow = objpl_object.GetByPrimaryKey(objAreaRow.Table_pid);
                objpl_objectRow.Name = objAreaRow.Name;
                objpl_object.Update(objpl_objectRow);

                pl_string objpl_string = new pl_string(_objTran);
                pl_stringRow objpl_strinRow = new pl_stringRow();
                objpl_strinRow.Table_pid = objAreaRow.Table_pid;
                objpl_strinRow.Column_type = "area_code";
                objpl_strinRow.Data_value = objAreaRow.Area_code;

                objpl_string.Update(objpl_strinRow);

                objpl_strinRow.Column_type = "area_description";
                objpl_strinRow.Data_value = objAreaRow.Description;

                objpl_string.Update(objpl_strinRow);

                pl_boolean objpl_boolean = new pl_boolean(_objTran);
                pl_booleanRow objpl_booleanRow = new pl_booleanRow();
                objpl_booleanRow.Table_pid = objAreaRow.Table_pid;
                objpl_booleanRow.Column_type = "area_is_for_dispensing";
                objpl_booleanRow.Data_value = objAreaRow.Is_for_dispensing;
                objpl_boolean.Update(objpl_booleanRow);

                objpl_booleanRow.Column_type = "area_status";
                objpl_booleanRow.Data_value = objAreaRow.Status;
                objpl_boolean.Update(objpl_booleanRow);

                pl_integer objpl_integer = new pl_integer(_objTran);
                pl_integerRow objpl_integerRow = new pl_integerRow();
                objpl_integerRow.Table_pid = objAreaRow.Table_pid;
                objpl_integerRow.Column_type = "area_department_id";
                objpl_integerRow.Data_value = (int) objAreaRow.Department_id;
                objpl_integer.Update(objpl_integerRow);

                _objTran.CommitTransaction();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                _objTran.RollbackTransaction();
                throw;
            }
        }
        public pl_areaRow GetAreaByTablePid(long table_pid)
        {
            try
            {
                SqlCommand cmd = _objTran.CreateCommand("sp_get_one_area_row", true);
                _objTran.AddParameter(cmd, "table_pid", DbType.Int64, table_pid);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    objAreaRow = new pl_areaRow
                    {
                        Table_pid = (long)reader["table_pid"],
                        Unique_code = reader["area_unique_code"].ToString(),
                        Name = reader["area_name"].ToString(),
                        Area_code = reader["area_code"].ToString(),
                        Description = reader["area_description"].ToString(),
                        Is_for_dispensing = (bool)reader["area_is_for_dispensing"],
                        Department_id = (long)reader["area_department_id"],
                        Department_name = reader["area_department_name"].ToString(),
                        Status = (bool)reader["area_status"],
                    };
                }

                reader.Close();

                return objAreaRow;
            }
            catch (Exception ex) {
                throw;
            }
            finally {
                
            }
        }
        public pl_objectRow[] GetDropDownValue() {
            pl_object objObject = new pl_object(_objTran);
            pl_objectRow[] rows = objObject.GetAsArray("table_name='Department'", "");
            return rows;

        }
        public string DropDownName()
        {
           
           


            SqlCommand cmd = _objTran.CreateCommand("GetAreaByID", true);
            _objTran.AddParameter(cmd, "id", DbType.Int64, 3);
            SqlDataReader reader = cmd.ExecuteReader();
            string name = "";
            while (reader.Read())
            {
                name = reader["name"].ToString();

            }





              

            
            return name;

        }
    }
}
