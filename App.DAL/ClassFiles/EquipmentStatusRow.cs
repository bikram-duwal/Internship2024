// <fileinfo name="EquipmentStatusRow_Base.cs">
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
	/// The base class for <see cref="EquipmentStatusRow"/> that 
	/// represents a record in the <c>EquipmentStatus</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="EquipmentStatusRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public class EquipmentStatusRow
	{
		private long _id;
		private string _uniqueCode;
		private string _statusName;
		private string _statusCaption;
		private string _details1;
		private string _details2;
		private string _details3;
		private string _details4;
		private string _details5;
		private bool _isDeleted;
		private bool _isDeletedNull = true;
		private bool _isActive;
		private bool _isActiveNull = true;

		/// <summary>
		/// Initializes a new instance of the <see cref="EquipmentStatusRow"/> class.
		/// </summary>
		public EquipmentStatusRow()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>ID</c> column value.
		/// </summary>
		/// <value>The <c>ID</c> column value.</value>
		public long ID
		{
			get { return _id; }
			set { _id = value; }
		}

		/// <summary>
		/// Gets or sets the <c>UniqueCode</c> column value.
		/// </summary>
		/// <value>The <c>UniqueCode</c> column value.</value>
		public string UniqueCode
		{
			get { return _uniqueCode; }
			set { _uniqueCode = value; }
		}

		/// <summary>
		/// Gets or sets the <c>StatusName</c> column value.
		/// </summary>
		/// <value>The <c>StatusName</c> column value.</value>
		public string StatusName
		{
			get { return _statusName; }
			set { _statusName = value; }
		}

		/// <summary>
		/// Gets or sets the <c>StatusCaption</c> column value.
		/// </summary>
		/// <value>The <c>StatusCaption</c> column value.</value>
		public string StatusCaption
		{
			get { return _statusCaption; }
			set { _statusCaption = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Details1</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Details1</c> column value.</value>
		public string Details1
		{
			get { return _details1; }
			set { _details1 = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Details2</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Details2</c> column value.</value>
		public string Details2
		{
			get { return _details2; }
			set { _details2 = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Details3</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Details3</c> column value.</value>
		public string Details3
		{
			get { return _details3; }
			set { _details3 = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Details4</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Details4</c> column value.</value>
		public string Details4
		{
			get { return _details4; }
			set { _details4 = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Details5</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Details5</c> column value.</value>
		public string Details5
		{
			get { return _details5; }
			set { _details5 = value; }
		}

		/// <summary>
		/// Gets or sets the <c>IsDeleted</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>IsDeleted</c> column value.</value>
		public bool IsDeleted
		{
			get
			{
				if(IsIsDeletedNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _isDeleted;
			}
			set
			{
				_isDeletedNull = false;
				_isDeleted = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="IsDeleted"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsIsDeletedNull
		{
			get { return _isDeletedNull; }
			set { _isDeletedNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>IsActive</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>IsActive</c> column value.</value>
		public bool IsActive
		{
			get
			{
				if(IsIsActiveNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _isActive;
			}
			set
			{
				_isActiveNull = false;
				_isActive = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="IsActive"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsIsActiveNull
		{
			get { return _isActiveNull; }
			set { _isActiveNull = value; }
		}

		/// <summary>
		/// Returns the string representation of this instance.
		/// </summary>
		/// <returns>The string representation of this instance.</returns>
		public override string ToString()
		{
			System.Text.StringBuilder dynStr = new System.Text.StringBuilder(GetType().Name);
			dynStr.Append(':');
			dynStr.Append("  ID=");
			dynStr.Append(ID);
			dynStr.Append("  UniqueCode=");
			dynStr.Append(UniqueCode);
			dynStr.Append("  StatusName=");
			dynStr.Append(StatusName);
			dynStr.Append("  StatusCaption=");
			dynStr.Append(StatusCaption);
			dynStr.Append("  Details1=");
			dynStr.Append(Details1);
			dynStr.Append("  Details2=");
			dynStr.Append(Details2);
			dynStr.Append("  Details3=");
			dynStr.Append(Details3);
			dynStr.Append("  Details4=");
			dynStr.Append(Details4);
			dynStr.Append("  Details5=");
			dynStr.Append(Details5);
			dynStr.Append("  IsDeleted=");
			dynStr.Append(IsIsDeletedNull ? (object)"<NULL>" : IsDeleted);
			dynStr.Append("  IsActive=");
			dynStr.Append(IsIsActiveNull ? (object)"<NULL>" : IsActive);
			return dynStr.ToString();
		}
	} // End of EquipmentStatusRow_Base class
} // End of namespace