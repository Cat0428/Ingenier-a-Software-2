-- Categorias
INSERT INTO Categorias (nombre, descripcion, fechaCreacion) VALUES
('Personal', 'Tareas personales del día a día', GETDATE()),
('Trabajo', 'Actividades laborales', GETDATE()),
('Estudio', 'Tareas relacionadas con la universidad o cursos', GETDATE()),
('Salud', 'Citas médicas y rutinas de salud', GETDATE()),
('Finanzas', 'Gestión de pagos y presupuestos', GETDATE());

-- Estados
INSERT INTO Estados (nombreEstado) VALUES
('Pendiente'),
('En Progreso'),
('Completada'),
('Cancelada'),
('En Espera');

-- Usuarios
INSERT INTO Usuarios (nombreUsuario, contrasena, correo, fechaCreacion) VALUES
('juanperez', '123456', 'juan@example.com', GETDATE()),
('mariagomez', 'abc123', 'maria@example.com', GETDATE()),
('luislopez', 'luis2024', 'luis@example.com', GETDATE()),
('anaortiz', 'ana_pass', 'ana@example.com', GETDATE()),
('pedrosanchez', 'pedro!45', 'pedro@example.com', GETDATE());

-- Tareas
INSERT INTO Tareas (titulo, descripcion, categoriaId, usuarioId, estadoId, fechaCreacion, fechaVencimiento) VALUES
('Comprar despensa', 'Ir al supermercado y comprar lo necesario', 1, 1, 1, GETDATE(), '2025-05-20'),
('Revisar informes', 'Verificar los reportes del área financiera', 2, 2, 2, GETDATE(), '2025-05-18'),
('Estudiar para examen', 'Preparar tema de bases de datos', 3, 3, 1, GETDATE(), '2025-05-25'),
('Chequeo médico', 'Consulta con el doctor general', 4, 4, 1, GETDATE(), '2025-05-21'),
('Pagar tarjeta de crédito', 'Pago mensual de la tarjeta', 5, 5, 3, GETDATE(), '2025-05-19');
SELECT * FROM CATEGORIAS