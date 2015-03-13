﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Datos_Center
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CentroComercial")]
	public partial class DatosDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertCategoria(Categoria instance);
    partial void UpdateCategoria(Categoria instance);
    partial void DeleteCategoria(Categoria instance);
    partial void InsertEventos(Eventos instance);
    partial void UpdateEventos(Eventos instance);
    partial void DeleteEventos(Eventos instance);
    partial void InsertUsuarios(Usuarios instance);
    partial void UpdateUsuarios(Usuarios instance);
    partial void DeleteUsuarios(Usuarios instance);
    #endregion
		
		public DatosDataContext() : 
				base(global::Datos_Center.Properties.Settings.Default.CentroComercialConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DatosDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatosDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatosDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DatosDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Categoria> Categoria
		{
			get
			{
				return this.GetTable<Categoria>();
			}
		}
		
		public System.Data.Linq.Table<Eventos> Eventos
		{
			get
			{
				return this.GetTable<Eventos>();
			}
		}
		
		public System.Data.Linq.Table<Locales> Locales
		{
			get
			{
				return this.GetTable<Locales>();
			}
		}
		
		public System.Data.Linq.Table<Usuarios> Usuarios
		{
			get
			{
				return this.GetTable<Usuarios>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.IniciarSesion")]
		public ISingleResult<IniciarSesionResult> IniciarSesion([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Usuario", DbType="VarChar(50)")] string usuario, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Contrasena", DbType="VarChar(50)")] string contrasena)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), usuario, contrasena);
			return ((ISingleResult<IniciarSesionResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.InsertarCategoria")]
		public int InsertarCategoria([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Nombre", DbType="VarChar(50)")] string nombre)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nombre);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.InsertarEvento")]
		public int InsertarEvento([global::System.Data.Linq.Mapping.ParameterAttribute(Name="NombreEvento", DbType="NVarChar(250)")] string nombreEvento, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DescripcionEvento", DbType="NVarChar(250)")] string descripcionEvento)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nombreEvento, descripcionEvento);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.InsertarLocal")]
		public int InsertarLocal([global::System.Data.Linq.Mapping.ParameterAttribute(Name="NombreLocal", DbType="VarChar(250)")] string nombreLocal, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Ubicacion", DbType="VarChar(250)")] string ubicacion, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Horario", DbType="VarChar(250)")] string horario, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id_Categoria", DbType="Int")] System.Nullable<int> id_Categoria, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id_Evento", DbType="Int")] System.Nullable<int> id_Evento)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nombreLocal, ubicacion, horario, id_Categoria, id_Evento);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Lista_Eventos_x_UbicacionLocal")]
		public ISingleResult<Lista_Eventos_x_UbicacionLocalResult> Lista_Eventos_x_UbicacionLocal([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id_Local", DbType="Int")] System.Nullable<int> id_Local)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id_Local);
			return ((ISingleResult<Lista_Eventos_x_UbicacionLocalResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ListaLocal_AtributosCategorias")]
		public ISingleResult<ListaLocal_AtributosCategoriasResult> ListaLocal_AtributosCategorias([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Id_Categoria", DbType="Int")] System.Nullable<int> id_Categoria)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), id_Categoria);
			return ((ISingleResult<ListaLocal_AtributosCategoriasResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.ListarLocalXstring")]
		public ISingleResult<ListarLocalXstringResult> ListarLocalXstring([global::System.Data.Linq.Mapping.ParameterAttribute(Name="NombreLocal", DbType="VarChar(250)")] string nombreLocal)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nombreLocal);
			return ((ISingleResult<ListarLocalXstringResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Categoria")]
	public partial class Categoria : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id_Categoria;
		
		private string _Nombre;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_CategoriaChanging(int value);
    partial void OnId_CategoriaChanged();
    partial void OnNombreChanging(string value);
    partial void OnNombreChanged();
    #endregion
		
		public Categoria()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Categoria", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id_Categoria
		{
			get
			{
				return this._Id_Categoria;
			}
			set
			{
				if ((this._Id_Categoria != value))
				{
					this.OnId_CategoriaChanging(value);
					this.SendPropertyChanging();
					this._Id_Categoria = value;
					this.SendPropertyChanged("Id_Categoria");
					this.OnId_CategoriaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(50)")]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this.OnNombreChanging(value);
					this.SendPropertyChanging();
					this._Nombre = value;
					this.SendPropertyChanged("Nombre");
					this.OnNombreChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Eventos")]
	public partial class Eventos : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id_Evento;
		
		private string _NombreEvento;
		
		private string _DescripcionEvento;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_EventoChanging(int value);
    partial void OnId_EventoChanged();
    partial void OnNombreEventoChanging(string value);
    partial void OnNombreEventoChanged();
    partial void OnDescripcionEventoChanging(string value);
    partial void OnDescripcionEventoChanged();
    #endregion
		
		public Eventos()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Evento", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id_Evento
		{
			get
			{
				return this._Id_Evento;
			}
			set
			{
				if ((this._Id_Evento != value))
				{
					this.OnId_EventoChanging(value);
					this.SendPropertyChanging();
					this._Id_Evento = value;
					this.SendPropertyChanged("Id_Evento");
					this.OnId_EventoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreEvento", DbType="NVarChar(250)")]
		public string NombreEvento
		{
			get
			{
				return this._NombreEvento;
			}
			set
			{
				if ((this._NombreEvento != value))
				{
					this.OnNombreEventoChanging(value);
					this.SendPropertyChanging();
					this._NombreEvento = value;
					this.SendPropertyChanged("NombreEvento");
					this.OnNombreEventoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DescripcionEvento", DbType="NVarChar(250)")]
		public string DescripcionEvento
		{
			get
			{
				return this._DescripcionEvento;
			}
			set
			{
				if ((this._DescripcionEvento != value))
				{
					this.OnDescripcionEventoChanging(value);
					this.SendPropertyChanging();
					this._DescripcionEvento = value;
					this.SendPropertyChanged("DescripcionEvento");
					this.OnDescripcionEventoChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Locales")]
	public partial class Locales
	{
		
		private int _Id_Local;
		
		private string _NombreLocal;
		
		private string _Ubicacion;
		
		private string _Horario;
		
		private System.Nullable<int> _Id_Categoria;
		
		private System.Nullable<int> _Id_Evento;
		
		public Locales()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Local", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int Id_Local
		{
			get
			{
				return this._Id_Local;
			}
			set
			{
				if ((this._Id_Local != value))
				{
					this._Id_Local = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreLocal", DbType="NVarChar(250)")]
		public string NombreLocal
		{
			get
			{
				return this._NombreLocal;
			}
			set
			{
				if ((this._NombreLocal != value))
				{
					this._NombreLocal = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ubicacion", DbType="NVarChar(250)")]
		public string Ubicacion
		{
			get
			{
				return this._Ubicacion;
			}
			set
			{
				if ((this._Ubicacion != value))
				{
					this._Ubicacion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Horario", DbType="NVarChar(250)")]
		public string Horario
		{
			get
			{
				return this._Horario;
			}
			set
			{
				if ((this._Horario != value))
				{
					this._Horario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Categoria", DbType="Int")]
		public System.Nullable<int> Id_Categoria
		{
			get
			{
				return this._Id_Categoria;
			}
			set
			{
				if ((this._Id_Categoria != value))
				{
					this._Id_Categoria = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Evento", DbType="Int")]
		public System.Nullable<int> Id_Evento
		{
			get
			{
				return this._Id_Evento;
			}
			set
			{
				if ((this._Id_Evento != value))
				{
					this._Id_Evento = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Usuarios")]
	public partial class Usuarios : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id_Usuario;
		
		private string _Usuario;
		
		private string _Contrasena;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnId_UsuarioChanging(int value);
    partial void OnId_UsuarioChanged();
    partial void OnUsuarioChanging(string value);
    partial void OnUsuarioChanged();
    partial void OnContrasenaChanging(string value);
    partial void OnContrasenaChanged();
    #endregion
		
		public Usuarios()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Usuario", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id_Usuario
		{
			get
			{
				return this._Id_Usuario;
			}
			set
			{
				if ((this._Id_Usuario != value))
				{
					this.OnId_UsuarioChanging(value);
					this.SendPropertyChanging();
					this._Id_Usuario = value;
					this.SendPropertyChanged("Id_Usuario");
					this.OnId_UsuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Usuario", DbType="NVarChar(50)")]
		public string Usuario
		{
			get
			{
				return this._Usuario;
			}
			set
			{
				if ((this._Usuario != value))
				{
					this.OnUsuarioChanging(value);
					this.SendPropertyChanging();
					this._Usuario = value;
					this.SendPropertyChanged("Usuario");
					this.OnUsuarioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Contrasena", DbType="NVarChar(50)")]
		public string Contrasena
		{
			get
			{
				return this._Contrasena;
			}
			set
			{
				if ((this._Contrasena != value))
				{
					this.OnContrasenaChanging(value);
					this.SendPropertyChanging();
					this._Contrasena = value;
					this.SendPropertyChanged("Contrasena");
					this.OnContrasenaChanged();
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
	
	public partial class IniciarSesionResult
	{
		
		private string _Usuario;
		
		private string _Contrasena;
		
		public IniciarSesionResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Usuario", DbType="NVarChar(50)")]
		public string Usuario
		{
			get
			{
				return this._Usuario;
			}
			set
			{
				if ((this._Usuario != value))
				{
					this._Usuario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Contrasena", DbType="NVarChar(50)")]
		public string Contrasena
		{
			get
			{
				return this._Contrasena;
			}
			set
			{
				if ((this._Contrasena != value))
				{
					this._Contrasena = value;
				}
			}
		}
	}
	
	public partial class Lista_Eventos_x_UbicacionLocalResult
	{
		
		private string _NombreLocal;
		
		private string _NombreEvento;
		
		private string _DescripcionEvento;
		
		private string _Nombre;
		
		private int _Id_Local;
		
		private string _Ubicacion;
		
		private string _Nombre1;
		
		public Lista_Eventos_x_UbicacionLocalResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreLocal", DbType="NVarChar(250)")]
		public string NombreLocal
		{
			get
			{
				return this._NombreLocal;
			}
			set
			{
				if ((this._NombreLocal != value))
				{
					this._NombreLocal = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreEvento", DbType="NVarChar(250)")]
		public string NombreEvento
		{
			get
			{
				return this._NombreEvento;
			}
			set
			{
				if ((this._NombreEvento != value))
				{
					this._NombreEvento = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DescripcionEvento", DbType="NVarChar(250)")]
		public string DescripcionEvento
		{
			get
			{
				return this._DescripcionEvento;
			}
			set
			{
				if ((this._DescripcionEvento != value))
				{
					this._DescripcionEvento = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="VarChar(50)")]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this._Nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Local", DbType="Int NOT NULL")]
		public int Id_Local
		{
			get
			{
				return this._Id_Local;
			}
			set
			{
				if ((this._Id_Local != value))
				{
					this._Id_Local = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ubicacion", DbType="NVarChar(250)")]
		public string Ubicacion
		{
			get
			{
				return this._Ubicacion;
			}
			set
			{
				if ((this._Ubicacion != value))
				{
					this._Ubicacion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre1", DbType="VarChar(50)")]
		public string Nombre1
		{
			get
			{
				return this._Nombre1;
			}
			set
			{
				if ((this._Nombre1 != value))
				{
					this._Nombre1 = value;
				}
			}
		}
	}
	
	public partial class ListaLocal_AtributosCategoriasResult
	{
		
		private string _NombreLocal;
		
		private string _Ubicacion;
		
		private string _Horario;
		
		private int _Id_Local;
		
		public ListaLocal_AtributosCategoriasResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreLocal", DbType="NVarChar(250)")]
		public string NombreLocal
		{
			get
			{
				return this._NombreLocal;
			}
			set
			{
				if ((this._NombreLocal != value))
				{
					this._NombreLocal = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ubicacion", DbType="NVarChar(250)")]
		public string Ubicacion
		{
			get
			{
				return this._Ubicacion;
			}
			set
			{
				if ((this._Ubicacion != value))
				{
					this._Ubicacion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Horario", DbType="NVarChar(250)")]
		public string Horario
		{
			get
			{
				return this._Horario;
			}
			set
			{
				if ((this._Horario != value))
				{
					this._Horario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id_Local", DbType="Int NOT NULL")]
		public int Id_Local
		{
			get
			{
				return this._Id_Local;
			}
			set
			{
				if ((this._Id_Local != value))
				{
					this._Id_Local = value;
				}
			}
		}
	}
	
	public partial class ListarLocalXstringResult
	{
		
		private string _NombreLocal;
		
		private string _Ubicacion;
		
		private string _Horario;
		
		public ListarLocalXstringResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NombreLocal", DbType="NVarChar(250)")]
		public string NombreLocal
		{
			get
			{
				return this._NombreLocal;
			}
			set
			{
				if ((this._NombreLocal != value))
				{
					this._NombreLocal = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ubicacion", DbType="NVarChar(250)")]
		public string Ubicacion
		{
			get
			{
				return this._Ubicacion;
			}
			set
			{
				if ((this._Ubicacion != value))
				{
					this._Ubicacion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Horario", DbType="NVarChar(250)")]
		public string Horario
		{
			get
			{
				return this._Horario;
			}
			set
			{
				if ((this._Horario != value))
				{
					this._Horario = value;
				}
			}
		}
	}
}
#pragma warning restore 1591