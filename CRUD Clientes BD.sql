------Procedimientos para CRUD cliente

---Procedimiento Almacenado para mostrar clientes

insert into Cliente values ('Ariel','Funez','213 123','sdwsd233','2423 2342','sdsdsd')

Create proc mostrar_cliente
as
select * from Cliente


exec mostrar_cliente




---Procedimiento almacenado para Buscar Clientes
create proc buscar_cliente
@textobuscar varchar(50)
as
select*from Cliente
where nombre_cliente like @textobuscar + '%' or identidad_cliente like @textobuscar + '%' 
go

exec buscar_cliente 'Ariel'


---Procedimiento almacenado para Insertar Clientes
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


---Procedimiento para Editar Clientes
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

--Procedimiento almacenado para Eliminar Clientes
create proc eliminar_cliente
@id_cliente int
as
delete from Cliente where id_cliente=@id_cliente
go


