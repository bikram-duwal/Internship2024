using App.DAL.Repositories;
using Infragistics.Win.UltraWinGrid;
using Internship2024.Presenter;
using Internship2024.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public DateTime CalibrationTriggerDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string EquipmentSerialNo
        {
            get => eqpSerialText.Text;
            set => eqpSerialText.Text = value;
        }
        public string MakeValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ModelValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
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
        public string EquipmentTypeValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string EquipmentStatusValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
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
        public string PrimaryMeterValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SecondaryMeterValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
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
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Presenter.UpdateEquipment();
        }
    }
}
