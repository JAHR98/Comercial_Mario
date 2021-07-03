----Procedimientos almacenados

---Mostrar E
Create proc mostrar_empleado
as
SELECT       dbo.Empleados.cod_empleado,dbo.Empleados.nombre_empleado, dbo.Empleados.identidad_empleado, dbo.Empleados.direccion, dbo.Empleados.telefono, dbo.Empleados.correo_electronico, dbo.Empleados.estado,  
                         dbo.Empleados.usuario, dbo.Empleados.id_cargo AS Expr1, dbo.Usuario.contraseña
FROM            dbo.Cargo INNER JOIN
                         dbo.Empleados ON dbo.Cargo.id_cargo = dbo.Empleados.id_cargo INNER JOIN
                         dbo.Usuario ON dbo.Cargo.id_cargo = dbo.Usuario.id_cargo AND dbo.Empleados.usuario = dbo.Usuario.usuario

exec mostrar_empleado




---Buscar E
create proc buscar_empleado
@textobuscar varchar(50)
as
select*from Empleados
where nombre_empleado like @textobuscar + '%' or identidad_empleado like @textobuscar + '%' 
go

---Insertar E
Insert into Cargo values('Administrador',null)
go
Insert into Cargo values('Empleado',null)
go

---Insertar E
exec  intertar_empleado 'Rony Ariel','012 102','Frente A sa','504 89492124','mhshd@gmail.com','Activo','1','@Rony123','Rony123'
exec  intertar_empleado 'Jese Abraham','123 344','Frente A sa','504 34343432','mhshd@gmail.com','Activo','2','@Jese123','Jese123'

create proc insertar_empleado
@nombre_empleado varchar(30),
@identidad_empleado varchar(15),
@direccion varchar(500),
@telefono varchar (15),
@correo_electronico varchar(20),
@estado varchar(20),
@id_cargo int,
@usuario varchar(20),
@contraseña varchar(15)
as
insert into Usuario values (@usuario,@contraseña,@id_cargo)
insert into Empleados values (@nombre_empleado,@identidad_empleado,@direccion ,@telefono,@correo_electronico ,@estado ,@id_cargo ,@usuario)
go

---Editar E
create proc editar_empleado
@cod_empleado int,
@nombre_empleado varchar(30),
@identidad_empleado varchar(15),
@direccion varchar(500),
@telefono varchar (15),
@correo_electronico varchar(20),
@estado varchar(20),
@id_cargo int,
@usuario varchar(20),
@contraseña varchar (15)
as
update  Usuario set usuario=@usuario,contraseña=@contraseña, id_cargo=@id_cargo where usuario=@usuario
update Empleados set nombre_empleado=@nombre_empleado, identidad_empleado=@identidad_empleado,direccion=@direccion ,telefono=@telefono, correo_electronico=@correo_electronico ,estado=@estado ,id_cargo=@id_cargo where cod_empleado=@cod_empleado
go

--Eliminar E
create proc eliminar_empleado
@cod_empleado int
as
delete from Empleados where cod_empleado=@cod_empleado
go

exec  intertar_empleado 'Rony Ariel','012 102','Frente A sa','504 89492124','mhshd@gmail.com','Activo','1','@Rony123','Rony123'
exec  intertar_empleado 'Jese Abraham','123 344','Frente A sa','504 34343432','mhshd@gmail.com','Activo','2','@Jese123','Jese123'


exec  editar_empleado '1','Rony F Marcia','012 102','Frente A sa','504 89492124','mhshd@gmail.com','Activo','2','@Rony123','Rony1234'
select * from Empleados
select * from Usuario



------Procedimientos para CRUD cliente

---Mostrar C

insert into Cliente values ('Ariel','Funez','213 123','sdwsd233','2423 2342','sdsdsd')

Create proc mostrar_cliente
as
select * from Cliente


exec mostrar_cliente




---Buscar C
create proc buscar_cliente
@textobuscar varchar(50)
as
select*from Cliente
where nombre_cliente like @textobuscar + '%' or identidad_cliente like @textobuscar + '%' 
go

exec buscar_cliente 'Ariel'


---Insertar C
create proc insertar_cliente
@nombre_cliente varchar(30),
@apellido_cliente varchar(30),
@identidad_cliente varchar(16),
@rtn_cliente varchar(20),
@telefono varchar (15),
@correo_electronico varchar(20)
as
insert into Cliente values (@nombre_cliente,@apellido_cliente,@identidad_cliente,@rtn_cliente,@telefono,@correo_electronico)
go


---Editar C
create proc editar_cliente
@id_cliente int,
@nombre_cliente varchar(30),
@apellido_cliente varchar(30),
@identidad_cliente varchar(16),
@rtn_cliente varchar(20),
@telefono varchar (15),
@correo_electronico varchar(20)
as
update Cliente set nombre_cliente=@nombre_cliente, identidad_cliente=@identidad_cliente,rtn_cliente=@rtn_cliente ,telefono=@telefono, correo_electronico=@correo_electronico  where id_cliente=@id_cliente
go

--Eliminar C
create proc eliminar_cliente
@id_cliente int
as
delete from Cliente where id_cliente=@id_cliente
go


