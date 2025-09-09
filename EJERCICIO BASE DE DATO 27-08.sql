-- ESTA CONSULTA SOLO FUNCIONA EN MASTER

use master 
create login Vendedor_login with password = 'Vendedor123';
create login Admin_login with password = 'Admin123';

-- verificar si la tabla no esta duplicada 
if db_id ('CasaEstilo') is not null
	begin 
	alter database [CasaEstilo] set single_user with rollback immediate;
	drop database  [CasaEstilo];
end

create database [CasaEstilo];
go
use [CasaEstilo];

create table Proveedores ( 
	ProveedorID int primary key identity (1,1),
	NombreProveedor varchar (100) not null,
	PaisOrigen varchar (100)
	);
go

create table Productos (
	ProductosID int primary key identity (1,1),
	NombreProducto varchar (100) not null,
	PrecioUnitario int not null,
	ProveedorID int,
	constraint fk_Productos_Proveedores foreign key (ProductosID) references Proveedores (ProveedorID)
);

go

create table Venta (
	VentaID int primary key identity (1,1),
	FechaVenta date not null
	);

create table DetallesVentas (
	DetalleVentaID int primary key identity (1,1),
	VentaID int not null,
	ProductoID int not null,
	Cantidad int not null,
	constraint fk_DetallesVentas_Ventas foreign key (VentaID) references Venta (VentaID),
	constraint fk_DetalleVentas_Productos foreign key  (ProductoID) references Productos (ProductosID)
);
--insercion masivas de  productos
insert into Proveedores (NombreProveedor,PaisOrigen)  values 
('Muebles del sur', 'Chile'), ('DecoHogar' , 'Chile') , ('Textiles Andinos' , 'Chile'), 
('Global desing' , 'Italia') , ('Nordic  style' , 'Suecia') , ('Tech Ilumination', 'China'),
('Cristaleria Fina', 'Francia'), ('Maderas premium', 'Brasil'), ('Ceramicas del maule' , 'Chile'),
('Importadora oriental' , 'Chile'); 

select * from Proveedores -- ver laas tablas

select * from Productos 

insert into Productos (NombreProducto,PrecioUnitario,ProveedorID) values
('Silla comedor roble' , 85000,1) , ('Mesa centro', 120000,1) , ('Sofa 3 Cuerpos tela' , 450000,2),
('Lampara led' , 65000,6), ('Juego de vasos (6 un.', 25000,7), ('Alfombra Pasillo' , 95000,3),
('Cojin Decorativo' , 15000,3), ('Mesa lateral' ,55000,5), ('Vajilla 15 piezas', 75000,9),
('Lampara colgante', 9900,4); 

select * from Productos 

---------------------------------------------------------------------------------------------------------------


-- simulacion masiva de ventas de forma aleatoria 

declare @i int = 1;
while @i <500
begin
	declare @VentasID int;
	declare @FechaVenta date = dateadd( day, -cast (rand()*730 as int) , getdate ());

	insert into Venta (FechaVenta) values (@FechaVenta);
	set @VentasID = SCOPE_IDENTITY();

	declare @num_detalles int = cast(rand()* 3 as int) +1;
	declare @j int=1; 
	while @j <@num_detalles
	begin
		 insert into DetallesVentas(VentaID,ProductoID,Cantidad)
		 values (
			@VentasID,
			cast(rand()*10 as int)+1,
			cast(rand()*10 as int)+1
	);
	set @j = @j + 1;
	end 
	set @i =  @i +1;

end 
set nocount off; -- para terminar la sentencia 

select * from Productos
select * from Venta 

---------------------------------------------------------------------------------------------------------------------

-- declare @dbName NVARCHAR (128) = N'CasaEstilo'; 

use master -- para que un usuario tenga acceso siempre en master 

create login [Analista_reporte]
with password = N'Reportes.2025';

print 'Login [Analista_reporte] creado con exito';

-- pregunta de prueba 

use [CasaEstilo];

create user [Analista_reporte] for login [Analista_reporte];

alter role db_datareader add member [Analista_reporte];

select * from Productos 

select suser_name();
select user_name();