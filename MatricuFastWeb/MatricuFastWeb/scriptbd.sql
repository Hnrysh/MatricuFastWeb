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
