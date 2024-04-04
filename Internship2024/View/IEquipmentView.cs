using Internship2024.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship2024.View
{
    public interface IEquipmentView
    {
        long EquipmentId { get; set; }
        long TablePid { get; set; }
        string UniqueCode { get; set; }
        string Area { get; set; }
        string EquipmentNo { get; set; }
        string EquipmentName { get; set; }
        string SopNoOperation { get; set; }
        string SopNoCleaning { get; set; }
        string SopNoPreventiveMaintenance { get; set; }
        int CalibrationFrequency { get; set; }
        DateTime CalibrationTriggerDate { get; set; }
        string EquipmentSerialNo { get; set; }
        string MakeValue { get; set; }
        string ModelValue { get; set; }
        int Year { get; set; }
        decimal EquipmentAnnualBudget { get; set; }
        string EquipmentTypeValue { get; set; }
        string EquipmentStatusValue { get; set; }
        int DecimalPlaces { get; set; }
        string Identification { get; set; }
        string PrimaryMeterValue { get; set; }
        string SecondaryMeterValue { get; set; }
        string Remarks { get; set; }
        bool EquipmentHasMeter { get; set; }
        bool IsExcludedInLineClearanceReport { get; set; }
        bool IsActive { get; set; }
        bool IsMoveable { get; set; }
        pl_equipmentRow Equipment { get; set; }
        EquipmentPresenter Presenter { get; set; }
    }
}
