﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.296
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TPdeDiseño
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="TP-DISEÑO")]
	public partial class DataClasses2DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertDeporte(Deporte instance);
    partial void UpdateDeporte(Deporte instance);
    partial void DeleteDeporte(Deporte instance);
    partial void InsertModalidad(Modalidad instance);
    partial void UpdateModalidad(Modalidad instance);
    partial void DeleteModalidad(Modalidad instance);
    partial void InsertForma_de_Puntuacion(Forma_de_Puntuacion instance);
    partial void UpdateForma_de_Puntuacion(Forma_de_Puntuacion instance);
    partial void DeleteForma_de_Puntuacion(Forma_de_Puntuacion instance);
    #endregion
		
		public DataClasses2DataContext() : 
				base(global::TPdeDiseño.Properties.Settings.Default.TP_DISEÑOConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses2DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Deporte> Deporte
		{
			get
			{
				return this.GetTable<Deporte>();
			}
		}
		
		public System.Data.Linq.Table<Modalidad> Modalidad
		{
			get
			{
				return this.GetTable<Modalidad>();
			}
		}
		
		public System.Data.Linq.Table<Forma_de_Puntuacion> Forma_de_Puntuacion
		{
			get
			{
				return this.GetTable<Forma_de_Puntuacion>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Deporte")]
	public partial class Deporte : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private short _id_deporte;
		
		private string _nombre;
		
		private System.Nullable<short> _id_lugar;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_deporteChanging(short value);
    partial void Onid_deporteChanged();
    partial void OnnombreChanging(string value);
    partial void OnnombreChanged();
    partial void Onid_lugarChanging(System.Nullable<short> value);
    partial void Onid_lugarChanged();
    #endregion
		
		public Deporte()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_deporte", DbType="SmallInt NOT NULL", IsPrimaryKey=true)]
		public short id_deporte
		{
			get
			{
				return this._id_deporte;
			}
			set
			{
				if ((this._id_deporte != value))
				{
					this.Onid_deporteChanging(value);
					this.SendPropertyChanging();
					this._id_deporte = value;
					this.SendPropertyChanged("id_deporte");
					this.Onid_deporteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nombre", DbType="NVarChar(50)")]
		public string nombre
		{
			get
			{
				return this._nombre;
			}
			set
			{
				if ((this._nombre != value))
				{
					this.OnnombreChanging(value);
					this.SendPropertyChanging();
					this._nombre = value;
					this.SendPropertyChanged("nombre");
					this.OnnombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_lugar", DbType="SmallInt")]
		public System.Nullable<short> id_lugar
		{
			get
			{
				return this._id_lugar;
			}
			set
			{
				if ((this._id_lugar != value))
				{
					this.Onid_lugarChanging(value);
					this.SendPropertyChanging();
					this._id_lugar = value;
					this.SendPropertyChanged("id_lugar");
					this.Onid_lugarChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Modalidad")]
	public partial class Modalidad : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private short _id_modalidad;
		
		private System.Nullable<int> _ptos_por_PG;
		
		private System.Data.Linq.Binary _empate;
		
		private System.Nullable<int> _ptos_empate;
		
		private System.Nullable<int> _ptos_por_presentarse;
		
		private System.Nullable<short> _id_forma;
		
		private EntityRef<Forma_de_Puntuacion> _Forma_de_Puntuacion;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_modalidadChanging(short value);
    partial void Onid_modalidadChanged();
    partial void Onptos_por_PGChanging(System.Nullable<int> value);
    partial void Onptos_por_PGChanged();
    partial void OnempateChanging(System.Data.Linq.Binary value);
    partial void OnempateChanged();
    partial void Onptos_empateChanging(System.Nullable<int> value);
    partial void Onptos_empateChanged();
    partial void Onptos_por_presentarseChanging(System.Nullable<int> value);
    partial void Onptos_por_presentarseChanged();
    partial void Onid_formaChanging(System.Nullable<short> value);
    partial void Onid_formaChanged();
    #endregion
		
		public Modalidad()
		{
			this._Forma_de_Puntuacion = default(EntityRef<Forma_de_Puntuacion>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_modalidad", DbType="SmallInt NOT NULL", IsPrimaryKey=true)]
		public short id_modalidad
		{
			get
			{
				return this._id_modalidad;
			}
			set
			{
				if ((this._id_modalidad != value))
				{
					this.Onid_modalidadChanging(value);
					this.SendPropertyChanging();
					this._id_modalidad = value;
					this.SendPropertyChanged("id_modalidad");
					this.Onid_modalidadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ptos_por_PG", DbType="Int")]
		public System.Nullable<int> ptos_por_PG
		{
			get
			{
				return this._ptos_por_PG;
			}
			set
			{
				if ((this._ptos_por_PG != value))
				{
					this.Onptos_por_PGChanging(value);
					this.SendPropertyChanging();
					this._ptos_por_PG = value;
					this.SendPropertyChanged("ptos_por_PG");
					this.Onptos_por_PGChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_empate", DbType="Binary(50)", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary empate
		{
			get
			{
				return this._empate;
			}
			set
			{
				if ((this._empate != value))
				{
					this.OnempateChanging(value);
					this.SendPropertyChanging();
					this._empate = value;
					this.SendPropertyChanged("empate");
					this.OnempateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ptos_empate", DbType="Int")]
		public System.Nullable<int> ptos_empate
		{
			get
			{
				return this._ptos_empate;
			}
			set
			{
				if ((this._ptos_empate != value))
				{
					this.Onptos_empateChanging(value);
					this.SendPropertyChanging();
					this._ptos_empate = value;
					this.SendPropertyChanged("ptos_empate");
					this.Onptos_empateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ptos_por_presentarse", DbType="Int")]
		public System.Nullable<int> ptos_por_presentarse
		{
			get
			{
				return this._ptos_por_presentarse;
			}
			set
			{
				if ((this._ptos_por_presentarse != value))
				{
					this.Onptos_por_presentarseChanging(value);
					this.SendPropertyChanging();
					this._ptos_por_presentarse = value;
					this.SendPropertyChanged("ptos_por_presentarse");
					this.Onptos_por_presentarseChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_forma", DbType="SmallInt")]
		public System.Nullable<short> id_forma
		{
			get
			{
				return this._id_forma;
			}
			set
			{
				if ((this._id_forma != value))
				{
					if (this._Forma_de_Puntuacion.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onid_formaChanging(value);
					this.SendPropertyChanging();
					this._id_forma = value;
					this.SendPropertyChanged("id_forma");
					this.Onid_formaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Forma_de_Puntuacion_Modalidad", Storage="_Forma_de_Puntuacion", ThisKey="id_forma", OtherKey="id_forma", IsForeignKey=true)]
		public Forma_de_Puntuacion Forma_de_Puntuacion
		{
			get
			{
				return this._Forma_de_Puntuacion.Entity;
			}
			set
			{
				Forma_de_Puntuacion previousValue = this._Forma_de_Puntuacion.Entity;
				if (((previousValue != value) 
							|| (this._Forma_de_Puntuacion.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Forma_de_Puntuacion.Entity = null;
						previousValue.Modalidad.Remove(this);
					}
					this._Forma_de_Puntuacion.Entity = value;
					if ((value != null))
					{
						value.Modalidad.Add(this);
						this._id_forma = value.id_forma;
					}
					else
					{
						this._id_forma = default(Nullable<short>);
					}
					this.SendPropertyChanged("Forma_de_Puntuacion");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.[Forma de Puntuacion]")]
	public partial class Forma_de_Puntuacion : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private short _id_forma;
		
		private System.Nullable<short> _cant_sets;
		
		private System.Nullable<int> _tantos_x_ausencia_del_rival;
		
		private EntitySet<Modalidad> _Modalidad;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onid_formaChanging(short value);
    partial void Onid_formaChanged();
    partial void Oncant_setsChanging(System.Nullable<short> value);
    partial void Oncant_setsChanged();
    partial void Ontantos_x_ausencia_del_rivalChanging(System.Nullable<int> value);
    partial void Ontantos_x_ausencia_del_rivalChanged();
    #endregion
		
		public Forma_de_Puntuacion()
		{
			this._Modalidad = new EntitySet<Modalidad>(new Action<Modalidad>(this.attach_Modalidad), new Action<Modalidad>(this.detach_Modalidad));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id_forma", DbType="SmallInt NOT NULL", IsPrimaryKey=true)]
		public short id_forma
		{
			get
			{
				return this._id_forma;
			}
			set
			{
				if ((this._id_forma != value))
				{
					this.Onid_formaChanging(value);
					this.SendPropertyChanging();
					this._id_forma = value;
					this.SendPropertyChanged("id_forma");
					this.Onid_formaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cant_sets", DbType="SmallInt")]
		public System.Nullable<short> cant_sets
		{
			get
			{
				return this._cant_sets;
			}
			set
			{
				if ((this._cant_sets != value))
				{
					this.Oncant_setsChanging(value);
					this.SendPropertyChanging();
					this._cant_sets = value;
					this.SendPropertyChanged("cant_sets");
					this.Oncant_setsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_tantos_x_ausencia_del_rival", DbType="Int")]
		public System.Nullable<int> tantos_x_ausencia_del_rival
		{
			get
			{
				return this._tantos_x_ausencia_del_rival;
			}
			set
			{
				if ((this._tantos_x_ausencia_del_rival != value))
				{
					this.Ontantos_x_ausencia_del_rivalChanging(value);
					this.SendPropertyChanging();
					this._tantos_x_ausencia_del_rival = value;
					this.SendPropertyChanged("tantos_x_ausencia_del_rival");
					this.Ontantos_x_ausencia_del_rivalChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Forma_de_Puntuacion_Modalidad", Storage="_Modalidad", ThisKey="id_forma", OtherKey="id_forma")]
		public EntitySet<Modalidad> Modalidad
		{
			get
			{
				return this._Modalidad;
			}
			set
			{
				this._Modalidad.Assign(value);
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
		
		private void attach_Modalidad(Modalidad entity)
		{
			this.SendPropertyChanging();
			entity.Forma_de_Puntuacion = this;
		}
		
		private void detach_Modalidad(Modalidad entity)
		{
			this.SendPropertyChanging();
			entity.Forma_de_Puntuacion = null;
		}
	}
}
#pragma warning restore 1591
