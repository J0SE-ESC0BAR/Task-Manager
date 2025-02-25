CREATE DATABASE [TaskControlCenter];
GO
USE TaskControlCenter;
GO
-- Tabla Estudiante
CREATE TABLE Estudiante (
	Carnet VARCHAR(20),
	Carrera VARCHAR(15),
	Celular VARCHAR(15),
	Correo VARCHAR(20),
	Creado DATE,
	DeBaja DATE,
	Descripcion VARCHAR(100),
	Direccion VARCHAR(100),
	Edad INT,
	Id_Estudiante INT IDENTITY(1, 1) PRIMARY KEY,
	Nombre VARCHAR(50),
	Universidad VARCHAR(50),
	Contraseña VARCHAR(50)
);
-- Tabla Tutor
CREATE TABLE Tutor (
    Celular VARCHAR(15),
    Correo VARCHAR(20),
    Creado DATE,
    DeBaja DATE,
    Descripcion VARCHAR(100),
	Direccion VARCHAR(100),
	Edad INT,
    Id_Tutor INT IDENTITY(1, 1) PRIMARY KEY,
    Nombre VARCHAR(50)
);
-- Tabla Grupo
CREATE TABLE Grupo (
    Id_Grupo INT IDENTITY(1, 1) PRIMARY KEY,
    Nombre VARCHAR(50),
    Materia VARCHAR(50),
    Creado DATE,
    Terminado DATE
);
-- Tabla Tarea
CREATE TABLE Tarea (
    Id_Tarea INT IDENTITY(1, 1) PRIMARY KEY,
    Id_Estudiante INT,
    Id_Tutor INT,
    Tema VARCHAR(50),
    Descripcion VARCHAR(100),
    Asignado DATETIME,
    Vencimiento DATETIME,
    Iniciado DATETIME,
    Finalizado DATETIME,
    Entregado DATETIME,
    Horas DECIMAL(3, 2),
    Calificacion TINYINT CHECK (Calificacion <= 10),
    Cancelado BIT,
	EntregarPortal BIT,
    FOREIGN KEY (Id_Estudiante) REFERENCES Estudiante(Id_Estudiante),
    FOREIGN KEY (Id_Tutor) REFERENCES Tutor(Id_Tutor)
);
-- Tabla GrupoEstudiante (relación muchos a muchos)
CREATE TABLE GrupoEstudiante (
    ID_Grupo INT,
    ID_Estudiante INT,
    Agregado DATE,
    DeBaja DATE,
    Descripcion VARCHAR(100),
    PRIMARY KEY (ID_Grupo, ID_Estudiante),
    FOREIGN KEY (ID_Grupo) REFERENCES Grupo(ID_Grupo),
    FOREIGN KEY (ID_Estudiante) REFERENCES Estudiante(ID_Estudiante)
);
CREATE TABLE PagoTarea (
    Id_PagoTarea INT IDENTITY(1, 1) PRIMARY KEY,
	Id_Estudiante INT,
    Id_Tarea INT,
    MetodoPago VARCHAR(50),
    Pagado DATETIME,
    Precio DECIMAL(10, 2),
	FOREIGN KEY (Id_Estudiante) REFERENCES Estudiante(Id_Estudiante),
    FOREIGN KEY (Id_Tarea) REFERENCES Tarea(Id_Tarea)
);
CREATE TABLE PagoTutor (
    Id_PagoTutor INT IDENTITY(1, 1) PRIMARY KEY,
    Id_Tutor INT,
    Id_Tarea INT,
    MetodoPago VARCHAR(50),
    Pagado DATETIME,
    Precio DECIMAL(10, 2),
    FOREIGN KEY (Id_Tutor) REFERENCES Tutor(Id_Tutor),
    FOREIGN KEY (Id_Tarea) REFERENCES Tarea(Id_Tarea)
);

--#################################################--
--#########   PROCEDIMIENTOS ALMACENADOS  #########--
--#################################################--


CREATE PROCEDURE AsignarTarea
    --Tarea
    @Id_Estudiante INT,
    @Id_Tutor INT,
    @Tema VARCHAR(50),
    @Descripcion VARCHAR(100),
    @Asignado DATETIME,
    @Vencimiento DATETIME,
    @EntregarPortal BIT,
    --PagoTarea
    @MetodoPagoTarea VARCHAR(50),
    @PagadoTarea DATETIME,
    @PrecioTarea DECIMAL(10, 2),
    --PagoTutor
    @MetodoPagoTutor VARCHAR(50),
    @PagadoTutor DATETIME,
    @PrecioTutor DECIMAL(10, 2)
AS
BEGIN
    -- Insertar datos en la tabla Tarea
    INSERT INTO Tarea (Id_Estudiante, Id_Tutor, Tema, Descripcion, Asignado, Vencimiento, EntregarPortal)
    VALUES (@Id_Estudiante, @Id_Tutor, @Tema, @Descripcion, @Asignado, @Vencimiento, @EntregarPortal);

    -- Obtener el Id_Tarea insertado
    DECLARE @Id_Tarea INT;
    SET @Id_Tarea = SCOPE_IDENTITY();

    -- Insertar datos en la tabla PagoTarea
    INSERT INTO PagoTarea (Id_Estudiante, Id_Tarea, MetodoPago, Pagado, Precio)
    VALUES (@Id_Estudiante, @Id_Tarea, @MetodoPagoTarea, @PagadoTarea, @PrecioTarea);

    -- Insertar datos en la tabla PagoTutor
    INSERT INTO PagoTutor (Id_Tutor, Id_Tarea, MetodoPago, Pagado, Precio)
    VALUES (@Id_Tutor, @Id_Tarea, @MetodoPagoTutor, @PagadoTutor, @PrecioTutor);
END

--Procedimiento almacenado que traega el id del estudiante, el nombre si la fecha de baja es null
CREATE PROCEDURE ObtenerEstudiantes
AS
BEGIN
    SELECT 
        Carnet,
        Carrera,
        Celular,
        Correo,
        Creado,
        DeBaja,
        Descripcion,
        Direccion,
        Edad,
        Id_Estudiante,
        Nombre,
        Universidad
    FROM Estudiante
    WHERE DeBaja IS NULL
END


CREATE PROCEDURE ObtenerTutores
AS
BEGIN
    SELECT Id_Tutor, Nombre
    FROM Tutor
    WHERE DeBaja IS NULL
END

CREATE PROCEDURE RegistrarEstudiante
	@Carnet VARCHAR(20),
	@Contraseña VARCHAR(50),
	@Carrera VARCHAR(50),
	@Celular VARCHAR(15),
	@Correo VARCHAR(100),
	@Creado DATE,
	@Descripcion VARCHAR(100),
	@Direccion VARCHAR(100),
	@Edad INT,
	@Nombre VARCHAR(50),
	@Universidad VARCHAR(50)
AS
BEGIN
    INSERT INTO Estudiante (Carnet,Carrera,Celular,Correo,Creado,Descripcion,Direccion,Edad,Nombre, Universidad)
    VALUES (@Carnet,@Carrera,@Celular,@Correo,@Creado,@Descripcion,@Direccion,@Edad,@Nombre, @Universidad)
END

CREATE PROCEDURE RegistrarTutor
	@Celular VARCHAR(15),
	@Correo VARCHAR(20),
	@Creado DATE,
	@Descripcion VARCHAR(100),
	@Direccion VARCHAR(100),
	@Edad INT,
	@Nombre VARCHAR(50)
AS
BEGIN
    INSERT INTO Tutor (Celular,Correo,Creado,Descripcion,Direccion,Edad,Nombre)
    VALUES (@Celular,@Correo,@Creado,@Descripcion,@Direccion,@Edad,@Nombre)
END




CREATE PROCEDURE ObtenerTareasPendientes
AS
BEGIN
    SET NOCOUNT ON;
    
    DECLARE @FechaActual AS DATE
    SET @FechaActual = GETDATE()
    
    SELECT DISTINCT T.*
    FROM Tarea T
    LEFT JOIN PagoTarea PT ON T.Id_Tarea = PT.Id_Tarea
    LEFT JOIN PagoTutor PTu ON T.Id_Tarea = PTu.Id_Tarea
    WHERE (T.Cancelado = 0 OR T.Cancelado IS NULL)
      AND (T.Vencimiento > DATEADD(DAY, -1, @FechaActual)
      AND T.Asignado >= DATEADD(DAY, -30, @FechaActual))
	  AND (T.Iniciado IS NULL OR T.Finalizado IS NULL OR T.Entregado IS NULL OR PT.Pagado IS NULL OR PTu.Pagado IS NULL)
END;

Select * from Tarea
EXEC ObtenerTareasPendientes


--Traer datos de la tabla PagoTarea
CREATE PROCEDURE ObtenerPagoTarea
AS
BEGIN
    SELECT Id_PagoTarea, Id_Estudiante, Id_Tarea, MetodoPago, Pagado, Precio
    FROM PagoTarea;
END;

--Traer datos de la tabla PagoTutor
CREATE PROCEDURE ObtenerPagoTutor
AS
BEGIN
    SELECT Id_PagoTutor, Id_Tutor, Id_Tarea, MetodoPago, Pagado, Precio
    FROM PagoTutor;
END;


CREATE PROCEDURE ActualizarTareaPendiente
    @Id_Tarea INT,
    @Iniciado DATETIME,
    @Finalizado DATETIME,
    @Entregado DATETIME,
    @Horas DECIMAL(3, 2)
AS
BEGIN
    -- Actualizar tabla Tarea
    UPDATE Tarea
    SET Iniciado = @Iniciado,
        Finalizado = @Finalizado,
        Entregado = @Entregado,
        Horas = @Horas
    WHERE Id_Tarea = @Id_Tarea;
END;

CREATE PROCEDURE ActualizarPagoTarea
    @Id_PagoTarea INT,
    @Pagado DATETIME
AS
BEGIN
    -- Actualizar tabla PagoTarea
    UPDATE PagoTarea
    SET Pagado = @Pagado
    WHERE Id_PagoTarea = @Id_PagoTarea;
END;

CREATE PROCEDURE ActualizarPagoTutor
    @Id_PagoTutor INT,
    @Pagado DATETIME
AS
BEGIN
    -- Actualizar tabla PagoTutor
    UPDATE PagoTutor
    SET Pagado = @Pagado
    WHERE Id_PagoTutor = @Id_PagoTutor;
END;

CREATE PROCEDURE EliminarTareaYPagos
    @Id_Tarea INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Eliminar PagoTutor asociado a la tarea
    DELETE FROM PagoTutor
    WHERE Id_Tarea = @Id_Tarea;

    -- Eliminar PagoTarea asociado a la tarea
    DELETE FROM PagoTarea
    WHERE Id_Tarea = @Id_Tarea;

    -- Eliminar la tarea
    DELETE FROM Tarea
    WHERE Id_Tarea = @Id_Tarea;
END;


CREATE PROCEDURE CancelarTarea
    @Id_Tarea INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Actualizar el campo "Cancelado" a 1 (verdadero) para la tarea especificada
    UPDATE Tarea
    SET Cancelado = 1
    WHERE Id_Tarea = @Id_Tarea;
END;

--Consultar la contraseña solo con el id
CREATE PROCEDURE ConsultarContraseña
    @Id_Estudiante INT
AS
BEGIN
    SELECT Contraseña
    FROM Estudiante
    WHERE Id_Estudiante = @Id_Estudiante;
END;

--################### Otras cosas variadas ##################

Select * From Estudiante
Select * From Tutor
Select * From Grupo
Select * From Tarea
Select * From GrupoEstudiante
Select * From PagoTarea
Select * From PagoTutor

EXEC ObtenerTareasPendientes
	-- Eliminar todos los registros de la tabla
DELETE FROM PagoTarea;
DELETE FROM PagoTutor;
DELETE FROM GrupoEstudiante;
DELETE FROM Tarea;
DELETE FROM Tutor;
DELETE FROM Estudiante;
DELETE FROM Grupo;
-- Resembrar la columna de identidad a 1
DBCC CHECKIDENT ('Grupo', RESEED, 0);
DBCC CHECKIDENT ('Estudiante', RESEED, 0);
DBCC CHECKIDENT ('Tutor', RESEED, 0);
DBCC CHECKIDENT ('Tarea', RESEED, 0);
DBCC CHECKIDENT ('GrupoEstudiante', RESEED, 0);
DBCC CHECKIDENT ('PagoTutor', RESEED, 0);
DBCC CHECKIDENT ('PagoTarea', RESEED, 0);



--######################  Alter  #####################
--Alteraciones despues de crear la base de datos

ALTER TABLE Estudiante
ADD Contraseña VARCHAR(50);

-- Suponiendo que el Id_Estudiante es 5 y la contraseña que deseas establecer es 'miContraseña123'
UPDATE Estudiante
SET Contraseña = '13041994'
WHERE Id_Estudiante = 4;
