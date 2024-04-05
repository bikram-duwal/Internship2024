// <fileinfo name="MakeCollection_Base.cs">
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
	/// The base class for <see cref="MakeCollection"/>. Provides methods 
	/// for common database table operations. 
	/// </summary>
	/// <remarks>
	/// Do not change this source code. Update the <see cref="MakeCollection"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public class Make
	{
		// Constants
		public const string IDColumnName = "ID";
		public const string UniqueCodeColumnName = "UniqueCode";
		public const string NameColumnName = "Name";
		public const string CaptionColumnName = "Caption";
		public const string Details1ColumnName = "Details1";
		public const string Details2ColumnName = "Details2";
		public const string Details3ColumnName = "Details3";
		public const string Details4ColumnName = "Details4";
		public const string Details5ColumnName = "Details5";
		public const string CreatedByColumnName = "CreatedBy";
		public const string CreatedDateColumnName = "CreatedDate";
		public const string ModifiedByColumnName = "ModifiedBy";
		public const string ModifiedDateColumnName = "ModifiedDate";
		public const string IsDeletedColumnName = "IsDeleted";
		public const string IsActiveColumnName = "IsActive";
		public const string DescriptionColumnColumnName = "DescriptionColumn";

		// Instance fields
		private Internship2024DB _db;

		/// <summary>
		/// Initializes a new instance of the <see cref="Make"/> 
		/// class with the specified <see cref="RapTier"/>.
		/// </summary>
		/// <param name="db">The <see cref="RapTier"/> object.</param>
		public Make(Internship2024DB db)
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
		/// Gets an array of all records from the <c>Make</c> table.
		/// </summary>
		/// <returns>An array of <see cref="MakeRow"/> objects.</returns>
		public virtual MakeRow[] GetAll()
		{
			return MapRecords(CreateGetAllCommand());
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object that 
		/// includes all records from the <c>Make</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetAllAsDataTable()
		{
			return MapRecordsToDataTable(CreateGetAllCommand());
		}

		/// <summary>
		/// Creates and returns an <see cref="System.Data.SqlCommand"/> object that is used
		/// to retrieve all records from the <c>Make</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.SqlCommand"/> object.</returns>
		protected virtual SqlCommand CreateGetAllCommand()
		{
			return _db.CreateCommand("dbo.Make_GetAll", true);
		}

		/// <summary>
		/// Gets the first <see cref="MakeRow"/> objects that 
		/// match the search condition.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>An instance of <see cref="MakeRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public MakeRow GetRow(string whereSql)
		{
			int totalRecordCount = -1;
			MakeRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
			return 0 == rows.Length ? null : rows[0];
		}

		/// <summary>
		/// Gets an array of <see cref="MakeRow"/> objects that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
		/// <returns>An array of <see cref="MakeRow"/> objects.</returns>
		public MakeRow[] GetAsArray(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsArray(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Gets an array of <see cref="MakeRow"/> objects that 
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
		/// <returns>An array of <see cref="MakeRow"/> objects.</returns>
		public virtual MakeRow[] GetAsArray(string whereSql, string orderBySql,
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
			string sql = "SELECT * FROM [dbo].[Make]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			if(null != orderBySql && 0 < orderBySql.Length)
				sql += " ORDER BY " + orderBySql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Gets <see cref="MakeRow"/> by the primary key.
		/// </summary>
		/// <param name="id">The <c>ID</c> column value.</param>
		/// <returns>An instance of <see cref="MakeRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public virtual MakeRow GetByPrimaryKey(long id)
		{
			SqlCommand cmd = _db.CreateCommand("dbo.Make_GetByPrimaryKey", true);
			AddParameter(cmd, "ID", id);
			MakeRow[] tempArray = MapRecords(cmd);
			return 0 == tempArray.Length ? null : tempArray[0];
		}

		/// <summary>
		/// Adds a new record into the <c>Make</c> table.
		/// </summary>
		/// <param name="value">The <see cref="MakeRow"/> object to be inserted.</param>
		public virtual void Insert(MakeRow value)
		{
			SqlCommand cmd = _db.CreateCommand("dbo.Make_Insert", true);
			AddParameter(cmd, "UniqueCode", value.UniqueCode);
			AddParameter(cmd, "Name", value.Name);
			AddParameter(cmd, "Caption", value.Caption);
			AddParameter(cmd, "Details1", value.Details1);
			AddParameter(cmd, "Details2", value.Details2);
			AddParameter(cmd, "Details3", value.Details3);
			AddParameter(cmd, "Details4", value.Details4);
			AddParameter(cmd, "Details5", value.Details5);
			AddParameter(cmd, "CreatedBy", value.CreatedBy);
			AddParameter(cmd, "CreatedDate", value.CreatedDate);
			AddParameter(cmd, "ModifiedBy",
				value.IsModifiedByNull ? DBNull.Value : (object)value.ModifiedBy);
			AddParameter(cmd, "ModifiedDate",
				value.IsModifiedDateNull ? DBNull.Value : (object)value.ModifiedDate);
			AddParameter(cmd, "IsDeleted",
				value.IsIsDeletedNull ? DBNull.Value : (object)value.IsDeleted);
			AddParameter(cmd, "IsActive",
				value.IsIsActiveNull ? DBNull.Value : (object)value.IsActive);
			AddParameter(cmd, "DescriptionColumn", value.DescriptionColumn);
			value.ID = Convert.ToInt64(cmd.ExecuteScalar());
		}

		/// <summary>
		/// Updates a record in the <c>Make</c> table.
		/// </summary>
		/// <param name="value">The <see cref="MakeRow"/>
		/// object used to update the table record.</param>
		/// <returns>true if the record was updated; otherwise, false.</returns>
		public virtual bool Update(MakeRow value)
		{
			SqlCommand cmd = _db.CreateCommand("dbo.Make_Update", true);
			AddParameter(cmd, "UniqueCode", value.UniqueCode);
			AddParameter(cmd, "Name", value.Name);
			AddParameter(cmd, "Caption", value.Caption);
			AddParameter(cmd, "Details1", value.Details1);
			AddParameter(cmd, "Details2", value.Details2);
			AddParameter(cmd, "Details3", value.Details3);
			AddParameter(cmd, "Details4", value.Details4);
			AddParameter(cmd, "Details5", value.Details5);
			AddParameter(cmd, "CreatedBy", value.CreatedBy);
			AddParameter(cmd, "CreatedDate", value.CreatedDate);
			AddParameter(cmd, "ModifiedBy",
				value.IsModifiedByNull ? DBNull.Value : (object)value.ModifiedBy);
			AddParameter(cmd, "ModifiedDate",
				value.IsModifiedDateNull ? DBNull.Value : (object)value.ModifiedDate);
			AddParameter(cmd, "IsDeleted",
				value.IsIsDeletedNull ? DBNull.Value : (object)value.IsDeleted);
			AddParameter(cmd, "IsActive",
				value.IsIsActiveNull ? DBNull.Value : (object)value.IsActive);
			AddParameter(cmd, "DescriptionColumn", value.DescriptionColumn);
			AddParameter(cmd, "ID", value.ID);
			return 0 != cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Updates the <c>Make</c> table and calls the <c>AcceptChanges</c> method
		/// on the changed DataRow objects.
		/// </summary>
		/// <param name="table">The <see cref="System.Data.DataTable"/> used to update the data source.</param>
		public void Update(DataTable table)
		{
			Update(table, true);
		}

		/// <summary>
		/// Updates the <c>Make</c> table. Pass <c>false</c> as the <c>acceptChanges</c> 
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
							DeleteByPrimaryKey((long)row["ID"]);
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
		/// Deletes the specified object from the <c>Make</c> table.
		/// </summary>
		/// <param name="value">The <see cref="MakeRow"/> object to delete.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public bool Delete(MakeRow value)
		{
			return DeleteByPrimaryKey(value.ID);
		}

		/// <summary>
		/// Deletes a record from the <c>Make</c> table using
		/// the specified primary key.
		/// </summary>
		/// <param name="id">The <c>ID</c> column value.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public virtual bool DeleteByPrimaryKey(long id)
		{
			SqlCommand cmd = _db.CreateCommand("dbo.Make_DeleteByPrimaryKey", true);
			AddParameter(cmd, "ID", id);
			return 0 < cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Deletes <c>Make</c> records that match the specified criteria.
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
		/// to delete <c>Make</c> records that match the specified criteria.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. 
		/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>A reference to the <see cref="System.Data.SqlCommand"/> object.</returns>
		protected virtual SqlCommand CreateDeleteCommand(string whereSql)
		{
			string sql = "DELETE FROM [dbo].[Make]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Deletes all records from the <c>Make</c> table.
		/// </summary>
		/// <returns>The number of deleted records.</returns>
		public int DeleteAll()
		{
			return _db.CreateCommand("dbo.Make_DeleteAll", true).ExecuteNonQuery();
		}

		/// <summary>
		/// Reads data using the specified command and returns 
		/// an array of mapped objects.
		/// </summary>
		/// <param name="command">The <see cref="System.Data.SqlCommand"/> object.</param>
		/// <returns>An array of <see cref="MakeRow"/> objects.</returns>
		protected MakeRow[] MapRecords(SqlCommand command)
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
		/// <returns>An array of <see cref="MakeRow"/> objects.</returns>
		protected MakeRow[] MapRecords(SqlDataReader reader)
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
		/// <returns>An array of <see cref="MakeRow"/> objects.</returns>
		protected virtual MakeRow[] MapRecords(SqlDataReader reader, 
										int startIndex, int length, ref int totalRecordCount)
		{
			if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

			int idColumnIndex = reader.GetOrdinal("ID");
			int uniqueCodeColumnIndex = reader.GetOrdinal("UniqueCode");
			int nameColumnIndex = reader.GetOrdinal("Name");
			int captionColumnIndex = reader.GetOrdinal("Caption");
			int details1ColumnIndex = reader.GetOrdinal("Details1");
			int details2ColumnIndex = reader.GetOrdinal("Details2");
			int details3ColumnIndex = reader.GetOrdinal("Details3");
			int details4ColumnIndex = reader.GetOrdinal("Details4");
			int details5ColumnIndex = reader.GetOrdinal("Details5");
			int createdByColumnIndex = reader.GetOrdinal("CreatedBy");
			int createdDateColumnIndex = reader.GetOrdinal("CreatedDate");
			int modifiedByColumnIndex = reader.GetOrdinal("ModifiedBy");
			int modifiedDateColumnIndex = reader.GetOrdinal("ModifiedDate");
			int isDeletedColumnIndex = reader.GetOrdinal("IsDeleted");
			int isActiveColumnIndex = reader.GetOrdinal("IsActive");
			int descriptionColumnColumnIndex = reader.GetOrdinal("DescriptionColumn");

			System.Collections.ArrayList recordList = new System.Collections.ArrayList();
			int ri = -startIndex;
			while(reader.Read())
			{
				ri++;
				if(ri > 0 && ri <= length)
				{
					MakeRow record = new MakeRow();
					recordList.Add(record);

					record.ID = Convert.ToInt64(reader.GetValue(idColumnIndex));
					record.UniqueCode = Convert.ToString(reader.GetValue(uniqueCodeColumnIndex));
					record.Name = Convert.ToString(reader.GetValue(nameColumnIndex));
					record.Caption = Convert.ToString(reader.GetValue(captionColumnIndex));
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
					record.CreatedBy = Convert.ToInt64(reader.GetValue(createdByColumnIndex));
					record.CreatedDate = Convert.ToDateTime(reader.GetValue(createdDateColumnIndex));
					if(!reader.IsDBNull(modifiedByColumnIndex))
						record.ModifiedBy = Convert.ToInt64(reader.GetValue(modifiedByColumnIndex));
					if(!reader.IsDBNull(modifiedDateColumnIndex))
						record.ModifiedDate = Convert.ToDateTime(reader.GetValue(modifiedDateColumnIndex));
					if(!reader.IsDBNull(isDeletedColumnIndex))
						record.IsDeleted = Convert.ToBoolean(reader.GetValue(isDeletedColumnIndex));
					if(!reader.IsDBNull(isActiveColumnIndex))
						record.IsActive = Convert.ToBoolean(reader.GetValue(isActiveColumnIndex));
					record.DescriptionColumn = Convert.ToString(reader.GetValue(descriptionColumnColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}

			totalRecordCount = 0 == totalRecordCount ? ri + startIndex : -1;
			return (MakeRow[])(recordList.ToArray(typeof(MakeRow)));
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
		/// Converts <see cref="System.Data.DataRow"/> to <see cref="MakeRow"/>.
		/// </summary>
		/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
		/// <returns>A reference to the <see cref="MakeRow"/> object.</returns>
		protected virtual MakeRow MapRow(DataRow row)
		{
			MakeRow mappedObject = new MakeRow();
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
			// Column "Name"
			dataColumn = dataTable.Columns["Name"];
			if(!row.IsNull(dataColumn))
				mappedObject.Name = (string)row[dataColumn];
			// Column "Caption"
			dataColumn = dataTable.Columns["Caption"];
			if(!row.IsNull(dataColumn))
				mappedObject.Caption = (string)row[dataColumn];
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
			// Column "CreatedBy"
			dataColumn = dataTable.Columns["CreatedBy"];
			if(!row.IsNull(dataColumn))
				mappedObject.CreatedBy = (long)row[dataColumn];
			// Column "CreatedDate"
			dataColumn = dataTable.Columns["CreatedDate"];
			if(!row.IsNull(dataColumn))
				mappedObject.CreatedDate = (System.DateTime)row[dataColumn];
			// Column "ModifiedBy"
			dataColumn = dataTable.Columns["ModifiedBy"];
			if(!row.IsNull(dataColumn))
				mappedObject.ModifiedBy = (long)row[dataColumn];
			// Column "ModifiedDate"
			dataColumn = dataTable.Columns["ModifiedDate"];
			if(!row.IsNull(dataColumn))
				mappedObject.ModifiedDate = (System.DateTime)row[dataColumn];
			// Column "IsDeleted"
			dataColumn = dataTable.Columns["IsDeleted"];
			if(!row.IsNull(dataColumn))
				mappedObject.IsDeleted = (bool)row[dataColumn];
			// Column "IsActive"
			dataColumn = dataTable.Columns["IsActive"];
			if(!row.IsNull(dataColumn))
				mappedObject.IsActive = (bool)row[dataColumn];
			// Column "DescriptionColumn"
			dataColumn = dataTable.Columns["DescriptionColumn"];
			if(!row.IsNull(dataColumn))
				mappedObject.DescriptionColumn = (string)row[dataColumn];
			return mappedObject;
		}

		/// <summary>
		/// Creates a <see cref="System.Data.DataTable"/> object for 
		/// the <c>Make</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected virtual DataTable CreateDataTable()
		{
			DataTable dataTable = new DataTable();
			dataTable.TableName = "Make";
			DataColumn dataColumn;
			dataColumn = dataTable.Columns.Add("ID", typeof(long));
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = true;
			dataColumn.Unique = true;
			dataColumn.AutoIncrement = true;
			dataColumn = dataTable.Columns.Add("UniqueCode", typeof(string));
			dataColumn.MaxLength = 20;
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Name", typeof(string));
			dataColumn.MaxLength = 100;
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Caption", typeof(string));
			dataColumn.MaxLength = 100;
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Details1", typeof(string));
			dataColumn = dataTable.Columns.Add("Details2", typeof(string));
			dataColumn = dataTable.Columns.Add("Details3", typeof(string));
			dataColumn = dataTable.Columns.Add("Details4", typeof(string));
			dataColumn = dataTable.Columns.Add("Details5", typeof(string));
			dataColumn = dataTable.Columns.Add("CreatedBy", typeof(long));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("CreatedDate", typeof(System.DateTime));
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("ModifiedBy", typeof(long));
			dataColumn = dataTable.Columns.Add("ModifiedDate", typeof(System.DateTime));
			dataColumn = dataTable.Columns.Add("IsDeleted", typeof(bool));
			dataColumn = dataTable.Columns.Add("IsActive", typeof(bool));
			dataColumn = dataTable.Columns.Add("DescriptionColumn", typeof(string));
			dataColumn.MaxLength = 1073741823;
			dataColumn.AllowDBNull = false;
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

				case "Name":
					parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
					break;

				case "Caption":
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

				case "CreatedBy":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int64, value);
					break;

				case "CreatedDate":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
					break;

				case "ModifiedBy":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int64, value);
					break;

				case "ModifiedDate":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
					break;

				case "IsDeleted":
					parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
					break;

				case "IsActive":
					parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
					break;

				case "DescriptionColumn":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
			}
			return parameter;
		}
	} // End of MakeCollection_Base class
}  // End of namespace