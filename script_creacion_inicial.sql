USE [GD2C2016]
GO

-- Validacion de existencia
IF SCHEMA_ID('JOINEANDO_ANDO') IS NOT NULL
BEGIN
	--TABLAS
	IF OBJECT_ID('JOINEANDO_ANDO.Cancelaciones') IS NOT NULL
	DROP TABLE [JOINEANDO_ANDO].Cancelaciones
	
	IF OBJECT_ID('JOINEANDO_ANDO.Habilitados') IS NOT NULL
	DROP TABLE [JOINEANDO_ANDO].Habilitados

	IF OBJECT_ID('JOINEANDO_ANDO.Medico_Especialidad') IS NOT NULL
	DROP TABLE [JOINEANDO_ANDO].Medico_Especialidad

	IF OBJECT_ID('JOINEANDO_ANDO.Rol_Funcionabilidad') IS NOT NULL
	DROP TABLE [JOINEANDO_ANDO].Rol_Funcionabilidad

	IF OBJECT_ID('JOINEANDO_ANDO.Usuario_Rol') IS NOT NULL
	DROP TABLE [JOINEANDO_ANDO].Usuario_Rol

	IF OBJECT_ID('JOINEANDO_ANDO.Rol') IS NOT NULL
	DROP TABLE [JOINEANDO_ANDO].Rol

	IF OBJECT_ID('JOINEANDO_ANDO.Compra_Bonos') IS NOT NULL
	DROP TABLE [JOINEANDO_ANDO].Compra_Bonos

	IF OBJECT_ID('JOINEANDO_ANDO.Funcionabilidades') IS NOT NULL
	DROP TABLE [JOINEANDO_ANDO].Funcionabilidades

	IF OBJECT_ID('JOINEANDO_ANDO.Resultados') IS NOT NULL
	DROP TABLE [JOINEANDO_ANDO].Resultados

	IF OBJECT_ID('JOINEANDO_ANDO.Consulta_Medica') IS NOT NULL
	DROP TABLE [JOINEANDO_ANDO].Consulta_Medica
	
	IF OBJECT_ID('JOINEANDO_ANDO.Bonos') IS NOT NULL
	DROP TABLE [JOINEANDO_ANDO].Bonos

	IF OBJECT_ID('JOINEANDO_ANDO.Turnos') IS NOT NULL
	DROP TABLE [JOINEANDO_ANDO].Turnos

	IF OBJECT_ID('JOINEANDO_ANDO.Dias_Atencion') IS NOT NULL
	DROP TABLE [JOINEANDO_ANDO].Dias_Atencion

	IF OBJECT_ID('JOINEANDO_ANDO.Agendas') IS NOT NULL
	DROP TABLE [JOINEANDO_ANDO].Agendas

	IF OBJECT_ID('JOINEANDO_ANDO.Dias_Semana') IS NOT NULL
	DROP TABLE [JOINEANDO_ANDO].Dias_Semana

	IF OBJECT_ID('JOINEANDO_ANDO.Especialidades') IS NOT NULL
	DROP TABLE [JOINEANDO_ANDO].Especialidades

	IF OBJECT_ID('JOINEANDO_ANDO.Medicos') IS NOT NULL
	DROP TABLE [JOINEANDO_ANDO].Medicos

	IF OBJECT_ID('JOINEANDO_ANDO.Hist_Cambios') IS NOT NULL
	DROP TABLE [JOINEANDO_ANDO].[Hist_Cambios]

	IF OBJECT_ID('JOINEANDO_ANDO.Pacientes') IS NOT NULL
	DROP TABLE [JOINEANDO_ANDO].Pacientes

	IF OBJECT_ID('JOINEANDO_ANDO.Planes') IS NOT NULL
	DROP TABLE [JOINEANDO_ANDO].Planes
	
	IF OBJECT_ID('JOINEANDO_ANDO.Tipo_Especialidad') IS NOT NULL
	DROP TABLE [JOINEANDO_ANDO].Tipo_Especialidad

	IF OBJECT_ID('JOINEANDO_ANDO.Usuarios') IS NOT NULL
	DROP TABLE [JOINEANDO_ANDO].Usuarios	
	
	IF OBJECT_ID('JOINEANDO_ANDO.Tipo_Documento') IS NOT NULL
	DROP TABLE [JOINEANDO_ANDO].Tipo_Documento

	IF OBJECT_ID('JOINEANDO_ANDO.Sexo') IS NOT NULL
	DROP TABLE [JOINEANDO_ANDO].Sexo
 
	

--Stored Procedures

  IF OBJECT_ID('JOINEANDO_ANDO.compra_bono') IS NOT NULL
	DROP PROCEDURE JOINEANDO_ANDO.compra_bono

  IF OBJECT_ID('JOINEANDO_ANDO.precio_bono') IS NOT NULL
	DROP PROCEDURE JOINEANDO_ANDO.precio_bono



  IF OBJECT_ID('JOINEANDO_ANDO.listar_cambios') IS NOT NULL
	DROP PROCEDURE JOINEANDO_ANDO.listar_cambios


  IF OBJECT_ID('JOINEANDO_ANDO.baja_paciente') IS NOT NULL
	DROP PROCEDURE JOINEANDO_ANDO.baja_paciente

  IF OBJECT_ID('JOINEANDO_ANDO.actualizar_paciente') IS NOT NULL
	DROP PROCEDURE JOINEANDO_ANDO.actualizar_paciente

IF OBJECT_ID('JOINEANDO_ANDO.listado_sexo') IS NOT NULL
	DROP PROCEDURE JOINEANDO_ANDO.listado_sexo

		IF OBJECT_ID('JOINEANDO_ANDO.listado_planes') IS NOT NULL


	DROP PROCEDURE JOINEANDO_ANDO.listado_planes
IF OBJECT_ID('JOINEANDO_ANDO.listado_tipo_documentos') IS NOT NULL
	DROP PROCEDURE JOINEANDO_ANDO.listado_tipo_documentos

	IF OBJECT_ID('JOINEANDO_ANDO.crear_paciente') IS NOT NULL
	DROP PROCEDURE JOINEANDO_ANDO.crear_paciente


	IF OBJECT_ID('JOINEANDO_ANDO.filtro_paciente') IS NOT NULL
	DROP PROCEDURE JOINEANDO_ANDO.filtro_paciente




	IF OBJECT_ID('JOINEANDO_ANDO.validar_usuario') IS NOT NULL
	DROP PROCEDURE JOINEANDO_ANDO.validar_usuario


	IF OBJECT_ID('JOINEANDO_ANDO.roles_x_usuario') IS NOT NULL
	DROP PROCEDURE JOINEANDO_ANDO.roles_x_usuario

	IF OBJECT_ID('JOINEANDO_ANDO.seleccionar_funcionabilidades_x_rol') IS NOT NULL
	DROP PROCEDURE JOINEANDO_ANDO.seleccionar_funcionabilidades_x_rol
	
		IF OBJECT_ID('JOINEANDO_ANDO.seleccionar_funcionabilidades') IS NOT NULL
	DROP PROCEDURE JOINEANDO_ANDO.seleccionar_funcionabilidades

			IF OBJECT_ID('JOINEANDO_ANDO.actualizar_Rol') IS NOT NULL
	DROP PROCEDURE JOINEANDO_ANDO.actualizar_Rol

		IF OBJECT_ID('JOINEANDO_ANDO.baja_funcionablilida_x_rol') IS NOT NULL
	DROP PROCEDURE JOINEANDO_ANDO.baja_funcionablilida_x_rol

		IF OBJECT_ID('JOINEANDO_ANDO.alta_funcionabiliad_x_rol') IS NOT NULL
	DROP PROCEDURE JOINEANDO_ANDO.alta_funcionabiliad_x_rol

			IF OBJECT_ID('JOINEANDO_ANDO.alta_Rol') IS NOT NULL
	DROP PROCEDURE JOINEANDO_ANDO.alta_Rol

			IF OBJECT_ID('JOINEANDO_ANDO.Seleccionar_Propiedades_Rol') IS NOT NULL
	DROP PROCEDURE JOINEANDO_ANDO.Seleccionar_Propiedades_Rol

		IF OBJECT_ID('JOINEANDO_ANDO.inHabilitar_Rol') IS NOT NULL
	DROP PROCEDURE JOINEANDO_ANDO.inHabilitar_Rol


		IF OBJECT_ID('JOINEANDO_ANDO.filtro_rol') IS NOT NULL
	DROP PROCEDURE JOINEANDO_ANDO.filtro_rol



		IF OBJECT_ID('JOINEANDO_ANDO.listarRoles') IS NOT NULL
	DROP PROCEDURE 	JOINEANDO_ANDO.listarRoles

	IF OBJECT_ID('JOINEANDO_ANDO.validar_usuario') IS NOT NULL
	DROP PROCEDURE JOINEANDO_ANDO.validar_usuario

	IF OBJECT_ID('JOINEANDO_ANDO.UsuariosPorId_seleccion') IS NOT NULL
	DROP PROCEDURE JOINEANDO_ANDO.UsuariosPorId_seleccion

	IF OBJECT_ID('JOINEANDO_ANDO.listarRoles') IS NOT NULL
	DROP PROCEDURE JOINEANDO_ANDO.listarRoles

	IF OBJECT_ID('JOINEANDO_ANDO.Seleccionar_rol') IS NOT NULL
	DROP PROCEDURE JOINEANDO_ANDO.Seleccionar_rol

	IF OBJECT_ID('JOINEANDO_ANDO.Seleccionar_Funcionabilidades_x_Rol') IS NOT NULL
	DROP PROCEDURE JOINEANDO_ANDO.Seleccionar_Funcionabilidades_x_Rol

	IF OBJECT_ID('JOINEANDO_ANDO.Seleccionar_Funcionabilidades') IS NOT NULL
	DROP PROCEDURE JOINEANDO_ANDO.Seleccionar_Funcionabilidades

	IF OBJECT_ID('JOINEANDO_ANDO.Historial_Modificacion_Paciente') IS NOT NULL
	DROP PROCEDURE JOINEANDO_ANDO.Historial_Modificacion_Paciente

--Funciones
	IF OBJECT_ID('JOINEANDO_ANDO.Existe_Usuario') IS NOT NULL
	DROP FUNCTION JOINEANDO_ANDO.Existe_Usuario

	IF OBJECT_ID('JOINEANDO_ANDO.Cantidad_Intentos_Fallidos') IS NOT NULL
	DROP FUNCTION JOINEANDO_ANDO.Cantidad_Intentos_Fallidos

-- Vistas
	IF OBJECT_ID('JOINEANDO_ANDO.Historial_cambios_paciente') IS NOT NULL
	DROP VIEW JOINEANDO_ANDO.Historial_cambios_paciente

--Esquema

	IF SCHEMA_ID('JOINEANDO_ANDO') IS NOT NULL
	DROP SCHEMA [JOINEANDO_ANDO]

END
GO

--Creacion de Esquema
CREATE SCHEMA [JOINEANDO_ANDO] AUTHORIZATION [gd]

GO

--Creacion de Tablas
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [JOINEANDO_ANDO].[Agendas](
	[Agenda_id] [int] IDENTITY(1,1) NOT NULL,
	[Medico_id] [int] NOT NULL,
	[Especialidad_id] [int] NOT NULL
	)
GO

CREATE TABLE [JOINEANDO_ANDO].[Dias_Atencion](
	[Agenda_id] [int] NOT NULL,
	[Dia_id] [int] NOT NULL,
	[Inicio_Horario] time (7) NOT NULL,
	[Fin_Horario] time (7) NOT NULL
	)
GO

CREATE TABLE [JOINEANDO_ANDO].[Bonos](
	[Bono_id] [int]  NOT NULL,
	[Plan_id] [int] NOT NULL,
	[Numero_Consulta_Medica] [int],
	[Numero_Afiliado] [int] NOT NULL,

)
GO

CREATE TABLE [JOINEANDO_ANDO].[Cancelaciones](
	[Turno_id] [int] NOT NULL,
	[Descripcion] [nvarchar](255) NOT NULL
) 
GO

CREATE TABLE [JOINEANDO_ANDO].[Compra_Bonos](
	[Compra_id] [int] IDENTITY(1,1) NOT NULL,
	[Paciente_id] [int] NOT NULL,
	[Monto] [numeric](18, 2) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Fecha_Compra] [datetime] NOT NULL
	)
GO

CREATE TABLE [JOINEANDO_ANDO].[Consulta_Medica](
	[Consulta_Medica_id] [int] IDENTITY(1,1) NOT NULL,
	[Turno_id] [int] NOT NULL,
	[Bono_id] [int] NOT NULL,
	[Horario_Llegada] [datetime] NULL,
	[Horario_Atencion] [datetime] NULL
	)
GO

CREATE TABLE [JOINEANDO_ANDO].[Especialidades](
	[Especialidad_id] [int]  NOT NULL,
	[Nombre_Especialidad] [nvarchar](255) NOT NULL,
	[Tipo_Especialidad_id] [int] NULL
	)
GO

CREATE TABLE [JOINEANDO_ANDO].[Funcionabilidades](
	[Funcionabilidad_id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL
	)
GO

CREATE TABLE [JOINEANDO_ANDO].[Habilitados](
	[Paciente_id] [int] NOT NULL,
	[Estado] [bit] NOT NULL,
	[Fecha_Alta] [datetime] NULL,
	[Fecha_Baja] [datetime] NULL
) 
GO

CREATE TABLE [JOINEANDO_ANDO].[Medico_Especialidad](
	[Medico_id] [int] NOT NULL,
	[Especialidad_id] [int] NOT NULL
) 
GO

CREATE TABLE [JOINEANDO_ANDO].[Medicos](
	[Medico_id] [int] NOT NULL,
	[Matricula] [int] ,
	)
GO

CREATE TABLE [JOINEANDO_ANDO].[Pacientes](
	[Paciente_id] [int] NOT NULL,
	[Estado_Civil] [nvarchar](255) ,
	[Familiares_A_Cargo] [int] NOT NULL,
	[Numero_Afiliado] [int] NOT NULL,
	[Plan_id] [int] NOT NULL
	)
GO

CREATE TABLE [JOINEANDO_ANDO].[Planes](
	[Plan_id] [int]  NOT NULL,
	[Nombre] [nvarchar](255) NOT NULL,
	[Precio_Bono_Consulta] [numeric](18, 0) NOT NULL,
	[Precio_Bono_Farmacia] [numeric] (18,0) NOT NULL
	) 
GO

CREATE TABLE [JOINEANDO_ANDO].[Resultados](
	[Resultado_id] [int] IDENTITY(1,1) NOT NULL,
	[Consulta_Medica_id] [int] NOT NULL,
	[Descripcion] [nvarchar](255) NOT NULL
	)
GO

CREATE TABLE [JOINEANDO_ANDO].[Rol](
	[Rol_id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Habilitado] [bit] NOT NULL
	) 
GO

CREATE TABLE [JOINEANDO_ANDO].[Rol_Funcionabilidad](
	[Rol_id] [int] NOT NULL,
	[Funcionabilidad_id] [int] NOT NULL
) 
GO

CREATE TABLE [JOINEANDO_ANDO].[Tipo_Documento](
	[Tipo_Documento_id] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [nvarchar](255) NOT NULL
	)
GO

CREATE TABLE [JOINEANDO_ANDO].[Tipo_Especialidad](
	[Tipo_Especialidad_id] [int]  NOT NULL,
	[Especializacion] [nvarchar](255) NOT NULL
	)
GO

CREATE TABLE [JOINEANDO_ANDO].[Turnos](
	[Paciente_id] [int] NOT NULL,
	[Agenda_id] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[Horario] [time](7) NOT NULL,
	[Turno_id] [int] IDENTITY(1,1) NOT NULL,
	[Tipo_Cancelacion] [int] NOT NULL,
	[Asistencia] [bit] NOT NULL
	) 
GO

CREATE TABLE [JOINEANDO_ANDO].[Usuario_Rol](
	[Usuario_id] [int] NOT NULL,
	[Rol_id] [int] NOT NULL
) 
GO

CREATE TABLE [JOINEANDO_ANDO].[Usuarios](
	[Usuario_id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](255) NOT NULL,
	[Apellido] [nvarchar](255) NOT NULL,
	[Numero_Documento] [numeric](18, 0) NOT NULL,
	[Tipo_Documento_id] [int] NOT NULL,
	[Direccion] [nvarchar](255) NOT NULL,
	[Telefono] [numeric](18, 0) NOT NULL,
	[Mail] [nvarchar](50) NOT NULL,
	[Fecha_Nacimiento] [datetime] NOT NULL,
	[Sexo_id] [int],
	[Nombre_Usuario] [nvarchar](255) NOT NULL,
	[Contrasena] [nvarchar](255) NOT NULL,
	[Habilitado] [bit] NOT NULL,
	[Intentos_Fallidos] [Int] NOT NULL
	)
	DBCC checkident ('[JOINEANDO_ANDO].[Usuarios]', reseed, 10000)

GO

CREATE TABLE [JOINEANDO_ANDO].[Sexo](
[Sexo_id] [int] IDENTITY(1,1) NOT NULL,
[Descripcion] [nvarchar](20) NOT NULL
)
GO

CREATE TABLE [JOINEANDO_ANDO].[Dias_Semana](
[Dia_Semana_id] [int] IDENTITY(1,1) NOT NULL,
[Dia] [nvarchar](20) NOT NULL
)
GO

CREATE TABLE [JOINEANDO_ANDO].[Hist_Cambios](
[Paciente_id][int] NOT NULL,
[Descripcion] [nvarchar](255) NOT NULL,
[Fecha_mod][datetime]
)
GO

--Vistas

CREATE view JOINEANDO_ANDO.Historial_cambios_paciente as
Select
	P.Paciente_id as AfiliadoId, 
	u.Nombre as NombreAfiliado,
	U.Apellido as ApellidoAfiliado,
	h.Fecha_mod as FechaModificacion,
	H.Descripcion as Descripcion	

From JOINEANDO_ANDO.Usuarios as U INNER JOIN JOINEANDO_ANDO.Pacientes as P
ON U.Usuario_id = P.Paciente_id INNER JOIN JOINEANDO_ANDO.Hist_Cambios AS H
ON P.Paciente_id = H.Paciente_id

GO

--Funciones

CREATE FUNCTION JOINEANDO_ANDO.Existe_Usuario (@Usuario nvarchar(255))
returns int
AS
begin
return (select count(Nombre_Usuario) from JOINEANDO_ANDO.Usuarios where Nombre_Usuario = @Usuario)
end
GO

CREATE FUNCTION JOINEANDO_ANDO.Cantidad_Intentos_Fallidos (@UnUsuario nvarchar(255))
returns int
AS
begin
return (select Intentos_Fallidos from JOINEANDO_ANDO.Usuarios where Nombre_Usuario = @UnUsuario)
end

GO

CREATE PROCEDURE JOINEANDO_ANDO.UsuariosPorId_seleccion
	@UsuarioId int
AS
BEGIN
	SELECT
	[Usuario_id] 
	,[Nombre]
	,[Apellido] 
	,[Numero_Documento] 
	,[Tipo_Documento_id] 
	,[Direccion] 
	,[Telefono] 
	,[Mail] 
	,[Fecha_Nacimiento] 
	,[Sexo_id] 
	,[Nombre_Usuario] 
	,[Contrasena]
	,[Habilitado] 
	,[Intentos_Fallidos] 
	FROM [JOINEANDO_ANDO].[Usuarios]
	WHERE [Usuario_id] = @UsuarioId
END
GO


CREATE procedure JOINEANDO_ANDO.Seleccionar_rol
@id int
As
	Begin
		Select * From [JOINEANDO_ANDO].[Rol] where Rol_id = @id
	End
GO


CREATE PROCEDURE JOINEANDO_ANDO.Historial_Modificacion_Paciente
@id int
AS
	BEGIN
		Select * From [JOINEANDO_ANDO].Historial_cambios_paciente as VP where vp.AfiliadoId = @id
	END
GO



--stored nico hay que borrar que c	reo que hay varios

CREATE procedure JOINEANDO_ANDO.compra_bono
@numeroAfiliado int,
@cantidad int
as
Begin


	declare @usr int
	set @usr = (select Paciente_id from [JOINEANDO_ANDO].Pacientes where Numero_Afiliado = @numeroAfiliado) 
  
	insert into [JOINEANDO_ANDO].Compra_bonos
	(Paciente_id,Monto,Cantidad,Fecha_Compra)
	values
	(@usr,@cantidad*(select top 1 Precio_Bono_Consulta from [JOINEANDO_ANDO].Planes where Plan_id = (select Plan_id from [JOINEANDO_ANDO].Pacientes where Paciente_id=@usr)  ),@cantidad,getdate())


End



go


CREATE procedure JOINEANDO_ANDO.precio_bono
@nombre nvarchar(255)
as


begin
SELECT TOP 1 Precio_Bono_Consulta
FROM [JOINEANDO_ANDO].Planes
WHERE  Nombre=@nombre
end
go



CREATE procedure JOINEANDO_ANDO.baja_paciente
@numeroAfiliado int
as
Begin
	update [JOINEANDO_ANDO].Habilitados
	set Fecha_Baja=getdate(),Estado=0
	WHERE Paciente_id=(select Paciente_id from [JOINEANDO_ANDO].Pacientes where Numero_Afiliado = @numeroAfiliado)
 
END
go

--stored nico hay que borrar que creo que hay varios
CREATE procedure JOINEANDO_ANDO.crear_paciente
 @nombre nvarchar(255) = '',
 @tipo nvarchar(255) = 'DNI',
 @numeroDocumento numeric(18,0) = 0,
 @apellido nvarchar(255) = '',
 @direccion nvarchar(255) = '',
 @sexo nvarchar(255) = '',
 @telefono numeric(18,0) = 0,
 @mail nvarchar(50)='',
 @fechaNac datetime = '5/5/5',
 @estadoCivil nvarchar(255) = '',
 @familiares int=0,
 @raiz int=0,
 @sub int=0,
 @plan nvarchar(255) = ''
        


 --@@IDENTITY
  AS 

  BEGIN  
   declare @returnValue int  
   declare @valor int
   declare @iden int
        INSERT INTO [JOINEANDO_ANDO].Usuarios (Nombre,Apellido,Numero_Documento,Tipo_Documento_id,Direccion,Telefono,Mail,Fecha_Nacimiento,Sexo_id,Nombre_Usuario,Contrasena,Habilitado,Intentos_Fallidos)
        values
		(@nombre,@apellido,@numeroDocumento,(select Tipo_Documento_id from [JOINEANDO_ANDO].Tipo_Documento where Tipo=@tipo),@direccion,@telefono,@mail,@fechaNac,(select Sexo_id from [JOINEANDO_ANDO].Sexo where Descripcion=@sexo),@nombre+'.'+@apellido,HASHBYTES('SHA2_256',str(@numeroDocumento)),1,0)
		set @iden = @@IDENTITY
		if @raiz = 0
		set @valor = @@IDENTITY*100 +1
		else
		set @valor = @raiz+@sub

		set @returnValue = @valor
        INSERT INTO [JOINEANDO_ANDO].Pacientes (Paciente_id,Estado_Civil,Familiares_A_Cargo,Numero_Afiliado,Plan_id)
		values
		(@@IDENTITY,@estadoCivil,@familiares,@valor,(select Plan_id from [JOINEANDO_ANDO].Planes where Nombre=@plan))

		INSERT INTO [JOINEANDO_ANDO].Habilitados (Paciente_id,Estado,Fecha_Alta,Fecha_Baja)
		values
		(@iden,1,getdate(),null)

 select @returnValue
 
  END 
go

CREATE procedure JOINEANDO_ANDO.listar_cambios
@numero_afiliado int
as
begin
select Descripcion as Razon, convert(varchar, Fecha_mod, 103) as 'Fecha Modificacion' from JOINEANDO_ANDO.Hist_Cambios where Paciente_id = (select Paciente_id from [JOINEANDO_ANDO].Pacientes where Numero_Afiliado = @numero_afiliado) 
end

go

CREATE procedure JOINEANDO_ANDO.actualizar_paciente
@direccion nvarchar(255),
@telefono numeric(18,0),
@email nvarchar(255),
@estadoCivil nvarchar(255),
@familiaresACargo int,
@plan nvarchar(255),
@numero_afiliado int,
@razon nvarchar(255) = ''

  AS 
  BEGIN   
  declare @usr int
  set @usr = (select Paciente_id from [JOINEANDO_ANDO].Pacientes where Numero_Afiliado = @numero_afiliado) 
   UPDATE [JOINEANDO_ANDO].Pacientes
   SET Estado_Civil=@estadoCivil,Familiares_A_Cargo = @familiaresACargo,Plan_id =(select Plan_id from [JOINEANDO_ANDO].Planes where Nombre=@plan)
   WHERE Numero_Afiliado = @numero_afiliado
   UPDATE [JOINEANDO_ANDO].Usuarios
   SET Direccion=@direccion, Telefono=@telefono,Mail=@email
   WHERE Usuario_id = @usr
   if @razon <>  '' 
   INSERT INTO [JOINEANDO_ANDO].Hist_Cambios 
   (Paciente_id,Descripcion,Fecha_mod)
   values
   (@usr,@razon,getdate())



  END 
go



CREATE procedure JOINEANDO_ANDO.listado_sexo
  AS 
  BEGIN    
   SELECT Descripcion from [JOINEANDO_ANDO].Sexo
  END 
go



CREATE procedure JOINEANDO_ANDO.listado_planes
  AS 
  BEGIN    
   SELECT Nombre from [JOINEANDO_ANDO].Planes
  END 
go



CREATE procedure JOINEANDO_ANDO.listado_tipo_documentos
  AS 
  BEGIN    
   SELECT Tipo from [JOINEANDO_ANDO].Tipo_Documento
  END 
go


CREATE procedure JOINEANDO_ANDO.filtro_paciente
 @nombre nvarchar(255) =null,
 @apellido nvarchar(255) = null,
 @tipo nvarchar(255)=null,
 @numeroDocumento numeric(18,0) = null

  AS 

  BEGIN    
   

   SELECT TOP 100 pa.Numero_Afiliado as 'Numero de Afiliado', us.Nombre,Apellido,Tipo,Numero_Documento,Direccion,Telefono,Mail as Email, convert(varchar, Fecha_Nacimiento, 103)  as 'Fecha Nacimiento', ISNULL(sexo.descripcion, 'No especificado' ) as Sexo, ISNULL(pa.Estado_Civil, 'No especificado' ) as 'Estado Civil',Familiares_A_Cargo as 'Familiares a cargo',pl.nombre as 'Plan'
     
  FROM [JOINEANDO_ANDO].[Tipo_Documento] inner join [JOINEANDO_ANDO].[Usuarios] us on us.Tipo_Documento_id = Tipo_Documento.Tipo_Documento_id inner join [JOINEANDO_ANDO].Pacientes pa on pa.Paciente_id = us.Usuario_id full join [JOINEANDO_ANDO].Sexo on Sexo.Sexo_id = us.Sexo_id join [JOINEANDO_ANDO].Planes pl on pl.Plan_id = pa.Plan_id inner join [JOINEANDO_ANDO].Habilitados ha on pa.Paciente_id = ha.Paciente_id 
   WHERE ha.Estado=1 AND us.Nombre like CASE WHEN @nombre is NOT NULL THEN 
							'%'+@nombre+'%'
						ELSE
							'%'
						END
   AND us.Apellido like CASE WHEN @apellido is NOT NULL THEN 
							'%'+@apellido+'%'
						ELSE
							'%'
						END

   AND us.Numero_Documento = CASE WHEN @numeroDocumento is NULL THEN 
							us.Numero_documento
						ELSE
							@numeroDocumento
						END


   AND Tipo = CASE WHEN @tipo is NULL THEN 
							Tipo
						ELSE
							@tipo
						END





  END 
go

GO


CREATE PROCEDURE JOINEANDO_ANDO.filtro_rol
@habilitado bit = null,
@idfuncionabilidad int = null


As
Begin

	IF(@idfuncionabilidad IS NOT NULL AND @habilitado IS NULL)
	BEGIN
	SELECT * from Rol R where EXISTS( Select 1 from Rol_Funcionabilidad F WHERE F.Funcionabilidad_id=@idFuncionabilidad AND R.Rol_id=F.Rol_id) 
	END

	IF(@habilitado IS NOT NULL AND @idfuncionabilidad IS NULL)
	BEGIN
	 Select * FROM Rol Where Habilitado = @habilitado
	END

	IF(@habilitado IS NOT NULL AND @idfuncionabilidad IS NOT NULL)
	BEGIN
	SELECT * from Rol R where EXISTS( Select 1 from Rol_Funcionabilidad F WHERE F.Funcionabilidad_id=@idFuncionabilidad AND R.Rol_id=F.Rol_id) 
	INTERSECT
	Select * FROM Rol Where Habilitado = @habilitado
	END

	IF(@idfuncionabilidad IS NULL AND @habilitado IS NULL)
	Select * FROM Rol 
End



GO
CREATE PROCEDURE JOINEANDO_ANDO.inHabilitar_Rol
@id int
As
Begin
UPDATE Rol
SET Habilitado=1
WHERE Rol_id=@id
End



GO
CREATE procedure JOINEANDO_ANDO.Seleccionar_Propiedades_Rol
@id int
As
	Begin
		Select * From [Rol] where Rol_id = @id
	End


GO
CREATE procedure JOINEANDO_ANDO.listarRoles

As
	Begin
		Select * From [Rol]
	End




GO

CREATE PROCEDURE JOINEANDO_ANDO.alta_Rol 
 @nombre nvarchar(50), @inHabilitado bit

  AS 
  BEGIN    
        INSERT INTO [JOINEANDO_ANDO].Rol (Nombre,Habilitado)
        OUTPUT Inserted.Rol_id
		VALUES (@nombre,@inHabilitado)

  END 
GO 


GO
CREATE PROCEDURE JOINEANDO_ANDO.actualizar_Rol
@id int,
@nombre nvarchar(50),
@inhabilitado bit
As
Begin
UPDATE Rol
SET nombre=@nombre, Habilitado=@inHabilitado
WHERE Rol_id=@id
End

GO

CREATE PROCEDURE JOINEANDO_ANDO.alta_funcionabiliad_x_rol
@idRol int,
@idFuncionabilidad int
As
Begin

 IF NOT EXISTS (SELECT * FROM Rol_Funcionabilidad 
                   WHERE Rol_id = @idRol
                   AND Funcionabilidad_id = @idFuncionabilidad)
             
   BEGIN
       INSERT INTO  [JOINEANDO_ANDO].Rol_Funcionabilidad  (Rol_id, Funcionabilidad_id)
       VALUES (@idRol, @idFuncionabilidad)
   END

END

GO

CREATE PROCEDURE JOINEANDO_ANDO.baja_funcionablilida_x_rol
@idRol int,
@idFuncionabilidad int
As
Begin
DELETE from Rol_Funcionabilidad WHERE Rol_id=@idRol AND Funcionabilidad_id=@idFuncionabilidad
End



GO

CREATE PROCEDURE JOINEANDO_ANDO.roles_x_usuario
@UserId int
AS
BEGIN
SELECT U.Rol_id, Nombre from JOINEANDO_ANDO.Usuario_rol U join JOINEANDO_ANDO.Rol R ON U.Rol_id = R.Rol_id AND R.Habilitado = 1

END

GO
-- Stored Procedure
CREATE PROCEDURE JOINEANDO_ANDO.validar_usuario
@UserId nvarchar(50),
@Pas varchar(50)

AS
BEGIN


IF Exists (Select 1 from JOINEANDO_ANDO.Usuarios where Nombre_Usuario = @UserId and [contrasena] = HASHBYTES('SHA2_256',@Pas) and Habilitado = 1)
	BEGIN
		select 'Ingreso OK' resultado, Usuario_id from JOINEANDO_ANDO.Usuarios where Nombre_Usuario = @UserId
	END
ELSE
	BEGIN
		IF Exists(Select 1 from JOINEANDO_ANDO.Usuarios Where Nombre_Usuario = @UserID)
			Begin
				if( (Select Intentos_Fallidos from JOINEANDO_ANDO.Usuarios Where Nombre_Usuario = @UserID) < 3 )
					Begin
						update JOINEANDO_ANDO.Usuarios set Intentos_Fallidos = Intentos_Fallidos + 1 Where Nombre_Usuario = @UserID
						select 'usuario o password invalido' resultado, 0
					End
				else
					Begin
						update JOINEANDO_ANDO.Usuarios set Habilitado = 0 Where Nombre_Usuario = @UserID
						select 'el usuario se encuentra bloqueado', -1
					End
			End
		ELSE
			Begin
						select 'usuario o password invalido' resultado, 0
				
			End
	end
End

GO

CREATE procedure JOINEANDO_ANDO.seleccionar_funcionabilidades_x_rol
@id int
As
Begin
	Select * From JOINEANDO_ANDO.Rol_Funcionabilidad R JOIN JOINEANDO_ANDO.Funcionabilidades F ON  F.Funcionabilidad_id = R.Funcionabilidad_id where R.Rol_id = @id
END
GO


CREATE procedure JOINEANDO_ANDO.seleccionar_funcionabilidades
As
Begin
	Select * From Funcionabilidades
End































--Migracion de Datos

INSERT INTO [JOINEANDO_ANDO].Funcionabilidades
Select 'Crear'
Union all
Select 'Modificar'
Union all
Select 'Eliminar'
GO

INSERT INTO [JOINEANDO_ANDO].Rol
Select 'Afiliado',1
Union all
Select 'Administrativo',1
Union all
Select 'Profesional',1
GO

INSERT INTO [JOINEANDO_ANDO].Rol_Funcionabilidad
select 2,1
union all
select 2,2
union all
select 2,3
GO

INSERT INTO [JOINEANDO_ANDO].Sexo
Select 'Masculino'
Union all
Select 'Femenino'
Union all
Select 'No especificado'
GO

INSERT INTO [JOINEANDO_ANDO].Dias_Semana
Select 'Lunes'
Union all
Select 'Martes'
Union all
Select 'Miercoles'
Union all
Select 'Jueves'
Union all
Select 'Viernes'
Union all
Select 'Sabado'
Union all
Select 'Domingo'
GO

INSERT INTO [JOINEANDO_ANDO].Tipo_Documento
Select 'DNI'
Union all
Select 'Libreta Civica'
Union all
Select 'Pasaporte'
Union all
Select 'Otro'
GO


INSERT INTO [JOINEANDO_ANDO].Tipo_Especialidad
SELECT DISTINCT 
	[Tipo_Especialidad_Codigo]
	,[Tipo_Especialidad_Descripcion]
FROM [gd_esquema].Maestra
WHERE Tipo_Especialidad_Codigo IS NOT NULL

GO

INSERT INTO [JOINEANDO_ANDO].Especialidades
SELECT DISTINCT
	[Especialidad_Codigo]
	,[Especialidad_Descripcion]
	,[Tipo_Especialidad_Codigo]
FROM [gd_esquema].Maestra
WHERE Especialidad_Codigo IS NOT NULL
GO

INSERT INTO [JOINEANDO_ANDO].Planes
SELECT DISTINCT
	[Plan_Med_Codigo]
	,[Plan_Med_Descripcion]
	,[Plan_Med_Precio_Bono_Consulta]
	,[Plan_Med_Precio_Bono_Farmacia]

FROM [gd_esquema].Maestra
WHERE Plan_Med_Codigo IS NOT NULL
GO

--Medicos
INSERT INTO [JOINEANDO_ANDO].Usuarios
SELECT DISTINCT
	[medico_nombre]
	,[medico_apellido]
	,[Medico_Dni]
	,1
	,[Medico_Direccion]
	,[Medico_Telefono]
	,[Medico_Mail]
	,[Medico_Fecha_Nac]
	,NULL
	,[Medico_Nombre]+'.'+[Medico_Apellido]
	,HASHBYTES('SHA2_256','123456')
	,1
	,0

	FROM [gd_esquema].Maestra
	WHERE MEDICO_NOMBRE IS NOT NULL
GO


INSERT INTO [JOINEANDO_ANDO].Medicos
SELECT DISTINCT
	U.Usuario_id
	,555
FROM  JOINEANDO_ANDO.Usuarios as U Inner Join gd_esquema.Maestra as M
ON (U.nombre = M.Medico_Nombre) and (u.Apellido = M.Medico_Apellido)
GO

INSERT INTO [JOINEANDO_ANDO].Medico_Especialidad
SELECT DISTINCT
	u.Usuario_id
	,E.Especialidad_id

	FROM [JOINEANDO_ANDO].Especialidades AS E, [JOINEANDO_ANDO].Usuarios as U INNER JOIN [gd_esquema].Maestra as M
	ON ( u.NOMBRE = m.Medico_Nombre) AND (U.Apellido = m.Medico_Apellido) 
	WHERE (E.Especialidad_id = M.Especialidad_Codigo)
GO

-- Pacientes
INSERT INTO [JOINEANDO_ANDO].Usuarios
SELECT DISTINCT
	[Paciente_Nombre]
	,[Paciente_Apellido]
	,[Paciente_Dni]
	,1
	,[Paciente_Direccion]
	,[Paciente_Telefono]
	,[Paciente_Mail]
	,[Paciente_Fecha_Nac]
	,NULL
	,[Paciente_Nombre]+'.'+[Paciente_Apellido]
	,HASHBYTES('SHA2_256','123456')
	,1
	,0

	FROM [gd_esquema].Maestra
	WHERE Paciente_Nombre IS NOT NULL
GO

INSERT INTO [JOINEANDO_ANDO].Pacientes
SELECT DISTINCT
	U.Usuario_id
	,NULL
	,0
	,((U.Usuario_id)*100+1)
	
	,M.Plan_Med_Codigo

FROM  (JOINEANDO_ANDO.Usuarios AS U INNER JOIN gd_esquema.Maestra as M
ON (U.Nombre = M.Paciente_Nombre)  and (U.apellido = M.Paciente_Apellido) and (U.Numero_Documento = M.Paciente_Dni))
go

INSERT INTO [JOINEANDO_ANDO].Habilitados
SELECT DISTINCT
	P.Paciente_id
	,1
	,getdate()
	,null

FROM  JOINEANDO_ANDO.Pacientes P
go

INSERT INTO [JOINEANDO_ANDO].Hist_Cambios
SELECT DISTINCT
	Paciente_id
	,'Migracion de usuario'
	,getDate()
	
FROM JOINEANDO_ANDO.Pacientes 
Go

--CompraBonos
/*
INSERT INTO [JOINEANDO_ANDO].Compra_Bonos
SELECT DISTINCT
	P.Plan_id,
	P.Precio_Bono_Consulta,
	1,
	M.Compra_Bono_Fecha
	
FROM gd_esquema.Maestra AS M INNER JOIN JOINEANDO_ANDO.Planes AS P 
ON M.Plan_Med_Codigo = P.Plan_id
WHERE M.Compra_Bono_Fecha IS NOT NULL

*/
GO

INSERT INTO [JOINEANDO_ANDO].Bonos
SELECT DISTINCT
	M.Bono_Consulta_Numero,
	P.Plan_id,
	0, --Numero consulta medica, maestra tenemos turno_numero
	0 --numero raiz
	
FROM gd_esquema.Maestra AS M INNER JOIN JOINEANDO_ANDO.Planes AS P
ON P.Plan_id = M.Plan_Med_Codigo
WHERE M.Bono_Consulta_Numero IS NOT NULL
GO

-- Usuario admin BORRAR ESTO QUE ENTRA EN CONFLICTO CON LO MIO

INSERT INTO [JOINEANDO_ANDO].Usuarios
	Select 'Administrador General','','12341234',1,'calle falsa 123','44445555','prueba@prueba.com', convert(datetime,'1990/09/12 00:00:00',121), NULL, 'Admin2','w23e',1,0
	GO

INSERT INTO [JOINEANDO_ANDO].Usuario_Rol
	Select 
	usuario_id,
	2
FROM JOINEANDO_ANDO.Usuarios
WHERE Usuarios.Nombre_Usuario = 'Admin'
GO


-- Constraints
ALTER TABLE [JOINEANDO_ANDO].[Agendas] ADD CONSTRAINT 
[PK_Agendas] PRIMARY KEY CLUSTERED 
(
	[Agenda_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
 
GO

ALTER TABLE [JOINEANDO_ANDO].[Bonos] ADD CONSTRAINT
[PK_Bonos] PRIMARY KEY CLUSTERED 
(
	[Bono_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]


GO

ALTER TABLE [JOINEANDO_ANDO].[Compra_Bonos] ADD CONSTRAINT
[PK_Compra_Bonos] PRIMARY KEY CLUSTERED 
(
	[Compra_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]


GO

ALTER TABLE [JOINEANDO_ANDO].[Consulta_Medica] ADD CONSTRAINT
[PK_Consulta_Medica] PRIMARY KEY CLUSTERED 
(
	[Consulta_Medica_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO

ALTER TABLE [JOINEANDO_ANDO].[Especialidades] ADD CONSTRAINT
[PK_Especialidades] PRIMARY KEY CLUSTERED 
(
	[Especialidad_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

ALTER TABLE [JOINEANDO_ANDO].[Funcionabilidades] ADD CONSTRAINT
[PK_Funcionabilidades] PRIMARY KEY CLUSTERED 
(
	[Funcionabilidad_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

ALTER TABLE [JOINEANDO_ANDO].[Medicos] ADD CONSTRAINT
[PK_Medicos] PRIMARY KEY CLUSTERED 
(
	[Medico_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO



ALTER TABLE [JOINEANDO_ANDO].[Pacientes] ADD CONSTRAINT
[PK_Pacientes] PRIMARY KEY CLUSTERED 
(
	[Paciente_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO


ALTER TABLE [JOINEANDO_ANDO].[Planes] ADD CONSTRAINT

[PK_Planes] PRIMARY KEY CLUSTERED 
(
	[Plan_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]


GO

ALTER TABLE [JOINEANDO_ANDO].[Resultados] ADD CONSTRAINT
[PK_Resultados] PRIMARY KEY CLUSTERED 
(
	[Resultado_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

ALTER TABLE [JOINEANDO_ANDO].[Rol] ADD CONSTRAINT
[PK_Rol] PRIMARY KEY CLUSTERED 
(
	[Rol_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]


GO

ALTER TABLE [JOINEANDO_ANDO].[Tipo_Documento] ADD CONSTRAINT
[PK_Tipo_Documento_id] PRIMARY KEY CLUSTERED 
(
	[Tipo_Documento_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

ALTER TABLE [JOINEANDO_ANDO].[Tipo_Especialidad] ADD CONSTRAINT
[PK_Tipo_Especialidad] PRIMARY KEY CLUSTERED 
(
	[Tipo_Especialidad_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]


GO

ALTER TABLE [JOINEANDO_ANDO].[Turnos] ADD CONSTRAINT
[PK_Turnos] PRIMARY KEY CLUSTERED 
(
	[Turno_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]


GO

ALTER TABLE [JOINEANDO_ANDO].[Usuarios] ADD CONSTRAINT
[PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[Usuario_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO

ALTER TABLE [JOINEANDO_ANDO].[Sexo] ADD CONSTRAINT
[Sexo_id] PRIMARY KEY CLUSTERED 
(
	[Sexo_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]


GO

ALTER TABLE [JOINEANDO_ANDO].[Dias_Semana] ADD CONSTRAINT
[Dia_Semana_id] PRIMARY KEY CLUSTERED 
(
	[Dia_Semana_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]


GO
/*
ALTER TABLE [JOINEANDO_ANDO].[Hist_Cambios] ADD CONSTRAINT
[paciente_id] PRIMARY KEY CLUSTERED
(
	[Paciente_id] ASC
	) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
*/

-- FK

ALTER TABLE [JOINEANDO_ANDO].[Agendas]  WITH CHECK ADD  CONSTRAINT [FK_Agendas_Especialidades] FOREIGN KEY([Especialidad_id])
REFERENCES [JOINEANDO_ANDO].[Especialidades] ([Especialidad_id])
GO
ALTER TABLE [JOINEANDO_ANDO].[Agendas] CHECK CONSTRAINT [FK_Agendas_Especialidades]
GO
ALTER TABLE [JOINEANDO_ANDO].[Agendas]  WITH CHECK ADD  CONSTRAINT [FK_Agendas_Medicos] FOREIGN KEY([Medico_id])
REFERENCES [JOINEANDO_ANDO].[Medicos] ([Medico_id])
GO
ALTER TABLE [JOINEANDO_ANDO].[Agendas] CHECK CONSTRAINT [FK_Agendas_Medicos]
GO
ALTER TABLE [JOINEANDO_ANDO].[Dias_Atencion] WITH CHECK ADD CONSTRAINT [FK_Agenda_id] FOREIGN KEY([Agenda_id])
REFERENCES [JOINEANDO_ANDO].[Agendas] ([Agenda_id])
GO
ALTER TABLE [JOINEANDO_ANDO].[Dias_Atencion] CHECK CONSTRAINT [FK_Agenda_id]
GO
ALTER TABLE [JOINEANDO_ANDO].[Dias_Atencion] WITH CHECK ADD CONSTRAINT [FK_Dia_id] FOREIGN KEY([Dia_id])
REFERENCES [JOINEANDO_ANDO].[Dias_Semana] ([Dia_Semana_id])
GO


ALTER TABLE [JOINEANDO_ANDO].[Bonos]  WITH CHECK ADD  CONSTRAINT [FK_Bonos_Planes] FOREIGN KEY([Plan_id])
REFERENCES [JOINEANDO_ANDO].[Planes] ([Plan_id])
GO
ALTER TABLE [JOINEANDO_ANDO].[Bonos] CHECK CONSTRAINT [FK_Bonos_Planes]
GO
ALTER TABLE [JOINEANDO_ANDO].[Cancelaciones]  WITH CHECK ADD  CONSTRAINT [FK_Cancelaciones_Turnos] FOREIGN KEY([Turno_id])
REFERENCES [JOINEANDO_ANDO].[Turnos] ([Turno_id])
GO
ALTER TABLE [JOINEANDO_ANDO].[Cancelaciones] CHECK CONSTRAINT [FK_Cancelaciones_Turnos]
GO
ALTER TABLE [JOINEANDO_ANDO].[Consulta_Medica]  WITH CHECK ADD  CONSTRAINT [FK_Consulta_Medica_Bonos] FOREIGN KEY([Bono_id])
REFERENCES [JOINEANDO_ANDO].[Bonos] ([Bono_id])
GO
ALTER TABLE [JOINEANDO_ANDO].[Consulta_Medica] CHECK CONSTRAINT [FK_Consulta_Medica_Bonos]
GO
ALTER TABLE [JOINEANDO_ANDO].[Consulta_Medica]  WITH CHECK ADD  CONSTRAINT [FK_Consulta_Medica_Turnos] FOREIGN KEY([Turno_id])
REFERENCES [JOINEANDO_ANDO].[Turnos] ([Turno_id])
GO
ALTER TABLE [JOINEANDO_ANDO].[Consulta_Medica] CHECK CONSTRAINT [FK_Consulta_Medica_Turnos]
GO
ALTER TABLE [JOINEANDO_ANDO].[Especialidades]  WITH CHECK ADD  CONSTRAINT [FK_Especialidades_Tipo_Especialidad] FOREIGN KEY([Tipo_Especialidad_id])
REFERENCES [JOINEANDO_ANDO].[Tipo_Especialidad] ([Tipo_Especialidad_id])
GO
ALTER TABLE [JOINEANDO_ANDO].[Especialidades] CHECK CONSTRAINT [FK_Especialidades_Tipo_Especialidad]
GO
ALTER TABLE [JOINEANDO_ANDO].[Habilitados]  WITH CHECK ADD  CONSTRAINT [FK_Habilitados_Pacientes] FOREIGN KEY([Paciente_id])
REFERENCES [JOINEANDO_ANDO].[Pacientes] ([Paciente_id])
GO
ALTER TABLE [JOINEANDO_ANDO].[Habilitados] CHECK CONSTRAINT [FK_Habilitados_Pacientes]
GO
ALTER TABLE [JOINEANDO_ANDO].[Medico_Especialidad]  WITH CHECK ADD  CONSTRAINT [FK_Medico_Especialidad_Especialidades] FOREIGN KEY([Especialidad_id])
REFERENCES [JOINEANDO_ANDO].[Especialidades] ([Especialidad_id])
GO
ALTER TABLE [JOINEANDO_ANDO].[Medico_Especialidad] CHECK CONSTRAINT [FK_Medico_Especialidad_Especialidades]
GO
ALTER TABLE [JOINEANDO_ANDO].[Medico_Especialidad]  WITH CHECK ADD  CONSTRAINT [FK_Medico_Especialidad_Medicos] FOREIGN KEY([Medico_id])
REFERENCES [JOINEANDO_ANDO].[Medicos] ([Medico_id])
GO
ALTER TABLE [JOINEANDO_ANDO].[Medico_Especialidad] CHECK CONSTRAINT [FK_Medico_Especialidad_Medicos]
GO
ALTER TABLE [JOINEANDO_ANDO].[Medicos]  WITH CHECK ADD  CONSTRAINT [FK_Medicos_Usuarios] FOREIGN KEY([Medico_id])
REFERENCES [JOINEANDO_ANDO].[Usuarios] ([Usuario_id])
GO
ALTER TABLE [JOINEANDO_ANDO].[Medicos] CHECK CONSTRAINT [FK_Medicos_Usuarios]
GO
ALTER TABLE [JOINEANDO_ANDO].[Pacientes]  WITH CHECK ADD  CONSTRAINT [FK_Pacientes_Planes] FOREIGN KEY([Plan_id])
REFERENCES [JOINEANDO_ANDO].[Planes] ([Plan_id])
GO
ALTER TABLE [JOINEANDO_ANDO].[Pacientes] CHECK CONSTRAINT [FK_Pacientes_Planes]
GO
ALTER TABLE [JOINEANDO_ANDO].[Pacientes]  WITH CHECK ADD  CONSTRAINT [FK_Pacientes_Usuarios] FOREIGN KEY([Paciente_id])
REFERENCES [JOINEANDO_ANDO].[Usuarios] ([Usuario_id])
GO
ALTER TABLE [JOINEANDO_ANDO].[Pacientes] CHECK CONSTRAINT [FK_Pacientes_Usuarios]
GO
ALTER TABLE [JOINEANDO_ANDO].[Resultados]  WITH CHECK ADD  CONSTRAINT [FK_Resultados_Consulta_Medica] FOREIGN KEY([Consulta_Medica_id])
REFERENCES [JOINEANDO_ANDO].[Consulta_Medica] ([Consulta_Medica_id])
GO
ALTER TABLE [JOINEANDO_ANDO].[Resultados] CHECK CONSTRAINT [FK_Resultados_Consulta_Medica]
GO
--ALTER TABLE [JOINEANDO_ANDO].[Rol_Funcionabilidad]  WITH CHECK ADD  CONSTRAINT [FK_Rol_Funcionabilidad_Funcionabilidades] FOREIGN KEY([Funcionabilidad_id])
--REFERENCES [JOINEANDO_ANDO].[Funcionabilidades] ([Funcionabilidad_id])
--GO
--ALTER TABLE [JOINEANDO_ANDO].[Rol_Funcionabilidad] CHECK CONSTRAINT [FK_Rol_Funcionabilidad_Funcionabilidades]
GO
ALTER TABLE [JOINEANDO_ANDO].[Rol_Funcionabilidad]  WITH CHECK ADD  CONSTRAINT [FK_Rol_Funcionabilidad_Rol] FOREIGN KEY([Rol_id])
REFERENCES [JOINEANDO_ANDO].[Rol] ([Rol_id])
GO
ALTER TABLE [JOINEANDO_ANDO].[Rol_Funcionabilidad] CHECK CONSTRAINT [FK_Rol_Funcionabilidad_Rol]
GO
ALTER TABLE [JOINEANDO_ANDO].[Turnos]  WITH CHECK ADD  CONSTRAINT [FK_Turnos_Agendas] FOREIGN KEY([Agenda_id])
REFERENCES [JOINEANDO_ANDO].[Agendas] ([Agenda_id])
GO
ALTER TABLE [JOINEANDO_ANDO].[Turnos] CHECK CONSTRAINT [FK_Turnos_Agendas]
GO
ALTER TABLE [JOINEANDO_ANDO].[Turnos]  WITH CHECK ADD  CONSTRAINT [FK_Turnos_Pacientes] FOREIGN KEY([Paciente_id])
REFERENCES [JOINEANDO_ANDO].[Pacientes] ([Paciente_id])
GO
ALTER TABLE [JOINEANDO_ANDO].[Turnos] CHECK CONSTRAINT [FK_Turnos_Pacientes]
GO
ALTER TABLE [JOINEANDO_ANDO].[Usuario_Rol]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Rol_Rol] FOREIGN KEY([Rol_id])
REFERENCES [JOINEANDO_ANDO].[Rol] ([Rol_id])
GO
ALTER TABLE [JOINEANDO_ANDO].[Usuario_Rol] CHECK CONSTRAINT [FK_Usuario_Rol_Rol]
GO
ALTER TABLE [JOINEANDO_ANDO].[Usuario_Rol]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Rol_Usuarios] FOREIGN KEY([Usuario_id])
REFERENCES [JOINEANDO_ANDO].[Usuarios] ([Usuario_id])
GO
ALTER TABLE [JOINEANDO_ANDO].[Usuario_Rol] CHECK CONSTRAINT [FK_Usuario_Rol_Usuarios]
GO
ALTER TABLE [JOINEANDO_ANDO].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Tipo_Documento] FOREIGN KEY([Tipo_Documento_id])
REFERENCES [JOINEANDO_ANDO].[Tipo_Documento] ([Tipo_Documento_id])
GO

ALTER TABLE [JOINEANDO_ANDO].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Tipo_Documento]
GO

ALTER TABLE [JOINEANDO_ANDO].[Usuarios] WITH CHECK ADD CONSTRAINT [FK_Usuarios_Sexo] FOREIGN KEY([Sexo_id]) 
REFERENCES [JOINEANDO_ANDO].[Sexo] ([Sexo_id])
GO

ALTER TABLE [JOINEANDO_ANDO].[Hist_Cambios] WITH CHECK ADD CONSTRAINT [FK_Paciente_id] FOREIGN KEY([Paciente_id])
REFERENCES [JOINEANDO_ANDO].[Pacientes] ([Paciente_id])
GO






















--Datos nico





declare @rol nvarchar(50);
declare @funcionabilidad nvarchar(50);
Begin


INSERT INTO [JOINEANDO_ANDO].Usuarios
SELECT 
	'asd'
	,'123'
	,123
	,1
	,89
	,98
	,'asd'
	,'4/4/1988'
	,NULL
	,'admin'
	,HASHBYTES('SHA2_256','w23e')
	,1
	,0
	WHERE NOT EXISTs (SELECT * FROM JOINEANDO_ANDO.Usuarios WHERE Nombre_Usuario='admin')



INSERT INTO [JOINEANDO_ANDO].Rol Select 'RolGroso',1  WHERE NOT EXISTS ( SELECT * FROM [JOINEANDO_ANDO].Rol WHERE Nombre='RolGroso')
INSERT INTO [JOINEANDO_ANDO].Rol Select 'RolPobre',1  WHERE NOT EXISTS ( SELECT * FROM [JOINEANDO_ANDO].Rol WHERE Nombre='RolPobre')


INSERT INTO [JOINEANDO_ANDO].Rol Select 'RolGroso',1  WHERE NOT EXISTS ( SELECT * FROM [JOINEANDO_ANDO].Rol WHERE Nombre='RolGroso')
INSERT INTO [JOINEANDO_ANDO].Rol Select 'RolPobre',1  WHERE NOT EXISTS ( SELECT * FROM [JOINEANDO_ANDO].Rol WHERE Nombre='RolPobre')


INSERT INTO [JOINEANDO_ANDO].Usuario_Rol Select (SELECT top 1 Usuario_id FROM JOINEANDO_ANDO.Usuarios WHERE Nombre_Usuario='admin' ),(SELECT top 1 Rol_id FROM JOINEANDO_ANDO.Rol Where Nombre='RolGroso')  WHERE NOT EXISTS ( SELECT top 1 * FROM [JOINEANDO_ANDO].Usuario_Rol WHERE Usuario_id=(SELECT top 1 Usuario_id FROM JOINEANDO_ANDO.Usuarios WHERE Nombre_Usuario='admin' ) AND Rol_id=(SELECT top 1 Rol_id FROM JOINEANDO_ANDO.Rol Where Nombre='RolGroso'))



INSERT INTO [JOINEANDO_ANDO].Usuario_Rol Select (SELECT top 1 Usuario_id FROM JOINEANDO_ANDO.Usuarios WHERE Nombre_Usuario='admin' ),(SELECT top 1 Rol_id FROM JOINEANDO_ANDO.Rol Where Nombre='RolPobre')  WHERE NOT EXISTS ( SELECT top 1 * FROM [JOINEANDO_ANDO].Usuario_Rol WHERE Usuario_id=(SELECT top 1 Usuario_id FROM JOINEANDO_ANDO.Usuarios WHERE Nombre_Usuario='admin' ) AND Rol_id=(SELECT top 1 Rol_id FROM JOINEANDO_ANDO.Rol Where Nombre='RolPobre'))




SET @rol = 'RolGroso';
SET @funcionabilidad = 'Crear Rol';

INSERT INTO [JOINEANDO_ANDO].Funcionabilidades Select @funcionabilidad WHERE NOT EXISTS ( SELECT * FROM [JOINEANDO_ANDO].Funcionabilidades WHERE Nombre=@funcionabilidad)
INSERT INTO JOINEANDO_ANDO.Rol_Funcionabilidad SELECT (SELECT Rol_id FROM JOINEANDO_ANDO.Rol WHERE Nombre=@rol),(SELECT Funcionabilidad_id FROM JOINEANDO_ANDO.Funcionabilidades WHERE Nombre=@funcionabilidad) WHERE NOT EXISTS (SELECT * FROM JOINEANDO_ANDO.Rol_Funcionabilidad WHERE Rol_id=(SELECT Rol_id FROM JOINEANDO_ANDO.Rol WHERE Nombre=@rol) AND Funcionabilidad_id=(SELECT Funcionabilidad_id FROM JOINEANDO_ANDO.Funcionabilidades WHERE Nombre=@funcionabilidad))


SET @funcionabilidad = 'Eliminar Rol';

INSERT INTO [JOINEANDO_ANDO].Funcionabilidades Select @funcionabilidad WHERE NOT EXISTS ( SELECT * FROM [JOINEANDO_ANDO].Funcionabilidades WHERE Nombre=@funcionabilidad)
INSERT INTO JOINEANDO_ANDO.Rol_Funcionabilidad SELECT (SELECT Rol_id FROM JOINEANDO_ANDO.Rol WHERE Nombre=@rol),(SELECT Funcionabilidad_id FROM JOINEANDO_ANDO.Funcionabilidades WHERE Nombre=@funcionabilidad) WHERE NOT EXISTS (SELECT * FROM JOINEANDO_ANDO.Rol_Funcionabilidad WHERE Rol_id=(SELECT Rol_id FROM JOINEANDO_ANDO.Rol WHERE Nombre=@rol) AND Funcionabilidad_id=(SELECT Funcionabilidad_id FROM JOINEANDO_ANDO.Funcionabilidades WHERE Nombre=@funcionabilidad))

SET @funcionabilidad = 'Modificar Rol';

INSERT INTO [JOINEANDO_ANDO].Funcionabilidades Select @funcionabilidad WHERE NOT EXISTS ( SELECT * FROM [JOINEANDO_ANDO].Funcionabilidades WHERE Nombre=@funcionabilidad)
INSERT INTO JOINEANDO_ANDO.Rol_Funcionabilidad SELECT (SELECT Rol_id FROM JOINEANDO_ANDO.Rol WHERE Nombre=@rol),(SELECT Funcionabilidad_id FROM JOINEANDO_ANDO.Funcionabilidades WHERE Nombre=@funcionabilidad) WHERE NOT EXISTS (SELECT * FROM JOINEANDO_ANDO.Rol_Funcionabilidad WHERE Rol_id=(SELECT Rol_id FROM JOINEANDO_ANDO.Rol WHERE Nombre=@rol) AND Funcionabilidad_id=(SELECT Funcionabilidad_id FROM JOINEANDO_ANDO.Funcionabilidades WHERE Nombre=@funcionabilidad))



End











