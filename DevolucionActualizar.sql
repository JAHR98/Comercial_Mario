create procedure devoluciones
@fecha_devolucion int,
@id_producto int,
@id_devolucion int
as
begin
update devoluciones
set
   fecha_devolucio=@fecha_devolucion,
   id_producto=@id_producto,
   id_devolucion=@id_devolucion
where devolucion=@fecha_devolucion
end

