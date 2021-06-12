

create database Proyecto
go
use Proyecto
go 




Create table Producto
(
  id_producto int identity(1,1) primary key,
  nombre_producto varchar(80),
  descripcion varchar(2000),
  precio_actual money,
  existencia int

)




Create table Proveedor
(
  id_proveedor int identity(1,1) primary key,
  rtn_proveedor varchar(15),
  nombre_prveedor varchar(80),
  direccion_proveedor varchar(500),
  telefono int

)


Create table Producto_Proveedor
(
 id_producto int
 foreign key (id_producto) references Producto(id_producto),
 id_proveedor int
 foreign key (id_proveedor) references Proveedor(id_proveedor)

)


create table Cliente
(
  id_cliente int identity(1,1) primary key,
  nombre_cliente varchar(30), 
  apellido_cliente varchar(30), 
  identidad_cliente varchar(16),
  rtn_cliente varchar(20),
  telefono int,
  correo_electronico varchar(20)

)


create table Cargo
(
  id_cargo int identity(1,1) primary key,
  cargo varchar(20),
  sueldo money

)


create table Usuario
(
  usuario varchar(20) primary key, 
  contraseña varchar(15),
  id_cargo int
  foreign key (id_cargo) references Cargo(id_cargo)

)

create table Empleados
(
  cod_empleado int identity(1,1) primary key,
  nombre_empleado varchar(30),
  identidad_empleado varchar(15),
  direccion varchar(500),
  telefono int,
  correo_electronico varchar(20),
  estado varchar(20),
  id_cargo int
  foreign key (id_cargo) references Cargo(id_cargo),
  usuario varchar(20)
  foreign key (usuario) references Usuario(usuario)

)

create table Termino_pago
(
 cod_termino int identity(1,1) primary key,
 Descripcion varchar(100)

)


create table Factura
(
  No_factura int identity(1,1) primary key,
  Fecha date,
  cod_termino int
  foreign key (cod_termino) references Termino_pago(cod_termino),
  id_cliente int
  foreign key (id_cliente) references Cliente(id_cliente), 
  cod_empleado int
  foreign key (cod_empleado) references Empleados(cod_empleado),
 
) 

create table detalle_factura
(
  No_factura int
  foreign key (No_factura) references Factura(No_factura),
  id_producto int
  foreign key (id_producto) references Producto(id_producto),
  cantidad int, 
  precio_venta money,
  precio_unitario money, 
  importe money, 
  ISV money, 
  Subtotal money,
  Total money
)




create table Pedidos
(
  id_pedido int identity(1,1) primary key,
  id_proveedor int
  foreign key (id_proveedor) references Proveedor(id_proveedor), 
  cod_empleado int
  foreign key (cod_empleado) references Empleados(cod_empleado),
)

create table detalle_pedido
(
  id_pedido int
  foreign key (id_pedido) references Pedidos(id_pedido), 
  id_producto int
  foreign key (id_producto) references Producto(id_producto),
  fecha_pedido datetime,
  fecha_entrega datetime,
  precio_compre money,
  cantidad int,
  estado varchar(20)
)

create table Devoluciones
(
  fecha_devolucion datetime primary key,
  id_proveedor int
  foreign key (id_proveedor) references Proveedor(id_proveedor), 
  cod_empleado int
  foreign key (cod_empleado) references Empleados(cod_empleado)

)

create table motivo_devolucion
(
 id_devolucion int identity(1,1) primary key,
 descripcion varchar(500)
)

create table detalle_devoluciones
(
 fecha_devolucion datetime,
 foreign key (fecha_devolucion) references Devoluciones(fecha_devolucion),
 id_producto int
 foreign key (id_producto) references Producto(id_producto),
 id_devolucion int
 foreign key (id_devolucion) references motivo_devolucion(id_devolucion)
)
