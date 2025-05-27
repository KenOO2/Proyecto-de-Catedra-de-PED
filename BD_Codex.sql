use Codex


CREATE DATABASE Codex

CREATE TABLE Usuarios(
Id int PRIMARY KEY NOT NULL,
Email varchar(30) NOT NULL,
Nombre varchar(10) NOT NULL,
Contraseña varchar(8) NOT NULL
);

CREATE TABLE Proveedores(
IdProveedor int PRIMARY KEY,
NomMarca varchar(15) NOT NULL,
Email varchar(30) NOT NULL,
TelProveedor char(16),
RegistroIva char(10) NOT NULL
);


CREATE TABLE Productos(
IdProducto CHAR(10) PRIMARY KEY,
Nomproducto varchar(30) NOT NULL,
IdProveedor int NOT NULL,
Precio decimal(10,2) NOT NULL,
Descuento int NOT NULL, --Entrada esperada:10, 50, 99 {(10/100) = 0.1 * precio = descuento }
Stock int NOT NULL,
FOREIGN KEY (IdProveedor) REFERENCES Proveedores(IdProveedor) ON DELETE CASCADE
);

 Drop Table Productos
 --La tabla Productos fue modificada
 
insert into Usuarios(id, Email, Nombre, Contraseña)
values ('1','gab@gmail.com', 'Gabriel', '1234')

insert into Proveedores(IdProveedor, NomMarca, Email, TelProveedor, RegistroIva)
values ('1','adoc', 'pp@gmail.com', '121254545', '3')

insert into Productos(IdProducto, Nomproducto, IdProveedor, Precio, Descuento, Stock)
values ('1','Zapato deporte', '1', '12.8', '2',10)


select * from Usuarios
select * from Productos
select * from Proveedores


SELECT IdProducto, NomProducto, IdProveedor, Precio, Descuento , Stock FROM Productos
