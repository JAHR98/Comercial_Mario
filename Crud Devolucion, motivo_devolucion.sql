

select * from motivo_devolucion
select * from Devoluciones

---------------------------------------CRUD PARA DEVOLUCIONES, DETALLE_DEVOLUCIONES, MOTIVO_DEVOLUCION

-----Mostrar Devolucion
Create procedure mostrar_devolucion
as
SELECT        dbo.Devoluciones.fecha_devolucion, dbo.motivo_devolucion.descripcion, dbo.Proveedor.nombre_prveedor, dbo.Producto.nombre_producto, dbo.Empleados.nombre_empleado
FROM            dbo.Devoluciones INNER JOIN
                         dbo.Empleados ON dbo.Devoluciones.cod_empleado = dbo.Empleados.cod_empleado INNER JOIN
                         dbo.motivo_devolucion ON dbo.Devoluciones.id_devolucion = dbo.motivo_devolucion.id_devolucion INNER JOIN
                         dbo.Producto ON dbo.Devoluciones.id_producto = dbo.Producto.id_producto INNER JOIN
                         dbo.Proveedor ON dbo.Devoluciones.id_proveedor = dbo.Proveedor.id_proveedor
exec mostrar_devolucion




------------Buscar Devolucion
create proc buscar_devolucion
@textobuscar varchar(50)
as
select*from Devoluciones
where id_devolucion like @textobuscar
go


----------Insertar Motivo de Devolucion
Insert into motivo_devolucion values('Producto Golpeado')
go
Insert into motivo_devolucion values('Producto No Funciona')
go


select * from Devoluciones


----------Insertar Devolucion
create proc insertar_devolucion
@id_devolucion int,
@id_proveedor int,
@id_producto int,
@cod_empleado int
as
insert into Devoluciones values (getdate(),@id_devolucion,@id_proveedor,@id_producto,@cod_empleado)
go

exec insertar_devolucion '1', '1', '1', '2'
select * from Devoluciones

select * from proveedor
insert into Proveedor values('01230', 'Diunsa', 'Kennedy', '1283')

insert into Producto values('Refrigeradora', 'lsbdf', '2,000', '10')
select * from Producto

insert into Cargo values('Administrador', '10,000')
select * from Cargo

insert into usuario values ('@jese', 'jese123', '1' )
insert into usuario values ('@rony', 'rony123', '1' )
select * from Usuario
insert into Empleados values('Jese', '9120391', 'oijer', '1923', 'ojw@.com', 'Contratado', '1', '@jese' )
select * from Empleados


---------Editar Devoluciones
create procedure editar_devolucion
@fecha_devolucion datetime,
@id_devolucion int,
@id_proveedor int,
@id_producto int,
@cod_empleado int
as
update Devoluciones set fecha_devolucion=@fecha_devolucion, id_devolucion=@id_devolucion, id_proveedor=@id_proveedor, id_producto=@id_producto, cod_empleado=@cod_empleado
go


------Eliminar Devolucion
create proc eliminar_devolucion
@fecha_devolucion datetime
as
delete from Devoluciones where fecha_devolucion=@fecha_devolucion
go










