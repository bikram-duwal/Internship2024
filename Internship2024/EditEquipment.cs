using App.DAL.Repositories;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Internship2024.Presenter;
using Internship2024.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internship2024
{
    public partial class EditEquipment : Form, IEquipmentView
    {

        #region Properties
        public long EquipmentId { get; set; }
        public long TablePid { get; set; }
        public string UniqueCode
        {
            get => unqCodeText.Text;
            set => unqCodeText.Text = value;
        }
        public string Area
        {
            get => areaText.Text;
            set => areaText.Text = value;
        }
        public string EquipmentNo
        {
            get => eqpNoText.Text;
            set => eqpNoText.Text = value;
        }
        public string SopNoOperation
        {
            get => sopNoOpText.Text;
            set => sopNoOpText.Text = value;
        }
        public string SopNoCleaning
        {
            get => sopNoClnText.Text;
            set => sopNoClnText.Text = value;
        }
        public string SopNoPreventiveMaintenance
        {
            get => sopNoPrvText.Text;
            set => sopNoPrvText.Text = value;
        }
        public int CalibrationFrequency
        {
            get => int.Parse(calibFreqText.Text);
            set => calibFreqText.Text = value.ToString();
        }
        public string EquipmentName
        {
            get => nameText.Text;
            set => nameText.Text = value;
        }
        public DateTime CalibrationTriggerDate
        {
            get => DateTime.ParseExact(ddlCalibTrig.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            set => ddlCalibTrig.Text = value.ToString("yyyy-MM-dd");
        }
        public string EquipmentSerialNo
        {
            get => eqpSerialText.Text;
            set => eqpSerialText.Text = value;
        }
        public string MakeValue
        {
            get => ddlMake.SelectedText;
            set => ddlMake.SelectedText = value;
        }
        public string ModelValue
        {
            get => ddlModel.SelectedText;
            set => ddlModel.SelectedText = value;
        }
        public int Year
        {
            get => int.Parse(yearText.Text);
            set => yearText.Text = value.ToString();
        }
        public decimal EquipmentAnnualBudget
        {
            get => decimal.Parse(eqpBudgetText.Text);
            set => eqpBudgetText.Text = value.ToString();
        }
        public string EquipmentTypeValue
        {
            get => ddlEqpType.SelectedText;
            set => ddlEqpType.SelectedText = value;
        }
        public string EquipmentStatusValue
        {
            get => ddlEqpStatus.SelectedText;
            set => ddlEqpStatus.SelectedText = value;
        }
        public int DecimalPlaces
        {
            get => int.Parse(decimalText.Text);
            set => decimalText.Text = value.ToString();
        }
        public string Identification
        {
            get => identText.Text;
            set => identText.Text = value;
        }
        public string PrimaryMeterValue
        {
            get => ddlPrimaryMet.SelectedText;
            set => ddlPrimaryMet.SelectedText = value;
        }
        public string SecondaryMeterValue
        {
            get => ddlSecMet.SelectedText;
            set => ddlSecMet.SelectedText = value;
        }
        public string Remarks
        {
            get => remarksText.Text;
            set => remarksText.Text = value;
        }
        public bool EquipmentHasMeter
        {
            get => hasMeterCheck.Checked;
            set => hasMeterCheck.Checked = value;
        }
        public bool IsExcludedInLineClearanceReport
        {
            get => isExcludedCheck.Checked;
            set => isExcludedCheck.Checked = value;
        }
        public bool IsActive
        {
            get => isActiveCheck.Checked;
            set => isActiveCheck.Checked = value;
        }
        public bool IsMoveable
        {
            get => moveableCheck.Checked;
            set => moveableCheck.Checked = value;
        }
        pl_equipmentRow IEquipmentView.Equipment { get; set; }
        public EquipmentPresenter Presenter { get; set; }
        #endregion

        public EditEquipment()
        {
            InitializeComponent();

            Presenter = new EquipmentPresenter(this, new EquipmentRepository());
        }

        private void Equipment_Load(object sender, EventArgs e)
        {
            Presenter.LoadEquipment(2);
            Presenter.LoadAllCombos();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (CheckControlsVal())
            {
                Presenter.UpdateEquipment();
                MessageBox.Show("Updated successfully.");
            }
            else
            {
                MessageBox.Show("Please provide all values.");
            }
        }

        private bool CheckControlsVal()
        {
            bool result = true;

            if (string.IsNullOrWhiteSpace(eqpNoText.Text)
                || string.IsNullOrWhiteSpace(nameText.Text)
                || string.IsNullOrWhiteSpace(sopNoOpText.Text)
                || string.IsNullOrWhiteSpace(sopNoClnText.Text)
                || string.IsNullOrWhiteSpace(calibFreqText.Text)
                || string.IsNullOrWhiteSpace(sopNoPrvText.Text)
                || string.IsNullOrWhiteSpace(eqpSerialText.Text)
                || string.IsNullOrWhiteSpace(ddlCalibTrig.SelectedText)
                || string.IsNullOrWhiteSpace(ddlMake.SelectedText)
                || string.IsNullOrWhiteSpace(ddlModel.SelectedText)
                || string.IsNullOrWhiteSpace(eqpBudgetText.Text)
                || string.IsNullOrWhiteSpace(yearText.Text)
                || string.IsNullOrWhiteSpace(ddlEqpStatus.SelectedText)
                || string.IsNullOrWhiteSpace(ddlEqpType.SelectedText)
                || string.IsNullOrWhiteSpace(decimalText.Text)
                || string.IsNullOrWhiteSpace(identText.Text)
                || string.IsNullOrWhiteSpace(ddlPrimaryMet.SelectedText)
                || string.IsNullOrWhiteSpace(ddlSecMet.SelectedText)
                || string.IsNullOrWhiteSpace(remarksText.Text)
                )
            {
                result = false;
            }

            return result;
        }

        public void PopulateAllDropDown(ColumnType dropDownType, List<string> items)
        {
            UltraCombo dropdown;

            switch (dropDownType)
            {
                case ColumnType.calibration_trigger_date:
                    dropdown = ddlCalibTrig;
                    break;
                case ColumnType.make_value:
                    dropdown = ddlMake;
                    break;
                case ColumnType.model_value:
                    dropdown = ddlModel;
                    break;
                case ColumnType.equipment_status:
                    dropdown = ddlEqpStatus;
                    break;
                case ColumnType.equipment_type:
                    dropdown = ddlEqpType;
                    break;
                case ColumnType.primary_meter:
                    dropdown = ddlPrimaryMet;
                    break;
                case ColumnType.secondary_meter:
                    dropdown = ddlSecMet;
                    break;
                default:
                    throw new ArgumentException("Invalid dropdown type specified.");
            }

            if (dropdown != null)
            {
                dropdown.DataSource = items;
            }
        }
    }
}
