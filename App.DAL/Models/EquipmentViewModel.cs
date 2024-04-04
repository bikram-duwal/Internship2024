using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DAL.Models
{
    public class EquipmentViewModel
    {
        public long EquipmentId { get; set; }
        public long TablePid { get; set; }
        public string UniqueCode { get; set; }
        public string Area { get; set; }
        public string EquipmentNo { get; set; }
        public  string Name { get; set; }
        public string SopNoOperation { get; set; }
        public string SopNoCleaning { get; set; }
        public string SopNoPreventiveMaintenance { get; set; }
        public int CalibrationFrequency { get; set; }
        public DateTime CalibrationTriggerDate { get; set; }
        public string EquipmentSerialNo { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal EquipmentAnnualBudget { get; set; }
        public string EquipmentType { get; set; }
        public string EquipmentStatus { get; set; }
        public int DecimalPlaces { get; set; }
        public string Identification { get; set; }
        public string PrimaryMeter { get; set; }
        public string SecondaryMeter { get; set; }
        public string Remarks { get; set; }
        public bool IsEquipmentHasMeter { get; set; }
        public bool IsExculdedInLineClearanceReport { get; set; }
        public bool IsActive { get; set; }
        public bool IsMoveable { get; set; }

    }
}
