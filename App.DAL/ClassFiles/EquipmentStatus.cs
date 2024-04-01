// <fileinfo name="EquipmentStatusCollection_Base.cs">
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
	/// The base class for <see cref="EquipmentStatusCollection"/>. Provides methods 
	/// for common database table operations. 
	/// </summary>
	/// <remarks>
	/// Do not change this source code. Update the <see cref="EquipmentStatusCollection"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public class EquipmentStatus
	{
		// Constants
		public const string IDColumnName = "ID";
		public const string UniqueCodeColumnName = "UniqueCode";
		public const string StatusNameColumnName = "StatusName";
		public const string StatusCaptionColumnName = "StatusCaption";
		public const string Details1ColumnName = "Details1";
		public const string Details2ColumnName = "Details2";
		public const string Details3ColumnName = "Details3";
		public const string Details4ColumnName = "Details4";
		public const string Details5ColumnName = "Details5";
		public const string IsDeletedColumnName = "IsDeleted";
		public const string IsActiveColumnName = "IsActive";

		// Instance fields
		private Internship2024DB _db;

		/// <summary>
		/// Initializes a new instance of the <see cref="EquipmentStatus"/> 
		/// class with the specified <see cref="RapTier"/>.
		/// </summary>
		/// <param name="db">The <see cref="RapTier"/> object.</param>
		public EquipmentStatus(Internship2024DB db)
		{
			_db = db;
		}

		/// <summary>
		/// Gets the database object that this table belongs to.
		///	</summary>
		///	<value>The <see cref="RapTier"/> object.</value>
		protected Internship2024DB Database
		{
			get { return _db; }
		}

		/// <summary>
		/// Gets an array of all records from the <c>EquipmentStatus</c> table.
		/// </summary>
		/// <returns>An array of <see cref="EquipmentStatusRow"/> objects.</returns>
		public virtual EquipmentStatusRow[] GetAll()
		{
			return MapRecords(CreateGetAllCommand());
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object that 
		/// includes all records from the <c>EquipmentStatus</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetAllAsDataTable()
		{
			return MapRecordsToDataTable(CreateGetAllCommand());
		}

		/// <summary>
		/// Creates and returns an <see cref="System.Data.SqlCommand"/> object that is used
		/// to retrieve all records from the <c>EquipmentStatus</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.SqlCommand"/> object.</returns>
		protected virtual SqlCommand CreateGetAllCommand()
		{
			return _db.CreateCommand("dbo.EquipmentStatus_GetAll", true);
		}

		/// <summary>
		/// Gets the first <see cref="EquipmentStatusRow"/> objects that 
		/// match the search condition.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>An instance of <see cref="EquipmentStatusRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public EquipmentStatusRow GetRow(string whereSql)
		{
			int totalRecordCount = -1;
			EquipmentStatusRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
			return 0 == rows.Length ? null : rows[0];
		}

		/// <summary>
		/// Gets an array of <see cref="EquipmentStatusRow"/> objects that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
		/// <returns>An array of <see cref="EquipmentStatusRow"/> objects.</returns>
		public EquipmentStatusRow[] GetAsArray(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsArray(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Gets an array of <see cref="EquipmentStatusRow"/> objects that 
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
		/// <returns>An array of <see cref="EquipmentStatusRow"/> objects.</returns>
		public virtual EquipmentStatusRow[] GetAsArray(string whereSql, string orderBySql,
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
			string sql = "SELECT * FROM [dbo].[EquipmentStatus]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			if(null != orderBySql && 0 < orderBySql.Length)
				sql += " ORDER BY " + orderBySql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Adds a new record into the <c>EquipmentStatus</c> table.
		/// </summary>
		/// <param name="value">The <see cref="EquipmentStatusRow"/> object to be inserted.</param>
		public virtual void Insert(EquipmentStatusRow value)
		{
			SqlCommand cmd = _db.CreateCommand("dbo.EquipmentStatus_Insert", true);
			AddParameter(cmd, "UniqueCode", value.UniqueCode);
			AddParameter(cmd, "StatusName", value.StatusName);
			AddParameter(cmd, "StatusCaption", value.StatusCaption);
			AddParameter(cmd, "Details1", value.Details1);
			AddParameter(cmd, "Details2", value.Details2);
			AddParameter(cmd, "Details3", value.Details3);
			AddParameter(cmd, "Details4", value.Details4);
			AddParameter(cmd, "Details5", value.Details5);
			AddParameter(cmd, "IsDeleted",
				value.IsIsDeletedNull ? DBNull.Value : (object)value.IsDeleted);
			AddParameter(cmd, "IsActive",
				value.IsIsActiveNull ? DBNull.Value : (object)value.IsActive);
			value.ID = Convert.ToInt64(cmd.ExecuteScalar());
		}

		/// <summary>
		/// Deletes <c>EquipmentStatus</c> records that match the specified criteria.
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
		/// to delete <c>EquipmentStatus</c> records that match the specified criteria.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. 
		/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>A reference to the <see cref="System.Data.SqlCommand"/> object.</returns>
		protected virtual SqlCommand CreateDeleteCommand(string whereSql)
		{
			string sql = "DELETE FROM [dbo].[EquipmentStatus]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Deletes all records from the <c>EquipmentStatus</c> table.
		/// </summary>
		/// <returns>The number of deleted records.</returns>
		public int DeleteAll()
		{
			return _db.CreateCommand("dbo.EquipmentStatus_DeleteAll", true).ExecuteNonQuery();
		}

		/// <summary>
		/// Reads data using the specified command and returns 
		/// an array of mapped objects.
		/// </summary>
		/// <param name="command">The <see cref="System.Data.SqlCommand"/> object.</param>
		/// <returns>An array of <see cref="EquipmentStatusRow"/> objects.</returns>
		protected EquipmentStatusRow[] MapRecords(SqlCommand command)
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
		/// <returns>An array of <see cref="EquipmentStatusRow"/> objects.</returns>
		protected EquipmentStatusRow[] MapRecords(SqlDataReader reader)
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
		/// <returns>An array of <see cref="EquipmentStatusRow"/> objects.</returns>
		protected virtual EquipmentStatusRow[] MapRecords(SqlDataReader reader, 
										int startIndex, int length, ref int totalRecordCount)
		{
			if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

			int idColumnIndex = reader.GetOrdinal("ID");
			int uniqueCodeColumnIndex = reader.GetOrdinal("UniqueCode");
			int statusNameColumnIndex = reader.GetOrdinal("StatusName");
			int statusCaptionColumnIndex = reader.GetOrdinal("StatusCaption");
			int details1ColumnIndex = reader.GetOrdinal("Details1");
			int details2ColumnIndex = reader.GetOrdinal("Details2");
			int details3ColumnIndex = reader.GetOrdinal("Details3");
			int details4ColumnIndex = reader.GetOrdinal("Details4");
			int details5ColumnIndex = reader.GetOrdinal("Details5");
			int isDeletedColumnIndex = reader.GetOrdinal("IsDeleted");
			int isActiveColumnIndex = reader.GetOrdinal("IsActive");

			System.Collections.ArrayList recordList = new System.Collections.ArrayList();
			int ri = -startIndex;
			while(reader.Read())
			{
				ri++;
				if(ri > 0 && ri <= length)
				{
					EquipmentStatusRow record = new EquipmentStatusRow();
					recordList.Add(record);

					record.ID = Convert.ToInt64(reader.GetValue(idColumnIndex));
					record.UniqueCode = Convert.ToString(reader.GetValue(uniqueCodeColumnIndex));
					record.StatusName = Convert.ToString(reader.GetValue(statusNameColumnIndex));
					record.StatusCaption = Convert.ToString(reader.GetValue(statusCaptionColumnIndex));
					if(!reader.IsDBNull(details1ColumnIndex))
						record.Details1 = Convert.ToString(reader.GetValue(details1ColumnIndex));
					if(!reader.IsDBNull(details2ColumnIndex))
						record.Details2 = Convert.ToString(reader.GetValue(details2ColumnIndex));
					if(!reader.IsDBNull(details3ColumnIndex))
						record.Details3 = Convert.ToString(reader.GetValue(details3ColumnIndex));
					if(!reader.IsDBNull(details4ColumnIndex))
						record.Details4 = Convert.ToString(reader.GetValue(details4ColumnIndex));
					if(!reader.IsDBNull(details5ColumnIndex))
						record.Details5 = Convert.ToString(reader.GetValue(details5ColumnIndex));
					if(!reader.IsDBNull(isDeletedColumnIndex))
						record.IsDeleted = Convert.ToBoolean(reader.GetValue(isDeletedColumnIndex));
					if(!reader.IsDBNull(isActiveColumnIndex))
						record.IsActive = Convert.ToBoolean(reader.GetValue(isActiveColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}

			totalRecordCount = 0 == totalRecordCount ? ri + startIndex : -1;
			return (EquipmentStatusRow[])(recordList.ToArray(typeof(EquipmentStatusRow)));
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
		/// Converts <see cref="System.Data.DataRow"/> to <see cref="EquipmentStatusRow"/>.
		/// </summary>
		/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
		/// <returns>A reference to the <see cref="EquipmentStatusRow"/> object.</returns>
		protected virtual EquipmentStatusRow MapRow(DataRow row)
		{
			EquipmentStatusRow mappedObject = new EquipmentStatusRow();
			DataTable dataTable = row.Table;
			DataColumn dataColumn;
			// Column "ID"
			dataColumn = dataTable.Columns["ID"];
			if(!row.IsNull(dataColumn))
				mappedObject.ID = (long)row[dataColumn];
			// Column "UniqueCode"
			dataColumn = dataTable.Columns["UniqueCode"];
			if(!row.IsNull(dataColumn))
				mappedObject.UniqueCode = (string)row[dataColumn];
			// Column "StatusName"
			dataColumn = dataTable.Columns["StatusName"];
			if(!row.IsNull(dataColumn))
				mappedObject.StatusName = (string)row[dataColumn];
			// Column "StatusCaption"
			dataColumn = dataTable.Columns["StatusCaption"];
			if(!row.IsNull(dataColumn))
				mappedObject.StatusCaption = (string)row[dataColumn];
			// Column "Details1"
			dataColumn = dataTable.Columns["Details1"];
			if(!row.IsNull(dataColumn))
				mappedObject.Details1 = (string)row[dataColumn];
			// Column "Details2"
			dataColumn = dataTable.Columns["Details2"];
			if(!row.IsNull(dataColumn))
				mappedObject.Details2 = (string)row[dataColumn];
			// Column "Details3"
			dataColumn = dataTable.Columns["Details3"];
			if(!row.IsNull(dataColumn))
				mappedObject.Details3 = (string)row[dataColumn];
			// Column "Details4"
			dataColumn = dataTable.Columns["Details4"];
			if(!row.IsNull(dataColumn))
				mappedObject.Details4 = (string)row[dataColumn];
			// Column "Details5"
			dataColumn = dataTable.Columns["Details5"];
			if(!row.IsNull(dataColumn))
				mappedObject.Details5 = (string)row[dataColumn];
			// Column "IsDeleted"
			dataColumn = dataTable.Columns["IsDeleted"];
			if(!row.IsNull(dataColumn))
				mappedObject.IsDeleted = (bool)row[dataColumn];
			// Column "IsActive"
			dataColumn = dataTable.Columns["IsActive"];
			if(!row.IsNull(dataColumn))
				mappedObject.IsActive = (bool)row[dataColumn];
			return mappedObject;
		}

		/// <summary>
		/// Creates a <see cref="System.Data.DataTable"/> object for 
		/// the <c>EquipmentStatus</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected virtual DataTable CreateDataTable()
		{
			DataTable dataTable = new DataTable();
			dataTable.TableName = "EquipmentStatus";
			DataColumn dataColumn;
			dataColumn = dataTable.Columns.Add("ID", typeof(long));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = true;
			dataColumn.Unique = true;
			dataColumn.AutoIncrement = true;
			dataColumn = dataTable.Columns.Add("UniqueCode", typeof(string));
			dataColumn.MaxLength = 20;
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("StatusName", typeof(string));
			dataColumn.MaxLength = 100;
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("StatusCaption", typeof(string));
			dataColumn.MaxLength = 100;
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Details1", typeof(string));
			dataColumn = dataTable.Columns.Add("Details2", typeof(string));
			dataColumn = dataTable.Columns.Add("Details3", typeof(string));
			dataColumn = dataTable.Columns.Add("Details4", typeof(string));
			dataColumn = dataTable.Columns.Add("Details5", typeof(string));
			dataColumn = dataTable.Columns.Add("IsDeleted", typeof(bool));
			dataColumn = dataTable.Columns.Add("IsActive", typeof(bool));
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
				case "ID":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int64, value);
					break;

				case "UniqueCode":
					parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
					break;

				case "StatusName":
					parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
					break;

				case "StatusCaption":
					parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
					break;

				case "Details1":
					parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
					break;

				case "Details2":
					parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
					break;

				case "Details3":
					parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
					break;

				case "Details4":
					parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
					break;

				case "Details5":
					parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
					break;

				case "IsDeleted":
					parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
					break;

				case "IsActive":
					parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
					break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
			}
			return parameter;
		}
	} // End of EquipmentStatusCollection_Base class
}  // End of namespace
