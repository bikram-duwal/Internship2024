// <fileinfo name="pl_combo_valueRow_Base.cs">
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
	/// The base class for <see cref="pl_combo_valueRow"/> that 
	/// represents a record in the <c>pl_combo_value</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="pl_combo_valueRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public class pl_combo_valueRow
	{
		private long _combo_value_id;
		private string _column_type;
		private string _data_value;

		/// <summary>
		/// Initializes a new instance of the <see cref="pl_combo_valueRow"/> class.
		/// </summary>
		public pl_combo_valueRow()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>combo_value_id</c> column value.
		/// </summary>
		/// <value>The <c>combo_value_id</c> column value.</value>
		public long Combo_value_id
		{
			get { return _combo_value_id; }
			set { _combo_value_id = value; }
		}

		/// <summary>
		/// Gets or sets the <c>column_type</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>column_type</c> column value.</value>
		public string Column_type
		{
			get { return _column_type; }
			set { _column_type = value; }
		}

		/// <summary>
		/// Gets or sets the <c>data_value</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>data_value</c> column value.</value>
		public string Data_value
		{
			get { return _data_value; }
			set { _data_value = value; }
		}

		/// <summary>
		/// Returns the string representation of this instance.
		/// </summary>
		/// <returns>The string representation of this instance.</returns>
		public override string ToString()
		{
			System.Text.StringBuilder dynStr = new System.Text.StringBuilder(GetType().Name);
			dynStr.Append(':');
			dynStr.Append("  Combo_value_id=");
			dynStr.Append(Combo_value_id);
			dynStr.Append("  Column_type=");
			dynStr.Append(Column_type);
			dynStr.Append("  Data_value=");
			dynStr.Append(Data_value);
			return dynStr.ToString();
		}
	} // End of pl_combo_valueRow_Base class
} // End of namespace
