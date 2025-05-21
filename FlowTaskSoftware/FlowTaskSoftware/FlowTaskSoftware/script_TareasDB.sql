CREATE DATABASE TareasDB;
GO

USE TareasDB;
GO

-- Tabla: Categorias
CREATE TABLE Categorias (
    id INT PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(100) NOT NULL,
    descripcion TEXT NULL,
    fechaCreacion DATETIME NULL
);

-- Tabla: Estados
CREATE TABLE Estados (
    id INT PRIMARY KEY IDENTITY(1,1),
    nombreEstado VARCHAR(50) NOT NULL
);

-- Tabla: Usuarios
CREATE TABLE Usuarios (
    id INT PRIMARY KEY IDENTITY(1,1),
    nombreUsuario VARCHAR(50) NOT NULL,
    contrasena VARCHAR(MAX) NOT NULL,
    correo VARCHAR(100) NULL,
    fechaCreacion DATETIME NULL
);

-- Tabla: Tareas
CREATE TABLE Tareas (
    id INT PRIMARY KEY IDENTITY(1,1),
    titulo VARCHAR(255) NOT NULL,
    descripcion TEXT NOT NULL,
    categoriaId INT NOT NULL,
    usuarioId INT NOT NULL,
    estadoId INT NOT NULL,
    fechaCreacion DATETIME NULL,
    fechaVencimiento DATE NULL,
    FOREIGN KEY (categoriaId) REFERENCES Categorias(id),
    FOREIGN KEY (usuarioId) REFERENCES Usuarios(id),
    FOREIGN KEY (estadoId) REFERENCES Estados(id)
);
