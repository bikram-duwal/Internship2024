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



                objStringRow = objString.GetRow("column_type='area_name' and table_pid=" + objAreaRow.Table_pid);
                objStringRow.Data_value = objAreaRow.Name;
                objString.Update(objStringRow);



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

               

                pl_area objArea = new pl_area(objTran);
                objAreaRow  = objArea.GetRow("table_pid=11");
             
              
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
            pl_object objObject = new pl_object(objTran);
            pl_objectRow objObjectRow = objObject.GetRow("table_pid=11");




           
            
            return objObjectRow.Name;

        }
    }
}
