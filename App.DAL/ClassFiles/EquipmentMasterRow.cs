// <fileinfo name="EquipmentMasterRow_Base.cs">
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
	/// The base class for <see cref="EquipmentMasterRow"/> that 
	/// represents a record in the <c>EquipmentMaster</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="EquipmentMasterRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public  class EquipmentMasterRow
	{
		private long _id;
		private string _name;
		private string _description;
		private string _details1;
		private string _details2;
		private string _details3;
		private string _details4;
		private string _city;
		private bool _isActive;
		private bool _isActiveNull = true;

		/// <summary>
		/// Initializes a new instance of the <see cref="EquipmentMasterRow_Base"/> class.
		/// </summary>
		public EquipmentMasterRow()
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
		/// Gets or sets the <c>Name</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>Name</c> column value.</value>
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		/// <summary>
		/// Gets or sets the <c>Description</c> column value.
		/// This column is nullable.
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
		/// Gets or sets the <c>City</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>City</c> column value.</value>
		public string City
		{
			get { return _city; }
			set { _city = value; }
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
			dynStr.Append("  City=");
			dynStr.Append(City);
			dynStr.Append("  IsActive=");
			dynStr.Append(IsIsActiveNull ? (object)"<NULL>" : IsActive);
			return dynStr.ToString();
		}
	} // End of EquipmentMasterRow_Base class
} // End of namespace
