using App.DAL.Repositories;
using Internship2024.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internship2024.Presenter
{
    public class EquipmentPresenter
    {
        private readonly IEquipmentView _equipmentView;
        private readonly IEquipmentRepository _equipmentRepository;

        public EquipmentPresenter(IEquipmentView equipmentView, IEquipmentRepository equimentRepository)
        {
            _equipmentView = equipmentView;
            _equipmentRepository = equimentRepository;
        }

        public void LoadEquipment(long equipmentId)
        {
            var row = _equipmentRepository.GetEquipment(equipmentId);
            if (row != null)
            {
                _equipmentView.Equipment = row;
                PopulateData(_equipmentView.Equipment);
            }
        }

        public void UpdateEquipment()
        {
            var existingRow = _equipmentView.Equipment;
            var newRow = PopulateNewData(existingRow);

            _equipmentRepository.UpdateEquipment(newRow);
        }

        private pl_equipmentRow PopulateNewData(pl_equipmentRow existingRow)
        {
            existingRow.Equipment_id = _equipmentView.EquipmentId;
            existingRow.Table_pid = _equipmentView.TablePid;
            existingRow.Unique_code = _equipmentView.UniqueCode;
            existingRow.Area = _equipmentView.Area;
            existingRow.Equipment_no = _equipmentView.EquipmentNo;
            existingRow.Name = _equipmentView.EquipmentName;
            existingRow.Sop_no_operation = _equipmentView.SopNoOperation;
            existingRow.Sop_no_cleaning = _equipmentView.SopNoCleaning;
            existingRow.Calibration_frequency = _equipmentView.CalibrationFrequency;
            existingRow.Sop_no_preventive_maintenance = _equipmentView.SopNoPreventiveMaintenance;
            existingRow.Equipment_serial_No = _equipmentView.EquipmentSerialNo;
            existingRow.Equipment_annual_budget = _equipmentView.EquipmentAnnualBudget;
            existingRow.Year = _equipmentView.Year;
            existingRow.Decimal_places = _equipmentView.DecimalPlaces;
            existingRow.Identification = _equipmentView.Identification;
            existingRow.Remarks = _equipmentView.Remarks;
            existingRow.Equipment_has_meter = _equipmentView.EquipmentHasMeter;
            existingRow.Is_excluded_in_line_clearance_report = _equipmentView.IsExcludedInLineClearanceReport;
            existingRow.Is_moveable = _equipmentView.IsMoveable;
            existingRow.Is_active = _equipmentView.IsActive;

            return existingRow;
        }

        private void PopulateData(pl_equipmentRow row)
        {
            _equipmentView.EquipmentId = row.Equipment_id;
            _equipmentView.TablePid = row.Table_pid;
            _equipmentView.UniqueCode = row.Unique_code;
            _equipmentView.Area = row.Area;
            _equipmentView.EquipmentNo = row.Equipment_no;
            _equipmentView.EquipmentName = row.Name;
            _equipmentView.SopNoOperation = row.Sop_no_operation;
            _equipmentView.SopNoCleaning = row.Sop_no_cleaning;
            _equipmentView.CalibrationFrequency = row.Calibration_frequency;
            _equipmentView.SopNoPreventiveMaintenance = row.Sop_no_preventive_maintenance;
            _equipmentView.EquipmentSerialNo = row.Equipment_serial_No;
            _equipmentView.EquipmentAnnualBudget = row.Equipment_annual_budget;
            _equipmentView.Year = row.Year;
            _equipmentView.DecimalPlaces = row.Decimal_places;
            _equipmentView.Identification = row.Identification;
            _equipmentView.Remarks = row.Remarks;
            _equipmentView.EquipmentHasMeter = row.Equipment_has_meter;
            _equipmentView.IsExcludedInLineClearanceReport = row.Is_excluded_in_line_clearance_report;
            _equipmentView.IsMoveable = row.Is_moveable;
            _equipmentView.IsActive = row.Is_active;
        }
    }
}
