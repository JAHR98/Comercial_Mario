

-------Mostrar Pedido-------------------------------------------------------------------------------------
create procedure mostrar_pedido
as
SELECT        dbo.detalle_pedido.id_pedido, dbo.Producto.nombre_producto, dbo.Proveedor.nombre_prveedor, dbo.Proveedor.rtn_proveedor, dbo.detalle_pedido.fecha_pedido, dbo.detalle_pedido.fecha_entrega, dbo.detalle_pedido.cantidad, 
                         dbo.detalle_pedido.estado, dbo.Empleados.nombre_empleado
FROM            dbo.detalle_pedido INNER JOIN
                         dbo.Pedidos ON dbo.detalle_pedido.id_pedido = dbo.Pedidos.id_pedido INNER JOIN
                         dbo.Empleados ON dbo.Pedidos.cod_empleado = dbo.Empleados.cod_empleado INNER JOIN
                         dbo.Producto ON dbo.detalle_pedido.id_producto = dbo.Producto.id_producto INNER JOIN
                         dbo.Proveedor ON dbo.Pedidos.id_proveedor = dbo.Proveedor.id_proveedor

exec mostrar_pedido


-------------Buscar Pedido---------------------------------------------------------------------------------
create proc buscar_pedido
@textobuscar varchar(50)
as
select*from detalle_pedido
where  id_pedido like @textobuscar + '%' 
go



-----------Insertar Pedido-----------------------------------------------------------------------------------
create procedure insertar_pedido
@id_proveedor int,
@cod_empleado int
as
insert into Pedidos values (@id_proveedor,@cod_empleado)
go


---------Insertar detale pedido-------------------------------------------------------------------------------
create procedure insertear_detalle_pedido
@id_pedido int,
@id_producto int,
@fecha_pedido date,
@fecha_entrega date,
@precio_compra money,
@cantidad int,
@estado varchar(20)
as
insert into detalle_pedido values (@id_pedido,@id_producto,@fecha_pedido,@fecha_entrega,@precio_compra,@cantidad,@estado)
go


select * from Pedidos
select * from detalle_pedido


----------------Editar Pedidos----------------------------------------------------------------------------
create proc editar_pedidos
@id_pedido int,
@id_proveedor int,
@cod_empleado int
as
update  Pedidos set id_proveedor=@id_proveedor,cod_empleado=@cod_empleado where id_pedido=@id_pedido
go



--------------------Editar detalle_pedido-------------------------------------------------------------------------
create proc editar_detalle_pedidos
@id_pedido int,
@id_producto int,
@fecha_pedido date,
@fecha_entrega date,
@precio_compra money,
@cantidad int,
@estado varchar(20)
as
update  detalle_pedido set id_producto=@id_producto,fecha_pedido=@fecha_pedido, fecha_entrega=@fecha_entrega, precio_compre=@precio_compra, cantidad=@cantidad, estado=@estado where id_pedido=@id_pedido
go


----------Eliminar de pedidos y detalle_pedidos------------------------------------------------------------------------
create proc eliminar_pedido
@id_pedido int
as
delete from detalle_pedido where id_pedido=@id_pedido
delete from Pedidos where id_pedido=@id_pedido
go

