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

