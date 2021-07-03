---CRUD Proveedor
---Mostrar P
insert into Proveedor values ('090 1212','Andrea Garcia','Calle 213 123','2423 2342')

Create proc mostrar_proveedor
as
select * from Proveedor

exec mostrar_proveedor

---Buscar P
create proc buscar_proveedor
@textobuscar varchar(50)
as
select * from Proveedor
where nombre_proveedor like @textobuscar + '%' or rtn_proveedor like @textobuscar + '%'
go

exec buscar_proveedor 'Andrea Garcia'

---Insertar P
create proc insertar_proveedor
@rtn_proveedor varchar(15),
@nombre_proveedor varchar(80),
@direccion varchar(500),
@telefono varchar (15)
as
insert into Proveedor values (@rtn_proveedor,@nombre_proveedor,@direccion,@telefono)
go

---Editar P
create proc editar_proveedor
@id_proveedor int,
@rtn_proveedor varchar(15),
@nombre_proveedor varchar(80),
@direccion varchar(500),
@telefono varchar(15)
as
update Proveedor set @rtn_proveedor=@rtn_proveedor,@nombre_proveedor,direccion_proveedor=@direccion,telefono=@telefono where id_proveedor=@id_proveedor
go

---Eliminar P
create proc eliminar_proveedor
@id_proveedor int
as
delete from Proveedor where id_proveedor=@id_proveedor
go
