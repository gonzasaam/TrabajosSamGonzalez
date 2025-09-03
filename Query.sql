--esta coonsulta solo funciona en master
use master
CREATE LOGIN vendedor_login WITH PASSWORD= 'Vendedor123';
----------------------------------------------------------
CREATE LOGIN admin_login WITH PASSWORD='Admin123';

IF DB_ID ('CasaEstilo') IS NOT NULL
BEGIN
	ALTER DATABASE [CasaEstilo] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
	DROP DATABASE [CasaEstilo];
END

CREATE DATABASE [CasaEstilo];
GO
USE [CasaEstilo];

CREATE TABLE Proveedores(
	ProveedorID int primary key identity(1,1),
	NombreProveedor VARCHAR(100) NOT NULL,
	PaisOrigen  VARCHAR(100)
);
GO
CREATE TABLE Productos (
	ProductoID INT PRIMARY KEY IDENTITY(1,1),
	NombreProducto VARCHAR(100) NOT NULL,
	PrecioUnitario INT NOT NULL,
	ProveedorID INT,
	CONSTRAINT FK_Productos_Proveedores FOREIGN KEY (ProveedorID) REFERENCES Proveedores(ProveedorID)
);
go

CREATE TABLE Ventas(
	VentaID  INT PRIMARY KEY IDENTITY(1,1),
	FechaVenta DATE NOT NULL
);

CREATE TABLE DetallesVentas(
	DetalleVentaID INT PRIMARY KEY IDENTITY (1,1),
	VentaID INT NOT NULL,
	ProductoID INT NOT NULL,
	Cantidad INT NOT NULL,
	CONSTRAINT FK_DetallesVentas_Ventas FOREIGN KEY (VentaID) REFERENCES Ventas(VentaID),
	CONSTRAINT FK_DetallesVentas_Productos FOREIGN KEY(ProductoID) REFERENCES Productos(ProductoID)
);

---insercion masiva de productos

insert into Proveedores(NombreProveedor,PaisOrigen) values
('Muebles del Sur','Chile'),('DecoHogar','Chile'),('Textiles Andinos','Chile'),
('Global Desing','Italia'),('Nordic Style','Suecia'),('Tech Ilumintation','China'),
('Cristaleria Fina','Francia'),('Maderas Premium','Brasil'),('Ceramicas del Maule','Chile'),
('Importadora Oriental','China');
-------------------------------------------------------------------
select * from Proveedores
select * from Productos
INSERT INTO Productos(NombreProducto,PrecioUnitario,ProveedorID) VALUES
('Silla Comedor Roble',85000,1),('Mesa Centro',120000,1),('Sofa 3 cuerpos Tela',450000,2),
('Lampara LED ',65000,6),('Juego de Vasos(6 un.)',25000,7),('Alfombra Pasillo',95000,3),
('Cojin Decorativo',15000,3),('Mesa Lateral',55000,5),('Vajilla 15 piezas',75000,9),
('Lampara Colgante',9900,4);
-----------------------------------------------------------------------------------------------
---simulacion masiva de ventasd de forma aleatoria
DECLARE @i INT =1;
WHILE @i <500
BEGIN
	DECLARE @VentaID INT;
	DECLARE @FechaVenta DATE = DATEADD(day, -CAST(RAND()*730 AS INT), GETDATE());--VENTA DE LOS ULTIMOS 2 AÑOS

	INSERT INTO Ventas(FechaVenta) VALUES (@FechaVenta);
	SET @VentaID = SCOPE_IDENTITY();
	---INSERTAR ENTRE 1 Y 4 PRODUCTOS POR VENTA
	DECLARE @num_detalles INT= CAST(RAND()*3 AS INT)+1;
	DECLARE @j INT=1;
	WHILE @j < @num_detalles
	BEGIN
		INSERT INTO DetallesVentas(VentaID,ProductoID,Cantidad)
		VALUES (
			@VentaID,
			CAST(RAND()*10 AS INT)+1,----ProductoID entre 1 y 14(NUMERO QUE VARIA SEGUN PRODUCTOS TENGAMOS EN LA TABLA)
			CAST(RAND()*10 AS INT)+1 ----cCantidad entre 1 y 10,
		);
		SET @j = @j +1;
	END
	SET @i =@i+1;
END
SET  NOCOUNT OFF;

SELECT * FROM Ventas
SELECT * FROM Productos



--------------------------------------------------------------------------------------------------------------------------
---DECLARE @dbName NVARCHAR(128)= N'CasaEstilo';

----declaracion de variables que usara el script
use master

CREATE LOGIN [analista_reporte]
WITH PASSWORD =N'Reportes.2025';

print 'Login [analista_reporte] creado con exito';

USE[CasaEstilo];

CREATE USER [analista_reporte] FOR LOGIN [analista_reporte];


ALTER ROLE db_datareader ADD MEMBER [analista_reporte];