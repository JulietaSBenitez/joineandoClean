BEGIN
IF OBJECT_ID('seleccionar_rol') IS NOT NULL 
DROP procedure  seleccionar_rol
IF OBJECT_ID('seleccionar_funcionabilidades_x_rol') IS NOT NULL 
DROP procedure  seleccionar_funcionabilidades_x_rol
IF OBJECT_ID('seleccionar_funcionabilidades') IS NOT NULL 
DROP procedure  seleccionar_funcionabilidades

END
GO
CREATE procedure seleccionar_rol
@id int
As
Begin
	Select * From Rol where Rol_id = @id
End
GO


CREATE procedure seleccionar_funcionabilidades_x_rol
@id int
As
Begin
	Select * From Rol_Funcionabilidad where Rol_id = @id
End
GO
CREATE procedure seleccionar_funcionabilidades
As
Begin
	Select * From Funcionabilidades
End



CREATE PROCEDURE filtro_rol_habilitados
@habilitado bit
As
Begin
Select * FROM Rol Where inHabilitado = @habilitado
End

CREATE PROCEDURE filtro_rol_funcionabilidad
@idfuncionabilidad int
As
Begin
SELECT * from Rol R where EXISTS( Select 1 from Rol_Funcionabilidad F WHERE F.Funcionabilidad_id=@idFuncionabilidad AND R.Rol_id=F.Rol_id) 
End


IF OBJECT_ID('filtro_rol') IS NOT NULL 
DROP procedure  filtro_rol

CREATE PROCEDURE filtro_rol
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
	 Select * FROM Rol Where inHabilitado = @habilitado
	END

	IF(@habilitado IS NOT NULL AND @idfuncionabilidad IS NOT NULL)
	BEGIN
	SELECT * from Rol R where EXISTS( Select 1 from Rol_Funcionabilidad F WHERE F.Funcionabilidad_id=@idFuncionabilidad AND R.Rol_id=F.Rol_id) 
	INTERSECT
	Select * FROM Rol Where inHabilitado = @habilitado
	END

	IF(@idfuncionabilidad IS NULL AND @habilitado IS NULL)
	Select * FROM Rol 
End






CREATE PROCEDURE alta_funcionabiliad_x_rol
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


CREATE PROCEDURE baja_funcionablilida_x_rol
@idRol int,
@idFuncionabilidad int
As
Begin
DELETE from Rol_Funcionabilidad WHERE Rol_id=@idRol AND Funcionabilidad_id=@idFuncionabilidad
End


CREATE PROCEDURE actualizar_Rol
@id int,
@nombre nvarchar(50),
@inhabilitado bit
As
Begin
UPDATE Rol
SET nombre=@nombre, inHabilitado=@inHabilitado
WHERE Rol_id=@idi
End





CREATE PROCEDURE altaRol 
 @nombre nvarchar(50), @inHabilitado bit

  AS 
  BEGIN    
        INSERT INTO Rol (Nombre,Inhabilitado)
        OUTPUT Inserted.Rol_id
		VALUES (@nombre,@inHabilitado)

  END 
GO 





