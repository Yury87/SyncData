﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SyncData
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="dwh")]
	public partial class IADataClassessDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBILL(BILL instance);
    partial void UpdateBILL(BILL instance);
    partial void DeleteBILL(BILL instance);
    #endregion
		
		public IADataClassessDataContext() : 
				base(global::SyncData.Properties.Settings.Default.dwhConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public IADataClassessDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public IADataClassessDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public IADataClassessDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public IADataClassessDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<BILL> BILLs
		{
			get
			{
				return this.GetTable<BILL>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BILLS")]
	public partial class BILL : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _DOC_ID;
		
		private long _SMEN_ID;
		
		private int _PAYMENT;
		
		private int _SALETYPE;
		
		private System.Nullable<decimal> _DISCOUNT;
		
		private System.Nullable<long> _DCARD;
		
		private string _BCARD;
		
		private System.Nullable<short> _BCARD_TYPE;
		
		private System.Nullable<int> _BONUS_BEFORE;
		
		private System.Nullable<int> _BONUS_ADD;
		
		private System.Nullable<int> _BONUS_LIMIT;
		
		private System.Nullable<int> _BONUS_PAY;
		
		private System.Nullable<int> _BONUS_ENABLE;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDOC_IDChanging(long value);
    partial void OnDOC_IDChanged();
    partial void OnSMEN_IDChanging(long value);
    partial void OnSMEN_IDChanged();
    partial void OnPAYMENTChanging(int value);
    partial void OnPAYMENTChanged();
    partial void OnSALETYPEChanging(int value);
    partial void OnSALETYPEChanged();
    partial void OnDISCOUNTChanging(System.Nullable<decimal> value);
    partial void OnDISCOUNTChanged();
    partial void OnDCARDChanging(System.Nullable<long> value);
    partial void OnDCARDChanged();
    partial void OnBCARDChanging(string value);
    partial void OnBCARDChanged();
    partial void OnBCARD_TYPEChanging(System.Nullable<short> value);
    partial void OnBCARD_TYPEChanged();
    partial void OnBONUS_BEFOREChanging(System.Nullable<int> value);
    partial void OnBONUS_BEFOREChanged();
    partial void OnBONUS_ADDChanging(System.Nullable<int> value);
    partial void OnBONUS_ADDChanged();
    partial void OnBONUS_LIMITChanging(System.Nullable<int> value);
    partial void OnBONUS_LIMITChanged();
    partial void OnBONUS_PAYChanging(System.Nullable<int> value);
    partial void OnBONUS_PAYChanged();
    partial void OnBONUS_ENABLEChanging(System.Nullable<int> value);
    partial void OnBONUS_ENABLEChanged();
    #endregion
		
		public BILL()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DOC_ID", DbType="BigInt NOT NULL", IsPrimaryKey=true)]
		public long DOC_ID
		{
			get
			{
				return this._DOC_ID;
			}
			set
			{
				if ((this._DOC_ID != value))
				{
					this.OnDOC_IDChanging(value);
					this.SendPropertyChanging();
					this._DOC_ID = value;
					this.SendPropertyChanged("DOC_ID");
					this.OnDOC_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SMEN_ID", DbType="BigInt NOT NULL")]
		public long SMEN_ID
		{
			get
			{
				return this._SMEN_ID;
			}
			set
			{
				if ((this._SMEN_ID != value))
				{
					this.OnSMEN_IDChanging(value);
					this.SendPropertyChanging();
					this._SMEN_ID = value;
					this.SendPropertyChanged("SMEN_ID");
					this.OnSMEN_IDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PAYMENT", DbType="Int NOT NULL")]
		public int PAYMENT
		{
			get
			{
				return this._PAYMENT;
			}
			set
			{
				if ((this._PAYMENT != value))
				{
					this.OnPAYMENTChanging(value);
					this.SendPropertyChanging();
					this._PAYMENT = value;
					this.SendPropertyChanged("PAYMENT");
					this.OnPAYMENTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SALETYPE", DbType="Int NOT NULL")]
		public int SALETYPE
		{
			get
			{
				return this._SALETYPE;
			}
			set
			{
				if ((this._SALETYPE != value))
				{
					this.OnSALETYPEChanging(value);
					this.SendPropertyChanging();
					this._SALETYPE = value;
					this.SendPropertyChanged("SALETYPE");
					this.OnSALETYPEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DISCOUNT", DbType="Decimal(18,2)")]
		public System.Nullable<decimal> DISCOUNT
		{
			get
			{
				return this._DISCOUNT;
			}
			set
			{
				if ((this._DISCOUNT != value))
				{
					this.OnDISCOUNTChanging(value);
					this.SendPropertyChanging();
					this._DISCOUNT = value;
					this.SendPropertyChanged("DISCOUNT");
					this.OnDISCOUNTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DCARD", DbType="BigInt")]
		public System.Nullable<long> DCARD
		{
			get
			{
				return this._DCARD;
			}
			set
			{
				if ((this._DCARD != value))
				{
					this.OnDCARDChanging(value);
					this.SendPropertyChanging();
					this._DCARD = value;
					this.SendPropertyChanged("DCARD");
					this.OnDCARDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BCARD", DbType="NVarChar(100)")]
		public string BCARD
		{
			get
			{
				return this._BCARD;
			}
			set
			{
				if ((this._BCARD != value))
				{
					this.OnBCARDChanging(value);
					this.SendPropertyChanging();
					this._BCARD = value;
					this.SendPropertyChanged("BCARD");
					this.OnBCARDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BCARD_TYPE", DbType="SmallInt")]
		public System.Nullable<short> BCARD_TYPE
		{
			get
			{
				return this._BCARD_TYPE;
			}
			set
			{
				if ((this._BCARD_TYPE != value))
				{
					this.OnBCARD_TYPEChanging(value);
					this.SendPropertyChanging();
					this._BCARD_TYPE = value;
					this.SendPropertyChanged("BCARD_TYPE");
					this.OnBCARD_TYPEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BONUS_BEFORE", DbType="Int")]
		public System.Nullable<int> BONUS_BEFORE
		{
			get
			{
				return this._BONUS_BEFORE;
			}
			set
			{
				if ((this._BONUS_BEFORE != value))
				{
					this.OnBONUS_BEFOREChanging(value);
					this.SendPropertyChanging();
					this._BONUS_BEFORE = value;
					this.SendPropertyChanged("BONUS_BEFORE");
					this.OnBONUS_BEFOREChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BONUS_ADD", DbType="Int")]
		public System.Nullable<int> BONUS_ADD
		{
			get
			{
				return this._BONUS_ADD;
			}
			set
			{
				if ((this._BONUS_ADD != value))
				{
					this.OnBONUS_ADDChanging(value);
					this.SendPropertyChanging();
					this._BONUS_ADD = value;
					this.SendPropertyChanged("BONUS_ADD");
					this.OnBONUS_ADDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BONUS_LIMIT", DbType="Int")]
		public System.Nullable<int> BONUS_LIMIT
		{
			get
			{
				return this._BONUS_LIMIT;
			}
			set
			{
				if ((this._BONUS_LIMIT != value))
				{
					this.OnBONUS_LIMITChanging(value);
					this.SendPropertyChanging();
					this._BONUS_LIMIT = value;
					this.SendPropertyChanged("BONUS_LIMIT");
					this.OnBONUS_LIMITChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BONUS_PAY", DbType="Int")]
		public System.Nullable<int> BONUS_PAY
		{
			get
			{
				return this._BONUS_PAY;
			}
			set
			{
				if ((this._BONUS_PAY != value))
				{
					this.OnBONUS_PAYChanging(value);
					this.SendPropertyChanging();
					this._BONUS_PAY = value;
					this.SendPropertyChanged("BONUS_PAY");
					this.OnBONUS_PAYChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BONUS_ENABLE", DbType="Int")]
		public System.Nullable<int> BONUS_ENABLE
		{
			get
			{
				return this._BONUS_ENABLE;
			}
			set
			{
				if ((this._BONUS_ENABLE != value))
				{
					this.OnBONUS_ENABLEChanging(value);
					this.SendPropertyChanging();
					this._BONUS_ENABLE = value;
					this.SendPropertyChanged("BONUS_ENABLE");
					this.OnBONUS_ENABLEChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
