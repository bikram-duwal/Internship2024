// <fileinfo name="EquipmentTypeRow_Base.cs">
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
	/// The base class for <see cref="EquipmentTypeRow"/> that 
	/// represents a record in the <c>EquipmentType</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="EquipmentTypeRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public abstract class EquipmentTypeRow
	{
		private long _id;
		private string _uniqueCode;
		private string _name;
		private string _description;
		private string _details1;
		private string _details2;
		private string _details3;
		private string _details4;
		private string _details5;
		private long _createdBy;
		private System.DateTime _createdDate;
		private long _modifiedBy;
		private bool _modifiedByNull = true;
		private System.DateTime _modifiedDate;
		private bool _modifiedDateNull = true;

		/// <summary>
		/// Initializes a new instance of the <see cref="EquipmentTypeRow"/> class.
		/// </summary>
		public EquipmentTypeRow()
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
		/// Gets or sets the <c>Name</c> column value.
		/// </summary>
		/// <value>The <c>Name</c> column value.</value>
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Description</c> column value.
		/// </summary>
		/// <value>The <c>Description</c> column value.</value>
		public string Description
		{
			get { return _description; }
			set { _description = value; }
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
		/// Gets or sets the <c>CreatedBy</c> column value.
		/// </summary>
		/// <value>The <c>CreatedBy</c> column value.</value>
		public long CreatedBy
		{
			get { return _createdBy; }
			set { _createdBy = value; }
		}

		/// <summary>
		/// Gets or sets the <c>CreatedDate</c> column value.
		/// </summary>
		/// <value>The <c>CreatedDate</c> column value.</value>
		public System.DateTime CreatedDate
		{
			get { return _createdDate; }
			set { _createdDate = value; }
		}

		/// <summary>
		/// Gets or sets the <c>ModifiedBy</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ModifiedBy</c> column value.</value>
		public long ModifiedBy
		{
			get
			{
				if(IsModifiedByNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _modifiedBy;
			}
			set
			{
				_modifiedByNull = false;
				_modifiedBy = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="ModifiedBy"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsModifiedByNull
		{
			get { return _modifiedByNull; }
			set { _modifiedByNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>ModifiedDate</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>ModifiedDate</c> column value.</value>
		public System.DateTime ModifiedDate
		{
			get
			{
				if(IsModifiedDateNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _modifiedDate;
			}
			set
			{
				_modifiedDateNull = false;
				_modifiedDate = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="ModifiedDate"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsModifiedDateNull
		{
			get { return _modifiedDateNull; }
			set { _modifiedDateNull = value; }
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
			dynStr.Append("  Name=");
			dynStr.Append(Name);
			dynStr.Append("  Description=");
			dynStr.Append(Description);
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
			dynStr.Append("  CreatedBy=");
			dynStr.Append(CreatedBy);
			dynStr.Append("  CreatedDate=");
			dynStr.Append(CreatedDate);
			dynStr.Append("  ModifiedBy=");
			dynStr.Append(IsModifiedByNull ? (object)"<NULL>" : ModifiedBy);
			dynStr.Append("  ModifiedDate=");
			dynStr.Append(IsModifiedDateNull ? (object)"<NULL>" : ModifiedDate);
			return dynStr.ToString();
		}
	} // End of EquipmentTypeRow_Base class
} // End of namespace