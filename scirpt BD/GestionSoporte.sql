/*Create Database DB_GestionSoporte
Go 
Use DB_GestionSoporte
*/

Create Table TipoDocumento
(
Codigo_TDO		Int identity Primary Key Not Null,
Nombre_TDO		Varchar(100),
Estado_Tdo		Varchar(3),
FechaSys_TDO	DateTime Default GetDate()
)
Go
If Not Exists (Select  * from TipoDocumento)
Begin
	Insert Into TipoDocumento Values ('TARJETA DE IDENTIDAD','ACT',GETDATE()) 
	Insert Into TipoDocumento Values ('CEDULA DE CIUDADANIA','ACT',GETDATE()) 
	Insert Into TipoDocumento Values ('CEDULA DE EXTRANJERIA','ACT',GETDATE()) 
End
Go
Create Table Empleado
(
Identificacion_Emp	Varchar(50) Primary Key Not Null,
Codigo_TDO			Int, Foreign Key (Codigo_TDO) REferences TipoDocumento(Codigo_TDO),
PrimerNombre_Emp	Varchar(100),
SegundoNombre_Emp	Varchar(100),
PrimerApellido_Emp	Varchar(100),
SegundoApellido_Emp	Varchar(100),
Direccion_Emp		Varchar(100),
Telefono_Emp		Varchar(20),
FechaNacimiento_Emp Date,
Correo_Emp			Varchar(50),
Estado_Emp			Varchar(3),
FechaRegistro_Emp	DateTime Default GetDate()
)
Go
Create Table Perfiles
(
Codigo_PER	Int identity Primary Key Not Null,
Nombre_PER	Varchar(50)
)
Go
If Not Exists (Select  * from Perfiles)
Begin
	Insert Into Perfiles Values ('ADMINISTRADOR') 
End
Go
Create Table Usuario
(
Codigo_USR			Int identity Primary Key Not Null,
Codigo_PER			Int, Foreign Key (Codigo_PER)REferences Perfiles(Codigo_PER),
Identificacion_Emp	Varchar(50) Foreign Key (Identificacion_Emp) References Empleado(Identificacion_Emp),
Contraseña_USR		Varchar(20),
Estado_USR			Varchar(3),
FechaSys_USR		DateTime Default GetDate()
)
Go
Create Table Ubicacion
(
Codigo_UBI		Int Identity Primary Key Not Null,
Nombre_UBI		Varchar(100),
Direccion_UBI	Varchar(100),
Telefono_UBI	Varchar(20),
Estado_UBI		Varchar(3),
FechaSys_UBI	DateTime Default GetDate()
)
Go
Create Table TipoEquipo
(
Codigo_TPE		Int Identity Primary Key Not Null,
Nombre_TPE		Varchar(100),
)
Go
Create Table Equipo
(
Codigo_EQP				Int Identity(1,1) Primary Key Not Null,
Etiqueta_EQP			Varchar(50),
Codigo_UBI				Int, Foreign Key (Codigo_UBI)References Ubicacion(Codigo_UBI),
Codigo_TPE				Int, Foreign Key (Codigo_TPE)References TipoEquipo(Codigo_TPE),
IdResponsable_EQP		Varchar(50) Foreign Key (IdResponsable_EQP) References Empleado(Identificacion_Emp),
Marca_EQP				Varchar(50),
Descripcion_EQP			Varchar(300),
Serial_EQP				Varchar(50),
Estado_EQP				Varchar(3),
FechaRegistro_EQP		Date,
FechaSys_EQP			Datetime Default GetDate()
)
Go -- DROP TABLE Componente
Create Table Componente
(
Codigo_CPT		Int Identity Primary Key Not Null, 
Nombre_CPT		VArchar(100),
Estado_CPT		Varchar(3),
FechaSys_CPT	Datetime Default GetDate()
)
GO -- DROP Table EquipoDetalle
Create Table EquipoDetalle
(
Codigo_EQD		Int Identity(1,1) Primary Key Not Null,
Codigo_CPT		Int, Foreign Key (Codigo_CPT) References Componente(Codigo_CPT),
Codigo_EQP		Int, Foreign Key (Codigo_EQP) References Equipo(Codigo_EQP),
Marca_EQD		Varchar(50),
Modelo_EQD		Varchar(50),
Serial_EQD		Varchar(50),	
Dato_EQD		Varchar(100),
Estado_EQD		Varchar(3),
FechaSys_CRT	Datetime Default GetDate()
)
Go
Create Table TipoSolicitud-- Select  * from TipoSolicitud
(
Codigo_TPS		Int Identity Primary Key Not Null, 
Nombre_TPS		VArchar(100) 
)
Go
If Not Exists (Select  * from TipoSolicitud)
Begin
	 Insert Into TipoSolicitud Values ('MANTENIMIENTO DE COMPUTO');
	 Insert Into TipoSolicitud Values ('MANTENIMIENTO ELECTRICO');
	 Insert Into TipoSolicitud Values ('MANTENIMIENTO ELECTRONICO');
	 Insert Into TipoSolicitud Values ('MANTENIMIENTO LOCATIVO');
	 Insert Into TipoSolicitud Values ('MANTENIMIENTO DE COMUNICACIONES');
End
Go
Create Table Solicitud -- Drop Table Solicitud
(
Codigo_STD		Int Identity(1,1) Primary Key Not Null, 
Codigo_UBI		Int, Foreign Key (Codigo_UBI) References Ubicacion(Codigo_UBI),
Codigo_EQP		Int,-- Foreign Key (Codigo_EQP) References Equipo(Codigo_EQP),
Codigo_TPS		Int, Foreign Key (Codigo_TPS) References TipoSolicitud(Codigo_TPS),
Descripcion_STD Varchar(300),
FechaInicio_STD	Date,
FechaFin_STD	Date,
IdCrea_STD		Varchar(50) Foreign Key (IdCrea_STD) References Empleado(Identificacion_Emp),
IdAsignado_STD	Varchar(50),
Estado_STD		Varchar(3),
FechaSys_STD	DateTime Default GetDate()
)
Go
Create Table TipoHistoria
(
Codigo_TPH		Int Identity Primary Key Not Null, 
Nombre_TPH		Varchar(100),
Estado_TPH		Varchar(3) 
)
Go
If Not Exists (Select  * from TipoHistoria)
Begin
	Insert Into TipoHistoria Values ('CREACION', 'ACT')
	Insert Into TipoHistoria Values ('ASIGNACION','ACT')
	Insert Into TipoHistoria Values ('LECTURA', 'ACT')
	Insert Into TipoHistoria Values ('APLAZADO', 'ACT')
	Insert Into TipoHistoria Values ('PROCESADO', 'ACT')
	Insert Into TipoHistoria Values ('FINALIZADO', 'ACT')
End
Go
Create Table HistoriaSolicitud -- Drop Table HistoriaSolicitud
(
Codigo_HST			Int Identity(1,1) Primary Key Not Null, 
Codigo_STD			Int, Foreign Key (Codigo_STD) References Solicitud(Codigo_STD),
Codigo_TPH			Int, Foreign Key (Codigo_TPH) References TipoHistoria(Codigo_TPH),
FechaAtencion_HST	DateTime,
EmpleadoAtiende_HST	Varchar(50) Foreign Key (EmpleadoAtiende_HST) References Empleado(Identificacion_Emp),
Observacion_HST		Varchar(300),
Costo_HST			DEcimal(12,2),
FechaSys_HST		DateTime Default GetDate()
) 
Go
If Not Exists(select  * from empleado where Identificacion_Emp='ANONIMO')
Begin
	Insert Into empleado Values ('1',2,'ANONIMO','','ANONIMO','','','','1900-01-01','','DEF',GetDate());
	Insert Into Usuario Values (1,'1','GiStm#89','ACT',getDate());
End
Go
--|======================================================================================================================|
--|==================================== PROCEDIMIENTOS ALMACENADOS ======================================================|
--|======================================================================================================================|

Create Procedure PER_ListarPerfiles
@codPerfil	Int = Null
As
Begin
	Select *
	From	Perfiles
	Where	Codigo_PER = IsNull(@codPerfil,Codigo_PER)
End
Go
Create Procedure PER_RegistrarPerfil
@codPerfil	Int=null,
@Nombre		Varchar(50)
As
Begin
	If (@codPerfil Is null)
	Begin
		Insert Into Perfiles Values (@Nombre)
	End
	Else
		Begin
			Update Perfiles
			Set	Nombre_PER = @Nombre
			Where	Codigo_PER = @codPerfil
		End
End
Go
Create Procedure TDO_ListarTipoDoc 
As
Begin
	Select *
	From	TipoDocumento 
End
Go
Create Procedure TDO_RegistrarTipoDoc
@codTipo	Int=null,
@Nombre		Varchar(50),
@Estado		Varchar(3)='ACT'
As
Begin
	If (@codTipo Is null)
	Begin
		Insert Into TipoDocumento Values (@Nombre,@Estado,GETDATE())
	End
	Else
		Begin
			Update TipoDocumento
			Set	Nombre_TDO = @Nombre,
				Estado_Tdo = @Estado
			Where	Codigo_TDO = @codTipo
		End
End
Go
Go
If Not OBJECT_ID('EMP_ListarEmpleado') Is Null BEgin Drop Procedure EMP_ListarEmpleado End
Go
Create Procedure EMP_ListarEmpleado
@IdEmp	Varchar(50)=null
As
Begin
	Select	*
	From	Empleado
	Where	Identificacion_Emp = IsNull(@IdEmp,Identificacion_Emp)
			And Estado_Emp in('ACT','DEF')
End
Go 
Create Procedure EMP_RegistrarEmpleado
@IdEmp		Varchar(50),
@tipoDoc	Int,
@pNombre	Varchar(100),
@sNombre	Varchar(100),
@pApellido	Varchar(100),
@sApellido	Varchar(100),
@Direccion	Varchar(100),
@telefono	Varchar(20),
@fechaNac	Date,
@correo		Varchar(100),
@Estado		Varchar(3)='ACT'
As
Begin
	 If Not Exists(Select	* From	Empleado Where	Identificacion_Emp = @IdEmp)
	 Begin
		Insert Into Empleado VAlues (@IdEmp,@tipoDoc,@pNombre,@sNombre,@pApellido,@sApellido,@Direccion,@telefono,@fechaNac,@correo,@Estado,GetDate())
	 End
	 Else
		 Begin
			Update Empleado 
			Set PrimerNombre_Emp = @pNombre,
				SegundoNombre_Emp = @sNombre,
				PrimerApellido_Emp=@pApellido,
				SegundoApellido_Emp=@sApellido,
				Direccion_Emp = @Direccion,
				Telefono_Emp= @telefono,
				Estado_Emp = @Estado,
				Correo_Emp = @correo 
			Where	Identificacion_Emp = @IdEmp
		 End
End
Go
Create Procedure USU_ListarUsuarios
@idEmp	Varchar(50)=null
As
Begin
	Select	*
	From	Usuario u
	Inner Join Perfiles p	
		On P.Codigo_PER = u.Codigo_PER
	Where	Identificacion_Emp = IsNull(@idEmp,Identificacion_Emp)
			aND Estado_USR = 'ACT'
End
Go
Create Procedure USU_RegistrarUsuario
@codPerfil	Int,
@idEmp		Varchar(50),
@password	varchar(20),
@Estado		VArchar(3)='ACT'
As
Begin
	If Not Exists(Select * From Usuario where Identificacion_Emp = @idEmp)
	Begin
		Insert Into Usuario Values (@codPerfil,@idEmp,@password,@Estado,GetDate())
	End	
	Else
		Begin
			Update Usuario 
			Set Codigo_PER = @codPerfil,
				Contraseña_USR=@password,
				Estado_USR = @Estado
			Where Identificacion_Emp = @idEmp
		End 
End
Go
Create Procedure TPE_ListarTiposEquipo
As
	Select	*
	From	TipoEquipo

Go
Create Procedure TPE_RegistrarTipoEquipo
@codigo	Int	= Null,
@Nombre	Varchar(100)
As
Begin
	If(@codigo Is Null)
	Begin
		Insert Into TipoEquipo Values (@Nombre)
	End
	Else
		Begin
			Update TipoEquipo 
			Set Nombre_TPE = @Nombre
			Where Codigo_TPE = @codigo
		End
End
Go
Create Procedure CPT_ListarComponentes
As
	Select	*
	From	Componente
Go
Create Procedure  CPT_RegistrarComponente
@codigo		Int = Null,
@Nombre		Varchar(100),
@estado		Varchar(3)='ACT'
As
Begin
	If(@codigo Is Null)
	Begin
		Insert Into Componente Values (@Nombre,@estado,GetDate())
	End
	Else
		Begin
			Update Componente 
			Set Nombre_CPT = @Nombre,
				Estado_CPT = @estado
			Where Codigo_CPT = @codigo
		End
End
Go

Create Procedure UBI_ListarUbicaciones
@codUbi	Int=null
As
Begin
	Select	*
	From	Ubicacion
	Where	Codigo_UBI = IsNull(@codUbi,Codigo_UBI)
End
Go

Create Procedure UBI_CrearUbicacion
@codUbi		Int=null,
@Nombre		Varchar(100),
@Direccion	Varchar(100),
@Telefono	Varchar(20),
@Estado		Varchar(3)='ACT'
As
Begin
	If(@codUbi Is Null)
	Begin
		Insert Into Ubicacion Values (@Nombre,@Direccion,@Telefono,@estado,GetDate())
	End
	Else
		Begin
			Update Ubicacion 
			Set Nombre_UBI = @Nombre,
				Direccion_UBI= @Direccion,
				Telefono_UBI = @Telefono,
				Estado_UBI = @estado
			Where Codigo_UBI = @codUbi
		End
End
Go
If Not OBJECT_ID('EQP_ListarEquipos') Is Null BEgin Drop Procedure EQP_ListarEquipos End
Go
Create Procedure EQP_ListarEquipos
@codEquipo			Int = null
As
Begin
	Select  e.*,
			emp.PrimerNombre_Emp + ' ' + SegundoNombre_Emp + ' ' + PrimerApellido_Emp+ ' ' +SegundoApellido_Emp Empleado,
			u.Nombre_UBI ubicacion, te.Nombre_TPE As TipoEquipo 
	From	Equipo  e
	Inner	Join Empleado emp	
		On e.IdResponsable_EQP = emp.Identificacion_Emp
	Inner Join Ubicacion u
		On e.Codigo_UBI = u.Codigo_UBI
	Inner Join TipoEquipo te
		On e.Codigo_TPE = te.Codigo_TPE
	Where	Codigo_EQP = IsNull(@codEquipo,Codigo_EQP)
			--And Estado_EQP = 'ACT'
End
Go
If Not OBJECT_ID('EQP_RegistrarEquipo') Is Null BEgin Drop Procedure EQP_RegistrarEquipo End
Go
Create Procedure [dbo].[EQP_RegistrarEquipo]
@codEquipo			Int = null,
@codUbicacion		Int,
@codTipoEquipo		Int,
@Responsable		Varchar(50),
@descripcion		Varchar(300),
@estado				Varchar(3)='ACT',
@etiqueta			varchar(50),
@serial				varchar(50),
@marca				varchar(50)
As
Begin
	If(@codEquipo Is Null)
	Begin
		Insert Into [Equipo] Values (@etiqueta,@codUbicacion,@codTipoEquipo,@Responsable, @marca,@descripcion, @serial,@estado,GetDate(),GetDate())
	End
	Else
		Begin
			Update	Equipo
			Set		Codigo_UBI = @codUbicacion,
			        Etiqueta_EQP = @etiqueta,
					Codigo_TPE = @codTipoEquipo,
					IdResponsable_EQP = @Responsable,
					Descripcion_EQP= @descripcion,
					Serial_EQP=@serial,
					MArca_EQP = @marca,
					Estado_EQP= @estado
			Where	Codigo_EQP = @codEquipo
		End
End
Go--
If Not OBJECT_ID('EQD_ListarDetallesEquipo') Is Null BEgin Drop Procedure EQD_ListarDetallesEquipo End  
Go
Create Procedure EQD_ListarDetallesEquipo
@codDetalle			Int = null
As
Begin
	Select  * 
	From	EquipoDetalle 
	Where	Codigo_EQD = IsNull(@codDetalle,Codigo_EQD)
End
Go--
If Not OBJECT_ID('EQD_RegistrarDetalleEquipo') Is Null BEgin Drop Procedure EQD_RegistrarDetalleEquipo End
Go
Create Procedure EQD_RegistrarDetalleEquipo
@codDetalle			Int = null,
@codEquipo			Int ,
@codComponente		Int,
@marca				varchar(50),
@modelo				Varchar(50),
@serial				Varchar(50),
@datoAdic			Varchar(100),
@estado				Varchar(3)='ACT'
As
Begin
	If(@codDetalle Is Null)
	Begin
		Insert Into EquipoDetalle Values (@codComponente,@codEquipo,@marca,@modelo,@serial,@datoAdic,@estado,GetDate() )
	End
	Else
		Begin
			Update	EquipoDetalle
			Set		Codigo_CPT = @codComponente, 
					Marca_EQD = @marca,
					Modelo_EQD= @modelo,
					Serial_EQD = @serial,
					Dato_EQD= @datoAdic,
					Estado_EQD = @estado
			Where	Codigo_EQD = @codDetalle
		End
End 

Go

Create procedure TPS_ListarTipoSolicitud
As
 Select	*
 From	TipoSolicitud

Go
If Not OBJECT_ID('STD_CrearSolicitud') Is Null BEgin Drop Procedure STD_CrearSolicitud End
Go 
 Create Procedure STD_CrearSolicitud
 @codigo		Int = Null,
 @codUbi		Int,
 @codEquipo		Int,
 @codTipoSol	Int,
 @descripcion	Varchar(300),
 @fechaIni		DateTime,
 @fechaFin		DateTime =Null,
 @idCrea		Varchar(50)='',
 @idAsignado	Varchar(50)='',
 @estado		Varchar(3)='ACT'
 As
 Begin
	If(@codigo Is Null)
	Begin
		Insert Into Solicitud  Values (@codUbi,@codEquipo,@codTipoSol,@descripcion,@fechaIni,@fechaFin,@idCrea,@idAsignado,@estado, GetDate())
	End
	Else
		Begin
			Update	Solicitud
					Set FechaFin_STD = @fechaFin,
					Estado_STD=@estado,
					IdAsignado_STD = @idAsignado
			Where	Codigo_STD = @codigo
		End
 End	 
Go
If Not OBJECT_ID('STD_ListarSolicitudes') Is Null BEgin Drop Procedure STD_ListarSolicitudes End
Go 
 Create Procedure STD_ListarSolicitudes
 @codigo		Int = Null,
 @fechaIni		Date = null,
 @fechaFin		Date = null, 
 @estado		varchar(3)=null
 As
 Begin
	Select	s.*, ts.Nombre_TPS,u.Nombre_UBI,
			ec.PrimerNombre_Emp+ ' ' + ec.SegundoNombre_Emp + ' ' +ec.PrimerApellido_Emp + ' ' +ec.SegundoApellido_Emp EmpCrea,
			ea.PrimerNombre_Emp+ ' ' + ea.SegundoNombre_Emp + ' ' +ea.PrimerApellido_Emp + ' ' +ea.SegundoApellido_Emp EmpAsignado,
			case s.estado_std
				when 'ACT' Then 'SIN LEER'
				when 'LEI' Then 'LEIDO'
				when 'PRO' Then 'PROCESADO'
				when 'ASI' Then 'ASIGNADO'
				when 'FIN' Then 'FINALIZADO'
				when 'APL' Then 'APLAZADO'
				else 'SIN DEFINIR'
			End   Estado
	From	Solicitud  s
	Inner Join TipoSolicitud ts
		On s.Codigo_TPS = ts.Codigo_TPS
	Inner Join Ubicacion u
		On u.Codigo_UBI = s.Codigo_UBI
	left Join Empleado ec
		On ec.Identificacion_Emp = s.IdCrea_STD
    left Join Empleado ea
		On ea.Identificacion_Emp = s.IdAsignado_STD
	Where	Codigo_STD = IsNull(@codigo,Codigo_STD)
			And FechaInicio_STD Between ISNULL(@fechaIni,FechaInicio_STD)And ISNULL(@fechaFin,FechaInicio_STD)
			And Estado_STD = IsNull(@estado,Estado_STD)
	Order By FechaSys_STD desc
 End

 
Go--
If Not OBJECT_ID('HST_RegistrarHistoria') Is Null BEgin Drop Procedure HST_RegistrarHistoria End
Go
Create Procedure HST_RegistrarHistoria
@codigo		Int=Null,
@codSolic	Int,
@codTipoH	Int,
@Fecha		Date,
@empAtiende Varchar(50),
@observ		varchar(300),
@costo		Decimal(12,2)=0
As
Begin
	If(@codigo Is Null)
	Begin
		Insert Into HistoriaSolicitud Values (@codSolic,@codTipoH,@Fecha,@empAtiende,@observ,@costo,GetDate())
	End
	--Else
	--	Begin

	--	End
End

Go--
If Not OBJECT_ID('HST_ListarHistoriaSolicitud') Is Null BEgin Drop Procedure HST_ListarHistoriaSolicitud End
Go
Create Procedure HST_ListarHistoriaSolicitud  -- HST_ListarHistoriaSolicitud 1
@codigoSolic		Int=Null
As
Begin
	Select	h.*,
			e.PrimerNombre_Emp+ ' ' + e.SegundoNombre_Emp + ' ' +e.PrimerApellido_Emp + ' ' +e.SegundoApellido_Emp Empleado,
			th.Nombre_TPH
	From	HistoriaSolicitud h
	Inner Join Empleado e
		On e.Identificacion_Emp = h.EmpleadoAtiende_HST
	Inner Join TipoHistoria th
		On th.Codigo_TPH = h.Codigo_TPH
	Where	Codigo_STD  = @codigoSolic
End
Go--
If Not OBJECT_ID('STD_ActualizarEstado') Is Null BEgin Drop Procedure STD_ActualizarEstado End
Go
Create Procedure STD_ActualizarEstado
@codigoSTD	Int,
@estado		Varchar(3)
As
Begin
	 Update Solicitud 
	 Set Estado_STD = @estado
	 Where	Codigo_STD = @codigoSTD
End
Go

-- select  * from EquipoDescartado
Create table EquipoDescartado
(
Codigo_EDC		Int Identity(1,1) Primary Key Not Null, 
--Codigo_STD			Int, Foreign Key (Codigo_STD) References Solicitud(Codigo_STD),
Codigo_EQP		Int, Foreign Key (Codigo_EQP) References Equipo(Codigo_EQP),
Nota_EDC		Varchar(300),
Identificacion_Emp	Varchar(50) Foreign Key (Identificacion_Emp) References Empleado(Identificacion_Emp),
FechaSys_EDC	DateTime Default GetDAte()
)
Go
If Not Object_Id('EQP_DescartarEquipo') Is Null Begin Drop Procedure EQP_DescartarEquipo End
Go
Create Procedure EQP_DescartarEquipo
@codEquipo		Int,
@nota			Varchar(300),
@idEmp			varchar(50)
As
Begin
	Insert Into EquipoDescartado Values (@codEquipo,@nota,@idEmp,GetDate())

	Update	Equipo 
	Set		Estado_EQP = 'DB'
	Where	Codigo_EQP = @codEquipo
End