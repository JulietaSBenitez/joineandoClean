USE [GD2C2016] 

go 

-- Validacion de existencia 
IF Schema_id('JOINEANDO_ANDO') IS NOT NULL 
  BEGIN 
      --TABLAS 
      IF Object_id('JOINEANDO_ANDO.Habilitados') IS NOT NULL 
        DROP TABLE [JOINEANDO_ANDO].habilitados 

      IF Object_id('JOINEANDO_ANDO.Medico_Especialidad') IS NOT NULL 
        DROP TABLE [JOINEANDO_ANDO].medico_especialidad 

      IF Object_id('JOINEANDO_ANDO.Rol_Funcionabilidad') IS NOT NULL 
        DROP TABLE [JOINEANDO_ANDO].rol_funcionabilidad 

      IF Object_id('JOINEANDO_ANDO.Usuario_Rol') IS NOT NULL 
        DROP TABLE [JOINEANDO_ANDO].usuario_rol 

      IF Object_id('JOINEANDO_ANDO.Rol') IS NOT NULL 
        DROP TABLE [JOINEANDO_ANDO].rol 

      IF Object_id('JOINEANDO_ANDO.Funcionabilidades') IS NOT NULL 
        DROP TABLE [JOINEANDO_ANDO].funcionabilidades 

      IF Object_id('JOINEANDO_ANDO.Sintomas') IS NOT NULL 
        DROP TABLE [JOINEANDO_ANDO].[sintomas] 

      IF Object_id('JOINEANDO_ANDO.Resultados') IS NOT NULL 
        DROP TABLE [JOINEANDO_ANDO].resultados 

      IF Object_id('JOINEANDO_ANDO.Consulta_Medica') IS NOT NULL 
        DROP TABLE [JOINEANDO_ANDO].consulta_medica 

      IF Object_id('JOINEANDO_ANDO.Bonos') IS NOT NULL 
        DROP TABLE [JOINEANDO_ANDO].bonos 

      IF Object_id('JOINEANDO_ANDO.Compra_Bonos') IS NOT NULL 
        DROP TABLE [JOINEANDO_ANDO].compra_bonos 

      IF Object_id('JOINEANDO_ANDO.Turnos') IS NOT NULL 
        DROP TABLE [JOINEANDO_ANDO].turnos 

      IF Object_id('JOINEANDO_ANDO.Cancelaciones') IS NOT NULL 
        DROP TABLE [JOINEANDO_ANDO].cancelaciones 

      IF Object_id('JOINEANDO_ANDO.Tipo_Cancelaciones') IS NOT NULL 
        DROP TABLE joineando_ando.tipo_cancelaciones 

      IF Object_id('JOINEANDO_ANDO.Dias_Atencion') IS NOT NULL 
        DROP TABLE [JOINEANDO_ANDO].dias_atencion 

      IF Object_id('JOINEANDO_ANDO.Agendas') IS NOT NULL 
        DROP TABLE [JOINEANDO_ANDO].agendas 

      IF Object_id('JOINEANDO_ANDO.Dias_Semana') IS NOT NULL 
        DROP TABLE [JOINEANDO_ANDO].dias_semana 

      IF Object_id('JOINEANDO_ANDO.Especialidades') IS NOT NULL 
        DROP TABLE [JOINEANDO_ANDO].especialidades 

      IF Object_id('JOINEANDO_ANDO.Medicos') IS NOT NULL 
        DROP TABLE [JOINEANDO_ANDO].medicos 

      IF Object_id('JOINEANDO_ANDO.Hist_Cambios') IS NOT NULL 
        DROP TABLE [JOINEANDO_ANDO].[hist_cambios] 

      IF Object_id('JOINEANDO_ANDO.Pacientes') IS NOT NULL 
        DROP TABLE [JOINEANDO_ANDO].pacientes 

      IF Object_id('JOINEANDO_ANDO.Planes') IS NOT NULL 
        DROP TABLE [JOINEANDO_ANDO].planes 

      IF Object_id('JOINEANDO_ANDO.Tipo_Especialidad') IS NOT NULL 
        DROP TABLE [JOINEANDO_ANDO].tipo_especialidad 

      IF Object_id('JOINEANDO_ANDO.Usuarios') IS NOT NULL 
        DROP TABLE [JOINEANDO_ANDO].usuarios 

      IF Object_id('JOINEANDO_ANDO.Tipo_Documento') IS NOT NULL 
        DROP TABLE [JOINEANDO_ANDO].tipo_documento 

      IF Object_id('JOINEANDO_ANDO.Sexo') IS NOT NULL 
        DROP TABLE [JOINEANDO_ANDO].sexo 

      --Stored Procedures 
      IF Object_id ('JOINEANDO_ANDO.cantidadFamilia', 'FN') IS NOT NULL 
        DROP FUNCTION joineando_ando.cantidadfamilia; 

      IF Object_id('[JOINEANDO_ANDO].lista_planes') IS NOT NULL 
        DROP PROCEDURE [JOINEANDO_ANDO].lista_planes 

      IF Object_id('[JOINEANDO_ANDO].lista_especialidades') IS NOT NULL 
        DROP PROCEDURE [JOINEANDO_ANDO].lista_especialidades 

      IF Object_id('[JOINEANDO_ANDO].cargar_sintoma') IS NOT NULL 
        DROP PROCEDURE [JOINEANDO_ANDO].cargar_sintoma 

      IF Object_id('[JOINEANDO_ANDO].cargar_diagnostico') IS NOT NULL 
        DROP PROCEDURE [JOINEANDO_ANDO].cargar_diagnostico 

      IF Object_id('[JOINEANDO_ANDO].busqueda_medico_resultado') IS NOT NULL 
        DROP PROCEDURE [JOINEANDO_ANDO].busqueda_medico_resultado 

      IF Object_id('[JOINEANDO_ANDO].confirmar_presencia') IS NOT NULL 
        DROP PROCEDURE [JOINEANDO_ANDO].confirmar_presencia 

      IF Object_id('[JOINEANDO_ANDO].listado_especialidades') IS NOT NULL 
        DROP PROCEDURE [JOINEANDO_ANDO].listado_especialidades 

      IF Object_id('JOINEANDO_ANDO.bonos_disponibles') IS NOT NULL 
        DROP PROCEDURE joineando_ando.bonos_disponibles 

      IF Object_id('JOINEANDO_ANDO.listado_registro_atencion') IS NOT NULL 
        DROP PROCEDURE joineando_ando.listado_registro_atencion 

      IF Object_id('JOINEANDO_ANDO.compra_bono') IS NOT NULL 
        DROP PROCEDURE joineando_ando.compra_bono 

      IF Object_id('JOINEANDO_ANDO.precio_bono') IS NOT NULL 
        DROP PROCEDURE joineando_ando.precio_bono 

      IF Object_id('JOINEANDO_ANDO.listar_cambios') IS NOT NULL 
        DROP PROCEDURE joineando_ando.listar_cambios 

      IF Object_id('JOINEANDO_ANDO.baja_paciente') IS NOT NULL 
        DROP PROCEDURE joineando_ando.baja_paciente 

      IF Object_id('JOINEANDO_ANDO.actualizar_paciente') IS NOT NULL 
        DROP PROCEDURE joineando_ando.actualizar_paciente 

      IF Object_id('JOINEANDO_ANDO.listado_sexo') IS NOT NULL 
        DROP PROCEDURE joineando_ando.listado_sexo 

      IF Object_id('JOINEANDO_ANDO.listado_planes') IS NOT NULL 
        DROP PROCEDURE joineando_ando.listado_planes 

      IF Object_id('JOINEANDO_ANDO.listado_tipo_documentos') IS NOT NULL 
        DROP PROCEDURE joineando_ando.listado_tipo_documentos 

      IF Object_id('JOINEANDO_ANDO.crear_paciente') IS NOT NULL 
        DROP PROCEDURE joineando_ando.crear_paciente 

      IF Object_id('JOINEANDO_ANDO.filtro_paciente') IS NOT NULL 
        DROP PROCEDURE joineando_ando.filtro_paciente 

      IF Object_id('JOINEANDO_ANDO.validar_usuario') IS NOT NULL 
        DROP PROCEDURE joineando_ando.validar_usuario 

      IF Object_id('JOINEANDO_ANDO.roles_x_usuario') IS NOT NULL 
        DROP PROCEDURE joineando_ando.roles_x_usuario 

      IF Object_id('JOINEANDO_ANDO.seleccionar_funcionabilidades_x_rol') IS NOT 
         NULL 
        DROP PROCEDURE joineando_ando.seleccionar_funcionabilidades_x_rol 

      IF Object_id('JOINEANDO_ANDO.seleccionar_funcionabilidades') IS NOT NULL 
        DROP PROCEDURE joineando_ando.seleccionar_funcionabilidades 

      IF Object_id('JOINEANDO_ANDO.actualizar_Rol') IS NOT NULL 
        DROP PROCEDURE joineando_ando.actualizar_rol 

      IF Object_id('JOINEANDO_ANDO.baja_funcionablilida_x_rol') IS NOT NULL 
        DROP PROCEDURE joineando_ando.baja_funcionablilida_x_rol 

      IF Object_id('JOINEANDO_ANDO.alta_funcionabiliad_x_rol') IS NOT NULL 
        DROP PROCEDURE joineando_ando.alta_funcionabiliad_x_rol 

      IF Object_id('JOINEANDO_ANDO.alta_Rol') IS NOT NULL 
        DROP PROCEDURE joineando_ando.alta_rol 

      IF Object_id('JOINEANDO_ANDO.Seleccionar_Propiedades_Rol') IS NOT NULL 
        DROP PROCEDURE joineando_ando.seleccionar_propiedades_rol 

      IF Object_id('JOINEANDO_ANDO.inHabilitar_Rol') IS NOT NULL 
        DROP PROCEDURE joineando_ando.inhabilitar_rol 

      IF Object_id('JOINEANDO_ANDO.filtro_rol') IS NOT NULL 
        DROP PROCEDURE joineando_ando.filtro_rol 

      IF Object_id('JOINEANDO_ANDO.listarRoles') IS NOT NULL 
        DROP PROCEDURE joineando_ando.listarroles 

      IF Object_id('JOINEANDO_ANDO.validar_usuario') IS NOT NULL 
        DROP PROCEDURE joineando_ando.validar_usuario 

      IF Object_id('JOINEANDO_ANDO.UsuariosPorId_seleccion') IS NOT NULL 
        DROP PROCEDURE joineando_ando.usuariosporid_seleccion 

      IF Object_id('JOINEANDO_ANDO.listarRoles') IS NOT NULL 
        DROP PROCEDURE joineando_ando.listarroles 

      IF Object_id('JOINEANDO_ANDO.Seleccionar_rol') IS NOT NULL 
        DROP PROCEDURE joineando_ando.seleccionar_rol 

      IF Object_id('JOINEANDO_ANDO.Seleccionar_Funcionabilidades_x_Rol') IS NOT 
         NULL 
        DROP PROCEDURE joineando_ando.seleccionar_funcionabilidades_x_rol 

      IF Object_id('JOINEANDO_ANDO.Seleccionar_Funcionabilidades') IS NOT NULL 
        DROP PROCEDURE joineando_ando.seleccionar_funcionabilidades 

      IF Object_id('JOINEANDO_ANDO.Historial_Modificacion_Paciente') IS NOT NULL 
        DROP PROCEDURE joineando_ando.historial_modificacion_paciente 

      IF Object_id('JOINEANDO_ANDO.ESPECIALIDADMedicoPoseeAgenda') IS NOT NULL 
        DROP PROCEDURE joineando_ando.especialidadmedicoposeeagenda 

      IF Object_id('JOINEANDO_ANDO.MEDICOHorasSemanales') IS NOT NULL 
        DROP PROCEDURE joineando_ando.medicohorassemanales 

      IF Object_id('JOINEANDO_ANDO.ESPECIALIDADEspecialidadesMedico') IS NOT 
         NULL 
        DROP PROCEDURE joineando_ando.especialidadespecialidadesmedico 

      IF Object_id('JOINEANDO_ANDO.MEDICOTodos') IS NOT NULL 
        DROP PROCEDURE joineando_ando.medicotodos 

      IF Object_id('JOINEANDO_ANDO.ESPECIALIDADTodas') IS NOT NULL 
        DROP PROCEDURE joineando_ando.especialidadtodas 

      IF Object_id('JOINEANDO_ANDO.TURNOHorarios') IS NOT NULL 
        DROP PROCEDURE joineando_ando.turnohorarios 

      IF Object_id('JOINEANDO_ANDO.TURNOEstaOcupado') IS NOT NULL 
        DROP PROCEDURE joineando_ando.turnoestaocupado 

      IF Object_id('JOINEANDO_ANDO.PERSONATurnos') IS NOT NULL 
        DROP PROCEDURE joineando_ando.personaturnos 

      IF Object_id('JOINEANDO_ANDO.ListadoEspecialidadesConMasCancelaciones') IS 
         NOT NULL 
        DROP PROCEDURE joineando_ando.listadoespecialidadesconmascancelaciones 

      IF Object_id('JOINEANDO_ANDO.ListadoProfesionalesConMenosHorasTrabajadas') 
         IS NOT 
         NULL 
        DROP PROCEDURE 
        joineando_ando.listadoprofesionalesconmenoshorastrabajadas 

      IF Object_id('JOINEANDO_ANDO.ListadoEspecialidadesConMasBonosUtilizados') 
         IS 
         NOT 
         NULL 
        DROP PROCEDURE joineando_ando.listadoespecialidadesconmasbonosutilizados 

      IF Object_id('JOINEANDO_ANDO.ListadoAfiliadosConMayorBonosComprados') IS 
         NOT 
         NULL 
        DROP PROCEDURE joineando_ando.listadoafiliadosconmayorbonoscomprados 

      IF Object_id('JOINEANDO_ANDO.ListadoProfesionalesMasConsultadosPorPlan') 
         IS 
         NOT 
         NULL 
        DROP PROCEDURE joineando_ando.listadoprofesionalesmasconsultadosporplan 

      IF Object_id('JOINEANDO_ANDO.TIPOCANCELACIONTodos') IS NOT NULL 
        DROP PROCEDURE joineando_ando.tipocancelaciontodos 

      IF Object_id('JOINEANDO_ANDO.CANCELACIONEliminarTurnoAfiliado') IS NOT 
         NULL 
        DROP PROCEDURE joineando_ando.cancelacioneliminarturnoafiliado 

      IF Object_id('JOINEANDO_ANDO.CANCELACIONEliminarTurnoProfesional') IS NOT 
         NULL 
        DROP PROCEDURE joineando_ando.cancelacioneliminarturnoprofesional 

      IF Object_id('JOINEANDO_ANDO.TURNOInsertarNuevo') IS NOT NULL 
        DROP PROCEDURE joineando_ando.turnoinsertarnuevo 

      IF Object_id('JOINEANDO_ANDO.AGENDAInsertarNueva') IS NOT NULL 
        DROP PROCEDURE joineando_ando.agendainsertarnueva 

      IF Object_id('JOINEANDO_ANDO.AGENDARangoColisionaConAgendaExistente') IS 
         NOT 
         NULL 
        DROP PROCEDURE joineando_ando.agendarangocolisionaconagendaexistente 

      IF Object_id('JOINEANDO_ANDO.MEDICOTurnos') IS NOT NULL 
        DROP PROCEDURE joineando_ando.medicoturnos 

      --Funciones 
      IF Object_id('JOINEANDO_ANDO.Existe_Usuario') IS NOT NULL 
        DROP FUNCTION joineando_ando.existe_usuario 

      IF Object_id('JOINEANDO_ANDO.Cantidad_Intentos_Fallidos') IS NOT NULL 
        DROP FUNCTION joineando_ando.cantidad_intentos_fallidos 

      IF Object_id('JOINEANDO_ANDO.COLISIONANRangos') IS NOT NULL 
        DROP FUNCTION joineando_ando.colisionanrangos 

      -- Vistas 
      IF Object_id('JOINEANDO_ANDO.Historial_cambios_paciente') IS NOT NULL 
        DROP VIEW joineando_ando.historial_cambios_paciente 

      --Esquema 
      IF Schema_id('JOINEANDO_ANDO') IS NOT NULL 
        DROP SCHEMA [JOINEANDO_ANDO] 
  END 

go 

--Creacion de Esquema 
CREATE SCHEMA [JOINEANDO_ANDO] AUTHORIZATION [gd] 

go 

--Creacion de Tablas 
SET ansi_nulls ON 

go 

SET quoted_identifier ON 

go 

CREATE TABLE [JOINEANDO_ANDO].[agendas] 
  ( 
     [agenda_id]       [INT] IDENTITY(1, 1) NOT NULL, 
     [medico_id]       [INT] NOT NULL, 
     [especialidad_id] [INT] NOT NULL 
  ) 

go 

CREATE TABLE [JOINEANDO_ANDO].[dias_atencion] 
  ( 
     [agenda_id]      [INT] NOT NULL, 
     [dia_id]         [INT] NOT NULL, 
     [inicio_horario] TIME (7) NOT NULL, 
     [fin_horario]    TIME (7) NOT NULL 
  ) 

go 

CREATE TABLE [JOINEANDO_ANDO].[bonos] 
  ( 
     [bono_id]                [INT] IDENTITY(1, 1) NOT NULL, 
     [plan_id]                [INT] NOT NULL, 
     [numero_consulta_medica] [INT], 
     [fecha_impresion]        DATETIME, 
     [numero_afiliado]        [INT] NOT NULL, 
     [compra_id]              [INT] NOT NULL, 
  ) 

go 

CREATE TABLE [JOINEANDO_ANDO].[tipo_cancelaciones] 
  ( 
     [tipo_cancelacion_id] [INT] NOT NULL, 
     [descripcion]         [NVARCHAR](50) NOT NULL 
  ) 

CREATE TABLE [JOINEANDO_ANDO].[cancelaciones] 
  ( 
     [cancelacion_id] [INT] IDENTITY(1, 1) NOT NULL, 
     [tipo]           [INT] NOT NULL, 
     [descripcion]    [NVARCHAR](255) NOT NULL 
  ) 

go 

CREATE TABLE [JOINEANDO_ANDO].[compra_bonos] 
  ( 
     [compra_id]    [INT] IDENTITY(1, 1) NOT NULL, 
     [paciente_id]  [INT] NOT NULL, 
     [monto]        [NUMERIC](18, 2) NOT NULL, 
     [cantidad]     [INT] NOT NULL, 
     [fecha_compra] [DATETIME] NOT NULL 
  ) 

go 

CREATE TABLE [JOINEANDO_ANDO].[consulta_medica] 
  ( 
     [consulta_medica_id] [INT] IDENTITY(1, 1) NOT NULL, 
     [turno_id]           [INT] NOT NULL, 
     [bono_id]            [INT] NOT NULL, 
     [horario_llegada]    [DATETIME] NULL, 
     [horario_atencion]   [DATETIME] NULL 
  ) 

go 

CREATE TABLE [JOINEANDO_ANDO].[especialidades] 
  ( 
     [especialidad_id]      [INT] NOT NULL, 
     [nombre_especialidad]  [NVARCHAR](255) NOT NULL, 
     [tipo_especialidad_id] [INT] NULL 
  ) 

go 

CREATE TABLE [JOINEANDO_ANDO].[funcionabilidades] 
  ( 
     [funcionabilidad_id] [INT] IDENTITY(1, 1) NOT NULL, 
     [nombre]             [NVARCHAR](50) NULL 
  ) 

go 

CREATE TABLE [JOINEANDO_ANDO].[habilitados] 
  ( 
     [paciente_id] [INT] NOT NULL, 
     [estado]      [BIT] NOT NULL, 
     [fecha_alta]  [DATETIME] NULL, 
     [fecha_baja]  [DATETIME] NULL 
  ) 

go 

CREATE TABLE [JOINEANDO_ANDO].[medico_especialidad] 
  ( 
     [medico_id]       [INT] NOT NULL, 
     [especialidad_id] [INT] NOT NULL 
  ) 

go 

CREATE TABLE [JOINEANDO_ANDO].[medicos] 
  ( 
     [medico_id] [INT] NOT NULL, 
     [matricula] [INT], 
  ) 

go 

CREATE TABLE [JOINEANDO_ANDO].[pacientes] 
  ( 
     [paciente_id]        [INT] NOT NULL, 
     [estado_civil]       [NVARCHAR](255), 
     [familiares_a_cargo] [INT] NOT NULL, 
     [numero_afiliado]    [INT] NOT NULL, 
     [plan_id]            [INT] NOT NULL 
  ) 

go 

CREATE TABLE [JOINEANDO_ANDO].[planes] 
  ( 
     [plan_id]              [INT] NOT NULL, 
     [nombre]               [NVARCHAR](255) NOT NULL, 
     [precio_bono_consulta] [NUMERIC](18, 0) NOT NULL, 
     [precio_bono_farmacia] [NUMERIC] (18, 0) NOT NULL 
  ) 

go 

CREATE TABLE [JOINEANDO_ANDO].[resultados] 
  ( 
     [resultado_id]       [INT] IDENTITY(1, 1) NOT NULL, 
     [consulta_medica_id] [INT] NOT NULL, 
     [enfermedad]         [NVARCHAR](255) NULL, 
     [descripcion]        [NVARCHAR](255) NULL 
  ) 

go 

CREATE TABLE [JOINEANDO_ANDO].[sintomas] 
  ( 
     [sintoma_id]   [INT] IDENTITY(1, 1) NOT NULL, 
     [resultado_id] [INT] NOT NULL, 
     [descripcion]  NVARCHAR(255) NULL 
  ) 

go 

CREATE TABLE [JOINEANDO_ANDO].[rol] 
  ( 
     [rol_id]     [INT] IDENTITY(1, 1) NOT NULL, 
     [nombre]     [NVARCHAR](50) NOT NULL, 
     [habilitado] [BIT] NOT NULL 
  ) 

go 

CREATE TABLE [JOINEANDO_ANDO].[rol_funcionabilidad] 
  ( 
     [rol_id]             [INT] NOT NULL, 
     [funcionabilidad_id] [INT] NOT NULL 
  ) 

go 

CREATE TABLE [JOINEANDO_ANDO].[tipo_documento] 
  ( 
     [tipo_documento_id] [INT] IDENTITY(1, 1) NOT NULL, 
     [tipo]              [NVARCHAR](255) NOT NULL 
  ) 

go 

CREATE TABLE [JOINEANDO_ANDO].[tipo_especialidad] 
  ( 
     [tipo_especialidad_id] [INT] NOT NULL, 
     [especializacion]      [NVARCHAR](255) NOT NULL 
  ) 

go 

CREATE TABLE [JOINEANDO_ANDO].[turnos] 
  ( 
     [turno_id]       [INT] IDENTITY(1, 1) NOT NULL, 
     [paciente_id]    [INT] NOT NULL, 
     [agenda_id]      [INT] NOT NULL, 
     [fecha]          [DATE] NOT NULL, 
     [horario]        [TIME](7) NOT NULL, 
     [cancelacion_id] [INT] NULL, 
     [asistencia]     [BIT] NOT NULL 
  ) 

go 

CREATE TABLE [JOINEANDO_ANDO].[usuario_rol] 
  ( 
     [usuario_id] [INT] NOT NULL, 
     [rol_id]     [INT] NOT NULL 
  ) 

go 

CREATE TABLE [JOINEANDO_ANDO].[usuarios] 
  ( 
     [usuario_id]        [INT] IDENTITY(1, 1) NOT NULL, 
     [nombre]            [NVARCHAR](255) NOT NULL, 
     [apellido]          [NVARCHAR](255) NOT NULL, 
     [numero_documento]  [NUMERIC](18, 0) NOT NULL, 
     [tipo_documento_id] [INT] NOT NULL, 
     [direccion]         [NVARCHAR](255) NOT NULL, 
     [telefono]          [NUMERIC](18, 0) NOT NULL, 
     [mail]              [NVARCHAR](50) NOT NULL, 
     [fecha_nacimiento]  [DATETIME] NOT NULL, 
     [sexo_id]           [INT], 
     [nombre_usuario]    [NVARCHAR](255) NOT NULL, 
     [contrasena]        [NVARCHAR](255) NOT NULL, 
     [habilitado]        [BIT] NOT NULL, 
     [intentos_fallidos] [INT] NOT NULL 
  ) 

DBCC checkident ('[JOINEANDO_ANDO].[Usuarios]', reseed, 10000) 

go 

CREATE TABLE [JOINEANDO_ANDO].[sexo] 
  ( 
     [sexo_id]     [INT] IDENTITY(1, 1) NOT NULL, 
     [descripcion] [NVARCHAR](20) NOT NULL 
  ) 

go 

CREATE TABLE [JOINEANDO_ANDO].[dias_semana] 
  ( 
     [dia_semana_id] [INT] IDENTITY(1, 1) NOT NULL, 
     [dia]           [NVARCHAR](20) NOT NULL 
  ) 

go 

CREATE TABLE [JOINEANDO_ANDO].[hist_cambios] 
  ( 
     [paciente_id] [INT] NOT NULL, 
     [descripcion] [NVARCHAR](255) NOT NULL, 
     [fecha_mod]   [DATETIME] 
  ) 

go 

--Vistas 
CREATE VIEW joineando_ando.historial_cambios_paciente 
AS 
  SELECT P.paciente_id AS AfiliadoId, 
         u.nombre      AS NombreAfiliado, 
         U.apellido    AS ApellidoAfiliado, 
         h.fecha_mod   AS FechaModificacion, 
         H.descripcion AS Descripcion 
  FROM   joineando_ando.usuarios AS U 
         INNER JOIN joineando_ando.pacientes AS P 
                 ON U.usuario_id = P.paciente_id 
         INNER JOIN joineando_ando.hist_cambios AS H 
                 ON P.paciente_id = H.paciente_id 

go 

--Funciones 
CREATE FUNCTION joineando_ando.Cantidadfamilia(@numeroAfiliado INT) 
returns INT 
AS 
  -- Returns the stock level for the product.   
  BEGIN 
      RETURN 
        (SELECT TOP 1 Count(*) 
         FROM   [JOINEANDO_ANDO].[pacientes] 
         WHERE  ( numero_afiliado / 100 ) = @numeroAfiliado / 100 
         GROUP  BY ( numero_afiliado / 100 )) 
  END; 

go 

CREATE FUNCTION joineando_ando.Existe_usuario (@Usuario NVARCHAR(255)) 
returns INT 
AS 
  BEGIN 
      RETURN 
        (SELECT Count(nombre_usuario) 
         FROM   joineando_ando.usuarios 
         WHERE  nombre_usuario = @Usuario) 
  END 

go 

CREATE FUNCTION joineando_ando.Cantidad_intentos_fallidos (@UnUsuario NVARCHAR( 
255)) 
returns INT 
AS 
  BEGIN 
      RETURN 
        (SELECT intentos_fallidos 
         FROM   joineando_ando.usuarios 
         WHERE  nombre_usuario = @UnUsuario) 
  END 

go 

-- Stored Procedures 
CREATE PROCEDURE joineando_ando.Usuariosporid_seleccion @UsuarioId INT 
AS 
  BEGIN 
      SELECT [usuario_id], 
             [nombre], 
             [apellido], 
             [numero_documento], 
             [tipo_documento_id], 
             [direccion], 
             [telefono], 
             [mail], 
             [fecha_nacimiento], 
             [sexo_id], 
             [nombre_usuario], 
             [contrasena], 
             [habilitado], 
             [intentos_fallidos] 
      FROM   [JOINEANDO_ANDO].[usuarios] 
      WHERE  [usuario_id] = @UsuarioId 
  END 

go 

CREATE PROCEDURE joineando_ando.Seleccionar_rol @id INT 
AS 
  BEGIN 
      SELECT * 
      FROM   [JOINEANDO_ANDO].[rol] 
      WHERE  rol_id = @id 
  END 

go 

CREATE PROCEDURE joineando_ando.Historial_modificacion_paciente @id INT 
AS 
  BEGIN 
      SELECT * 
      FROM   [JOINEANDO_ANDO].historial_cambios_paciente AS VP 
      WHERE  vp.afiliadoid = @id 
  END 

go 


CREATE PROCEDURE [JOINEANDO_ANDO].Lista_planes 
AS 
  BEGIN 
      SELECT plan_id, 
             nombre 
      FROM   joineando_ando.planes 
  END 

go 

CREATE PROCEDURE [JOINEANDO_ANDO].Lista_especialidades 
AS 
  BEGIN 
      SELECT especialidad_id, 
             nombre_especialidad 
      FROM   joineando_ando.especialidades 
  END 

go 

CREATE PROCEDURE [JOINEANDO_ANDO].Cargar_diagnostico @paciente    INT, 
                                                     @diagnostico NVARCHAR(255), 
                                                     @enfermedad  NVARCHAR(255), 
                                                     @consulta    INT, 
                                                     @horario     DATETIME 
AS 
  BEGIN 
      UPDATE [JOINEANDO_ANDO].consulta_medica 
      SET    horario_atencion = @horario 
      WHERE  consulta_medica_id = @consulta 

      INSERT INTO [JOINEANDO_ANDO].resultados 
                  (enfermedad, 
                   descripcion, 
                   consulta_medica_id) 
      VALUES      (@enfermedad, 
                   @diagnostico, 
                   @consulta) 

      SELECT @@IDENTITY 
  END 

go 

CREATE PROCEDURE [JOINEANDO_ANDO].Cargar_sintoma @resultado INT, 
                                                 @sintoma   NVARCHAR(255) 
AS 
  BEGIN 
      INSERT INTO [JOINEANDO_ANDO].sintomas 
                  (resultado_id, 
                   descripcion) 
      VALUES      (@resultado, 
                   @sintoma) 
  END 

go 

CREATE PROCEDURE [JOINEANDO_ANDO].Busqueda_medico_resultado 
@fecha DATETIME ='', 
@numeroTurno    INT = 0, 
@numeroAfiliado INT = 0, 
@medico         INT 
AS 
  BEGIN 
      SELECT t.turno_id                          AS 'Numero de Turno', 
             CONVERT(VARCHAR, t.fecha, 103)      AS 'Dia', 
             CONVERT(VARCHAR(8), t.horario, 108) AS "Horario", 
             ( u.nombre + ' ' + u.apellido )     AS 'Nombre Paciente', 
             p.numero_afiliado                   AS 'Numero Afiliado', 
             p.paciente_id                       AS 'Id Paciente', 
             e.nombre_especialidad               AS "Especialidad", 
             c.consulta_medica_id 
      FROM   [JOINEANDO_ANDO].turnos t 
             INNER JOIN [JOINEANDO_ANDO].usuarios u 
                     ON u.usuario_id = t.paciente_id 
             INNER JOIN [JOINEANDO_ANDO].pacientes p 
                     ON p.paciente_id = u.usuario_id 
             INNER JOIN [JOINEANDO_ANDO].agendas a 
                     ON a.agenda_id = t.agenda_id 
             INNER JOIN [JOINEANDO_ANDO].medicos m 
                     ON a.medico_id = m.medico_id 
             INNER JOIN [JOINEANDO_ANDO].especialidades e 
                     ON e.especialidad_id = a.especialidad_id 
             INNER JOIN [JOINEANDO_ANDO].usuarios mm 
                     ON mm.usuario_id = m.medico_id 
             INNER JOIN [JOINEANDO_ANDO].consulta_medica c 
                     ON c.turno_id = t.turno_id 
      WHERE  ( ( Datediff(day, C.horario_llegada, @fecha) = 0 
                 AND Day(C.horario_llegada) = Day(@fecha) ) 
                OR ( @fecha = '' ) ) 
       
             AND ( ( @numeroAfiliado = 0 ) 
                    OR ( @numeroAfiliado = p.numero_afiliado ) ) 
             AND ( ( @numeroTurno = 0 ) 
                    OR ( @numeroTurno = t.turno_id ) ) 
             AND m.medico_id = @medico 
             AND c.horario_atencion IS NULL 
      ORDER  BY t.horario ASC 
  END 

go 

CREATE PROCEDURE joineando_ando.Compra_bono @numeroAfiliado INT, 
                                            @cantidad       INT, 
                                            @fecha          DATETIME 
AS 
  BEGIN 
      DECLARE @usr INT 
      DECLARE @plan INT 

      SET @usr = (SELECT paciente_id 
                  FROM   [JOINEANDO_ANDO].pacientes 
                  WHERE  numero_afiliado = @numeroAfiliado) 
      SET @plan = (SELECT plan_id 
                   FROM   [JOINEANDO_ANDO].pacientes 
                   WHERE  paciente_id = @usr) 

      INSERT INTO [JOINEANDO_ANDO].compra_bonos 
                  (paciente_id, 
                   monto, 
                   cantidad, 
                   fecha_compra) 
      VALUES      (@usr, 
                   @cantidad * (SELECT TOP 1 precio_bono_consulta 
                                FROM   [JOINEANDO_ANDO].planes 
                                WHERE  plan_id = @plan), 
                   @cantidad, 
                   @fecha) 

      DECLARE @compra INT = @@identity 
      DECLARE @cnt INT = 0; 

      WHILE @cnt < @cantidad 
        BEGIN 
            INSERT INTO [JOINEANDO_ANDO].bonos 
                        (plan_id, 
                         numero_afiliado, 
                         numero_consulta_medica, 
                         compra_id) 
            VALUES      (@plan, 
                         @numeroAfiliado, 
                         0, 
                         @compra) 

            SET @cnt = @cnt + 1; 
        END; 
  END 

go 

CREATE PROCEDURE joineando_ando.Precio_bono @nombre NVARCHAR(255) 
AS 
  BEGIN 
      SELECT TOP 1 precio_bono_consulta 
      FROM   [JOINEANDO_ANDO].planes 
      WHERE  nombre = @nombre 
  END 

go 


CREATE PROCEDURE joineando_ando.Baja_paciente @numeroAfiliado INT, 
                                              @fecha          DATETIME 
AS 
  BEGIN 
      DECLARE @paciente INT = (SELECT paciente_id 
         FROM   [JOINEANDO_ANDO].pacientes 
         WHERE  numero_afiliado = @numeroAfiliado) 

      UPDATE [JOINEANDO_ANDO].habilitados 
      SET    fecha_baja = @fecha, 
             estado = 0 
      WHERE  paciente_id = @paciente 

      DELETE FROM [JOINEANDO_ANDO].turnos 
      WHERE  paciente_id = @paciente 
             AND asistencia = 0; 
  END 

go 

CREATE PROCEDURE [JOINEANDO_ANDO].Confirmar_presencia @turno          INT, 
                                                      @numeroAfiliado INT, 
                                                      @horario        DATETIME 
AS 
  BEGIN 
      DECLARE @bono INT 

      SET @bono = (SELECT TOP 1 bono_id 
                   FROM   [JOINEANDO_ANDO].bonos 
                   WHERE  numero_afiliado BETWEEN ( Round(@numeroAfiliado / 100, 
                                                    0 
                                                    ) * 
                                                    100 ) AND ( 
                          Round(@numeroAfiliado / 100, 0) * 100 + 
                          99 ) 
                          AND plan_id = (SELECT TOP 1 plan_id 
                                         FROM   [JOINEANDO_ANDO].pacientes 
                                         WHERE  numero_afiliado = 
                                                @numeroAfiliado) 
                          AND numero_consulta_medica = 0) 

      UPDATE [JOINEANDO_ANDO].bonos 
      SET    numero_consulta_medica = (SELECT Isnull(Max(numero_consulta_medica) 
                                              , 
                                              0) 
                                       FROM   [JOINEANDO_ANDO].bonos 
                                       WHERE  numero_afiliado = @numeroAfiliado) 
                                      + 1 
      WHERE  bono_id = @bono 

      UPDATE [JOINEANDO_ANDO].turnos 
      SET    asistencia = 1 
      WHERE  turno_id = @turno 

      INSERT INTO [JOINEANDO_ANDO].consulta_medica 
                  (turno_id, 
                   bono_id, 
                   horario_llegada) 
      VALUES      (@turno, 
                   @bono, 
                   @horario) 

  END 

go 

CREATE PROCEDURE [JOINEANDO_ANDO].Listado_especialidades 
AS 
  BEGIN 
      SELECT nombre_especialidad 
      FROM   [JOINEANDO_ANDO].especialidades 
  END 

go 

CREATE PROCEDURE [JOINEANDO_ANDO].Bonos_disponibles @numeroAfiliado INT 
AS 
  BEGIN 
      SELECT Count(*) 
      FROM   [JOINEANDO_ANDO].bonos 
      WHERE  numero_afiliado BETWEEN ( Round(@numeroAfiliado / 100, 0) * 100 ) 
                                     AND 
                                     ( 
                                            Round(@numeroAfiliado / 100, 0) * 
                                            100 
                                            + 99 
                                     ) 
             AND plan_id = (SELECT TOP 1 plan_id 
                            FROM   [JOINEANDO_ANDO].pacientes 
                            WHERE  numero_afiliado = @numeroAfiliado) 
             AND numero_consulta_medica = 0 
  END 

go 

CREATE PROCEDURE [JOINEANDO_ANDO].Listado_registro_atencion @fecha 
DATETIME, @numeroTurno INT = 0,
@numeroAfiliado INT = 0, 
@medico NVARCHAR(255) = '', 
@especialidad NVARCHAR(255) = '' 
AS 
  BEGIN 
      SELECT t.turno_id                          AS 'Numero de Turno', 
             CONVERT(VARCHAR, t.fecha, 103)      AS 'Dia', 
             CONVERT(VARCHAR(8), t.horario, 108) AS "Horario", 
             ( u.nombre + ' ' + u.apellido )     AS 'Nombre Paciente', 
             p.numero_afiliado                   AS 'Numero Afiliado', 
             ( mm.nombre + ' ' + mm.apellido )   AS 'Nombre Profesional', 
             e.nombre_especialidad               AS "Especialidad" 
      FROM   [JOINEANDO_ANDO].turnos t 
             INNER JOIN [JOINEANDO_ANDO].usuarios u 
                     ON u.usuario_id = t.paciente_id 
             INNER JOIN [JOINEANDO_ANDO].pacientes p 
                     ON p.paciente_id = u.usuario_id 
             INNER JOIN [JOINEANDO_ANDO].agendas a 
                     ON a.agenda_id = t.agenda_id 
             INNER JOIN [JOINEANDO_ANDO].medicos m 
                     ON a.medico_id = m.medico_id 
             INNER JOIN [JOINEANDO_ANDO].especialidades e 
                     ON e.especialidad_id = a.especialidad_id 
             INNER JOIN [JOINEANDO_ANDO].usuarios mm 
                     ON mm.usuario_id = m.medico_id 
      WHERE  (( Datediff(day, fecha, @fecha) = 0 
                AND Day(fecha) = Day(@fecha) )) 
           
             AND ( ( @numeroAfiliado = 0 ) 
                    OR ( @numeroAfiliado = p.numero_afiliado ) ) 
             AND ( ( @numeroTurno = 0 ) 
                    OR ( @numeroTurno = t.turno_id ) ) 
             AND ( ( @medico = '' ) 
                    OR ( mm.nombre LIKE '%' + @medico + '%' ) 
                    OR ( mm.apellido LIKE '%' + @medico + '%' ) ) 
             AND ( ( @especialidad = '' ) 
                    OR ( e.nombre_especialidad = @especialidad ) ) 
             AND t.asistencia = 0 
      ORDER  BY t.horario ASC 
  END 

go 

CREATE PROCEDURE joineando_ando.Crear_paciente 
@nombre          NVARCHAR(255) = '', 
@tipo            NVARCHAR(255) = 'DNI', 
@numeroDocumento NUMERIC(18, 0) = 0, 
@apellido        NVARCHAR(255) = '', 
@direccion       NVARCHAR(255) = '', 
@sexo            NVARCHAR(255) = '', 
@telefono        NUMERIC(18, 0) = 0, 
@mail            NVARCHAR(50)='', 
@fechaNac        DATETIME = '5/5/5', 
@estadoCivil     NVARCHAR(255) = '', 
@familiares      INT=0, 
@raiz            INT=0, 
@sub             INT=0, 
@plan            NVARCHAR(255) = '', 
@fecha           DATETIME 

AS 
  BEGIN 
      DECLARE @returnValue INT 
      DECLARE @valor INT 
      DECLARE @iden INT 

      INSERT INTO [JOINEANDO_ANDO].usuarios 
                  (nombre, 
                   apellido, 
                   numero_documento, 
                   tipo_documento_id, 
                   direccion, 
                   telefono, 
                   mail, 
                   fecha_nacimiento, 
                   sexo_id, 
                   nombre_usuario, 
                   contrasena, 
                   habilitado, 
                   intentos_fallidos) 
      VALUES      (@nombre, 
                   @apellido, 
                   @numeroDocumento, 
                   (SELECT tipo_documento_id 
                    FROM   [JOINEANDO_ANDO].tipo_documento 
                    WHERE  tipo = @tipo), 
                   @direccion, 
                   @telefono, 
                   @mail, 
                   @fechaNac, 
                   (SELECT sexo_id 
                    FROM   [JOINEANDO_ANDO].sexo 
                    WHERE  descripcion = @sexo), 
                   @nombre + '.' + @apellido, 
                   Hashbytes('SHA2_256', Str(@numeroDocumento)), 
                   1, 
                   0) 

      SET @iden = @@IDENTITY 

      IF @raiz = 0 
        SET @valor = @@IDENTITY * 100 + 1 
      ELSE 
        SET @valor = @raiz + @sub 

      SET @returnValue = @valor 

      INSERT INTO [JOINEANDO_ANDO].pacientes 
                  (paciente_id, 
                   estado_civil, 
                   familiares_a_cargo, 
                   numero_afiliado, 
                   plan_id) 
      VALUES      (@@IDENTITY, 
                   @estadoCivil, 
                   @familiares, 
                   @valor, 
                   (SELECT plan_id 
                    FROM   [JOINEANDO_ANDO].planes 
                    WHERE  nombre = @plan)) 

      INSERT INTO [JOINEANDO_ANDO].habilitados 
                  (paciente_id, 
                   estado, 
                   fecha_alta, 
                   fecha_baja) 
      VALUES      (@iden, 
                   1, 
                   @fecha, 
                   NULL) 

      INSERT INTO [JOINEANDO_ANDO].usuario_rol 
      SELECT @iden, 
             1 

      SELECT @returnValue 
  END 

go 

CREATE PROCEDURE joineando_ando.Listar_cambios @numero_afiliado INT 
AS 
  BEGIN 
      SELECT descripcion                      AS Razon, 
             CONVERT(VARCHAR, fecha_mod, 103) AS 'Fecha Modificacion' 
      FROM   joineando_ando.hist_cambios 
      WHERE  paciente_id = (SELECT paciente_id 
                            FROM   [JOINEANDO_ANDO].pacientes 
                            WHERE  numero_afiliado = @numero_afiliado) 
  END 

go 

CREATE PROCEDURE joineando_ando.Actualizar_paciente 
@direccion        NVARCHAR(255), 
@telefono         NUMERIC(18 , 0), 
@email            NVARCHAR( 255), 
@estadoCivil      NVARCHAR( 255), 
@familiaresACargo INT, 
@plan             NVARCHAR(255), 
@numero_afiliado  INT, 
@razon            NVARCHAR(255) = '', 
@fecha            DATETIME 
AS 
  BEGIN 
      DECLARE @usr INT 

      SET @usr = (SELECT paciente_id 
                  FROM   [JOINEANDO_ANDO].pacientes 
                  WHERE  numero_afiliado = @numero_afiliado) 

      UPDATE [JOINEANDO_ANDO].pacientes 
      SET    estado_civil = @estadoCivil, 
             familiares_a_cargo = @familiaresACargo, 
             plan_id = (SELECT plan_id 
                        FROM   [JOINEANDO_ANDO].planes 
                        WHERE  nombre = @plan) 
      WHERE  numero_afiliado = @numero_afiliado 

      UPDATE [JOINEANDO_ANDO].usuarios 
      SET    direccion = @direccion, 
             telefono = @telefono, 
             mail = @email 
      WHERE  usuario_id = @usr 

      IF @razon <> '' 
        INSERT INTO [JOINEANDO_ANDO].hist_cambios 
                    (paciente_id, 
                     descripcion, 
                     fecha_mod) 
        VALUES      (@usr, 
                     @razon, 
                     @fecha) 
  END 

go 

CREATE PROCEDURE joineando_ando.Listado_sexo 
AS 
  BEGIN 
      SELECT descripcion 
      FROM   [JOINEANDO_ANDO].sexo 
  END 

go 

CREATE PROCEDURE joineando_ando.Listado_planes 
AS 
  BEGIN 
      SELECT nombre 
      FROM   [JOINEANDO_ANDO].planes 
  END 

go 

CREATE PROCEDURE joineando_ando.Listado_tipo_documentos 
AS 
  BEGIN 
      SELECT tipo 
      FROM   [JOINEANDO_ANDO].tipo_documento 
  END 

go 

CREATE PROCEDURE joineando_ando.Filtro_paciente 
@nombre          NVARCHAR(255) = NULL, 
@apellido        NVARCHAR(255) = NULL, 
@tipo            NVARCHAR(255)= NULL, 
@numeroDocumento NUMERIC(18, 0) = NULL 
AS 
  BEGIN 
      SELECT TOP 100 pa.numero_afiliado                          AS 
                     'Numero de Afiliado', 
                     us.nombre, 
                     apellido, 
                     tipo, 
                     numero_documento, 
                     direccion, 
                     telefono, 
                     mail                                        AS Email, 
                     CONVERT(VARCHAR, fecha_nacimiento, 103)     AS 
                     'Fecha Nacimiento' 
                     , 
                     Isnull(sexo.descripcion, 'No especificado') AS 
                     Sexo, 
                     Isnull(pa.estado_civil, 'No especificado')  AS 
                     'Estado Civil' 
                     , 
                     familiares_a_cargo 
                     AS 
                     'Familiares a cargo', 
                     pl.nombre                                   AS 'Plan' 
      FROM   [JOINEANDO_ANDO].[tipo_documento] 
             INNER JOIN [JOINEANDO_ANDO].[usuarios] us 
                     ON us.tipo_documento_id = tipo_documento.tipo_documento_id 
             INNER JOIN [JOINEANDO_ANDO].pacientes pa 
                     ON pa.paciente_id = us.usuario_id 
             FULL JOIN [JOINEANDO_ANDO].sexo 
                    ON sexo.sexo_id = us.sexo_id 
             JOIN [JOINEANDO_ANDO].planes pl 
               ON pl.plan_id = pa.plan_id 
             INNER JOIN [JOINEANDO_ANDO].habilitados ha 
                     ON pa.paciente_id = ha.paciente_id 
      WHERE  ha.estado = 1 
             AND us.nombre LIKE CASE 
                                  WHEN @nombre IS NOT NULL THEN 
                                  '%' + @nombre + '%' 
                                  ELSE '%' 
                                END 
             AND us.apellido LIKE CASE 
                                    WHEN @apellido IS NOT NULL THEN 
                                    '%' + @apellido + '%' 
                                    ELSE '%' 
                                  END 
             AND us.numero_documento = CASE 
                                         WHEN @numeroDocumento IS NULL THEN 
                                         us.numero_documento 
                                         ELSE @numeroDocumento 
                                       END 
             AND tipo = CASE 
                          WHEN @tipo IS NULL THEN tipo 
                          ELSE @tipo 
                        END 
  END 

go 

CREATE PROCEDURE joineando_ando.Filtro_rol @habilitado        BIT = NULL, 
                                           @idfuncionabilidad INT = NULL 
AS 
  BEGIN 
      IF( @idfuncionabilidad IS NOT NULL 
          AND @habilitado IS NULL ) 
        BEGIN 
            SELECT * 
            FROM   rol R 
            WHERE  EXISTS(SELECT 1 
                          FROM   rol_funcionabilidad F 
                          WHERE  F.funcionabilidad_id = @idFuncionabilidad 
                                 AND R.rol_id = F.rol_id) 
        END 

      IF( @habilitado IS NOT NULL 
          AND @idfuncionabilidad IS NULL ) 
        BEGIN 
            SELECT * 
            FROM   rol 
            WHERE  habilitado = @habilitado 
        END 

      IF( @habilitado IS NOT NULL 
          AND @idfuncionabilidad IS NOT NULL ) 
        BEGIN 
            SELECT * 
            FROM   rol R 
            WHERE  EXISTS(SELECT 1 
                          FROM   rol_funcionabilidad F 
                          WHERE  F.funcionabilidad_id = @idFuncionabilidad 
                                 AND R.rol_id = F.rol_id) 
            INTERSECT 
            SELECT * 
            FROM   rol 
            WHERE  habilitado = @habilitado 
        END 

      IF( @idfuncionabilidad IS NULL 
          AND @habilitado IS NULL ) 
        SELECT * 
        FROM   rol 
  END 

go 

CREATE PROCEDURE joineando_ando.Inhabilitar_rol @id INT 
AS 
  BEGIN 
      UPDATE rol 
      SET    habilitado = 1 
      WHERE  rol_id = @id 
  END 

go 

CREATE PROCEDURE joineando_ando.Seleccionar_propiedades_rol @id INT 
AS 
  BEGIN 
      SELECT * 
      FROM   [rol] 
      WHERE  rol_id = @id 
  END 

go 

CREATE PROCEDURE joineando_ando.Listarroles 
AS 
  BEGIN 
      SELECT * 
      FROM   [rol] 
  END 

go 

CREATE PROCEDURE joineando_ando.Alta_rol @nombre       NVARCHAR(50), 
                                         @inHabilitado BIT 
AS 
  BEGIN 
      INSERT INTO [JOINEANDO_ANDO].rol 
                  (nombre, 
                   habilitado) 
      output      inserted.rol_id 
      VALUES      (@nombre, 
                   @inHabilitado) 
  END 

go 

CREATE PROCEDURE joineando_ando.Actualizar_rol @id           INT, 
                                               @nombre       NVARCHAR(50), 
                                               @inhabilitado BIT 
AS 
  BEGIN 
      UPDATE rol 
      SET    nombre = @nombre, 
             habilitado = @inHabilitado 
      WHERE  rol_id = @id 

      IF @inhabilitado = 0 
        BEGIN 
            DELETE FROM [JOINEANDO_ANDO].usuario_rol 
            WHERE  rol_id = @id 
        END 
  END 

go 

CREATE PROCEDURE joineando_ando.Alta_funcionabiliad_x_rol 
@idRol             INT , 
@idFuncionabilidad INT 
AS 
  BEGIN 
      IF NOT EXISTS (SELECT * 
                     FROM   rol_funcionabilidad 
                     WHERE  rol_id = @idRol 
                            AND funcionabilidad_id = @idFuncionabilidad) 
        BEGIN 
            INSERT INTO [JOINEANDO_ANDO].rol_funcionabilidad 
                        (rol_id, 
                         funcionabilidad_id) 
            VALUES      (@idRol, 
                         @idFuncionabilidad) 
        END 
  END 

go 

CREATE PROCEDURE joineando_ando.Baja_funcionablilida_x_rol 
@idRol INT, 
@idFuncionabilidad INT 
AS 
  BEGIN 
      DELETE FROM rol_funcionabilidad 
      WHERE  rol_id = @idRol 
             AND funcionabilidad_id = @idFuncionabilidad 
  END 

go 

CREATE PROCEDURE joineando_ando.Roles_x_usuario @UserId INT 
AS 
  BEGIN 
      SELECT U.rol_id, 
             nombre 
      FROM   joineando_ando.usuario_rol U 
             JOIN joineando_ando.rol R 
               ON U.rol_id = R.rol_id 
                  AND R.habilitado = 1 
      WHERE  U.usuario_id = @Userid 
  END 

go 

CREATE PROCEDURE joineando_ando.Validar_usuario @UserId NVARCHAR(50), 
                                                @Pas    VARCHAR(50) 
AS 
  BEGIN 
      IF EXISTS (SELECT 1 
                 FROM   joineando_ando.usuarios 
                 WHERE  nombre_usuario = @UserId 
                        AND [contrasena] = Hashbytes('SHA2_256', @Pas) 
                        AND habilitado = 1) 
        BEGIN 
            SELECT 'Ingreso OK' resultado, 
                   usuario_id 
            FROM   joineando_ando.usuarios 
            WHERE  nombre_usuario = @UserId 
        END 
      ELSE 
        BEGIN 
            IF EXISTS(SELECT usuario_id, 
                             usuario_id 
                      FROM   joineando_ando.usuarios 
                      WHERE  nombre_usuario = @UserID) 
              BEGIN 
                  IF( (SELECT intentos_fallidos 
                       FROM   joineando_ando.usuarios 
                       WHERE  nombre_usuario = @UserID) < 3 ) 
                    BEGIN 
                        UPDATE joineando_ando.usuarios 
                        SET    intentos_fallidos = intentos_fallidos + 1 
                        WHERE  nombre_usuario = @UserID 

                        SELECT 'usuario o password invalido' resultado, 
                               0 
                    END 
                  ELSE 
                    BEGIN 
                        UPDATE joineando_ando.usuarios 
                        SET    habilitado = 0 
                        WHERE  nombre_usuario = @UserID 

                        SELECT 'el usuario se encuentra bloqueado', 
                               -1 
                    END 
              END 
            ELSE 
              BEGIN 
                  SELECT 'usuario o password invalido' resultado, 
                         0 
              END 
        END 
  END 

go 

CREATE PROCEDURE joineando_ando.Seleccionar_funcionabilidades_x_rol @id INT 
AS 
  BEGIN 
      SELECT * 
      FROM   joineando_ando.rol_funcionabilidad R 
             JOIN joineando_ando.funcionabilidades F 
               ON F.funcionabilidad_id = R.funcionabilidad_id 
      WHERE  R.rol_id = @id 
  END 

go 

CREATE PROCEDURE joineando_ando.Seleccionar_funcionabilidades 
AS 
  BEGIN 
      SELECT * 
      FROM   funcionabilidades 
  END 

go 


CREATE PROCEDURE joineando_ando.Especialidadmedicoposeeagenda 
@Medico_ID INT, 
@Especialidad_ID INT 
AS 
    DECLARE @VariableRetorno BIT 

  BEGIN 
      IF EXISTS (SELECT * 
                 FROM   agendas 
                 WHERE  medico_id = @Medico_ID 
                        AND especialidad_id = @Especialidad_ID) 
        SET @VariableRetorno = 1 
      ELSE 
        SET @VariableRetorno = 0 

      SELECT @VariableRetorno 
  END 

go 

CREATE PROCEDURE joineando_ando.Medicohorassemanales @Medico_id INT 
AS 
  BEGIN 
      SELECT Isnull(Sum(Datediff(hour, inicio_horario, fin_horario)), 0)   AS 
             Horas, 
             Isnull(Sum(Datediff(minute, inicio_horario, fin_horario)), 0) AS 
             Minutos 
      FROM   dias_atencion 
             JOIN agendas 
               ON agendas.agenda_id = dias_atencion.agenda_id 
      WHERE  agendas.medico_id = @Medico_id 
  END 

go 

CREATE PROCEDURE joineando_ando.Especialidadespecialidadesmedico @Medico_id INT 
AS 
  BEGIN 
      SELECT nombre_especialidad, 
             especialidades.especialidad_id 
      FROM   especialidades 
             JOIN medico_especialidad 
               ON especialidades.especialidad_id = 
                  medico_especialidad.especialidad_id 
      WHERE  medico_especialidad.medico_id = @Medico_id 
  END 

go 

CREATE PROCEDURE joineando_ando.Medicotodos 
AS 
  BEGIN 
      SELECT usuarios.nombre, 
             usuarios.apellido, 
             medicos.medico_id 
      FROM   medicos 
             JOIN usuarios 
               ON medicos.medico_id = usuarios.usuario_id 
  END 

go 

CREATE PROCEDURE joineando_ando.Especialidadtodas 
AS 
  BEGIN 
      SELECT * 
      FROM   especialidades 
  END 

go 

CREATE PROCEDURE joineando_ando.Turnohorarios @Medico_id       INT, 
                                              @Especialidad_id INT, 
                                              @Dia_Semana      INT 
AS 
  BEGIN 
      SELECT inicio_horario, 
             fin_horario 
      FROM   agendas 
             JOIN dias_atencion 
               ON agendas.agenda_id = dias_atencion.agenda_id 
      WHERE  agendas.especialidad_id = @Especialidad_id 
             AND agendas.medico_id = @Medico_id 
             AND dias_atencion.dia_id = @Dia_Semana 
  END 

go 

CREATE PROCEDURE joineando_ando.Turnoestaocupado @Horario          TIME(7), 
                                                 @Medico_id        INT, 
                                                 @Especialidad_id  INT, 
                                                 @Dia_seleccionado DATE 
AS 
  BEGIN 
      SELECT Count(*) 
      FROM   agendas 
             JOIN turnos 
               ON agendas.agenda_id = turnos.agenda_id 
      WHERE  agendas.medico_id = @Medico_id 
             AND agendas.especialidad_id = @Especialidad_id 
             AND turnos.fecha = @Dia_seleccionado 
             AND turnos.horario = @Horario 
             AND turnos.cancelacion_id IS NULL 
  END 

go 

CREATE PROCEDURE joineando_ando.Personaturnos @Nombre          VARCHAR(30) = 
NULL, 
                                              @Apellido        VARCHAR(30) = 
NULL, 
                                              @Dia             DATE = NULL, 
                                              @Especialidad_id INT = NULL, 
                                              @Persona_id      INT, 
                                              @FechaHoy        DATE 
AS 
  BEGIN 
      SELECT usuarios.nombre                    AS Nombre, 
             usuarios.apellido                  AS Apellido, 
             especialidades.nombre_especialidad AS Especialidad, 
             turnos.fecha                       AS Dia, 
             turnos.horario                     AS Horario, 
             turnos.turno_id                    AS IDTurno 
      FROM   turnos 
             JOIN agendas 
               ON agendas.agenda_id = turnos.agenda_id 
             JOIN usuarios 
               ON usuarios.usuario_id = agendas.medico_id 
             JOIN especialidades 
               ON especialidades.especialidad_id = agendas.especialidad_id 
      WHERE ( @Nombre IS NULL 
               OR usuarios.nombre = @Nombre ) 
            AND ( @Apellido IS NULL 
                   OR usuarios.apellido = @Apellido ) 
            AND ( @Dia IS NULL 
                   OR turnos.fecha = @Dia ) 
            AND ( turnos.fecha >= @FechaHoy ) 
            AND ( @Especialidad_id IS NULL 
                   OR especialidades.especialidad_id = @Especialidad_id ) 
            AND ( paciente_id = @Persona_id ) 
            AND ( turnos.cancelacion_id IS NULL ) 
            AND ( asistencia = 0 ) 
  END 

go 

CREATE PROCEDURE joineando_ando.Tipocancelaciontodos 
AS 
  BEGIN 
      SELECT * 
      FROM   tipo_cancelaciones 
  END 

go 

CREATE PROCEDURE joineando_ando.Cancelacioneliminarturnoafiliado @Turno_id 
INT, 
@Tipo_Cancelacion_id INT, 
@Descripcion         NVARCHAR(50) 
AS 
BEGIN 
INSERT INTO cancelaciones 
(tipo, 
descripcion) 
VALUES     (@Tipo_Cancelacion_id, 
@Descripcion) 

UPDATE turnos 
SET    cancelacion_id = @@IDENTITY 
WHERE  turnos.turno_id = @Turno_id 
END 

go 

CREATE PROCEDURE joineando_ando.Cancelacioneliminarturnoprofesional @Dia 
DATE, 
@Tipo_Cancelacion_id INT, 
@Descripcion         NVARCHAR(50), 
@Medico_id           INT 
AS 
BEGIN 
DECLARE @Cancelacion_id INT 

IF EXISTS(SELECT turno_id 
FROM   turnos 
JOIN agendas 
ON agendas.agenda_id = turnos.agenda_id 
WHERE  agendas.medico_id = @Medico_id 
AND turnos.fecha = @Dia 
AND turnos.cancelacion_id IS NULL) 
BEGIN 
INSERT INTO cancelaciones 
(tipo, 
descripcion) 
VALUES     (@Tipo_Cancelacion_id, 
@Descripcion) 

SET @Cancelacion_id = @@IDENTITY 

UPDATE turnos 
SET    cancelacion_id = @Cancelacion_id 
WHERE  turno_id IN (SELECT turno_id 
FROM   turnos 
JOIN agendas 
ON agendas.agenda_id = turnos.agenda_id 
WHERE  agendas.medico_id = @Medico_id 
AND turnos.fecha = @Dia 
AND turnos.cancelacion_id IS NULL) 
END 
END 

go 

CREATE PROCEDURE joineando_ando.Turnoinsertarnuevo @Paciente_id     INT, 
                                                   @Fecha           DATE, 
                                                   @Horario         TIME(7), 
                                                   @Medico_id       INT, 
                                                   @Especialidad_id INT 
AS 
  BEGIN 
      INSERT INTO turnos 
                  (paciente_id, 
                   fecha, 
                   horario, 
                   asistencia, 
                   agenda_id) 
      VALUES     (@Paciente_id, 
                  @Fecha, 
                  @Horario, 
                  0, 
                  (SELECT agendas.agenda_id 
                   FROM   agendas 
                   WHERE  agendas.medico_id = @Medico_id 
                          AND agendas.especialidad_id = @Especialidad_id) ) 
  END 

go 

CREATE PROCEDURE joineando_ando.Agendainsertarnueva @Medico_id       INT, 
                                                    @Especialidad_id INT, 
                                                    @Dia_id          INT, 
                                                    @Inicio_Horario  TIME(7), 
                                                    @Fin_Horario     TIME(7) 
AS 
  BEGIN 
      DECLARE @id_Agenda INT 

      IF EXISTS(SELECT agenda_id 
                FROM   agendas 
                WHERE  agendas.medico_id = @Medico_id 
                       AND agendas.especialidad_id = @Especialidad_id) 
        BEGIN 
            SET @id_Agenda = (SELECT agenda_id 
                              FROM   agendas 
                              WHERE  agendas.medico_id = @Medico_id 
                                     AND agendas.especialidad_id = 
                                         @Especialidad_id) 
        END 
      ELSE 
        BEGIN 
            INSERT INTO agendas 
                        (medico_id, 
                         especialidad_id) 
            VALUES     (@Medico_id, 
                        @Especialidad_id) 

            SET @id_Agenda = @@IDENTITY 
        END 

      INSERT INTO dias_atencion 
                  (agenda_id, 
                   dia_id, 
                   inicio_horario, 
                   fin_horario) 
      VALUES     (@id_Agenda, 
                  @Dia_id, 
                  @Inicio_Horario, 
                  @Fin_Horario) 
  END 

go 

CREATE PROCEDURE joineando_ando.Medicoturnos @id_medico INT, 
                                             @Dia       DATE, 
                                             @FechaHoy  DATE 
AS 
  BEGIN 
      SELECT usuarios.nombre AS Nombre, 
             turnos.fecha    AS Fecha, 
             turnos.horario  AS Horario 
      FROM   turnos 
             JOIN agendas 
               ON agendas.agenda_id = turnos.agenda_id 
             JOIN usuarios 
               ON usuarios.usuario_id = agendas.medico_id 
      WHERE  ( @Dia IS NULL 
                OR turnos.fecha = @Dia ) 
             AND ( turnos.fecha >= @FechaHoy ) 
             AND ( turnos.cancelacion_id IS NULL ) 
             AND ( asistencia = 0 ) 
  END 

go 

CREATE FUNCTION joineando_ando.Colisionanrangos(@Inicio_Horario TIME(7), 
                                                @Fin_Horario    TIME(7), 
                                                @Inicio_Rango   TIME(7), 
                                                @Fin_Rango      TIME(7)) 
returns BIT 
AS 
  BEGIN 
      DECLARE @colisiona BIT 

      IF ( ( @Inicio_Horario >= @Inicio_Rango 
             AND @Inicio_Horario < @Fin_Rango ) 
            OR ( @Fin_Horario > @Inicio_Rango 
                 AND @Fin_Horario <= @Fin_Rango ) 
            OR ( @Inicio_Horario < @Inicio_Rango 
                 AND @Fin_Horario > @Fin_Rango ) ) 
        BEGIN 
            RETURN 1 
        END 

      RETURN 0 
  END 

go 

CREATE PROCEDURE joineando_ando.Agendarangocolisionaconagendaexistente 
@Medico_id      INT, 
@Dia_id         INT, 
@Inicio_Horario TIME(7), 
@Fin_Horario    TIME(7) 
AS 
  BEGIN 
      SELECT Cast(Count(*) AS BIT) 
      FROM   agendas 
             JOIN dias_atencion 
               ON dias_atencion.agenda_id = agendas.agenda_id 
      WHERE  agendas.medico_id = @Medico_id 
             AND dias_atencion.dia_id = @Dia_id 
             AND joineando_ando.Colisionanrangos(@Inicio_Horario, @Fin_Horario, 
                     dias_atencion.inicio_horario, dias_atencion.fin_horario) = 
                 1 
  END 

go 

--Listados Estadísticos 
CREATE PROCEDURE joineando_ando.Listadoespecialidadesconmascancelaciones @anio 
INT, 
@semestre INT 
AS 
BEGIN 
SET language spanish 

DECLARE @Out TABLE 
( 
"mes"                       NVARCHAR(255), 
"posicion mensual"          INT, 
"nombre especialidad"       NVARCHAR(255), 
"cantidad de cancelaciones" INT 
); 
DECLARE @end INT = 7 + 6 * ( @semestre - 1 ) 
DECLARE @start INT = 1 + 6 * ( @semestre - 1 ) 

WHILE ( @start < @end ) 
BEGIN 
INSERT INTO @Out 
SELECT TOP 5 Datename(mm, Dateadd(mm, Month(t.fecha), -1)), 
Row_number() 
OVER ( 
ORDER BY Count(*) DESC), 
e.nombre_especialidad, 
Count(*) 
FROM   [JOINEANDO_ANDO].cancelaciones c 
INNER JOIN [JOINEANDO_ANDO].turnos t 
ON t.cancelacion_id = c.cancelacion_id 
INNER JOIN [JOINEANDO_ANDO].agendas a 
ON a.agenda_id = t.agenda_id 
INNER JOIN [JOINEANDO_ANDO].especialidades e 
ON e.especialidad_id = a.especialidad_id 
WHERE  Year(t.fecha) = @anio 
GROUP  BY e.nombre_especialidad, 
Month(t.fecha) 
HAVING Month(t.fecha) = @start 

SET @start = @start + 1; 
END 

SELECT * 
FROM   @out 
END 

go 

CREATE PROCEDURE joineando_ando.Listadoprofesionalesmasconsultadosporplan 
@semestre INT, 
@anio     INT, 
@planid   INT 
AS 
  BEGIN 
      SET language spanish 

      DECLARE @Out TABLE 
        ( 
           "mes"                   NVARCHAR(255), 
           "posicion mensual"      INT, 
           "medico"                NVARCHAR(255), 
           "nombre especialidad"   NVARCHAR(255), 
           "cantidad de consultas" INT 
        ); 
      DECLARE @end INT = 7 + 6 * ( @semestre - 1 ) 
      DECLARE @start INT = 1 + 6 * ( @semestre - 1 ) 

      WHILE ( @start < @end ) 
        BEGIN 
            INSERT INTO @Out 
            SELECT TOP 5 Datename(mm, Dateadd(mm, Month(t.fecha), -1)), 
                         Row_number() 
                           OVER ( 
                             ORDER BY Count(*) DESC), 
                         u.nombre + ' ' + u.apellido, 
                         e.nombre_especialidad, 
                         Count(*) 
            FROM   [JOINEANDO_ANDO].turnos t 
                   INNER JOIN [JOINEANDO_ANDO].agendas a 
                           ON a.agenda_id = t.agenda_id 
                   INNER JOIN [JOINEANDO_ANDO].pacientes p 
                           ON p.paciente_id = t.paciente_id 
                   INNER JOIN [JOINEANDO_ANDO].especialidades e 
                           ON e.especialidad_id = a.especialidad_id 
                   INNER JOIN [JOINEANDO_ANDO].medicos m 
                           ON m.medico_id = a.medico_id 
                   INNER JOIN [JOINEANDO_ANDO].usuarios u 
                           ON u.usuario_id = m.medico_id 
            WHERE  p.plan_id = @planid 
                   AND t.asistencia = 1 
                   AND Year(t.fecha) = @anio 
            GROUP  BY u.nombre + ' ' + u.apellido, 
                      Month(t.fecha), 
                      e.nombre_especialidad 
            HAVING Month(t.fecha) = @start 

            SET @start = @start + 1; 
        END 

      SELECT * 
      FROM   @out 
  END 

go 

CREATE PROCEDURE joineando_ando.Listadoprofesionalesconmenoshorastrabajadas 
@semestre       INT, 
@anio           INT, 
@planid         INT, 
@especialidadid INT 
AS 
  BEGIN 
      SET language spanish 

      DECLARE @Out TABLE 
        ( 
           "mes"                   NVARCHAR(255), 
           "posicion mensual"      INT, 
           "medico"                NVARCHAR(255), 
           "nombre especialidad"   NVARCHAR(255), 
           "cantidad de consultas" INT 
        ); 
      DECLARE @end INT = 7 + 6 * ( @semestre - 1 ) 
      DECLARE @start INT = 1 + 6 * ( @semestre - 1 ) 

      WHILE ( @start < @end ) 
        BEGIN 
            INSERT INTO @Out 
            SELECT TOP 5 Datename(mm, Dateadd(mm, Month(t.fecha), -1)), 
                         Row_number() 
                           OVER ( 
                             ORDER BY Count(*) ASC), 
                         u.nombre + ' ' + u.apellido, 
                         e.nombre_especialidad, 
                         Count(*) 
            FROM   [JOINEANDO_ANDO].turnos t 
                   JOIN [JOINEANDO_ANDO].agendas a 
                     ON a.agenda_id = t.agenda_id 
                   JOIN [JOINEANDO_ANDO].especialidades e 
                     ON e.especialidad_id = a.especialidad_id 
                   JOIN [JOINEANDO_ANDO].medicos m 
                     ON m.medico_id = a.medico_id 
                   JOIN [JOINEANDO_ANDO].usuarios u 
                     ON u.usuario_id = m.medico_id 
                   JOIN [JOINEANDO_ANDO].pacientes p 
                     ON p.paciente_id = t.paciente_id 
                   JOIN [JOINEANDO_ANDO].planes pl 
                     ON pl.plan_id = p.plan_id 
            WHERE  pl.plan_id = @planid 
                   AND e.nombre_especialidad = @especialidadid 
                   AND Year(t.fecha) = @anio 
                   AND t.asistencia = 1 
                   AND Year(t.fecha) = @anio 
            GROUP  BY u.nombre + ' ' + u.apellido, 
                      Month(t.fecha), 
                      e.nombre_especialidad 
            HAVING Month(t.fecha) = @start 

            SET @start = @start + 1; 
        END 

      SELECT * 
      FROM   @out 
  END 

go 

CREATE PROCEDURE joineando_ando.Listadoafiliadosconmayorbonoscomprados 
@semestre INT, 
@anio INT 
AS 
  BEGIN 
      SET language spanish 

      DECLARE @Out TABLE 
        ( 
           "mes"                         NVARCHAR(255), 
           "posicion mensual"            INT, 
           "afiliado"                    NVARCHAR(255), 
           "numero de afiliado"          INT, 
           "cantidad de bonos comprados" INT 
        ); 
      DECLARE @end INT = 7 + 6 * ( @semestre - 1 ) 
      DECLARE @start INT = 1 + 6 * ( @semestre - 1 ) 

      WHILE ( @start < @end ) 
        BEGIN 
            INSERT INTO @Out 
            SELECT TOP 5 Datename(mm, Dateadd(mm, Month(cb.fecha_compra), -1)), 
                         Row_number() 
                           OVER ( 
                             ORDER BY Sum(cb.cantidad) DESC), 
                         u.nombre + ' ' + u.apellido, 
                         pa.numero_afiliado, 
                         Sum(cb.cantidad) 
            FROM   [JOINEANDO_ANDO].compra_bonos cb 
                   JOIN [JOINEANDO_ANDO].usuarios u 
                     ON u.usuario_id = cb.paciente_id 
                   JOIN [JOINEANDO_ANDO].pacientes pa 
                     ON pa.paciente_id = u.usuario_id 
            WHERE  Year(cb.fecha_compra) = @anio 
            GROUP  BY u.nombre + ' ' + u.apellido, 
                      Month(cb.fecha_compra), 
                      pa.numero_afiliado 
            HAVING Month(cb.fecha_compra) = @start 

            SET @start = @start + 1; 
        END 

      SELECT mes, 
             [posicion mensual], 
             afiliado, 
             [numero de afiliado], 
             joineando_ando.Cantidadfamilia([numero de afiliado]) AS 
             'Tamano grupo familiar', 
             [cantidad de bonos comprados] 
      FROM   @out 
  END 

go 

CREATE PROCEDURE joineando_ando.Listadoespecialidadesconmasbonosutilizados 
@semestre INT, 
@anio     INT 
AS 
  BEGIN 
      SET language spanish 

      DECLARE @Out TABLE 
        ( 
           "mes"                   NVARCHAR(255), 
           "posicion mensual"      INT, 
           "nombre especialidad"   NVARCHAR(255), 
           "cantidad de consultas" INT 
        ); 
      DECLARE @end INT = 7 + 6 * ( @semestre - 1 ) 
      DECLARE @start INT = 1 + 6 * ( @semestre - 1 ) 

      WHILE ( @start < @end ) 
        BEGIN 
            INSERT INTO @Out 
            SELECT TOP 5 Datename(mm, Dateadd(mm, Month(t.fecha), -1)), 
                         Row_number() 
                           OVER ( 
                             ORDER BY Count(*) DESC), 
                         e.nombre_especialidad, 
                         Count(*) 
            FROM   [JOINEANDO_ANDO].turnos t 
                   INNER JOIN [JOINEANDO_ANDO].agendas a 
                           ON a.agenda_id = t.agenda_id 
                   INNER JOIN [JOINEANDO_ANDO].especialidades e 
                           ON e.especialidad_id = a.especialidad_id 
            WHERE  t.asistencia = 1 
                   AND Year(t.fecha) = @anio 
            GROUP  BY e.nombre_especialidad, 
                      Month(t.fecha) 
            HAVING Month(t.fecha) = @start 

            SET @start = @start + 1; 
        END 

      SELECT * 
      FROM   @out 
  END 

go 

--Migracion de Datos 
INSERT INTO [JOINEANDO_ANDO].tipo_cancelaciones 
            (descripcion, 
             tipo_cancelacion_id) 
VALUES      ('Enfermedad', 
             1) 

INSERT INTO [JOINEANDO_ANDO].tipo_cancelaciones 
            (descripcion, 
             tipo_cancelacion_id) 
VALUES      ('Reprogramacion del turno', 
             2) 

INSERT INTO [JOINEANDO_ANDO].tipo_cancelaciones 
            (descripcion, 
             tipo_cancelacion_id) 
VALUES      ('Razones personales', 
             3) 

INSERT INTO [JOINEANDO_ANDO].tipo_cancelaciones 
            (descripcion, 
             tipo_cancelacion_id) 
VALUES      ('Vacaciones / Feriado', 
             4) 

INSERT INTO [JOINEANDO_ANDO].funcionabilidades 
SELECT 'Alta Rol' 
UNION ALL 
SELECT 'Modificacion Rol' 
UNION ALL 
SELECT 'Baja Rol' 
UNION ALL 
SELECT 'Alta Afiliado' 
UNION ALL 
SELECT 'Modificacion Afiliado' 
UNION ALL 
SELECT 'Baja Afiliado' 
UNION ALL 
SELECT 'Alta Agenda Profesional' 
UNION ALL 
SELECT 'Compra bonos' 
UNION ALL 
SELECT 'Pedido turnos' 
UNION ALL 
SELECT 'Cancerlar turnos' 
UNION ALL 
SELECT 'Registo de llegada' 
UNION ALL 
SELECT 'Registo de resultados' 
UNION ALL 
SELECT 'Listado Estadistico' 

go 

INSERT INTO [JOINEANDO_ANDO].rol 
SELECT 'Afiliado', 
       1 
UNION ALL 
SELECT 'Administrativo', 
       1 
UNION ALL 
SELECT 'Profesional', 
       1 
UNION ALL 
SELECT 'Admin', 
       1 

go 

INSERT INTO [JOINEANDO_ANDO].rol_funcionabilidad 
SELECT 4, 
       1 
UNION ALL 
SELECT 4, 
       2 
UNION ALL 
SELECT 4, 
       3 
UNION ALL 
SELECT 4, 
       4 
UNION ALL 
SELECT 4, 
       5 
UNION ALL 
SELECT 4, 
       6 
UNION ALL 
SELECT 4, 
       8 
UNION ALL 
SELECT 4, 
       11 
UNION ALL 
SELECT 4, 
       13 
UNION ALL 
SELECT 3, 
       10 
UNION ALL 
SELECT 3, 
       12 
UNION ALL 
SELECT 3, 
       7 
UNION ALL 
SELECT 1, 
       9 
UNION ALL 
SELECT 1, 
       10 
UNION ALL 
SELECT 2, 
       4 
UNION ALL 
SELECT 2, 
       5 
UNION ALL 
SELECT 2, 
       6 
UNION ALL 
SELECT 2, 
       8 
UNION ALL 
SELECT 2, 
       11 
UNION ALL 
SELECT 2, 
       13 

go 

INSERT INTO [JOINEANDO_ANDO].sexo 
SELECT 'Masculino' 
UNION ALL 
SELECT 'Femenino' 
UNION ALL 
SELECT 'No especificado' 

go 

INSERT INTO [JOINEANDO_ANDO].dias_semana 
SELECT 'Lunes' 
UNION ALL 
SELECT 'Martes' 
UNION ALL 
SELECT 'Miercoles' 
UNION ALL 
SELECT 'Jueves' 
UNION ALL 
SELECT 'Viernes' 
UNION ALL 
SELECT 'Sabado' 

go 

INSERT INTO [JOINEANDO_ANDO].tipo_documento 
SELECT 'DNI' 
UNION ALL 
SELECT 'Libreta Civica' 
UNION ALL 
SELECT 'Pasaporte' 
UNION ALL 
SELECT 'Otro' 

go 

INSERT INTO [JOINEANDO_ANDO].tipo_especialidad 
SELECT DISTINCT [tipo_especialidad_codigo], 
                [tipo_especialidad_descripcion] 
FROM   [gd_esquema].maestra 
WHERE  tipo_especialidad_codigo IS NOT NULL 

go 

INSERT INTO [JOINEANDO_ANDO].especialidades 
SELECT DISTINCT [especialidad_codigo], 
                [especialidad_descripcion], 
                [tipo_especialidad_codigo] 
FROM   [gd_esquema].maestra 
WHERE  especialidad_codigo IS NOT NULL 

go 

INSERT INTO [JOINEANDO_ANDO].planes 
SELECT DISTINCT [plan_med_codigo], 
                [plan_med_descripcion], 
                [plan_med_precio_bono_consulta], 
                [plan_med_precio_bono_farmacia] 
FROM   [gd_esquema].maestra 
WHERE  plan_med_codigo IS NOT NULL 

go 

--Medicos 
INSERT INTO [JOINEANDO_ANDO].usuarios 
SELECT DISTINCT [medico_nombre], 
                [medico_apellido], 
                [medico_dni], 
                1, 
                [medico_direccion], 
                [medico_telefono], 
                [medico_mail], 
                [medico_fecha_nac], 
                NULL, 
                [medico_nombre] + '.' + [medico_apellido], 
                Hashbytes('SHA2_256', '123456'), 
                1, 
                0 
FROM   [gd_esquema].maestra 
WHERE  medico_nombre IS NOT NULL 

go 

INSERT INTO [JOINEANDO_ANDO].medicos 
SELECT DISTINCT U.usuario_id, 
                555 
FROM   joineando_ando.usuarios AS U 
       INNER JOIN gd_esquema.maestra AS M 
               ON ( U.nombre = M.medico_nombre ) 
                  AND ( u.apellido = M.medico_apellido ) 
                  AND ( u.numero_documento = m.medico_dni ) 

go 

INSERT INTO [JOINEANDO_ANDO].medico_especialidad 
SELECT DISTINCT u.usuario_id, 
                E.especialidad_id 
FROM   [JOINEANDO_ANDO].especialidades AS E, 
       [JOINEANDO_ANDO].usuarios AS U 
       INNER JOIN [gd_esquema].maestra AS M 
               ON ( u.nombre = m.medico_nombre ) 
                  AND ( U.apellido = m.medico_apellido ) 
WHERE  ( E.especialidad_id = M.especialidad_codigo ) 

go 

INSERT INTO [JOINEANDO_ANDO].agendas 
SELECT DISTINCT e.medico_id, 
                e.especialidad_id 
FROM   gd_esquema.maestra ma, 
       joineando_ando.usuarios u, 
       joineando_ando.medico_especialidad e 
WHERE  ma.medico_dni = u.numero_documento 
       AND u.usuario_id = e.medico_id 

go 

-- Pacientes 
INSERT INTO [JOINEANDO_ANDO].usuarios 
SELECT DISTINCT [paciente_nombre], 
                [paciente_apellido], 
                [paciente_dni], 
                1, 
                [paciente_direccion], 
                [paciente_telefono], 
                [paciente_mail], 
                [paciente_fecha_nac], 
                NULL, 
                [paciente_nombre] + '.' + [paciente_apellido], 
                Hashbytes('SHA2_256', '123456'), 
                1, 
                0 
FROM   [gd_esquema].maestra 
WHERE  paciente_nombre IS NOT NULL 

go 

INSERT INTO [JOINEANDO_ANDO].pacientes 
SELECT DISTINCT U.usuario_id, 
                NULL, 
                0, 
                ( ( U.usuario_id ) * 100 + 1 ), 
                M.plan_med_codigo 
FROM   (joineando_ando.usuarios AS U 
        INNER JOIN gd_esquema.maestra AS M 
                ON ( U.nombre = M.paciente_nombre ) 
                   AND ( U.apellido = M.paciente_apellido ) 
                   AND ( U.numero_documento = M.paciente_dni )) 

go 

INSERT INTO [JOINEANDO_ANDO].habilitados 
SELECT DISTINCT P.paciente_id, 
                1, 
                Getdate(), 
                NULL 
FROM   joineando_ando.pacientes P 

go 

SET IDENTITY_INSERT joineando_ando.turnos ON 

go 

INSERT INTO [JOINEANDO_ANDO].turnos 
            (turno_id, 
             paciente_id, 
             agenda_id, 
             fecha, 
             horario, 
             asistencia) 
SELECT DISTINCT M.turno_numero, 
                u.usuario_id, 
                a.agenda_id, 
              
                Format(turno_fecha, 'yyyy-MM-dd'), 
              
                RIGHT(turno_fecha, 7), 
                1 
FROM   gd_esquema.maestra m 
       INNER JOIN joineando_ando.usuarios U 
               ON m.paciente_dni = u.numero_documento 
       INNER JOIN joineando_ando.usuarios u2 
               ON u2.numero_documento = m.medico_dni 
       INNER JOIN joineando_ando.medicos med 
               ON u2.usuario_id = med.medico_id 
       INNER JOIN joineando_ando.agendas a 
               ON med.medico_id = a.medico_id 
       INNER JOIN joineando_ando.especialidades es 
               ON es.especialidad_id = a.especialidad_id 
WHERE  ( m.turno_numero IS NOT NULL ) 
       AND ( m.bono_consulta_numero IS NULL ) 
       AND m.especialidad_descripcion = es.nombre_especialidad 

go 

SET IDENTITY_INSERT joineando_ando.turnos OFF 

go 

INSERT INTO [JOINEANDO_ANDO].hist_cambios 
SELECT DISTINCT paciente_id, 
                'Migracion de usuario', 
                Getdate() 
FROM   joineando_ando.pacientes 

go 

INSERT INTO [JOINEANDO_ANDO].compra_bonos 
SELECT DISTINCT u.usuario_id, 
                Pl.precio_bono_consulta, 
                1, 
                M.compra_bono_fecha 
FROM   gd_esquema.maestra M, 
       joineando_ando.planes Pl, 
       joineando_ando.usuarios u 
WHERE  M.plan_med_codigo = Pl.plan_id 
       AND M.compra_bono_fecha IS NOT NULL 
       AND m.paciente_dni = u.numero_documento 

go 

SET IDENTITY_INSERT joineando_ando.bonos ON 

go 

INSERT INTO [JOINEANDO_ANDO].bonos 
            (bono_id, 
             plan_id, 
             numero_consulta_medica, 
             fecha_impresion, 
             numero_afiliado, 
             compra_id) 
SELECT DISTINCT M.bono_consulta_numero, 
                Pl.plan_id, 
                0, 
                M.bono_consulta_fecha_impresion, 
                ( u.usuario_id * 100 ) + 1, 
                c.compra_id 
FROM   gd_esquema.maestra M 
       INNER JOIN joineando_ando.usuarios u 
               ON m.paciente_dni = u.numero_documento 
       INNER JOIN joineando_ando.pacientes pa 
               ON u.usuario_id = pa.paciente_id 
       INNER JOIN joineando_ando.planes pl 
               ON pa.plan_id = pl.plan_id 
       INNER JOIN joineando_ando.compra_bonos c 
               ON ( pa.paciente_id = c.paciente_id 
                    AND c.fecha_compra = m.compra_bono_fecha ) 
WHERE  m.bono_consulta_numero IS NOT NULL 

go 

SET IDENTITY_INSERT joineando_ando.bonos OFF 

go 

INSERT INTO [JOINEANDO_ANDO].consulta_medica 
            (turno_id, 
             bono_id, 
             horario_llegada, 
             horario_atencion) 
SELECT m.turno_numero, 
       M.bono_consulta_numero, 
       ( CONVERT(DATETIME, m.turno_fecha, 108) ), 
       ( CONVERT(DATETIME, m.turno_fecha, 108) ) 
FROM   gd_esquema.maestra M 
WHERE  m.turno_numero IS NOT NULL 
       AND m.bono_consulta_numero IS NOT NULL 

go 

INSERT INTO joineando_ando.resultados 
            (consulta_medica_id, 
             enfermedad) 
SELECT cm.consulta_medica_id, 
       m.consulta_enfermedades 
FROM   gd_esquema.maestra m 
       INNER JOIN joineando_ando.consulta_medica cm 
               ON m.turno_numero = cm.turno_id 
WHERE  ( m.turno_numero IS NOT NULL ) 
       AND ( m.bono_consulta_numero IS NOT NULL ) 

go 

INSERT INTO joineando_ando.sintomas 
            (resultado_id, 
             descripcion) 
SELECT r.resultado_id, 
       m.consulta_sintomas 
FROM   joineando_ando.resultados r 
       INNER JOIN joineando_ando.consulta_medica cm 
               ON r.consulta_medica_id = cm.consulta_medica_id 
       INNER JOIN gd_esquema.maestra m 
               ON cm.turno_id = m.turno_numero 

go 

INSERT INTO [JOINEANDO_ANDO].usuario_rol 
SELECT usuario_id, 
       2 
FROM   joineando_ando.usuarios 
WHERE  usuarios.nombre_usuario = 'Admin' 

go 

INSERT INTO [JOINEANDO_ANDO].usuario_rol 
SELECT paciente_id, 
       1 
FROM   [JOINEANDO_ANDO].pacientes 

go 

INSERT INTO [JOINEANDO_ANDO].usuario_rol 
SELECT medico_id, 
       3 
FROM   [JOINEANDO_ANDO].medicos 

go 

-- Constraints 
ALTER TABLE [JOINEANDO_ANDO].[agendas] 
  ADD CONSTRAINT [PK_Agendas] PRIMARY KEY CLUSTERED ( [agenda_id] ASC )WITH ( 
  pad_index = OFF, statistics_norecompute = OFF, ignore_dup_key = OFF, 
  allow_row_locks = on, allow_page_locks = on) ON [PRIMARY] 

go 

ALTER TABLE [JOINEANDO_ANDO].[bonos] 
  ADD CONSTRAINT [PK_Bonos] PRIMARY KEY CLUSTERED ( [bono_id] ASC )WITH ( 
  pad_index = OFF, statistics_norecompute = OFF, ignore_dup_key = OFF, 
  allow_row_locks = on, allow_page_locks = on) ON [PRIMARY] 

go 

ALTER TABLE [JOINEANDO_ANDO].[compra_bonos] 
  ADD CONSTRAINT [PK_Compra_Bonos] PRIMARY KEY CLUSTERED ( [compra_id] ASC )WITH 
  (pad_index = OFF, statistics_norecompute = OFF, ignore_dup_key = OFF, 
  allow_row_locks = on, allow_page_locks = on) ON [PRIMARY] 

go 

ALTER TABLE [JOINEANDO_ANDO].[consulta_medica] 
  ADD CONSTRAINT [PK_Consulta_Medica] PRIMARY KEY CLUSTERED ( 
  [consulta_medica_id] ASC )WITH (pad_index = OFF, statistics_norecompute = OFF, 
  ignore_dup_key = OFF, allow_row_locks = on, allow_page_locks = on) ON 
  [PRIMARY] 

go 

ALTER TABLE [JOINEANDO_ANDO].[especialidades] 
  ADD CONSTRAINT [PK_Especialidades] PRIMARY KEY CLUSTERED ( [especialidad_id] 
  ASC )WITH (pad_index = OFF, statistics_norecompute = OFF, ignore_dup_key = OFF 
  , allow_row_locks = on, allow_page_locks = on) ON [PRIMARY] 

go 

ALTER TABLE [JOINEANDO_ANDO].[funcionabilidades] 
  ADD CONSTRAINT [PK_Funcionabilidades] PRIMARY KEY CLUSTERED ( 
  [funcionabilidad_id] ASC )WITH (pad_index = OFF, statistics_norecompute = OFF, 
  ignore_dup_key = OFF, allow_row_locks = on, allow_page_locks = on) ON 
  [PRIMARY] 

go 

ALTER TABLE [JOINEANDO_ANDO].[medicos] 
  ADD CONSTRAINT [PK_Medicos] PRIMARY KEY CLUSTERED ( [medico_id] ASC )WITH ( 
  pad_index = OFF, statistics_norecompute = OFF, ignore_dup_key = OFF, 
  allow_row_locks = on, allow_page_locks = on) ON [PRIMARY] 

go 

ALTER TABLE [JOINEANDO_ANDO].[pacientes] 
  ADD CONSTRAINT [PK_Pacientes] PRIMARY KEY CLUSTERED ( [paciente_id] ASC )WITH 
  (pad_index = OFF, statistics_norecompute = OFF, ignore_dup_key = OFF, 
  allow_row_locks = on, allow_page_locks = on) ON [PRIMARY] 

go 

ALTER TABLE [JOINEANDO_ANDO].[planes] 
  ADD CONSTRAINT [PK_Planes] PRIMARY KEY CLUSTERED ( [plan_id] ASC )WITH ( 
  pad_index = OFF, statistics_norecompute = OFF, ignore_dup_key = OFF, 
  allow_row_locks = on, allow_page_locks = on) ON [PRIMARY] 

go 

ALTER TABLE [JOINEANDO_ANDO].[resultados] 
  ADD CONSTRAINT [PK_Resultados] PRIMARY KEY CLUSTERED ( [resultado_id] ASC ) 
  WITH (pad_index = OFF, statistics_norecompute = OFF, ignore_dup_key = OFF, 
  allow_row_locks = on, allow_page_locks = on) ON [PRIMARY] 

go 

ALTER TABLE [JOINEANDO_ANDO].[sintomas] 
  ADD CONSTRAINT [PK_Sintomas] PRIMARY KEY CLUSTERED ( [sintoma_id] ASC )WITH ( 
  pad_index = OFF, statistics_norecompute = OFF, ignore_dup_key = OFF, 
  allow_row_locks = on, allow_page_locks = on) ON [PRIMARY] 

go 

ALTER TABLE [JOINEANDO_ANDO].[rol] 
  ADD CONSTRAINT [PK_Rol] PRIMARY KEY CLUSTERED ( [rol_id] ASC )WITH (pad_index 
  = OFF, statistics_norecompute = OFF, ignore_dup_key = OFF, allow_row_locks = 
  on, allow_page_locks = on) ON [PRIMARY] 

go 

ALTER TABLE [JOINEANDO_ANDO].[tipo_documento] 
  ADD CONSTRAINT [PK_Tipo_Documento_id] PRIMARY KEY CLUSTERED ( 
  [tipo_documento_id] ASC )WITH (pad_index = OFF, statistics_norecompute = OFF, 
  ignore_dup_key = OFF, allow_row_locks = on, allow_page_locks = on) ON 
  [PRIMARY] 

go 

ALTER TABLE [JOINEANDO_ANDO].[tipo_especialidad] 
  ADD CONSTRAINT [PK_Tipo_Especialidad] PRIMARY KEY CLUSTERED ( 
  [tipo_especialidad_id] ASC )WITH (pad_index = OFF, statistics_norecompute = 
  OFF, ignore_dup_key = OFF, allow_row_locks = on, allow_page_locks = on) ON 
  [PRIMARY] 

go 

ALTER TABLE [JOINEANDO_ANDO].[turnos] 
  ADD CONSTRAINT [PK_Turnos] PRIMARY KEY CLUSTERED ( [turno_id] ASC )WITH ( 
  pad_index = OFF, statistics_norecompute = OFF, ignore_dup_key = OFF, 
  allow_row_locks = on, allow_page_locks = on) ON [PRIMARY] 

go 

ALTER TABLE [JOINEANDO_ANDO].[usuarios] 
  ADD CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED ( [usuario_id] ASC )WITH ( 
  pad_index = OFF, statistics_norecompute = OFF, ignore_dup_key = OFF, 
  allow_row_locks = on, allow_page_locks = on) ON [PRIMARY] 

go 

ALTER TABLE [JOINEANDO_ANDO].[sexo] 
  ADD CONSTRAINT [Sexo_id] PRIMARY KEY CLUSTERED ( [sexo_id] ASC )WITH ( 
  pad_index = OFF, statistics_norecompute = OFF, ignore_dup_key = OFF, 
  allow_row_locks = on, allow_page_locks = on) ON [PRIMARY] 

go 

ALTER TABLE [JOINEANDO_ANDO].[dias_semana] 
  ADD CONSTRAINT [Dia_Semana_id] PRIMARY KEY CLUSTERED ( [dia_semana_id] ASC ) 
  WITH (pad_index = OFF, statistics_norecompute = OFF, ignore_dup_key = OFF, 
  allow_row_locks = on, allow_page_locks = on) ON [PRIMARY] 

go 

ALTER TABLE [JOINEANDO_ANDO].[cancelaciones] 
  ADD CONSTRAINT [cancelacion_id] PRIMARY KEY CLUSTERED ( [cancelacion_id] ASC ) 
  WITH (pad_index = OFF, statistics_norecompute = OFF, ignore_dup_key = OFF, 
  allow_row_locks = on, allow_page_locks = on) ON [PRIMARY] 

go 

ALTER TABLE [JOINEANDO_ANDO].[tipo_cancelaciones] 
  ADD CONSTRAINT [Tipo_Cancelacion_id] PRIMARY KEY CLUSTERED ( 
  [tipo_cancelacion_id] ASC )WITH (pad_index = OFF, statistics_norecompute = OFF 
  , ignore_dup_key = OFF, allow_row_locks = on, allow_page_locks = on) ON 
  [PRIMARY] 

go 


-- FK 
ALTER TABLE [JOINEANDO_ANDO].[agendas] 
  WITH CHECK ADD CONSTRAINT [FK_Agendas_Especialidades] FOREIGN KEY( 
  [especialidad_id]) REFERENCES [JOINEANDO_ANDO].[especialidades] ( 
  [especialidad_id]) 

go 

ALTER TABLE [JOINEANDO_ANDO].[agendas] 
  CHECK CONSTRAINT [FK_Agendas_Especialidades] 

go 

ALTER TABLE [JOINEANDO_ANDO].[agendas] 
  WITH CHECK ADD CONSTRAINT [FK_Agendas_Medicos] FOREIGN KEY([medico_id]) 
  REFERENCES [JOINEANDO_ANDO].[medicos] ([medico_id]) 

go 

ALTER TABLE [JOINEANDO_ANDO].[agendas] 
  CHECK CONSTRAINT [FK_Agendas_Medicos] 

go 

ALTER TABLE [JOINEANDO_ANDO].[dias_atencion] 
  WITH CHECK ADD CONSTRAINT [FK_Agenda_id] FOREIGN KEY([agenda_id]) REFERENCES 
  [JOINEANDO_ANDO].[agendas] ([agenda_id]) 

go 

ALTER TABLE [JOINEANDO_ANDO].[dias_atencion] 
  CHECK CONSTRAINT [FK_Agenda_id] 

go 

ALTER TABLE [JOINEANDO_ANDO].[dias_atencion] 
  WITH CHECK ADD CONSTRAINT [FK_Dia_id] FOREIGN KEY([dia_id]) REFERENCES 
  [JOINEANDO_ANDO].[dias_semana] ([dia_semana_id]) 

go 

ALTER TABLE [JOINEANDO_ANDO].[bonos] 
  WITH CHECK ADD CONSTRAINT [FK_Bonos_Planes] FOREIGN KEY([plan_id]) REFERENCES 
  [JOINEANDO_ANDO].[planes] ([plan_id]) 

go 

ALTER TABLE [JOINEANDO_ANDO].[bonos] 
  CHECK CONSTRAINT [FK_Bonos_Planes] 

go 

ALTER TABLE [JOINEANDO_ANDO].[bonos] 
  WITH CHECK ADD CONSTRAINT [FK_compra_bono_id] FOREIGN KEY([compra_id]) 
  REFERENCES [JOINEANDO_ANDO].[compra_bonos]([compra_id]) 

go 

ALTER TABLE [JOINEANDO_ANDO].[bonos] 
  CHECK CONSTRAINT [FK_compra_bono_id] 

go 

ALTER TABLE [JOINEANDO_ANDO].[turnos] 
  WITH CHECK ADD CONSTRAINT [FK_Cancelacion_id] FOREIGN KEY([cancelacion_id]) 
  REFERENCES [JOINEANDO_ANDO].[cancelaciones] ([cancelacion_id]) 

go 

ALTER TABLE [JOINEANDO_ANDO].[turnos] 
  CHECK CONSTRAINT [FK_Cancelacion_id] 

go 

ALTER TABLE [JOINEANDO_ANDO].[cancelaciones] 
  WITH CHECK ADD CONSTRAINT [FK_Tipo_Cancelacion] FOREIGN KEY([tipo]) REFERENCES 
  [JOINEANDO_ANDO].[tipo_cancelaciones] ([tipo_cancelacion_id]) 

go 

ALTER TABLE [JOINEANDO_ANDO].[cancelaciones] 
  CHECK CONSTRAINT [FK_Tipo_Cancelacion] 

go 

ALTER TABLE [JOINEANDO_ANDO].[consulta_medica] 
  WITH CHECK ADD CONSTRAINT [FK_Consulta_Medica_Bonos] FOREIGN KEY([bono_id]) 
  REFERENCES [JOINEANDO_ANDO].[bonos] ([bono_id]) 

go 

ALTER TABLE [JOINEANDO_ANDO].[consulta_medica] 
  CHECK CONSTRAINT [FK_Consulta_Medica_Bonos] 

go 

ALTER TABLE [JOINEANDO_ANDO].[consulta_medica] 
  WITH CHECK ADD CONSTRAINT [FK_Consulta_Medica_Turnos] FOREIGN KEY([turno_id]) 
  REFERENCES [JOINEANDO_ANDO].[turnos] ([turno_id]) 

go 

ALTER TABLE [JOINEANDO_ANDO].[consulta_medica] 
  CHECK CONSTRAINT [FK_Consulta_Medica_Turnos] 

go 

ALTER TABLE [JOINEANDO_ANDO].[especialidades] 
  WITH CHECK ADD CONSTRAINT [FK_Especialidades_Tipo_Especialidad] FOREIGN KEY( 
  [tipo_especialidad_id]) REFERENCES [JOINEANDO_ANDO].[tipo_especialidad] ( 
  [tipo_especialidad_id]) 

go 

ALTER TABLE [JOINEANDO_ANDO].[especialidades] 
  CHECK CONSTRAINT [FK_Especialidades_Tipo_Especialidad] 

go 

ALTER TABLE [JOINEANDO_ANDO].[habilitados] 
  WITH CHECK ADD CONSTRAINT [FK_Habilitados_Pacientes] FOREIGN KEY([paciente_id] 
  ) REFERENCES [JOINEANDO_ANDO].[pacientes] ([paciente_id]) 

go 

ALTER TABLE [JOINEANDO_ANDO].[habilitados] 
  CHECK CONSTRAINT [FK_Habilitados_Pacientes] 

go 

ALTER TABLE [JOINEANDO_ANDO].[medico_especialidad] 
  WITH CHECK ADD CONSTRAINT [FK_Medico_Especialidad_Especialidades] FOREIGN KEY( 
  [especialidad_id]) REFERENCES [JOINEANDO_ANDO].[especialidades] ( 
  [especialidad_id]) 

go 

ALTER TABLE [JOINEANDO_ANDO].[medico_especialidad] 
  CHECK CONSTRAINT [FK_Medico_Especialidad_Especialidades] 

go 

ALTER TABLE [JOINEANDO_ANDO].[medico_especialidad] 
  WITH CHECK ADD CONSTRAINT [FK_Medico_Especialidad_Medicos] FOREIGN KEY( 
  [medico_id]) REFERENCES [JOINEANDO_ANDO].[medicos] ([medico_id]) 

go 

ALTER TABLE [JOINEANDO_ANDO].[medico_especialidad] 
  CHECK CONSTRAINT [FK_Medico_Especialidad_Medicos] 

go 

ALTER TABLE [JOINEANDO_ANDO].[medicos] 
  WITH CHECK ADD CONSTRAINT [FK_Medicos_Usuarios] FOREIGN KEY([medico_id]) 
  REFERENCES [JOINEANDO_ANDO].[usuarios] ([usuario_id]) 

go 

ALTER TABLE [JOINEANDO_ANDO].[medicos] 
  CHECK CONSTRAINT [FK_Medicos_Usuarios] 

go 

ALTER TABLE [JOINEANDO_ANDO].[pacientes] 
  WITH CHECK ADD CONSTRAINT [FK_Pacientes_Planes] FOREIGN KEY([plan_id]) 
  REFERENCES [JOINEANDO_ANDO].[planes] ([plan_id]) 

go 

ALTER TABLE [JOINEANDO_ANDO].[pacientes] 
  CHECK CONSTRAINT [FK_Pacientes_Planes] 

go 

ALTER TABLE [JOINEANDO_ANDO].[pacientes] 
  WITH CHECK ADD CONSTRAINT [FK_Pacientes_Usuarios] FOREIGN KEY([paciente_id]) 
  REFERENCES [JOINEANDO_ANDO].[usuarios] ([usuario_id]) 

go 

ALTER TABLE [JOINEANDO_ANDO].[pacientes] 
  CHECK CONSTRAINT [FK_Pacientes_Usuarios] 

go 

ALTER TABLE [JOINEANDO_ANDO].[resultados] 
  WITH CHECK ADD CONSTRAINT [FK_Resultados_Consulta_Medica] FOREIGN KEY( 
  [consulta_medica_id]) REFERENCES [JOINEANDO_ANDO].[consulta_medica] ( 
  [consulta_medica_id]) 

go 

ALTER TABLE [JOINEANDO_ANDO].[resultados] 
  CHECK CONSTRAINT [FK_Resultados_Consulta_Medica] 

go 

ALTER TABLE [JOINEANDO_ANDO].[sintomas] 
  WITH CHECK ADD CONSTRAINT [FK_Resultado_id] FOREIGN KEY ([resultado_id]) 
  REFERENCES [JOINEANDO_ANDO].[resultados] ([resultado_id]) 

go 

ALTER TABLE [JOINEANDO_ANDO].[sintomas] 
  CHECK CONSTRAINT [FK_Resultado_id] 

go 

ALTER TABLE [JOINEANDO_ANDO].[rol_funcionabilidad] 
  WITH CHECK ADD CONSTRAINT [FK_Rol_Funcionabilidad_Funcionabilidades] FOREIGN 
  KEY([funcionabilidad_id]) REFERENCES [JOINEANDO_ANDO].[funcionabilidades] ( 
  [funcionabilidad_id]) 

go 

ALTER TABLE [JOINEANDO_ANDO].[rol_funcionabilidad] 
  CHECK CONSTRAINT [FK_Rol_Funcionabilidad_Funcionabilidades] 

go 

ALTER TABLE [JOINEANDO_ANDO].[rol_funcionabilidad] 
  WITH CHECK ADD CONSTRAINT [FK_Rol_Funcionabilidad_Rol] FOREIGN KEY([rol_id]) 
  REFERENCES [JOINEANDO_ANDO].[rol] ([rol_id]) 

go 

ALTER TABLE [JOINEANDO_ANDO].[rol_funcionabilidad] 
  CHECK CONSTRAINT [FK_Rol_Funcionabilidad_Rol] 

go 

ALTER TABLE [JOINEANDO_ANDO].[turnos] 
  WITH CHECK ADD CONSTRAINT [FK_Turnos_Agendas] FOREIGN KEY([agenda_id]) 
  REFERENCES [JOINEANDO_ANDO].[agendas] ([agenda_id]) 

go 

ALTER TABLE [JOINEANDO_ANDO].[turnos] 
  CHECK CONSTRAINT [FK_Turnos_Agendas] 

go 

ALTER TABLE [JOINEANDO_ANDO].[turnos] 
  WITH CHECK ADD CONSTRAINT [FK_Turnos_Pacientes] FOREIGN KEY([paciente_id]) 
  REFERENCES [JOINEANDO_ANDO].[pacientes] ([paciente_id]) 

go 

ALTER TABLE [JOINEANDO_ANDO].[turnos] 
  CHECK CONSTRAINT [FK_Turnos_Pacientes] 

go 

ALTER TABLE [JOINEANDO_ANDO].[usuario_rol] 
  WITH CHECK ADD CONSTRAINT [FK_Usuario_Rol_Rol] FOREIGN KEY([rol_id]) 
  REFERENCES [JOINEANDO_ANDO].[rol] ([rol_id]) 

go 

ALTER TABLE [JOINEANDO_ANDO].[usuario_rol] 
  CHECK CONSTRAINT [FK_Usuario_Rol_Rol] 

go 

ALTER TABLE [JOINEANDO_ANDO].[usuario_rol] 
  WITH CHECK ADD CONSTRAINT [FK_Usuario_Rol_Usuarios] FOREIGN KEY([usuario_id]) 
  REFERENCES [JOINEANDO_ANDO].[usuarios] ([usuario_id]) 

go 

ALTER TABLE [JOINEANDO_ANDO].[usuario_rol] 
  CHECK CONSTRAINT [FK_Usuario_Rol_Usuarios] 

go 

ALTER TABLE [JOINEANDO_ANDO].[usuarios] 
  WITH CHECK ADD CONSTRAINT [FK_Usuarios_Tipo_Documento] FOREIGN KEY( 
  [tipo_documento_id]) REFERENCES [JOINEANDO_ANDO].[tipo_documento] ( 
  [tipo_documento_id]) 

go 

ALTER TABLE [JOINEANDO_ANDO].[usuarios] 
  CHECK CONSTRAINT [FK_Usuarios_Tipo_Documento] 

go 

ALTER TABLE [JOINEANDO_ANDO].[usuarios] 
  WITH CHECK ADD CONSTRAINT [FK_Usuarios_Sexo] FOREIGN KEY([sexo_id]) REFERENCES 
  [JOINEANDO_ANDO].[sexo] ([sexo_id]) 

go 

ALTER TABLE [JOINEANDO_ANDO].[compra_bonos] 
  WITH CHECK ADD CONSTRAINT [FK_compra_bono_paciente_id] FOREIGN KEY( 
  [paciente_id]) REFERENCES [JOINEANDO_ANDO].[pacientes] ([paciente_id]) 

go 

ALTER TABLE [JOINEANDO_ANDO].[hist_cambios] 
  WITH CHECK ADD CONSTRAINT [FK_Paciente_id] FOREIGN KEY([paciente_id]) 
  REFERENCES [JOINEANDO_ANDO].[pacientes] ([paciente_id]) 

go 

--Datos usuarios
DECLARE @rol NVARCHAR(50); 
DECLARE @funcionabilidad NVARCHAR(50); 

BEGIN 
    INSERT INTO [JOINEANDO_ANDO].usuarios 
    SELECT 'asd', 
           '123', 
           123, 
           1, 
           89, 
           98, 
           'asd', 
           '4/4/1988', 
           NULL, 
           'admin', 
           Hashbytes('SHA2_256', 'w23e'), 
           1, 
           0 
    WHERE  NOT EXISTS (SELECT * 
                       FROM   joineando_ando.usuarios 
                       WHERE  nombre_usuario = 'admin') 

    INSERT INTO [JOINEANDO_ANDO].usuario_rol 
    SELECT (SELECT TOP 1 usuario_id 
            FROM   joineando_ando.usuarios 
            WHERE  nombre_usuario = 'admin'), 
           (SELECT TOP 1 rol_id 
            FROM   joineando_ando.rol 
            WHERE  nombre = 'Admin') 
    WHERE  NOT EXISTS (SELECT TOP 1 * 
                       FROM   [JOINEANDO_ANDO].usuario_rol 
                       WHERE  usuario_id = (SELECT TOP 1 usuario_id 
                                            FROM   joineando_ando.usuarios 
                                            WHERE  nombre_usuario = 'admin') 
                              AND rol_id = (SELECT TOP 1 rol_id 
                                            FROM   joineando_ando.rol 
                                            WHERE  nombre = 'Admin')) 

    INSERT INTO [JOINEANDO_ANDO].usuarios 
    SELECT 'asd', 
           '123', 
           123, 
           1, 
           89, 
           98, 
           'asd', 
           '4/4/1988', 
           NULL, 
           'administrativo', 
           Hashbytes('SHA2_256', '123456'), 
           1, 
           0 
    WHERE  NOT EXISTS (SELECT * 
                       FROM   joineando_ando.usuarios 
                       WHERE  nombre_usuario = 'administrativo') 

    INSERT INTO [JOINEANDO_ANDO].usuario_rol 
    SELECT (SELECT TOP 1 usuario_id 
            FROM   joineando_ando.usuarios 
            WHERE  nombre_usuario = 'administrativo'), 
           (SELECT TOP 1 rol_id 
            FROM   joineando_ando.rol 
            WHERE  nombre = 'Administrativo') 
    WHERE  NOT EXISTS (SELECT TOP 1 * 
                       FROM   [JOINEANDO_ANDO].usuario_rol 
                       WHERE  usuario_id = (SELECT TOP 1 usuario_id 
                                            FROM   joineando_ando.usuarios 
                                            WHERE 
                              nombre_usuario = 'administrativo' 
                                           ) 
                              AND rol_id = (SELECT TOP 1 rol_id 
                                            FROM   joineando_ando.rol 
                                            WHERE  nombre = 'Administrativo')) 
END 

go 



-- AGREGO UNA AGENDA CON DISPONIBILIDAD HORARIA PARA PODER PROBAR TURNOS
INSERT INTO joineando_ando.medico_especialidad 
            (medico_id, 
             especialidad_id) 
VALUES      (10000, 
             9999) 

go 

INSERT INTO joineando_ando.agendas 
            (medico_id, 
             especialidad_id) 
VALUES      (10000, 
             9999) 


/*
Si desean probar con una agenda con horario descomentar esta zona

DECLARE @Agenda_Id INT 

SET @Agenda_Id = @@IDENTITY 

INSERT INTO joineando_ando.dias_atencion 
            (agenda_id, 
             dia_id, 
             inicio_horario, 
             fin_horario) 
VALUES      (@Agenda_Id, 
             1, 
             '08:00:00', 
             '14:00:00' ) 

INSERT INTO joineando_ando.dias_atencion 
            (agenda_id, 
             dia_id, 
             inicio_horario, 
             fin_horario) 
VALUES      (@Agenda_Id, 
             4, 
             '08:00:00', 
             '13:00:00') 

INSERT INTO joineando_ando.dias_atencion 
            (agenda_id, 
             dia_id, 
             inicio_horario, 
             fin_horario) 
VALUES      (@Agenda_Id, 
             5, 
             '08:00:00', 
             '16:00:00') 

*/