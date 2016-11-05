USE [GD2C2016]
GO
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
        INSERT INTO Rol (Nombre,Habilitado)
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
       INSERT INTO  Rol_Funcionabilidad  (Rol_id, Funcionabilidad_id)
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

GO


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

