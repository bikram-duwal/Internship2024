using Internship2024.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Internship2024.Repository
{
    public class EquipmentLandingRepository : IEquipmentLandingRepository
    {
        private Internship2024DB _objTran = null;

        public EquipmentLandingRepository(Internship2024DB objTran)
        {
            _objTran = objTran ?? throw new ArgumentNullException(nameof(objTran), "objTran cannot be null");
        }

        public List<Equipment> getAllEquipmentRows() 
        {
            List<Equipment> result = new List<Equipment>();

            using (SqlCommand cmd = _objTran.CreateCommand("sp_get_all_equipment_rows", true))
            {
                try
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Equipment row = MapEquipmentFromReader(reader);
                            result.Add(row);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    
                    Console.WriteLine("SQL Error occurred: " + ex.Message);
                    throw;
                }
                catch (Exception ex)
                {
                    
                    Console.WriteLine("Error occurred: " + ex.Message);
                    throw;
                }
            }

            return result;
        }

        private Equipment MapEquipmentFromReader(SqlDataReader reader)
        {
            return new Equipment
            {
                //TablePid = (long)reader["table_pid"],
                EquipmentName = reader["equipment_name"].ToString(),
                EquipmentUniqueCode = reader["equipment_unique_code"].ToString(),
              
               EquipmentNo = reader["equipment_no"].ToString(),
                EquipmentSopNoOperation = reader["equipment_sop_no_operation"].ToString(),
                EquipmentSopNoCleaning = reader["equipment_sop_no_cleaning"].ToString(),
                EquipmentSopNoPreventiveMaintenance = reader["equipment_sop_no_preventive_maintenance"].ToString(),
                EquipmentCalibrationFrequency = getInt(reader,"equipment_calibration_frequency"),
                EquipmentCalibrationTriggerDate = getDateTime(reader,"equipment_calibration_trigger_date"),
/*                EquipmentSerialNo = reader["equipment_serial_no"].ToString(),
                EquipmentMake = reader["equipment_make"].ToString(),
                EquipmentModel = reader["equipment_model"].ToString(),
                EquipmentYear = getInt(reader,"equipment_year"),
               EquipmentAnnualBudget = getDecimal(reader,"equipment_annual_budget"),
                EquipmentType = reader["equipment_type"].ToString(),*/
                EquipmentStatus = reader["equipment_status"].ToString(),
              /* EquipmentDecimalPlaces = getInt(reader,"equipment_decimal_places"),
                EquipmentIdentification = reader["equipment_identification"].ToString(),
                EquipmentPrimaryMeter = reader["equipment_primary_meter"].ToString(),
                EquipmentSecondaryMeter = reader["equipment_secondary_meter"].ToString(),
                EquipmentRemarks = reader["equipment_remarks"].ToString(),
                EquipmentHasMeter = getBool(reader,"equipment_has_meter"),
                EquipmentIsExcludedInLineClearanceReport = getBool(reader,"equipment_is_exculded_in_line_clearence_report"),
                EquipmentActive = getBool(reader,"equipment_active"),
                EquipmentIsMoveable = getBool(reader,"equipment_is_moveable"),
                EquipmentTimestampColumn = getDateTime(reader,"equipment_timestamp_column")
*/
            };
        }

       /* bool? getBool(SqlDataReader reader, string key)
        {
            if (reader[key] is DBNull) return null;
            return Convert.ToBoolean( reader[key]);
        }*/
        int?  getInt(SqlDataReader reader, string key)
        {
            if (reader[key] is DBNull) return null;
            return (int)(reader[key]);
        }
        /*ecimal? getDecimal(SqlDataReader reader, string key)
        {
            if (reader[key] is DBNull) return null;
            return (decimal)(reader[key]);
        }*/
        DateTime? getDateTime(SqlDataReader reader, string key)
        {
            if (reader[key] is DBNull) return null;
            return (DateTime)(reader[key]);
        }
    }
}
