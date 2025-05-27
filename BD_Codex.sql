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


insert into Usuarios(id, Email, Nombre, Contraseña)
values ('1','gab@gmail.com', 'Gabriel', '1234');

insert into Proveedores(IdProveedor, NomMarca, Email, TelProveedor, RegistroIva)
values ('1','Puma', 'pumasv@gmail.com', '1244-5689', '34356'),
       ('2', 'Adidas', 'adidassv@gmail.com', '2143-8090', '09546'),
       ('3', 'Nike', 'nikeusa@gmail.com', '2530-3090', '53467'),
       ('4', 'New Balance', 'newbalance@gmail.com', '2356-9638');

insert into Productos(IdProducto, Nomproducto, IdProveedor, Precio, Descuento, Stock)
values ('1','Tenis Suede Classic', '1', '90', '20',30),
       ('2', 'Scuderia Ferrari Speedcat', '1','110','20',36),
       ('3','Y-3 Superstar', '2','350','5',50);
       ('4','SUPERSTAR 82 SFTM','2','140','0', 35),
       ('5','Air Jordan 1 Mid', '3','130', '5', 76),
       ('6','Nike Air Force 1 '07'', '3','115','24', 56),
       ('7','NB 550','4','109.99', '10', 45),
       ('8','NB Made in UK 991v2','4','249.99','0',30);

select * from Usuarios
select * from Productos
select * from Proveedores



