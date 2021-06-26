create procedure Producto1
@id_producto int,
@nombre_producto varchar (80),
@descripcion varchar (2000),
@precio_actual int,
@existencia int
as
begin
update Producto
set
   nombre_producto=@nombre_producto,
   descripcion=@descripcion,
   precio_actual=@precio_actual,
   existencia=@existencia
where id_producto=@id_producto
end