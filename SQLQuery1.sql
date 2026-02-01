USE Reserva;
GO

DROP TABLE IF EXISTS Reserva;
DROP TABLE IF EXISTS Servicio;
DROP TABLE IF EXISTS Habitacion;
DROP TABLE IF EXISTS Huesped;
GO

CREATE TABLE Huesped (
    Id_Huesped INT IDENTITY(1,1) PRIMARY KEY,
    Cedula VARCHAR(15) NOT NULL UNIQUE,
    Nombres VARCHAR(100) NOT NULL,
    Nacionalidad VARCHAR(50),
    Correo VARCHAR(100),
    Telefono VARCHAR(20),
    Estado CHAR(1) DEFAULT 'A'
);
GO

CREATE TABLE Habitacion (
    Id_Habitacion INT PRIMARY KEY,  
    Num_Habitacion VARCHAR(10) NOT NULL,
    Num_Piso INT NOT NULL,
    Tipo_Habitacion VARCHAR(50) NOT NULL,
    Cant_Camas INT NOT NULL,
    Cant_Baños INT NOT NULL,
    Precio DECIMAL(10, 2) NOT NULL,
    Estado CHAR(1) DEFAULT 'A'
);
GO

CREATE TABLE Servicio (
    Id_Servicio INT PRIMARY KEY,  
    Nombre_Servicio VARCHAR(50) NOT NULL,
    Precio DECIMAL(10, 2) NOT NULL,
    Estado CHAR(1) DEFAULT 'A'
);
GO

CREATE TABLE Reserva (
    Id_Reserva INT IDENTITY(1,1) PRIMARY KEY,
    Id_Huesped INT NOT NULL,
    Id_Habitacion INT NULL,
    Id_Servicio INT NULL,
    Fecha_Llegada DATE NOT NULL,
    Fecha_Salida DATE NOT NULL,
    Fecha_De_Reserva DATETIME NOT NULL,
    Cantidad_Adulto INT NOT NULL,
    Cantidad_Ninios INT NOT NULL,
    Sub_Total DECIMAL(10, 2) NOT NULL,
    Iva DECIMAL(10, 2) NOT NULL,
    Total DECIMAL(10, 2) NOT NULL,
    Estado CHAR(1) DEFAULT 'A',
    CONSTRAINT FK_Reserva_Huesped FOREIGN KEY (Id_Huesped) REFERENCES Huesped(Id_Huesped),
    CONSTRAINT FK_Reserva_Habitacion FOREIGN KEY (Id_Habitacion) REFERENCES Habitacion(Id_Habitacion),
    CONSTRAINT FK_Reserva_Servicio FOREIGN KEY (Id_Servicio) REFERENCES Servicio(Id_Servicio)
);
GO

INSERT INTO Habitacion (Id_Habitacion, Num_Habitacion, Num_Piso, Tipo_Habitacion, Cant_Camas, Cant_Baños, Precio, Estado) VALUES 
(1, '101', 1, 'Matrimonial', 1, 1, 50.00, 'A'),
(2, '102', 1, 'Simple', 1, 1, 35.00, 'A'),
(3, '201', 2, 'Doble', 2, 1, 65.00, 'A'),
(4, '202', 2, 'Suite', 2, 2, 100.00, 'A'),
(5, '301', 3, 'Familiar', 3, 2, 120.00, 'A');
GO

INSERT INTO Servicio (Id_Servicio, Nombre_Servicio, Precio, Estado) VALUES 
(1, 'Sauna', 10.00, 'A'),
(2, 'Gimnasio', 5.00, 'A'),
(3, 'Transporte', 15.00, 'A'),
(4, 'Piscina', 7.00, 'A'),
(5, 'Lavanderia', 5.00, 'A');
GO

CREATE INDEX IX_Habitacion_Estado ON Habitacion(Estado);
CREATE INDEX IX_Servicio_Estado ON Servicio(Estado);
CREATE INDEX IX_Reserva_Fechas ON Reserva(Fecha_Llegada, Fecha_Salida);
CREATE INDEX IX_Reserva_Estado ON Reserva(Estado);
GO

SELECT 'Habitaciones' as Tabla, COUNT(*) as Registros FROM Habitacion
UNION ALL
SELECT 'Servicios', COUNT(*) FROM Servicio
UNION ALL
SELECT 'Huespedes', COUNT(*) FROM Huesped
UNION ALL
SELECT 'Reservas', COUNT(*) FROM Reserva;

SELECT * FROM Habitacion ORDER BY Id_Habitacion;

SELECT * FROM Servicio ORDER BY Id_Servicio;

GO