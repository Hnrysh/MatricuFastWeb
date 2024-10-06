CREATE TABLE Usuarios (
    UsuarioID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100),
    Apellido NVARCHAR(100),
    Email NVARCHAR(100),
    Contraseña NVARCHAR(255),
    AdicionadoPor NVARCHAR(100),
    FechaAdicion DATETIME,
    ModificadoPor NVARCHAR(100),
    FechaModificacion DATETIME
);
CREATE TABLE Estudiantes (
    EstudianteID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100),
    Apellido NVARCHAR(100),
    Carrera NVARCHAR(100),
    AnioIngreso INT,
    AdicionadoPor NVARCHAR(100),
    FechaAdicion DATETIME,
    ModificadoPor NVARCHAR(100),
    FechaModificacion DATETIME
);
CREATE TABLE Cursos (
    CursoID INT PRIMARY KEY IDENTITY(1,1),
    NombreCurso NVARCHAR(100),
    Creditos INT,
    Horas INT,
    AdicionadoPor NVARCHAR(100),
    FechaAdicion DATETIME,
    ModificadoPor NVARCHAR(100),
    FechaModificacion DATETIME
);

CREATE TABLE Matricula (
    MatriculaID INT PRIMARY KEY IDENTITY(1,1),
    EstudianteID INT FOREIGN KEY REFERENCES Estudiantes(EstudianteID),
    CursoID INT FOREIGN KEY REFERENCES Cursos(CursoID),
    FechaMatricula DATETIME,
    AdicionadoPor NVARCHAR(100),
    FechaAdicion DATETIME,
    ModificadoPor NVARCHAR(100),
    FechaModificacion DATETIME
);
