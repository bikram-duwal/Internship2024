// <fileinfo name="pl_equipmentRow_Base.cs">
//		<copyright>
//			All rights reserved.
//		</copyright>
//		<remarks>
//			Do not change this source code manually. Changes to this file may 
//			cause incorrect behavior and will be lost if the code is regenerated.
//		</remarks>
//		<generator rewritefile="True" infourl="http://www.SharpPower.com">RapTier</generator>
// </fileinfo>

using System;

namespace Internship2024
{
	/// <summary>
	/// The base class for <see cref="pl_equipmentRow"/> that 
	/// represents a record in the <c>pl_equipment</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="pl_equipmentRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public class pl_equipmentRow
	{
		private long _equipment_id;
		private long _table_pid;
		private bool _table_pidNull = true;
		private string _unique_code;
		private string _area;
		private string _equipment_no;
		private string _name;
		private string _sop_no_operation;
		private string _sop_no_cleaning;
		private string _sop_no_preventive_maintenance;
		private int _calibration_frequency;
		private bool _calibration_frequencyNull = true;
		private int _calibration_trigger_date_id;
		private bool _calibration_trigger_date_idNull = true;
		private string _equipment_serial_No;
		private int _make_id;
		private bool _make_idNull = true;
		private int _model_id;
		private bool _model_idNull = true;
		private int _year;
		private bool _yearNull = true;
		private decimal _equipment_annual_budget;
		private bool _equipment_annual_budgetNull = true;
		private int _equipment_type_id;
		private bool _equipment_type_idNull = true;
		private int _equipment_status_id;
		private bool _equipment_status_idNull = true;
		private int _decimal_places;
		private bool _decimal_placesNull = true;
		private string _identification;
		private int _primary_meter_id;
		private bool _primary_meter_idNull = true;
		private int _secondary_meter_id;
		private bool _secondary_meter_idNull = true;
		private string _remarks;
		private bool _equipment_has_meter;
		private bool _equipment_has_meterNull = true;
		private bool _is_excluded_in_line_clearance_report;
		private bool _is_excluded_in_line_clearance_reportNull = true;
		private bool _is_active;
		private bool _is_activeNull = true;
		private bool _is_moveable;
		private bool _is_moveableNull = true;
		private System.DateTime _timestamp_column;
		private bool _timestamp_columnNull = true;

		/// <summary>
		/// Initializes a new instance of the <see cref="pl_equipmentRow"/> class.
		/// </summary>
		public pl_equipmentRow()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>equipment_id</c> column value.
		/// </summary>
		/// <value>The <c>equipment_id</c> column value.</value>
		public long Equipment_id
		{
			get { return _equipment_id; }
			set { _equipment_id = value; }
		}

		/// <summary>
		/// Gets or sets the <c>table_pid</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>table_pid</c> column value.</value>
		public long Table_pid
		{
			get
			{
				if(IsTable_pidNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _table_pid;
			}
			set
			{
				_table_pidNull = false;
				_table_pid = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Table_pid"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsTable_pidNull
		{
			get { return _table_pidNull; }
			set { _table_pidNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>unique_code</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>unique_code</c> column value.</value>
		public string Unique_code
		{
			get { return _unique_code; }
			set { _unique_code = value; }
		}

		/// <summary>
		/// Gets or sets the <c>area</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>area</c> column value.</value>
		public string Area
		{
			get { return _area; }
			set { _area = value; }
		}

		/// <summary>
		/// Gets or sets the <c>equipment_no</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>equipment_no</c> column value.</value>
		public string Equipment_no
		{
			get { return _equipment_no; }
			set { _equipment_no = value; }
		}

		/// <summary>
		/// Gets or sets the <c>name</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>name</c> column value.</value>
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		/// <summary>
		/// Gets or sets the <c>sop_no_operation</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>sop_no_operation</c> column value.</value>
		public string Sop_no_operation
		{
			get { return _sop_no_operation; }
			set { _sop_no_operation = value; }
		}

		/// <summary>
		/// Gets or sets the <c>sop_no_cleaning</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>sop_no_cleaning</c> column value.</value>
		public string Sop_no_cleaning
		{
			get { return _sop_no_cleaning; }
			set { _sop_no_cleaning = value; }
		}

		/// <summary>
		/// Gets or sets the <c>sop_no_preventive_maintenance</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>sop_no_preventive_maintenance</c> column value.</value>
		public string Sop_no_preventive_maintenance
		{
			get { return _sop_no_preventive_maintenance; }
			set { _sop_no_preventive_maintenance = value; }
		}

		/// <summary>
		/// Gets or sets the <c>calibration_frequency</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>calibration_frequency</c> column value.</value>
		public int Calibration_frequency
		{
			get
			{
				if(IsCalibration_frequencyNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _calibration_frequency;
			}
			set
			{
				_calibration_frequencyNull = false;
				_calibration_frequency = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Calibration_frequency"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsCalibration_frequencyNull
		{
			get { return _calibration_frequencyNull; }
			set { _calibration_frequencyNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>calibration_trigger_date_id</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>calibration_trigger_date_id</c> column value.</value>
		public int Calibration_trigger_date_id
		{
			get
			{
				if(IsCalibration_trigger_date_idNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _calibration_trigger_date_id;
			}
			set
			{
				_calibration_trigger_date_idNull = false;
				_calibration_trigger_date_id = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Calibration_trigger_date_id"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsCalibration_trigger_date_idNull
		{
			get { return _calibration_trigger_date_idNull; }
			set { _calibration_trigger_date_idNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>equipment_serial_No</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>equipment_serial_No</c> column value.</value>
		public string Equipment_serial_No
		{
			get { return _equipment_serial_No; }
			set { _equipment_serial_No = value; }
		}

		/// <summary>
		/// Gets or sets the <c>make_id</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>make_id</c> column value.</value>
		public int Make_id
		{
			get
			{
				if(IsMake_idNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _make_id;
			}
			set
			{
				_make_idNull = false;
				_make_id = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Make_id"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsMake_idNull
		{
			get { return _make_idNull; }
			set { _make_idNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>model_id</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>model_id</c> column value.</value>
		public int Model_id
		{
			get
			{
				if(IsModel_idNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _model_id;
			}
			set
			{
				_model_idNull = false;
				_model_id = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Model_id"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsModel_idNull
		{
			get { return _model_idNull; }
			set { _model_idNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>year</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>year</c> column value.</value>
		public int Year
		{
			get
			{
				if(IsYearNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _year;
			}
			set
			{
				_yearNull = false;
				_year = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Year"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsYearNull
		{
			get { return _yearNull; }
			set { _yearNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>equipment_annual_budget</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>equipment_annual_budget</c> column value.</value>
		public decimal Equipment_annual_budget
		{
			get
			{
				if(IsEquipment_annual_budgetNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _equipment_annual_budget;
			}
			set
			{
				_equipment_annual_budgetNull = false;
				_equipment_annual_budget = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Equipment_annual_budget"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsEquipment_annual_budgetNull
		{
			get { return _equipment_annual_budgetNull; }
			set { _equipment_annual_budgetNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>equipment_type_id</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>equipment_type_id</c> column value.</value>
		public int Equipment_type_id
		{
			get
			{
				if(IsEquipment_type_idNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _equipment_type_id;
			}
			set
			{
				_equipment_type_idNull = false;
				_equipment_type_id = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Equipment_type_id"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsEquipment_type_idNull
		{
			get { return _equipment_type_idNull; }
			set { _equipment_type_idNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>equipment_status_id</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>equipment_status_id</c> column value.</value>
		public int Equipment_status_id
		{
			get
			{
				if(IsEquipment_status_idNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _equipment_status_id;
			}
			set
			{
				_equipment_status_idNull = false;
				_equipment_status_id = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Equipment_status_id"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsEquipment_status_idNull
		{
			get { return _equipment_status_idNull; }
			set { _equipment_status_idNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>decimal_places</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>decimal_places</c> column value.</value>
		public int Decimal_places
		{
			get
			{
				if(IsDecimal_placesNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _decimal_places;
			}
			set
			{
				_decimal_placesNull = false;
				_decimal_places = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Decimal_places"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsDecimal_placesNull
		{
			get { return _decimal_placesNull; }
			set { _decimal_placesNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>identification</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>identification</c> column value.</value>
		public string Identification
		{
			get { return _identification; }
			set { _identification = value; }
		}

		/// <summary>
		/// Gets or sets the <c>primary_meter_id</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>primary_meter_id</c> column value.</value>
		public int Primary_meter_id
		{
			get
			{
				if(IsPrimary_meter_idNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _primary_meter_id;
			}
			set
			{
				_primary_meter_idNull = false;
				_primary_meter_id = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Primary_meter_id"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsPrimary_meter_idNull
		{
			get { return _primary_meter_idNull; }
			set { _primary_meter_idNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>secondary_meter_id</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>secondary_meter_id</c> column value.</value>
		public int Secondary_meter_id
		{
			get
			{
				if(IsSecondary_meter_idNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _secondary_meter_id;
			}
			set
			{
				_secondary_meter_idNull = false;
				_secondary_meter_id = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Secondary_meter_id"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsSecondary_meter_idNull
		{
			get { return _secondary_meter_idNull; }
			set { _secondary_meter_idNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>remarks</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>remarks</c> column value.</value>
		public string Remarks
		{
			get { return _remarks; }
			set { _remarks = value; }
		}

		/// <summary>
		/// Gets or sets the <c>equipment_has_meter</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>equipment_has_meter</c> column value.</value>
		public bool Equipment_has_meter
		{
			get
			{
				if(IsEquipment_has_meterNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _equipment_has_meter;
			}
			set
			{
				_equipment_has_meterNull = false;
				_equipment_has_meter = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Equipment_has_meter"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsEquipment_has_meterNull
		{
			get { return _equipment_has_meterNull; }
			set { _equipment_has_meterNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>is_excluded_in_line_clearance_report</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>is_excluded_in_line_clearance_report</c> column value.</value>
		public bool Is_excluded_in_line_clearance_report
		{
			get
			{
				if(IsIs_excluded_in_line_clearance_reportNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _is_excluded_in_line_clearance_report;
			}
			set
			{
				_is_excluded_in_line_clearance_reportNull = false;
				_is_excluded_in_line_clearance_report = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Is_excluded_in_line_clearance_report"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsIs_excluded_in_line_clearance_reportNull
		{
			get { return _is_excluded_in_line_clearance_reportNull; }
			set { _is_excluded_in_line_clearance_reportNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>is_active</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>is_active</c> column value.</value>
		public bool Is_active
		{
			get
			{
				if(IsIs_activeNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _is_active;
			}
			set
			{
				_is_activeNull = false;
				_is_active = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Is_active"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsIs_activeNull
		{
			get { return _is_activeNull; }
			set { _is_activeNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>is_moveable</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>is_moveable</c> column value.</value>
		public bool Is_moveable
		{
			get
			{
				if(IsIs_moveableNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _is_moveable;
			}
			set
			{
				_is_moveableNull = false;
				_is_moveable = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Is_moveable"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsIs_moveableNull
		{
			get { return _is_moveableNull; }
			set { _is_moveableNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>timestamp_column</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>timestamp_column</c> column value.</value>
		public System.DateTime Timestamp_column
		{
			get
			{
				if(IsTimestamp_columnNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _timestamp_column;
			}
			set
			{
				_timestamp_columnNull = false;
				_timestamp_column = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Timestamp_column"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsTimestamp_columnNull
		{
			get { return _timestamp_columnNull; }
			set { _timestamp_columnNull = value; }
		}

		/// <summary>
		/// Returns the string representation of this instance.
		/// </summary>
		/// <returns>The string representation of this instance.</returns>
		public override string ToString()
		{
			System.Text.StringBuilder dynStr = new System.Text.StringBuilder(GetType().Name);
			dynStr.Append(':');
			dynStr.Append("  Equipment_id=");
			dynStr.Append(Equipment_id);
			dynStr.Append("  Table_pid=");
			dynStr.Append(IsTable_pidNull ? (object)"<NULL>" : Table_pid);
			dynStr.Append("  Unique_code=");
			dynStr.Append(Unique_code);
			dynStr.Append("  Area=");
			dynStr.Append(Area);
			dynStr.Append("  Equipment_no=");
			dynStr.Append(Equipment_no);
			dynStr.Append("  Name=");
			dynStr.Append(Name);
			dynStr.Append("  Sop_no_operation=");
			dynStr.Append(Sop_no_operation);
			dynStr.Append("  Sop_no_cleaning=");
			dynStr.Append(Sop_no_cleaning);
			dynStr.Append("  Sop_no_preventive_maintenance=");
			dynStr.Append(Sop_no_preventive_maintenance);
			dynStr.Append("  Calibration_frequency=");
			dynStr.Append(IsCalibration_frequencyNull ? (object)"<NULL>" : Calibration_frequency);
			dynStr.Append("  Calibration_trigger_date_id=");
			dynStr.Append(IsCalibration_trigger_date_idNull ? (object)"<NULL>" : Calibration_trigger_date_id);
			dynStr.Append("  Equipment_serial_No=");
			dynStr.Append(Equipment_serial_No);
			dynStr.Append("  Make_id=");
			dynStr.Append(IsMake_idNull ? (object)"<NULL>" : Make_id);
			dynStr.Append("  Model_id=");
			dynStr.Append(IsModel_idNull ? (object)"<NULL>" : Model_id);
			dynStr.Append("  Year=");
			dynStr.Append(IsYearNull ? (object)"<NULL>" : Year);
			dynStr.Append("  Equipment_annual_budget=");
			dynStr.Append(IsEquipment_annual_budgetNull ? (object)"<NULL>" : Equipment_annual_budget);
			dynStr.Append("  Equipment_type_id=");
			dynStr.Append(IsEquipment_type_idNull ? (object)"<NULL>" : Equipment_type_id);
			dynStr.Append("  Equipment_status_id=");
			dynStr.Append(IsEquipment_status_idNull ? (object)"<NULL>" : Equipment_status_id);
			dynStr.Append("  Decimal_places=");
			dynStr.Append(IsDecimal_placesNull ? (object)"<NULL>" : Decimal_places);
			dynStr.Append("  Identification=");
			dynStr.Append(Identification);
			dynStr.Append("  Primary_meter_id=");
			dynStr.Append(IsPrimary_meter_idNull ? (object)"<NULL>" : Primary_meter_id);
			dynStr.Append("  Secondary_meter_id=");
			dynStr.Append(IsSecondary_meter_idNull ? (object)"<NULL>" : Secondary_meter_id);
			dynStr.Append("  Remarks=");
			dynStr.Append(Remarks);
			dynStr.Append("  Equipment_has_meter=");
			dynStr.Append(IsEquipment_has_meterNull ? (object)"<NULL>" : Equipment_has_meter);
			dynStr.Append("  Is_excluded_in_line_clearance_report=");
			dynStr.Append(IsIs_excluded_in_line_clearance_reportNull ? (object)"<NULL>" : Is_excluded_in_line_clearance_report);
			dynStr.Append("  Is_active=");
			dynStr.Append(IsIs_activeNull ? (object)"<NULL>" : Is_active);
			dynStr.Append("  Is_moveable=");
			dynStr.Append(IsIs_moveableNull ? (object)"<NULL>" : Is_moveable);
			dynStr.Append("  Timestamp_column=");
			dynStr.Append(IsTimestamp_columnNull ? (object)"<NULL>" : Timestamp_column);
			return dynStr.ToString();
		}
	} // End of pl_equipmentRow_Base class
} // End of namespace
