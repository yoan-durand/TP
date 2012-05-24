﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SyndicationServiceBugTrack.DataAccess
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="BugTrack")]
	public partial class DataClassesBugTrackDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertT_Bug(T_Bug instance);
    partial void UpdateT_Bug(T_Bug instance);
    partial void DeleteT_Bug(T_Bug instance);
    partial void InsertT_Project(T_Project instance);
    partial void UpdateT_Project(T_Project instance);
    partial void DeleteT_Project(T_Project instance);
    #endregion
		
		public DataClassesBugTrackDataContext() : 
				base(global::SyndicationServiceBugTrack.Properties.Settings.Default.BugTrackConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesBugTrackDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesBugTrackDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesBugTrackDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesBugTrackDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<T_Bug> T_Bugs
		{
			get
			{
				return this.GetTable<T_Bug>();
			}
		}
		
		public System.Data.Linq.Table<T_Project> T_Projects
		{
			get
			{
				return this.GetTable<T_Project>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.T_Bug")]
	public partial class T_Bug : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _id;
		
		private string _title;
		
		private long _idProject;
		
		private int _Type;
		
		private string _Description;
		
		private System.DateTime _CreateDate;
		
		private EntityRef<T_Project> _T_Project;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(long value);
    partial void OnidChanged();
    partial void OntitleChanging(string value);
    partial void OntitleChanged();
    partial void OnidProjectChanging(long value);
    partial void OnidProjectChanged();
    partial void OnTypeChanging(int value);
    partial void OnTypeChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnCreateDateChanging(System.DateTime value);
    partial void OnCreateDateChanged();
    #endregion
		
		public T_Bug()
		{
			this._T_Project = default(EntityRef<T_Project>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_title", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string title
		{
			get
			{
				return this._title;
			}
			set
			{
				if ((this._title != value))
				{
					this.OntitleChanging(value);
					this.SendPropertyChanging();
					this._title = value;
					this.SendPropertyChanged("title");
					this.OntitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idProject", DbType="BigInt NOT NULL")]
		public long idProject
		{
			get
			{
				return this._idProject;
			}
			set
			{
				if ((this._idProject != value))
				{
					if (this._T_Project.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidProjectChanging(value);
					this.SendPropertyChanging();
					this._idProject = value;
					this.SendPropertyChanged("idProject");
					this.OnidProjectChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type", DbType="Int NOT NULL")]
		public int Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				if ((this._Type != value))
				{
					this.OnTypeChanging(value);
					this.SendPropertyChanging();
					this._Type = value;
					this.SendPropertyChanged("Type");
					this.OnTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreateDate", DbType="DateTime NOT NULL")]
		public System.DateTime CreateDate
		{
			get
			{
				return this._CreateDate;
			}
			set
			{
				if ((this._CreateDate != value))
				{
					this.OnCreateDateChanging(value);
					this.SendPropertyChanging();
					this._CreateDate = value;
					this.SendPropertyChanged("CreateDate");
					this.OnCreateDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="T_Project_T_Bug", Storage="_T_Project", ThisKey="idProject", OtherKey="id", IsForeignKey=true)]
		public T_Project T_Project
		{
			get
			{
				return this._T_Project.Entity;
			}
			set
			{
				T_Project previousValue = this._T_Project.Entity;
				if (((previousValue != value) 
							|| (this._T_Project.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._T_Project.Entity = null;
						previousValue.T_Bugs.Remove(this);
					}
					this._T_Project.Entity = value;
					if ((value != null))
					{
						value.T_Bugs.Add(this);
						this._idProject = value.id;
					}
					else
					{
						this._idProject = default(long);
					}
					this.SendPropertyChanged("T_Project");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.T_Project")]
	public partial class T_Project : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private long _id;
		
		private string _name;
		
		private string _version;
		
		private System.DateTime _startDate;
		
		private EntitySet<T_Bug> _T_Bugs;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(long value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnversionChanging(string value);
    partial void OnversionChanged();
    partial void OnstartDateChanging(System.DateTime value);
    partial void OnstartDateChanged();
    #endregion
		
		public T_Project()
		{
			this._T_Bugs = new EntitySet<T_Bug>(new Action<T_Bug>(this.attach_T_Bugs), new Action<T_Bug>(this.detach_T_Bugs));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="BigInt NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public long id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_version", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string version
		{
			get
			{
				return this._version;
			}
			set
			{
				if ((this._version != value))
				{
					this.OnversionChanging(value);
					this.SendPropertyChanging();
					this._version = value;
					this.SendPropertyChanged("version");
					this.OnversionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_startDate", DbType="DateTime NOT NULL")]
		public System.DateTime startDate
		{
			get
			{
				return this._startDate;
			}
			set
			{
				if ((this._startDate != value))
				{
					this.OnstartDateChanging(value);
					this.SendPropertyChanging();
					this._startDate = value;
					this.SendPropertyChanged("startDate");
					this.OnstartDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="T_Project_T_Bug", Storage="_T_Bugs", ThisKey="id", OtherKey="idProject")]
		public EntitySet<T_Bug> T_Bugs
		{
			get
			{
				return this._T_Bugs;
			}
			set
			{
				this._T_Bugs.Assign(value);
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
		
		private void attach_T_Bugs(T_Bug entity)
		{
			this.SendPropertyChanging();
			entity.T_Project = this;
		}
		
		private void detach_T_Bugs(T_Bug entity)
		{
			this.SendPropertyChanging();
			entity.T_Project = null;
		}
	}
}
#pragma warning restore 1591