using Internship2024.EditModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Internship2024.EditModel
{
    public class AreaEditRepository : IAreaEditRepository
    {
       
        Internship2024DB objTran = new Internship2024DB();
        pl_areaRow objAreaRow;
       


        // string cs = ConfigurationManager.ConnectionStrings["dbcs"].ConnectionString;


        public AreaEditRepository()
        {
           

        }

        public void UpdateArea(pl_areaRow objAreaRow)
        {
           
            try
            {
                Internship2024DB objTran = new Internship2024DB();
                objTran.BeginTransaction();
                pl_area objArea = new pl_area(objTran);
                objArea.Update(objAreaRow);

                pl_string objString=new pl_string(objTran); 
                pl_stringRow objStringRow = objString.GetRow("column_type='area_code' and table_pid=" + objAreaRow.Table_pid);
                objStringRow.Data_value = objAreaRow.Area_code;
                objString.Update(objStringRow);

                 objStringRow = objString.GetRow("column_type='area_description' and table_pid=" + objAreaRow.Table_pid);
                objStringRow.Data_value = objAreaRow.Description;
                objString.Update(objStringRow);

                SqlConnection con = null;
             
                con = objTran.CreateConnection();
                SqlCommand cmd = new SqlCommand("update pl_object set name=@AreaName where table_pid=11", con);
                cmd.Parameters.AddWithValue("@AreaName", objAreaRow.Name);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                //  pl_object objObject=new pl_object(objTran);

                //  pl_objectRow objobjectRow = objObject.GetRow("column_type='area_name' and table_pid=" + objAreaRow.Table_pid);
                // objObjectRow.Data_value = objAreaRow.Name;
                //  objObject.Update(objStringRow);
   



                pl_boolean objBoolean = new pl_boolean(objTran);
                pl_booleanRow objBooleanRow = objBoolean.GetRow("column_type='area_is_for_dispensing' and table_pid=" + objAreaRow.Table_pid);
                objBooleanRow.Data_value = objAreaRow.Is_for_dispensing;
                objBoolean.Update(objBooleanRow);

               objBoolean = new pl_boolean(objTran);
                objBooleanRow = objBoolean.GetRow("column_type='area_status' and table_pid=" + objAreaRow.Table_pid);
                objBooleanRow.Data_value = objAreaRow.Status;
                objBoolean.Update(objBooleanRow);



                objTran.CommitTransaction();





            }
            catch (Exception ex)
            {
                objTran.RollbackTransaction();
            }
            finally
            {
                objTran.Dispose();
            }
        }
        public pl_areaRow LoadFormValue()
        {
            try
            {
               
                SqlCommand cmd = objTran.CreateCommand("sp_get_one_area_row", true);
                objTran.AddParameter(cmd, "table_pid", DbType.Int64, 11);
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

                        Status = (bool)reader["area_status"],

                    };


                }


                reader.Close();
                return objAreaRow;
              

            }
            catch (Exception ex) {
                return new pl_areaRow();
            }
            finally {
                
            }
        }
        public pl_objectRow[] GetDropDownValue() {
            pl_object objObject = new pl_object(objTran);
            pl_objectRow[] rows = objObject.GetAsArray("table_name='Department'", "");
            return rows;

        }
        public string DropDownName()
        {
           
           


            SqlCommand cmd = objTran.CreateCommand("GetAreaByID", true);
            objTran.AddParameter(cmd, "id", DbType.Int64, 3);
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
