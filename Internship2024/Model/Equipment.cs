using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship2024.Model
{
 

    public class Equipment
    {
        //public Int64 TablePid { get; set; }
        public string EquipmentName { get; set; }
        public string EquipmentUniqueCode { get; set; }
        
        public string EquipmentNo { get; set; }
        public string EquipmentSopNoOperation { get; set; }
        public string EquipmentSopNoCleaning { get; set; }
        public string EquipmentSopNoPreventiveMaintenance { get; set; }
        public int? EquipmentCalibrationFrequency { get; set; }
        public DateTime? EquipmentCalibrationTriggerDate { get; set; }
       /* public string EquipmentSerialNo { get; set; }
        public string EquipmentMake { get; set; }
        public string EquipmentModel { get; set; }
        public int? EquipmentYear { get; set; }
        public decimal? EquipmentAnnualBudget { get; set; }
        public string EquipmentType { get; set; }*/
        public string EquipmentStatus { get; set; }
       /* public int? EquipmentDecimalPlaces { get; set; }
        public string EquipmentIdentification { get; set; }
        public string EquipmentPrimaryMeter { get; set; }
        public string EquipmentSecondaryMeter { get; set; }
        public string EquipmentRemarks { get; set; }
        public bool? EquipmentHasMeter { get; set; }
        public bool? EquipmentIsExcludedInLineClearanceReport { get; set; }
        public bool? EquipmentActive { get; set; }
        public bool? EquipmentIsMoveable { get; set; }
        public DateTime? EquipmentTimestampColumn { get; set; }*/
    }

}
