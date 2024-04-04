using Internship2024;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DAL.Repositories
{
    public class EquipmentRepository : IEquipmentRepository
    {
        private readonly InternTaskDbContext _internTaskDbContext = new InternTaskDbContext();

        public pl_equipmentRow GetEquipment(long equipmentId)
        {
            pl_equipment objEquipment = new pl_equipment(_internTaskDbContext);
            return objEquipment.GetByPrimaryKey(equipmentId);
        }

        public void LoadCombos()
        {
            throw new NotImplementedException();
        }

        public void UpdateEquipment(pl_equipmentRow equipmentRow)
        {
            try
            {
                _internTaskDbContext.BeginTransaction();

                #region Pl_Equipment
                pl_equipment objEquipment = new pl_equipment(_internTaskDbContext);
                objEquipment.Update(equipmentRow);
                #endregion

                #region Pl_String
                pl_string objString = new pl_string(_internTaskDbContext);
                pl_stringRow objStringRow = objString.GetRow("column_type='equipment_no' and table_pid ="
                                                             + equipmentRow.Table_pid);
                objStringRow.Data_value = equipmentRow.Equipment_no;
                objString.Update(objStringRow);

                objStringRow = objString.GetRow("column_type='name' and table_pid ="
                                                + equipmentRow.Table_pid);
                objStringRow.Data_value = equipmentRow.Name;
                objString.Update(objStringRow);

                objStringRow = objString.GetRow("column_type='sop_no_operation' and table_pid ="
                                                + equipmentRow.Table_pid);
                objStringRow.Data_value = equipmentRow.Sop_no_operation;
                objString.Update(objStringRow);

                objStringRow = objString.GetRow("column_type='sop_no_cleaning' and table_pid ="
                                                + equipmentRow.Table_pid);
                objStringRow.Data_value = equipmentRow.Sop_no_cleaning;
                objString.Update(objStringRow);

                objStringRow = objString.GetRow("column_type='sop_no_preventive_maintenance' and table_pid ="
                                                + equipmentRow.Table_pid);
                objStringRow.Data_value = equipmentRow.Sop_no_preventive_maintenance;
                objString.Update(objStringRow);

                objStringRow = objString.GetRow("column_type='equipment_serial_No' and table_pid ="
                                                + equipmentRow.Table_pid);
                objStringRow.Data_value = equipmentRow.Equipment_serial_No;
                objString.Update(objStringRow);

                objStringRow = objString.GetRow("column_type='identification' and table_pid ="
                                                + equipmentRow.Table_pid);
                objStringRow.Data_value = equipmentRow.Identification;
                objString.Update(objStringRow);

                objStringRow = objString.GetRow("column_type='remarks' and table_pid ="
                                                + equipmentRow.Table_pid);
                objStringRow.Data_value = equipmentRow.Remarks;
                objString.Update(objStringRow);
                #endregion

                #region Pl_Boolean
                pl_boolean objBoolean = new pl_boolean(_internTaskDbContext);
                pl_booleanRow objBooleanRow = objBoolean.GetRow("column_type='equipment_has_meter' and table_pid="
                                                                + equipmentRow.Table_pid);
                objBooleanRow.Data_value = equipmentRow.Equipment_has_meter;
                objBoolean.Update(objBooleanRow);

                objBooleanRow = objBoolean.GetRow("column_type='is_excluded_in_line_clearance_report' and table_pid="
                                                  + equipmentRow.Table_pid);
                objBooleanRow.Data_value = equipmentRow.Is_excluded_in_line_clearance_report;
                objBoolean.Update(objBooleanRow);

                objBooleanRow = objBoolean.GetRow("column_type='is_active' and table_pid="
                                                  + equipmentRow.Table_pid);
                objBooleanRow.Data_value = equipmentRow.Is_active;
                objBoolean.Update(objBooleanRow);

                objBooleanRow = objBoolean.GetRow("column_type='is_moveable' and table_pid="
                                                  + equipmentRow.Table_pid);
                objBooleanRow.Data_value = equipmentRow.Is_moveable;
                objBoolean.Update(objBooleanRow);
                #endregion

                #region Pl_Integer
                pl_integer objInteger = new pl_integer(_internTaskDbContext);
                pl_integerRow objIntegerRow = objInteger.GetRow("column_type='calibration_frequency' and table_pid="
                                                                + equipmentRow.Table_pid);
                objIntegerRow.Data_value = equipmentRow.Calibration_frequency;
                objInteger.Update(objIntegerRow);

                objIntegerRow = objInteger.GetRow("column_type='year' and table_pid="
                                                                + equipmentRow.Table_pid);
                objIntegerRow.Data_value = equipmentRow.Year;
                objInteger.Update(objIntegerRow);

                objIntegerRow = objInteger.GetRow("column_type='decimal_places' and table_pid="
                                                                + equipmentRow.Table_pid);
                objIntegerRow.Data_value = equipmentRow.Decimal_places;
                objInteger.Update(objIntegerRow);
                #endregion

                #region Pl_Decimal
                pl_decimal objDecimal = new pl_decimal(_internTaskDbContext);
                pl_decimalRow objDecimalRow = objDecimal.GetRow("column_type='equipment_annual_budget' and table_pid="
                                                                + equipmentRow.Table_pid);
                objDecimalRow.Data_value = equipmentRow.Equipment_annual_budget;
                objDecimal.Update(objDecimalRow);
                #endregion

                _internTaskDbContext.CommitTransaction();

            }
            catch
            {
                _internTaskDbContext.RollbackTransaction();
            }
            finally
            {
                _internTaskDbContext.Dispose();
            }

        }
    }
}
