-- Registros de ejemplo para Estudiante
INSERT INTO Estudiante (Carnet, Carrera, Celular, Correo, Creado, DeBaja, Descripcion, Direccion, Edad, Nombre, Universidad)
VALUES
    ('202300001', 'Ingeniería', '77777777', 'estudia@example.com', '2023-07-20', NULL, 'Estudiante 1', 'Dirección 1', 22, 'Estudiante Uno', 'Universidad Ejemplo'),
    ('202300002', 'Administración', '88888888', 'estud@example.com', '2023-07-20', NULL, 'Estudiante 2', 'Dirección 2', 20, 'Estudiante Dos', 'Universidad Ejemplo'),
    ('202300003', 'Arquitectura', '99999999', 'estudi@example.com', '2023-07-20', NULL, 'Estudiante 3', 'Dirección 3', 21, 'Estudiante Tres', 'Universidad Ejemplo');

-- Registros de ejemplo para Tutor
INSERT INTO Tutor (Celular, Correo, Creado, DeBaja, Descripcion, Direccion, Edad, Nombre)
VALUES
    ('55555555', 'tutor1@example.com', '2023-07-20', NULL, 'Tutor 1', 'Dirección Tutor 1', 30, 'Tutor Uno'),
    ('66666666', 'tutor2@example.com', '2023-07-20', NULL, 'Tutor 2', 'Dirección Tutor 2', 28, 'Tutor Dos');

-- Registros de ejemplo para Grupo
INSERT INTO Grupo (Nombre, Materia, Creado, Terminado)
VALUES
    ('Grupo 1', 'Matemáticas', '2023-07-20', NULL),
    ('Grupo 2', 'Física', '2023-07-20', NULL);

-- Registros de ejemplo para Tarea
INSERT INTO Tarea (Id_Estudiante, Id_Tutor, Tema, Descripcion, Asignado, Vencimiento, Iniciado, Finalizado, Entregado, Horas, Calificacion, Cancelado, EntregarPortal)
VALUES
    (8, 1, 'Tarea 1', 'Descripción Tarea 1', '20230720 10:00:00', '20230725 18:00:00', '20230721 14:00:00', '20230724 12:00:00', '20230725 10:00:00', 5.5, 9, 0, 1),
    (9, 1, 'Tarea 2', 'Descripción Tarea 2', '20230720 14:00:00', '20230727 18:00:00', NULL, NULL, NULL, 8, NULL, 0, 0),
    (10, 2, 'Tarea 3', 'Descripción Tarea 3', '20230720 09:00:00', '20230724 18:00:00', '20230720 10:00:00', '20230723 12:00:00', '20230724 09:30:00', 4.5, 8, 0, 1);

INSERT INTO Tarea (Id_Estudiante, Id_Tutor, Tema, Descripcion, Asignado, Vencimiento, Iniciado, Finalizado, Entregado, Horas, Calificacion, Cancelado, EntregarPortal)
VALUES
    (1, 2, 'POO', 'programa en c#', '20230722 10:50', '20230729 18:00', '20230721 23:59', '20230729 12:00', NULL, 2, 10, NULL, 1);

-- Registros de ejemplo para GrupoEstudiante
INSERT INTO GrupoEstudiante (ID_Grupo, ID_Estudiante, Agregado, DeBaja, Descripcion)
VALUES
    (1, 9, '2023-07-20', NULL, 'Estudiante 1 en Grupo 1'),
    (1, 10, '2023-07-20', NULL, 'Estudiante 2 en Grupo 1'),
    (2, 10, '2023-07-20', NULL, 'Estudiante 2 en Grupo 2'),
    (2, 8, '2023-07-20', NULL, 'Estudiante 3 en Grupo 2');

-- Registros de ejemplo para PagoTarea
INSERT INTO PagoTarea (Id_Estudiante, Id_Tarea, MetodoPago, Pagado, Precio)
VALUES
    (9, 9, 'Tarjeta de crédito', '20230720 14:00:00', 150.50),
    (10, 10, 'PayPal', NULL, 180.25),
    (8, 11, 'Efectivo', '20230720 14:00:00', 200.00);

-- Registros de ejemplo para PagoTutor
INSERT INTO PagoTutor (Id_Tutor, Id_Tarea, MetodoPago, Pagado, Precio)
VALUES
    (1, 1, 'Transferencia bancaria', '20230723 09:15', 80.00),
    (1, 3, 'PayPal', NULL, 100.00),
    (2, 2, 'Efectivo', '20230721 16:30', 120.75);
