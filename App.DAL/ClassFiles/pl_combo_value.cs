// <fileinfo name="pl_combo_valueCollection_Base.cs">
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
	/// The base class for <see cref="pl_combo_valueCollection"/>. Provides methods 
	/// for common database table operations. 
	/// </summary>
	/// <remarks>
	/// Do not change this source code. Update the <see cref="pl_combo_valueCollection"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public class pl_combo_value
	{
		// Constants
		public const string Combo_value_idColumnName = "combo_value_id";
		public const string Column_typeColumnName = "column_type";
		public const string Data_valueColumnName = "data_value";

		// Instance fields
		private InternTaskDbContext _db;

		/// <summary>
		/// Initializes a new instance of the <see cref="pl_combo_value"/> 
		/// class with the specified <see cref="InternTaskDbContext"/>.
		/// </summary>
		/// <param name="db">The <see cref="InternTaskDbContext"/> object.</param>
		public pl_combo_value(InternTaskDbContext db)
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
		/// Gets an array of all records from the <c>pl_combo_value</c> table.
		/// </summary>
		/// <returns>An array of <see cref="pl_combo_valueRow"/> objects.</returns>
		public virtual pl_combo_valueRow[] GetAll()
		{
			return MapRecords(CreateGetAllCommand());
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object that 
		/// includes all records from the <c>pl_combo_value</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetAllAsDataTable()
		{
			return MapRecordsToDataTable(CreateGetAllCommand());
		}

		/// <summary>
		/// Creates and returns an <see cref="System.Data.SqlCommand"/> object that is used
		/// to retrieve all records from the <c>pl_combo_value</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.SqlCommand"/> object.</returns>
		protected virtual SqlCommand CreateGetAllCommand()
		{
			return _db.CreateCommand("dbo.pl_combo_value_GetAll", true);
		}

		/// <summary>
		/// Gets the first <see cref="pl_combo_valueRow"/> objects that 
		/// match the search condition.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>An instance of <see cref="pl_combo_valueRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public pl_combo_valueRow GetRow(string whereSql)
		{
			int totalRecordCount = -1;
			pl_combo_valueRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
			return 0 == rows.Length ? null : rows[0];
		}

		/// <summary>
		/// Gets an array of <see cref="pl_combo_valueRow"/> objects that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
		/// <returns>An array of <see cref="pl_combo_valueRow"/> objects.</returns>
		public pl_combo_valueRow[] GetAsArray(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsArray(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Gets an array of <see cref="pl_combo_valueRow"/> objects that 
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
		/// <returns>An array of <see cref="pl_combo_valueRow"/> objects.</returns>
		public virtual pl_combo_valueRow[] GetAsArray(string whereSql, string orderBySql,
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
			string sql = "SELECT * FROM [dbo].[pl_combo_value]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			if(null != orderBySql && 0 < orderBySql.Length)
				sql += " ORDER BY " + orderBySql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Gets <see cref="pl_combo_valueRow"/> by the primary key.
		/// </summary>
		/// <param name="combo_value_id">The <c>combo_value_id</c> column value.</param>
		/// <returns>An instance of <see cref="pl_combo_valueRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public virtual pl_combo_valueRow GetByPrimaryKey(long combo_value_id)
		{
			SqlCommand cmd = _db.CreateCommand("dbo.pl_combo_value_GetByPrimaryKey", true);
			AddParameter(cmd, "Combo_value_id", combo_value_id);
			pl_combo_valueRow[] tempArray = MapRecords(cmd);
			return 0 == tempArray.Length ? null : tempArray[0];
		}

		/// <summary>
		/// Adds a new record into the <c>pl_combo_value</c> table.
		/// </summary>
		/// <param name="value">The <see cref="pl_combo_valueRow"/> object to be inserted.</param>
		public virtual void Insert(pl_combo_valueRow value)
		{
			SqlCommand cmd = _db.CreateCommand("dbo.pl_combo_value_Insert", true);
			AddParameter(cmd, "Column_type", value.Column_type);
			AddParameter(cmd, "Data_value", value.Data_value);
			value.Combo_value_id = Convert.ToInt64(cmd.ExecuteScalar());
		}

		/// <summary>
		/// Updates a record in the <c>pl_combo_value</c> table.
		/// </summary>
		/// <param name="value">The <see cref="pl_combo_valueRow"/>
		/// object used to update the table record.</param>
		/// <returns>true if the record was updated; otherwise, false.</returns>
		public virtual bool Update(pl_combo_valueRow value)
		{
			SqlCommand cmd = _db.CreateCommand("dbo.pl_combo_value_Update", true);
			AddParameter(cmd, "Column_type", value.Column_type);
			AddParameter(cmd, "Data_value", value.Data_value);
			AddParameter(cmd, "Combo_value_id", value.Combo_value_id);
			return 0 != cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Updates the <c>pl_combo_value</c> table and calls the <c>AcceptChanges</c> method
		/// on the changed DataRow objects.
		/// </summary>
		/// <param name="table">The <see cref="System.Data.DataTable"/> used to update the data source.</param>
		public void Update(DataTable table)
		{
			Update(table, true);
		}

		/// <summary>
		/// Updates the <c>pl_combo_value</c> table. Pass <c>false</c> as the <c>acceptChanges</c> 
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
							DeleteByPrimaryKey((long)row["Combo_value_id"]);
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
		/// Deletes the specified object from the <c>pl_combo_value</c> table.
		/// </summary>
		/// <param name="value">The <see cref="pl_combo_valueRow"/> object to delete.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public bool Delete(pl_combo_valueRow value)
		{
			return DeleteByPrimaryKey(value.Combo_value_id);
		}

		/// <summary>
		/// Deletes a record from the <c>pl_combo_value</c> table using
		/// the specified primary key.
		/// </summary>
		/// <param name="combo_value_id">The <c>combo_value_id</c> column value.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public virtual bool DeleteByPrimaryKey(long combo_value_id)
		{
			SqlCommand cmd = _db.CreateCommand("dbo.pl_combo_value_DeleteByPrimaryKey", true);
			AddParameter(cmd, "Combo_value_id", combo_value_id);
			return 0 < cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Deletes <c>pl_combo_value</c> records that match the specified criteria.
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
		/// to delete <c>pl_combo_value</c> records that match the specified criteria.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. 
		/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>A reference to the <see cref="System.Data.SqlCommand"/> object.</returns>
		protected virtual SqlCommand CreateDeleteCommand(string whereSql)
		{
			string sql = "DELETE FROM [dbo].[pl_combo_value]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Deletes all records from the <c>pl_combo_value</c> table.
		/// </summary>
		/// <returns>The number of deleted records.</returns>
		public int DeleteAll()
		{
			return _db.CreateCommand("dbo.pl_combo_value_DeleteAll", true).ExecuteNonQuery();
		}

		/// <summary>
		/// Reads data using the specified command and returns 
		/// an array of mapped objects.
		/// </summary>
		/// <param name="command">The <see cref="System.Data.SqlCommand"/> object.</param>
		/// <returns>An array of <see cref="pl_combo_valueRow"/> objects.</returns>
		protected pl_combo_valueRow[] MapRecords(SqlCommand command)
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
		/// <returns>An array of <see cref="pl_combo_valueRow"/> objects.</returns>
		protected pl_combo_valueRow[] MapRecords(SqlDataReader reader)
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
		/// <returns>An array of <see cref="pl_combo_valueRow"/> objects.</returns>
		protected virtual pl_combo_valueRow[] MapRecords(SqlDataReader reader, 
										int startIndex, int length, ref int totalRecordCount)
		{
			if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

			int combo_value_idColumnIndex = reader.GetOrdinal("combo_value_id");
			int column_typeColumnIndex = reader.GetOrdinal("column_type");
			int data_valueColumnIndex = reader.GetOrdinal("data_value");

			System.Collections.ArrayList recordList = new System.Collections.ArrayList();
			int ri = -startIndex;
			while(reader.Read())
			{
				ri++;
				if(ri > 0 && ri <= length)
				{
					pl_combo_valueRow record = new pl_combo_valueRow();
					recordList.Add(record);

					record.Combo_value_id = Convert.ToInt64(reader.GetValue(combo_value_idColumnIndex));
					if(!reader.IsDBNull(column_typeColumnIndex))
						record.Column_type = Convert.ToString(reader.GetValue(column_typeColumnIndex));
					if(!reader.IsDBNull(data_valueColumnIndex))
						record.Data_value = Convert.ToString(reader.GetValue(data_valueColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}

			totalRecordCount = 0 == totalRecordCount ? ri + startIndex : -1;
			return (pl_combo_valueRow[])(recordList.ToArray(typeof(pl_combo_valueRow)));
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
		/// Converts <see cref="System.Data.DataRow"/> to <see cref="pl_combo_valueRow"/>.
		/// </summary>
		/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
		/// <returns>A reference to the <see cref="pl_combo_valueRow"/> object.</returns>
		protected virtual pl_combo_valueRow MapRow(DataRow row)
		{
			pl_combo_valueRow mappedObject = new pl_combo_valueRow();
			DataTable dataTable = row.Table;
			DataColumn dataColumn;
			// Column "Combo_value_id"
			dataColumn = dataTable.Columns["Combo_value_id"];
			if(!row.IsNull(dataColumn))
				mappedObject.Combo_value_id = (long)row[dataColumn];
			// Column "Column_type"
			dataColumn = dataTable.Columns["Column_type"];
			if(!row.IsNull(dataColumn))
				mappedObject.Column_type = (string)row[dataColumn];
			// Column "Data_value"
			dataColumn = dataTable.Columns["Data_value"];
			if(!row.IsNull(dataColumn))
				mappedObject.Data_value = (string)row[dataColumn];
			return mappedObject;
		}

		/// <summary>
		/// Creates a <see cref="System.Data.DataTable"/> object for 
		/// the <c>pl_combo_value</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected virtual DataTable CreateDataTable()
		{
			DataTable dataTable = new DataTable();
			dataTable.TableName = "pl_combo_value";
			DataColumn dataColumn;
			dataColumn = dataTable.Columns.Add("Combo_value_id", typeof(long));
			dataColumn.Caption = "combo_value_id";
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = true;
			dataColumn.Unique = true;
			dataColumn.AutoIncrement = true;
			dataColumn = dataTable.Columns.Add("Column_type", typeof(string));
			dataColumn.Caption = "column_type";
			dataColumn.MaxLength = 50;
			dataColumn = dataTable.Columns.Add("Data_value", typeof(string));
			dataColumn.Caption = "data_value";
			dataColumn.MaxLength = 1073741823;
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
				case "Combo_value_id":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int64, value);
					break;

				case "Column_type":
					parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
					break;

				case "Data_value":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
			}
			return parameter;
		}
	} // End of pl_combo_valueCollection_Base class
}  // End of namespace
