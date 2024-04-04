// <fileinfo name="pl_equipmentCollection_Base.cs">
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
using System.Data;
using System.Data.SqlClient;

namespace Internship2024
{
	/// <summary>
	/// The base class for <see cref="pl_equipmentCollection"/>. Provides methods 
	/// for common database table operations. 
	/// </summary>
	/// <remarks>
	/// Do not change this source code. Update the <see cref="pl_equipmentCollection"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public class pl_equipment
	{
		// Constants
		public const string Equipment_idColumnName = "equipment_id";
		public const string Table_pidColumnName = "table_pid";
		public const string Unique_codeColumnName = "unique_code";
		public const string AreaColumnName = "area";
		public const string Equipment_noColumnName = "equipment_no";
		public const string NameColumnName = "name";
		public const string Sop_no_operationColumnName = "sop_no_operation";
		public const string Sop_no_cleaningColumnName = "sop_no_cleaning";
		public const string Sop_no_preventive_maintenanceColumnName = "sop_no_preventive_maintenance";
		public const string Calibration_frequencyColumnName = "calibration_frequency";
		public const string Calibration_trigger_dateColumnName = "calibration_trigger_date";
		public const string Equipment_serial_NoColumnName = "equipment_serial_No";
		public const string Make_valueColumnName = "make_value";
		public const string Model_valueColumnName = "model_value";
		public const string YearColumnName = "year";
		public const string Equipment_annual_budgetColumnName = "equipment_annual_budget";
		public const string Equipment_type_valueColumnName = "equipment_type_value";
		public const string Equipment_status_valueColumnName = "equipment_status_value";
		public const string Decimal_placesColumnName = "decimal_places";
		public const string IdentificationColumnName = "identification";
		public const string Primary_meter_valueColumnName = "primary_meter_value";
		public const string Secondary_meter_valueColumnName = "secondary_meter_value";
		public const string RemarksColumnName = "remarks";
		public const string Equipment_has_meterColumnName = "equipment_has_meter";
		public const string Is_excluded_in_line_clearance_reportColumnName = "is_excluded_in_line_clearance_report";
		public const string Is_activeColumnName = "is_active";
		public const string Is_moveableColumnName = "is_moveable";
		public const string Timestamp_columnColumnName = "timestamp_column";

		// Instance fields
		private InternTaskDbContext _db;

		/// <summary>
		/// Initializes a new instance of the <see cref="pl_equipment"/> 
		/// class with the specified <see cref="InternTaskDbContext"/>.
		/// </summary>
		/// <param name="db">The <see cref="InternTaskDbContext"/> object.</param>
		public pl_equipment(InternTaskDbContext db)
		{
			_db = db;
		}

		/// <summary>
		/// Gets the database object that this table belongs to.
		///	</summary>
		///	<value>The <see cref="InternTaskDbContext"/> object.</value>
		protected InternTaskDbContext Database
		{
			get { return _db; }
		}

		/// <summary>
		/// Gets an array of all records from the <c>pl_equipment</c> table.
		/// </summary>
		/// <returns>An array of <see cref="pl_equipmentRow"/> objects.</returns>
		public virtual pl_equipmentRow[] GetAll()
		{
			return MapRecords(CreateGetAllCommand());
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object that 
		/// includes all records from the <c>pl_equipment</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetAllAsDataTable()
		{
			return MapRecordsToDataTable(CreateGetAllCommand());
		}

		/// <summary>
		/// Creates and returns an <see cref="System.Data.SqlCommand"/> object that is used
		/// to retrieve all records from the <c>pl_equipment</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.SqlCommand"/> object.</returns>
		protected virtual SqlCommand CreateGetAllCommand()
		{
			return _db.CreateCommand("dbo.pl_equipment_GetAll", true);
		}

		/// <summary>
		/// Gets the first <see cref="pl_equipmentRow"/> objects that 
		/// match the search condition.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>An instance of <see cref="pl_equipmentRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public pl_equipmentRow GetRow(string whereSql)
		{
			int totalRecordCount = -1;
			pl_equipmentRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
			return 0 == rows.Length ? null : rows[0];
		}

		/// <summary>
		/// Gets an array of <see cref="pl_equipmentRow"/> objects that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
		/// <returns>An array of <see cref="pl_equipmentRow"/> objects.</returns>
		public pl_equipmentRow[] GetAsArray(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsArray(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Gets an array of <see cref="pl_equipmentRow"/> objects that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example:
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
		/// <param name="startIndex">The index of the first record to return.</param>
		/// <param name="length">The number of records to return.</param>
		/// <param name="totalRecordCount">A reference parameter that returns the total number 
		/// of records in the reader object if 0 was passed into the method; otherwise it returns -1.</param>
		/// <returns>An array of <see cref="pl_equipmentRow"/> objects.</returns>
		public virtual pl_equipmentRow[] GetAsArray(string whereSql, string orderBySql,
							int startIndex, int length, ref int totalRecordCount)
		{
			using(SqlDataReader reader = _db.ExecuteReader(CreateGetCommand(whereSql, orderBySql)))
			{
				return MapRecords(reader, startIndex, length, ref totalRecordCount);
			}
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object filled with data that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: "FirstName='Smith' AND Zip=75038".</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: "LastName ASC, FirstName ASC".</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public DataTable GetAsDataTable(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsDataTable(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object filled with data that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: "FirstName='Smith' AND Zip=75038".</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: "LastName ASC, FirstName ASC".</param>
		/// <param name="startIndex">The index of the first record to return.</param>
		/// <param name="length">The number of records to return.</param>
		/// <param name="totalRecordCount">A reference parameter that returns the total number 
		/// of records in the reader object if 0 was passed into the method; otherwise it returns -1.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetAsDataTable(string whereSql, string orderBySql,
							int startIndex, int length, ref int totalRecordCount)
		{
			using(SqlDataReader reader = _db.ExecuteReader(CreateGetCommand(whereSql, orderBySql)))
			{
				return MapRecordsToDataTable(reader, startIndex, length, ref totalRecordCount);
			}
		}

		/// <summary>
		/// Creates an <see cref="System.Data.SqlCommand"/> object for the specified search criteria.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: "FirstName='Smith' AND Zip=75038".</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: "LastName ASC, FirstName ASC".</param>
		/// <returns>A reference to the <see cref="System.Data.SqlCommand"/> object.</returns>
		protected virtual SqlCommand CreateGetCommand(string whereSql, string orderBySql)
		{
			string sql = "SELECT * FROM [dbo].[pl_equipment]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			if(null != orderBySql && 0 < orderBySql.Length)
				sql += " ORDER BY " + orderBySql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Gets <see cref="pl_equipmentRow"/> by the primary key.
		/// </summary>
		/// <param name="equipment_id">The <c>equipment_id</c> column value.</param>
		/// <returns>An instance of <see cref="pl_equipmentRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public virtual pl_equipmentRow GetByPrimaryKey(long equipment_id)
		{
			SqlCommand cmd = _db.CreateCommand("dbo.pl_equipment_GetByPrimaryKey", true);
			AddParameter(cmd, "Equipment_id", equipment_id);
			pl_equipmentRow[] tempArray = MapRecords(cmd);
			return 0 == tempArray.Length ? null : tempArray[0];
		}

		/// <summary>
		/// Adds a new record into the <c>pl_equipment</c> table.
		/// </summary>
		/// <param name="value">The <see cref="pl_equipmentRow"/> object to be inserted.</param>
		public virtual void Insert(pl_equipmentRow value)
		{
			SqlCommand cmd = _db.CreateCommand("dbo.pl_equipment_Insert", true);
			AddParameter(cmd, "Table_pid",
				value.IsTable_pidNull ? DBNull.Value : (object)value.Table_pid);
			AddParameter(cmd, "Unique_code", value.Unique_code);
			AddParameter(cmd, "Area", value.Area);
			AddParameter(cmd, "Equipment_no", value.Equipment_no);
			AddParameter(cmd, "Name", value.Name);
			AddParameter(cmd, "Sop_no_operation", value.Sop_no_operation);
			AddParameter(cmd, "Sop_no_cleaning", value.Sop_no_cleaning);
			AddParameter(cmd, "Sop_no_preventive_maintenance", value.Sop_no_preventive_maintenance);
			AddParameter(cmd, "Calibration_frequency",
				value.IsCalibration_frequencyNull ? DBNull.Value : (object)value.Calibration_frequency);
			AddParameter(cmd, "Calibration_trigger_date",
				value.IsCalibration_trigger_dateNull ? DBNull.Value : (object)value.Calibration_trigger_date);
			AddParameter(cmd, "Equipment_serial_No", value.Equipment_serial_No);
			AddParameter(cmd, "Make_value", value.Make_value);
			AddParameter(cmd, "Model_value", value.Model_value);
			AddParameter(cmd, "Year",
				value.IsYearNull ? DBNull.Value : (object)value.Year);
			AddParameter(cmd, "Equipment_annual_budget",
				value.IsEquipment_annual_budgetNull ? DBNull.Value : (object)value.Equipment_annual_budget);
			AddParameter(cmd, "Equipment_type_value", value.Equipment_type_value);
			AddParameter(cmd, "Equipment_status_value", value.Equipment_status_value);
			AddParameter(cmd, "Decimal_places",
				value.IsDecimal_placesNull ? DBNull.Value : (object)value.Decimal_places);
			AddParameter(cmd, "Identification", value.Identification);
			AddParameter(cmd, "Primary_meter_value", value.Primary_meter_value);
			AddParameter(cmd, "Secondary_meter_value", value.Secondary_meter_value);
			AddParameter(cmd, "Remarks", value.Remarks);
			AddParameter(cmd, "Equipment_has_meter",
				value.IsEquipment_has_meterNull ? DBNull.Value : (object)value.Equipment_has_meter);
			AddParameter(cmd, "Is_excluded_in_line_clearance_report",
				value.IsIs_excluded_in_line_clearance_reportNull ? DBNull.Value : (object)value.Is_excluded_in_line_clearance_report);
			AddParameter(cmd, "Is_active",
				value.IsIs_activeNull ? DBNull.Value : (object)value.Is_active);
			AddParameter(cmd, "Is_moveable",
				value.IsIs_moveableNull ? DBNull.Value : (object)value.Is_moveable);
			AddParameter(cmd, "Timestamp_column",
				value.IsTimestamp_columnNull ? DBNull.Value : (object)value.Timestamp_column);
			value.Equipment_id = Convert.ToInt64(cmd.ExecuteScalar());
		}

		/// <summary>
		/// Updates a record in the <c>pl_equipment</c> table.
		/// </summary>
		/// <param name="value">The <see cref="pl_equipmentRow"/>
		/// object used to update the table record.</param>
		/// <returns>true if the record was updated; otherwise, false.</returns>
		public virtual bool Update(pl_equipmentRow value)
		{
			SqlCommand cmd = _db.CreateCommand("dbo.pl_equipment_Update", true);
			AddParameter(cmd, "Table_pid",
				value.IsTable_pidNull ? DBNull.Value : (object)value.Table_pid);
			AddParameter(cmd, "Unique_code", value.Unique_code);
			AddParameter(cmd, "Area", value.Area);
			AddParameter(cmd, "Equipment_no", value.Equipment_no);
			AddParameter(cmd, "Name", value.Name);
			AddParameter(cmd, "Sop_no_operation", value.Sop_no_operation);
			AddParameter(cmd, "Sop_no_cleaning", value.Sop_no_cleaning);
			AddParameter(cmd, "Sop_no_preventive_maintenance", value.Sop_no_preventive_maintenance);
			AddParameter(cmd, "Calibration_frequency",
				value.IsCalibration_frequencyNull ? DBNull.Value : (object)value.Calibration_frequency);
			AddParameter(cmd, "Calibration_trigger_date",
				value.IsCalibration_trigger_dateNull ? DBNull.Value : (object)value.Calibration_trigger_date);
			AddParameter(cmd, "Equipment_serial_No", value.Equipment_serial_No);
			AddParameter(cmd, "Make_value", value.Make_value);
			AddParameter(cmd, "Model_value", value.Model_value);
			AddParameter(cmd, "Year",
				value.IsYearNull ? DBNull.Value : (object)value.Year);
			AddParameter(cmd, "Equipment_annual_budget",
				value.IsEquipment_annual_budgetNull ? DBNull.Value : (object)value.Equipment_annual_budget);
			AddParameter(cmd, "Equipment_type_value", value.Equipment_type_value);
			AddParameter(cmd, "Equipment_status_value", value.Equipment_status_value);
			AddParameter(cmd, "Decimal_places",
				value.IsDecimal_placesNull ? DBNull.Value : (object)value.Decimal_places);
			AddParameter(cmd, "Identification", value.Identification);
			AddParameter(cmd, "Primary_meter_value", value.Primary_meter_value);
			AddParameter(cmd, "Secondary_meter_value", value.Secondary_meter_value);
			AddParameter(cmd, "Remarks", value.Remarks);
			AddParameter(cmd, "Equipment_has_meter",
				value.IsEquipment_has_meterNull ? DBNull.Value : (object)value.Equipment_has_meter);
			AddParameter(cmd, "Is_excluded_in_line_clearance_report",
				value.IsIs_excluded_in_line_clearance_reportNull ? DBNull.Value : (object)value.Is_excluded_in_line_clearance_report);
			AddParameter(cmd, "Is_active",
				value.IsIs_activeNull ? DBNull.Value : (object)value.Is_active);
			AddParameter(cmd, "Is_moveable",
				value.IsIs_moveableNull ? DBNull.Value : (object)value.Is_moveable);
			AddParameter(cmd, "Timestamp_column",
				value.IsTimestamp_columnNull ? DBNull.Value : (object)value.Timestamp_column);
			AddParameter(cmd, "Equipment_id", value.Equipment_id);
			return 0 != cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Updates the <c>pl_equipment</c> table and calls the <c>AcceptChanges</c> method
		/// on the changed DataRow objects.
		/// </summary>
		/// <param name="table">The <see cref="System.Data.DataTable"/> used to update the data source.</param>
		public void Update(DataTable table)
		{
			Update(table, true);
		}

		/// <summary>
		/// Updates the <c>pl_equipment</c> table. Pass <c>false</c> as the <c>acceptChanges</c> 
		/// argument when your code calls this method in an ADO.NET transaction context. Note that in 
		/// this case, after you call the Update method you need call either <c>AcceptChanges</c> 
		/// or <c>RejectChanges</c> method on the DataTable object.
		/// <code>
		/// MyDb db = new MyDb();
		/// try
		/// {
		///		db.BeginTransaction();
		///		db.MyCollection.Update(myDataTable, false);
		///		db.CommitTransaction();
		///		myDataTable.AcceptChanges();
		/// }
		/// catch(Exception)
		/// {
		///		db.RollbackTransaction();
		///		myDataTable.RejectChanges();
		/// }
		/// </code>
		/// </summary>
		/// <param name="table">The <see cref="System.Data.DataTable"/> used to update the data source.</param>
		/// <param name="acceptChanges">Specifies whether this method calls the <c>AcceptChanges</c>
		/// method on the changed DataRow objects.</param>
		public virtual void Update(DataTable table, bool acceptChanges)
		{
			DataRowCollection rows = table.Rows;
			for(int i = rows.Count - 1; i >= 0; i--)
			{
				DataRow row = rows[i];
				switch(row.RowState)
				{
					case DataRowState.Added:
						Insert(MapRow(row));
						if(acceptChanges)
							row.AcceptChanges();
						break;

					case DataRowState.Deleted:
						// Temporary reject changes to be able to access to the PK column(s)
						row.RejectChanges();
						try
						{
							DeleteByPrimaryKey((long)row["Equipment_id"]);
						}
						finally
						{
							row.Delete();
						}
						if(acceptChanges)
							row.AcceptChanges();
						break;
						
					case DataRowState.Modified:
						Update(MapRow(row));
						if(acceptChanges)
							row.AcceptChanges();
						break;
				}
			}
		}

		/// <summary>
		/// Deletes the specified object from the <c>pl_equipment</c> table.
		/// </summary>
		/// <param name="value">The <see cref="pl_equipmentRow"/> object to delete.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public bool Delete(pl_equipmentRow value)
		{
			return DeleteByPrimaryKey(value.Equipment_id);
		}

		/// <summary>
		/// Deletes a record from the <c>pl_equipment</c> table using
		/// the specified primary key.
		/// </summary>
		/// <param name="equipment_id">The <c>equipment_id</c> column value.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public virtual bool DeleteByPrimaryKey(long equipment_id)
		{
			SqlCommand cmd = _db.CreateCommand("dbo.pl_equipment_DeleteByPrimaryKey", true);
			AddParameter(cmd, "Equipment_id", equipment_id);
			return 0 < cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Deletes <c>pl_equipment</c> records that match the specified criteria.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. 
		/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>The number of deleted records.</returns>
		public int Delete(string whereSql)
		{
			return CreateDeleteCommand(whereSql).ExecuteNonQuery();
		}

		/// <summary>
		/// Creates an <see cref="System.Data.SqlCommand"/> object that can be used 
		/// to delete <c>pl_equipment</c> records that match the specified criteria.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. 
		/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>A reference to the <see cref="System.Data.SqlCommand"/> object.</returns>
		protected virtual SqlCommand CreateDeleteCommand(string whereSql)
		{
			string sql = "DELETE FROM [dbo].[pl_equipment]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Deletes all records from the <c>pl_equipment</c> table.
		/// </summary>
		/// <returns>The number of deleted records.</returns>
		public int DeleteAll()
		{
			return _db.CreateCommand("dbo.pl_equipment_DeleteAll", true).ExecuteNonQuery();
		}

		/// <summary>
		/// Reads data using the specified command and returns 
		/// an array of mapped objects.
		/// </summary>
		/// <param name="command">The <see cref="System.Data.SqlCommand"/> object.</param>
		/// <returns>An array of <see cref="pl_equipmentRow"/> objects.</returns>
		protected pl_equipmentRow[] MapRecords(SqlCommand command)
		{
			using(SqlDataReader reader = _db.ExecuteReader(command))
			{
				return MapRecords(reader);
			}
		}

		/// <summary>
		/// Reads data from the provided data reader and returns 
		/// an array of mapped objects.
		/// </summary>
		/// <param name="reader">The <see cref="System.Data.SqlDataReader"/> object to read data from the table.</param>
		/// <returns>An array of <see cref="pl_equipmentRow"/> objects.</returns>
		protected pl_equipmentRow[] MapRecords(SqlDataReader reader)
		{
			int totalRecordCount = -1;
			return MapRecords(reader, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Reads data from the provided data reader and returns 
		/// an array of mapped objects.
		/// </summary>
		/// <param name="reader">The <see cref="System.Data.SqlDataReader"/> object to read data from the table.</param>
		/// <param name="startIndex">The index of the first record to map.</param>
		/// <param name="length">The number of records to map.</param>
		/// <param name="totalRecordCount">A reference parameter that returns the total number 
		/// of records in the reader object if 0 was passed into the method; otherwise it returns -1.</param>
		/// <returns>An array of <see cref="pl_equipmentRow"/> objects.</returns>
		protected virtual pl_equipmentRow[] MapRecords(SqlDataReader reader, 
										int startIndex, int length, ref int totalRecordCount)
		{
			if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

			int equipment_idColumnIndex = reader.GetOrdinal("equipment_id");
			int table_pidColumnIndex = reader.GetOrdinal("table_pid");
			int unique_codeColumnIndex = reader.GetOrdinal("unique_code");
			int areaColumnIndex = reader.GetOrdinal("area");
			int equipment_noColumnIndex = reader.GetOrdinal("equipment_no");
			int nameColumnIndex = reader.GetOrdinal("name");
			int sop_no_operationColumnIndex = reader.GetOrdinal("sop_no_operation");
			int sop_no_cleaningColumnIndex = reader.GetOrdinal("sop_no_cleaning");
			int sop_no_preventive_maintenanceColumnIndex = reader.GetOrdinal("sop_no_preventive_maintenance");
			int calibration_frequencyColumnIndex = reader.GetOrdinal("calibration_frequency");
			int calibration_trigger_dateColumnIndex = reader.GetOrdinal("calibration_trigger_date");
			int equipment_serial_NoColumnIndex = reader.GetOrdinal("equipment_serial_No");
			int make_valueColumnIndex = reader.GetOrdinal("make_value");
			int model_valueColumnIndex = reader.GetOrdinal("model_value");
			int yearColumnIndex = reader.GetOrdinal("year");
			int equipment_annual_budgetColumnIndex = reader.GetOrdinal("equipment_annual_budget");
			int equipment_type_valueColumnIndex = reader.GetOrdinal("equipment_type_value");
			int equipment_status_valueColumnIndex = reader.GetOrdinal("equipment_status_value");
			int decimal_placesColumnIndex = reader.GetOrdinal("decimal_places");
			int identificationColumnIndex = reader.GetOrdinal("identification");
			int primary_meter_valueColumnIndex = reader.GetOrdinal("primary_meter_value");
			int secondary_meter_valueColumnIndex = reader.GetOrdinal("secondary_meter_value");
			int remarksColumnIndex = reader.GetOrdinal("remarks");
			int equipment_has_meterColumnIndex = reader.GetOrdinal("equipment_has_meter");
			int is_excluded_in_line_clearance_reportColumnIndex = reader.GetOrdinal("is_excluded_in_line_clearance_report");
			int is_activeColumnIndex = reader.GetOrdinal("is_active");
			int is_moveableColumnIndex = reader.GetOrdinal("is_moveable");
			int timestamp_columnColumnIndex = reader.GetOrdinal("timestamp_column");

			System.Collections.ArrayList recordList = new System.Collections.ArrayList();
			int ri = -startIndex;
			while(reader.Read())
			{
				ri++;
				if(ri > 0 && ri <= length)
				{
					pl_equipmentRow record = new pl_equipmentRow();
					recordList.Add(record);

					record.Equipment_id = Convert.ToInt64(reader.GetValue(equipment_idColumnIndex));
					if(!reader.IsDBNull(table_pidColumnIndex))
						record.Table_pid = Convert.ToInt64(reader.GetValue(table_pidColumnIndex));
					if(!reader.IsDBNull(unique_codeColumnIndex))
						record.Unique_code = Convert.ToString(reader.GetValue(unique_codeColumnIndex));
					if(!reader.IsDBNull(areaColumnIndex))
						record.Area = Convert.ToString(reader.GetValue(areaColumnIndex));
					if(!reader.IsDBNull(equipment_noColumnIndex))
						record.Equipment_no = Convert.ToString(reader.GetValue(equipment_noColumnIndex));
					if(!reader.IsDBNull(nameColumnIndex))
						record.Name = Convert.ToString(reader.GetValue(nameColumnIndex));
					if(!reader.IsDBNull(sop_no_operationColumnIndex))
						record.Sop_no_operation = Convert.ToString(reader.GetValue(sop_no_operationColumnIndex));
					if(!reader.IsDBNull(sop_no_cleaningColumnIndex))
						record.Sop_no_cleaning = Convert.ToString(reader.GetValue(sop_no_cleaningColumnIndex));
					if(!reader.IsDBNull(sop_no_preventive_maintenanceColumnIndex))
						record.Sop_no_preventive_maintenance = Convert.ToString(reader.GetValue(sop_no_preventive_maintenanceColumnIndex));
					if(!reader.IsDBNull(calibration_frequencyColumnIndex))
						record.Calibration_frequency = Convert.ToInt32(reader.GetValue(calibration_frequencyColumnIndex));
					if(!reader.IsDBNull(calibration_trigger_dateColumnIndex))
						record.Calibration_trigger_date = Convert.ToDateTime(reader.GetValue(calibration_trigger_dateColumnIndex));
					if(!reader.IsDBNull(equipment_serial_NoColumnIndex))
						record.Equipment_serial_No = Convert.ToString(reader.GetValue(equipment_serial_NoColumnIndex));
					if(!reader.IsDBNull(make_valueColumnIndex))
						record.Make_value = Convert.ToString(reader.GetValue(make_valueColumnIndex));
					if(!reader.IsDBNull(model_valueColumnIndex))
						record.Model_value = Convert.ToString(reader.GetValue(model_valueColumnIndex));
					if(!reader.IsDBNull(yearColumnIndex))
						record.Year = Convert.ToInt32(reader.GetValue(yearColumnIndex));
					if(!reader.IsDBNull(equipment_annual_budgetColumnIndex))
						record.Equipment_annual_budget = Convert.ToDecimal(reader.GetValue(equipment_annual_budgetColumnIndex));
					if(!reader.IsDBNull(equipment_type_valueColumnIndex))
						record.Equipment_type_value = Convert.ToString(reader.GetValue(equipment_type_valueColumnIndex));
					if(!reader.IsDBNull(equipment_status_valueColumnIndex))
						record.Equipment_status_value = Convert.ToString(reader.GetValue(equipment_status_valueColumnIndex));
					if(!reader.IsDBNull(decimal_placesColumnIndex))
						record.Decimal_places = Convert.ToInt32(reader.GetValue(decimal_placesColumnIndex));
					if(!reader.IsDBNull(identificationColumnIndex))
						record.Identification = Convert.ToString(reader.GetValue(identificationColumnIndex));
					if(!reader.IsDBNull(primary_meter_valueColumnIndex))
						record.Primary_meter_value = Convert.ToString(reader.GetValue(primary_meter_valueColumnIndex));
					if(!reader.IsDBNull(secondary_meter_valueColumnIndex))
						record.Secondary_meter_value = Convert.ToString(reader.GetValue(secondary_meter_valueColumnIndex));
					if(!reader.IsDBNull(remarksColumnIndex))
						record.Remarks = Convert.ToString(reader.GetValue(remarksColumnIndex));
					if(!reader.IsDBNull(equipment_has_meterColumnIndex))
						record.Equipment_has_meter = Convert.ToBoolean(reader.GetValue(equipment_has_meterColumnIndex));
					if(!reader.IsDBNull(is_excluded_in_line_clearance_reportColumnIndex))
						record.Is_excluded_in_line_clearance_report = Convert.ToBoolean(reader.GetValue(is_excluded_in_line_clearance_reportColumnIndex));
					if(!reader.IsDBNull(is_activeColumnIndex))
						record.Is_active = Convert.ToBoolean(reader.GetValue(is_activeColumnIndex));
					if(!reader.IsDBNull(is_moveableColumnIndex))
						record.Is_moveable = Convert.ToBoolean(reader.GetValue(is_moveableColumnIndex));
					if(!reader.IsDBNull(timestamp_columnColumnIndex))
						record.Timestamp_column = Convert.ToDateTime(reader.GetValue(timestamp_columnColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}

			totalRecordCount = 0 == totalRecordCount ? ri + startIndex : -1;
			return (pl_equipmentRow[])(recordList.ToArray(typeof(pl_equipmentRow)));
		}

		/// <summary>
		/// Reads data using the specified command and returns 
		/// a filled <see cref="System.Data.DataTable"/> object.
		/// </summary>
		/// <param name="command">The <see cref="System.Data.SqlCommand"/> object.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected DataTable MapRecordsToDataTable(SqlCommand command)
		{
			using(SqlDataReader reader = _db.ExecuteReader(command))
			{
				return MapRecordsToDataTable(reader);
			}
		}

		/// <summary>
		/// Reads data from the provided data reader and returns 
		/// a filled <see cref="System.Data.DataTable"/> object.
		/// </summary>
		/// <param name="reader">The <see cref="System.Data.SqlDataReader"/> object to read data from the table.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected DataTable MapRecordsToDataTable(SqlDataReader reader)
		{
			int totalRecordCount = 0;
			return MapRecordsToDataTable(reader, 0, int.MaxValue, ref totalRecordCount);
		}
		
		/// <summary>
		/// Reads data from the provided data reader and returns 
		/// a filled <see cref="System.Data.DataTable"/> object.
		/// </summary>
		/// <param name="reader">The <see cref="System.Data.SqlDataReader"/> object to read data from the table.</param>
		/// <param name="startIndex">The index of the first record to read.</param>
		/// <param name="length">The number of records to read.</param>
		/// <param name="totalRecordCount">A reference parameter that returns the total number 
		/// of records in the reader object if 0 was passed into the method; otherwise it returns -1.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected virtual DataTable MapRecordsToDataTable(SqlDataReader reader, 
										int startIndex, int length, ref int totalRecordCount)
		{
			if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

			int columnCount = reader.FieldCount;
			int ri = -startIndex;
			
			DataTable dataTable = CreateDataTable();
			dataTable.BeginLoadData();
			object[] values = new object[columnCount];

			while(reader.Read())
			{
				ri++;
				if(ri > 0 && ri <= length)
				{
					reader.GetValues(values);
					dataTable.LoadDataRow(values, true);

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}
			dataTable.EndLoadData();

			totalRecordCount = 0 == totalRecordCount ? ri + startIndex : -1;
			return dataTable;
		}

		/// <summary>
		/// Converts <see cref="System.Data.DataRow"/> to <see cref="pl_equipmentRow"/>.
		/// </summary>
		/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
		/// <returns>A reference to the <see cref="pl_equipmentRow"/> object.</returns>
		protected virtual pl_equipmentRow MapRow(DataRow row)
		{
			pl_equipmentRow mappedObject = new pl_equipmentRow();
			DataTable dataTable = row.Table;
			DataColumn dataColumn;
			// Column "Equipment_id"
			dataColumn = dataTable.Columns["Equipment_id"];
			if(!row.IsNull(dataColumn))
				mappedObject.Equipment_id = (long)row[dataColumn];
			// Column "Table_pid"
			dataColumn = dataTable.Columns["Table_pid"];
			if(!row.IsNull(dataColumn))
				mappedObject.Table_pid = (long)row[dataColumn];
			// Column "Unique_code"
			dataColumn = dataTable.Columns["Unique_code"];
			if(!row.IsNull(dataColumn))
				mappedObject.Unique_code = (string)row[dataColumn];
			// Column "Area"
			dataColumn = dataTable.Columns["Area"];
			if(!row.IsNull(dataColumn))
				mappedObject.Area = (string)row[dataColumn];
			// Column "Equipment_no"
			dataColumn = dataTable.Columns["Equipment_no"];
			if(!row.IsNull(dataColumn))
				mappedObject.Equipment_no = (string)row[dataColumn];
			// Column "Name"
			dataColumn = dataTable.Columns["Name"];
			if(!row.IsNull(dataColumn))
				mappedObject.Name = (string)row[dataColumn];
			// Column "Sop_no_operation"
			dataColumn = dataTable.Columns["Sop_no_operation"];
			if(!row.IsNull(dataColumn))
				mappedObject.Sop_no_operation = (string)row[dataColumn];
			// Column "Sop_no_cleaning"
			dataColumn = dataTable.Columns["Sop_no_cleaning"];
			if(!row.IsNull(dataColumn))
				mappedObject.Sop_no_cleaning = (string)row[dataColumn];
			// Column "Sop_no_preventive_maintenance"
			dataColumn = dataTable.Columns["Sop_no_preventive_maintenance"];
			if(!row.IsNull(dataColumn))
				mappedObject.Sop_no_preventive_maintenance = (string)row[dataColumn];
			// Column "Calibration_frequency"
			dataColumn = dataTable.Columns["Calibration_frequency"];
			if(!row.IsNull(dataColumn))
				mappedObject.Calibration_frequency = (int)row[dataColumn];
			// Column "Calibration_trigger_date"
			dataColumn = dataTable.Columns["Calibration_trigger_date"];
			if(!row.IsNull(dataColumn))
				mappedObject.Calibration_trigger_date = (System.DateTime)row[dataColumn];
			// Column "Equipment_serial_No"
			dataColumn = dataTable.Columns["Equipment_serial_No"];
			if(!row.IsNull(dataColumn))
				mappedObject.Equipment_serial_No = (string)row[dataColumn];
			// Column "Make_value"
			dataColumn = dataTable.Columns["Make_value"];
			if(!row.IsNull(dataColumn))
				mappedObject.Make_value = (string)row[dataColumn];
			// Column "Model_value"
			dataColumn = dataTable.Columns["Model_value"];
			if(!row.IsNull(dataColumn))
				mappedObject.Model_value = (string)row[dataColumn];
			// Column "Year"
			dataColumn = dataTable.Columns["Year"];
			if(!row.IsNull(dataColumn))
				mappedObject.Year = (int)row[dataColumn];
			// Column "Equipment_annual_budget"
			dataColumn = dataTable.Columns["Equipment_annual_budget"];
			if(!row.IsNull(dataColumn))
				mappedObject.Equipment_annual_budget = (decimal)row[dataColumn];
			// Column "Equipment_type_value"
			dataColumn = dataTable.Columns["Equipment_type_value"];
			if(!row.IsNull(dataColumn))
				mappedObject.Equipment_type_value = (string)row[dataColumn];
			// Column "Equipment_status_value"
			dataColumn = dataTable.Columns["Equipment_status_value"];
			if(!row.IsNull(dataColumn))
				mappedObject.Equipment_status_value = (string)row[dataColumn];
			// Column "Decimal_places"
			dataColumn = dataTable.Columns["Decimal_places"];
			if(!row.IsNull(dataColumn))
				mappedObject.Decimal_places = (int)row[dataColumn];
			// Column "Identification"
			dataColumn = dataTable.Columns["Identification"];
			if(!row.IsNull(dataColumn))
				mappedObject.Identification = (string)row[dataColumn];
			// Column "Primary_meter_value"
			dataColumn = dataTable.Columns["Primary_meter_value"];
			if(!row.IsNull(dataColumn))
				mappedObject.Primary_meter_value = (string)row[dataColumn];
			// Column "Secondary_meter_value"
			dataColumn = dataTable.Columns["Secondary_meter_value"];
			if(!row.IsNull(dataColumn))
				mappedObject.Secondary_meter_value = (string)row[dataColumn];
			// Column "Remarks"
			dataColumn = dataTable.Columns["Remarks"];
			if(!row.IsNull(dataColumn))
				mappedObject.Remarks = (string)row[dataColumn];
			// Column "Equipment_has_meter"
			dataColumn = dataTable.Columns["Equipment_has_meter"];
			if(!row.IsNull(dataColumn))
				mappedObject.Equipment_has_meter = (bool)row[dataColumn];
			// Column "Is_excluded_in_line_clearance_report"
			dataColumn = dataTable.Columns["Is_excluded_in_line_clearance_report"];
			if(!row.IsNull(dataColumn))
				mappedObject.Is_excluded_in_line_clearance_report = (bool)row[dataColumn];
			// Column "Is_active"
			dataColumn = dataTable.Columns["Is_active"];
			if(!row.IsNull(dataColumn))
				mappedObject.Is_active = (bool)row[dataColumn];
			// Column "Is_moveable"
			dataColumn = dataTable.Columns["Is_moveable"];
			if(!row.IsNull(dataColumn))
				mappedObject.Is_moveable = (bool)row[dataColumn];
			// Column "Timestamp_column"
			dataColumn = dataTable.Columns["Timestamp_column"];
			if(!row.IsNull(dataColumn))
				mappedObject.Timestamp_column = (System.DateTime)row[dataColumn];
			return mappedObject;
		}

		/// <summary>
		/// Creates a <see cref="System.Data.DataTable"/> object for 
		/// the <c>pl_equipment</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected virtual DataTable CreateDataTable()
		{
			DataTable dataTable = new DataTable();
			dataTable.TableName = "pl_equipment";
			DataColumn dataColumn;
			dataColumn = dataTable.Columns.Add("Equipment_id", typeof(long));
			dataColumn.Caption = "equipment_id";
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = true;
			dataColumn.Unique = true;
			dataColumn.AutoIncrement = true;
			dataColumn = dataTable.Columns.Add("Table_pid", typeof(long));
			dataColumn.Caption = "table_pid";
			dataColumn = dataTable.Columns.Add("Unique_code", typeof(string));
			dataColumn.Caption = "unique_code";
			dataColumn.MaxLength = 10;
			dataColumn = dataTable.Columns.Add("Area", typeof(string));
			dataColumn.Caption = "area";
			dataColumn.MaxLength = 200;
			dataColumn = dataTable.Columns.Add("Equipment_no", typeof(string));
			dataColumn.Caption = "equipment_no";
			dataColumn.MaxLength = 100;
			dataColumn = dataTable.Columns.Add("Name", typeof(string));
			dataColumn.Caption = "name";
			dataColumn.MaxLength = 200;
			dataColumn = dataTable.Columns.Add("Sop_no_operation", typeof(string));
			dataColumn.Caption = "sop_no_operation";
			dataColumn.MaxLength = 100;
			dataColumn = dataTable.Columns.Add("Sop_no_cleaning", typeof(string));
			dataColumn.Caption = "sop_no_cleaning";
			dataColumn.MaxLength = 100;
			dataColumn = dataTable.Columns.Add("Sop_no_preventive_maintenance", typeof(string));
			dataColumn.Caption = "sop_no_preventive_maintenance";
			dataColumn.MaxLength = 100;
			dataColumn = dataTable.Columns.Add("Calibration_frequency", typeof(int));
			dataColumn.Caption = "calibration_frequency";
			dataColumn = dataTable.Columns.Add("Calibration_trigger_date", typeof(System.DateTime));
			dataColumn.Caption = "calibration_trigger_date";
			dataColumn = dataTable.Columns.Add("Equipment_serial_No", typeof(string));
			dataColumn.Caption = "equipment_serial_No";
			dataColumn.MaxLength = 100;
			dataColumn = dataTable.Columns.Add("Make_value", typeof(string));
			dataColumn.Caption = "make_value";
			dataColumn.MaxLength = 60;
			dataColumn = dataTable.Columns.Add("Model_value", typeof(string));
			dataColumn.Caption = "model_value";
			dataColumn.MaxLength = 60;
			dataColumn = dataTable.Columns.Add("Year", typeof(int));
			dataColumn.Caption = "year";
			dataColumn = dataTable.Columns.Add("Equipment_annual_budget", typeof(decimal));
			dataColumn.Caption = "equipment_annual_budget";
			dataColumn = dataTable.Columns.Add("Equipment_type_value", typeof(string));
			dataColumn.Caption = "equipment_type_value";
			dataColumn.MaxLength = 60;
			dataColumn = dataTable.Columns.Add("Equipment_status_value", typeof(string));
			dataColumn.Caption = "equipment_status_value";
			dataColumn.MaxLength = 60;
			dataColumn = dataTable.Columns.Add("Decimal_places", typeof(int));
			dataColumn.Caption = "decimal_places";
			dataColumn = dataTable.Columns.Add("Identification", typeof(string));
			dataColumn.Caption = "identification";
			dataColumn.MaxLength = 100;
			dataColumn = dataTable.Columns.Add("Primary_meter_value", typeof(string));
			dataColumn.Caption = "primary_meter_value";
			dataColumn.MaxLength = 60;
			dataColumn = dataTable.Columns.Add("Secondary_meter_value", typeof(string));
			dataColumn.Caption = "secondary_meter_value";
			dataColumn.MaxLength = 60;
			dataColumn = dataTable.Columns.Add("Remarks", typeof(string));
			dataColumn.Caption = "remarks";
			dataColumn = dataTable.Columns.Add("Equipment_has_meter", typeof(bool));
			dataColumn.Caption = "equipment_has_meter";
			dataColumn = dataTable.Columns.Add("Is_excluded_in_line_clearance_report", typeof(bool));
			dataColumn.Caption = "is_excluded_in_line_clearance_report";
			dataColumn = dataTable.Columns.Add("Is_active", typeof(bool));
			dataColumn.Caption = "is_active";
			dataColumn = dataTable.Columns.Add("Is_moveable", typeof(bool));
			dataColumn.Caption = "is_moveable";
			dataColumn = dataTable.Columns.Add("Timestamp_column", typeof(System.DateTime));
			dataColumn.Caption = "timestamp_column";
			return dataTable;
		}
		
		/// <summary>
		/// Adds a new parameter to the specified command.
		/// </summary>
		/// <param name="cmd">The <see cref="System.Data.SqlCommand"/> object to add the parameter to.</param>
		/// <param name="paramName">The name of the parameter.</param>
		/// <param name="value">The value of the parameter.</param>
		/// <returns>A reference to the added parameter.</returns>
		protected virtual SqlParameter AddParameter(SqlCommand cmd, string paramName, object value)
		{
			SqlParameter parameter;
			switch(paramName)
			{
				case "Equipment_id":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int64, value);
					break;

				case "Table_pid":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int64, value);
					break;

				case "Unique_code":
					parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
					break;

				case "Area":
					parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
					break;

				case "Equipment_no":
					parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
					break;

				case "Name":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "Sop_no_operation":
					parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
					break;

				case "Sop_no_cleaning":
					parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
					break;

				case "Sop_no_preventive_maintenance":
					parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
					break;

				case "Calibration_frequency":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Calibration_trigger_date":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
					break;

				case "Equipment_serial_No":
					parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
					break;

				case "Make_value":
					parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
					break;

				case "Model_value":
					parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
					break;

				case "Year":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Equipment_annual_budget":
					parameter = _db.AddParameter(cmd, paramName, DbType.Decimal, value);
					break;

				case "Equipment_type_value":
					parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
					break;

				case "Equipment_status_value":
					parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
					break;

				case "Decimal_places":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int32, value);
					break;

				case "Identification":
					parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
					break;

				case "Primary_meter_value":
					parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
					break;

				case "Secondary_meter_value":
					parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
					break;

				case "Remarks":
					parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
					break;

				case "Equipment_has_meter":
					parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
					break;

				case "Is_excluded_in_line_clearance_report":
					parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
					break;

				case "Is_active":
					parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
					break;

				case "Is_moveable":
					parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
					break;

				case "Timestamp_column":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
					break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
			}
			return parameter;
		}
	} // End of pl_equipmentCollection_Base class
}  // End of namespace
