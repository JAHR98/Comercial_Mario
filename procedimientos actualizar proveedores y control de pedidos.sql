create procedure ProveedoresActualizar
@id_proveedor int,
@nombre_prveedor varchar(80),
@rtn_proveedor varchar (15),
@telefono int,
@direccion_proveedor varchar (500)

AS
BEGIN
UPDATE Proveedor

SET

nombre_prveedor=@nombre_prveedor,
rtn_proveedor=@rtn_proveedor,
telefono=@telefono,
direccion_proveedor=@direccion_proveedor

where id_proveedor=@id_proveedor

END


create procedure controlPedidos
@id_pedido int,
@id_producto int,
@nombre_producto varchar (80),
@fecha_pedido datetime,
@fecha_entrega datetime,
@precio_compre money,
@cantidad int,
@estado varchar (20)

as
begin
update Producto 
set

nombre_producto=@nombre_producto

where id_producto=@id_producto

update detalle_pedido
set 
fecha_pedido=@fecha_pedido,
fecha_entrega=fecha_entrega,
precio_compre=@precio_compre,
cantidad=@cantidad,
estado=@estado


where id_pedido=@id_pedido
end






