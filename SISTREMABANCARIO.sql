create database Sistema_Bancario
GO
use Sistema_Bancario
GO
create table ClientesBanco (
	IdCliente INT PRIMARY KEY IDENTITY(1,1),
	Nombre  VARCHAR(50) NOT NULL,
	Apellido VARCHAR(60) NOT NULL,
	Direccion VARCHAR(100) NOT NULL,
	FechaCreacion DATETIME DEFAULT GETDATE()
);

-- CREACION DE TABLA CUENTASc
create table Cuentas(
	IdCuentas INT PRIMARY KEY IDENTITY(1001,1),
	IdCliente int not null,
	TipoCuenta VARCHAR(15) NOT NULL,
	Saldo Decimal(10,2) NOT  NULL,
	FechCreacion DATETIME DEFAULT GETDATE(),
	FOREIGN KEY (IdCliente) REFERENCES ClientesBanco(IdCliente)
);
GO
--3 tabla para las transacciones
CREATE TABLE Movimientos(
	MovimientoID INT PRIMARY KEY IDENTITY (1,1),
	IdCuentas INT NOT NULL,
	TipoMovimiento VARCHAR(10) NOT NULL,
	Monto DECIMAL(15,2) NOT NULL,
	FechaMovimiento DATETIME DEFAULT GETDATE(),
	FOREIGN KEY(IdCuentas) REFERENCES Cuentas(IdCuentas)
);

¡Perfecto! Aquí tienes el script SQL para llenar esas tres tablas con datos de ejemplo.

Copia todo este bloque, pégalo en un nuevo Editor SQL en DBeaver y ejecútalo con Alt + X (Ejecutar Script).

## Script de Inserción de Datos

SQL

USE Sistema_Bancario;
GO

-- 1. Llenamos la tabla de ClientesBanco (15 registros)
INSERT INTO ClientesBanco (Nombre, Apellido, Direccion) VALUES
('Ana', 'Rojas', 'Av. Providencia 123, Santiago'),
('Luis', 'Gómez', 'Calle Falsa 456, Las Condes'),
('Carla', 'Pérez', 'Paseo Ahumada 789, Santiago'),
('Jorge', 'Morales', 'Los Leones 101, Providencia'),
('María', 'Soto', 'Apoquindo 202, Las Condes'),
('Pedro', 'Contreras', 'Moneda 303, Santiago'),
('Sofía', 'Vargas', 'Vitacura 404, Vitacura'),
('Miguel', 'Castro', 'Eliodoro Yáñez 505, Providencia'),
('Laura', 'Díaz', 'Isidora Goyenechea 606, Las Condes'),
('Javier', 'Muñoz', 'Merced 707, Santiago'),
('Fernanda', 'Silva', 'Costanera Norte 808, Vitacura'),
('Ricardo', 'Flores', 'Bellavista 909, Providencia'),
('Valentina', 'Torres', 'Lastarria 111, Santiago'),
('Diego', 'Reyes', 'Manquehue Sur 222, Las Condes'),
('Camila', 'Gutiérrez', 'Orrego Luco 333, Providencia');
GO

-- 2. Llenamos la tabla de Cuentas, asignando saldos variados
-- Nota: Los IdCliente van del 1 al 15.
INSERT INTO Cuentas (IdCliente, TipoCuenta, Saldo) VALUES
(1, 'Ahorro', 750000.00),    -- Cuenta de Ana (IdCuentas: 1001)
(1, 'Corriente', 120000.00), -- Cuenta de Ana (IdCuentas: 1002)
(2, 'Ahorro', 1500000.00),   -- Cuenta de Luis (IdCuentas: 1003)
(3, 'Corriente', 300000.00), -- Cuenta de Carla (IdCuentas: 1004)
(4, 'Ahorro', 450000.00),    -- ...y así sucesivamente
(4, 'Corriente', 95000.00),
(5, 'Ahorro', 2500000.00),
(6, 'Corriente', 50000.00),
(7, 'Ahorro', 980000.00),
(8, 'Corriente', 180000.00),
(9, 'Ahorro', 3200000.00),
(9, 'Corriente', 400000.00),
(10, 'Ahorro', 600000.00),
(11, 'Corriente', 220000.00),
(12, 'Ahorro', 1250000.00),
(13, 'Corriente', 85000.00),
(14, 'Ahorro', 5000000.00),
(15, 'Corriente', 15000.00);
GO

-- 3. Llenamos la tabla de Movimientos con algunas transacciones de ejemplo
-- Nota: Los IdCuentas van desde 1001 en adelante.
INSERT INTO Movimientos (IdCuentas, TipoMovimiento, Monto) VALUES
-- Movimientos para la cuenta 1001 (Ahorro de Ana)
(1001, 'Abono', 800000.00),
(1001, 'Cargo', 50000.00),
-- Movimientos para la cuenta 1003 (Ahorro de Luis)
(1003, 'Abono', 1500000.00),
-- Movimientos para la cuenta 1004 (Corriente de Carla)
(1004, 'Abono', 350000.00),
(1004, 'Cargo', 50000.00),
-- Movimientos para la cuenta 1007 (Ahorro de María)
(1007, 'Abono', 2500000.00),
-- Movimientos para la cuenta 1011 (Ahorro de Laura)
(1011, 'Abono', 3200000.00),
(1011, 'Cargo', 100000.00),
-- Movimientos para la cuenta 1017 (Ahorro de Diego)
(1017, 'Abono', 5000000.00);
GO