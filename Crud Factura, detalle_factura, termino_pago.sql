

select * from Factura
select * from detalle_factura
select * from termino_pago

------Mostrar Factura-----------------------------------------------------------------------------------------------------------
create procedure mostrar_factura
as
SELECT        dbo.Factura.No_factura, dbo.Factura.Fecha, dbo.Cliente.nombre_cliente, dbo.Producto.nombre_producto, 
              dbo.detalle_factura.cantidad, dbo.detalle_factura.precio_unitario, dbo.detalle_factura.importe, 
			  dbo.detalle_factura.ISV, dbo.detalle_factura.Subtotal, dbo.detalle_factura.Total, dbo.Termino_pago.Descripcion,
			  dbo.Empleados.nombre_empleado
FROM            dbo.Cliente INNER JOIN
                         dbo.Factura ON dbo.Cliente.id_cliente = dbo.Factura.id_cliente INNER JOIN
                         dbo.detalle_factura ON dbo.Factura.No_factura = dbo.detalle_factura.No_factura INNER JOIN
                         dbo.Termino_pago ON dbo.Factura.cod_termino = dbo.Termino_pago.cod_termino INNER JOIN
                         dbo.Producto ON dbo.detalle_factura.id_producto = dbo.Producto.id_producto INNER JOIN
                         dbo.Empleados ON dbo.Factura.cod_empleado = dbo.Empleados.cod_empleado

exec mostrar_factura



--------Buscar Factura--------------------------------------------------------------------------------------------------------
create procedure buscar_factura
@textobuscar varchar(50)
as
select*from Factura
where No_factura like @textobuscar + '%' 
go


-------	Insertar Termino de pago-------------------------------------------------------------------------------------------------------
Insert into Termino_pago values('Crédito')
Insert into Termino_pago values('Contado')
Insert into Termino_pago values('Otro')


------Insertar en Factura--------------------------------------------------------------------------------------------------------------
create proc insertar_factura
@fecha date,
@cod_termino int,
@id_cliente int,
@cod_empleado int,
@No_factura int,
@id_producto int,
@cantidad int,
@precio_venta money,
@precio_unitario money,
@importe money,
@ISV money,
@Subtotal money,
@Total money
as
insert into Factura values (@fecha, @cod_termino, @id_cliente, @cod_empleado)
insert into detalle_factura values (@No_factura, @id_producto, @cantidad, @precio_venta, @precio_unitario, @importe, @ISV, @Subtotal, @Total)
go



------Editar Factura----------------------------------------------------------------------------------------------------------------
create proc editar_factura
@fecha date,
@cod_termino int,
@id_cliente int,
@cod_empleado int,
@No_factura int,
@id_producto int,
@cantidad int,
@precio_venta money,
@precio_unitario money,
@importe money,
@ISV money,
@Subtotal money,
@Total money
as
update  Factura set Fecha=@fecha, cod_termino=@cod_termino, id_cliente=@id_cliente, cod_empleado=@cod_empleado
update detalle_factura set @id_producto=@id_producto, cantidad=@cantidad, precio_venta=@precio_venta, precio_unitario=@precio_unitario, importe=@importe, ISV=@ISV, Subtotal=@Subtotal, Total=@Total  where No_factura=@No_factura
go




------------Eliminar Factura------------------------------------------------------------------------------------------------
create proc eliminar_factura
@No_factura int
as
delete from Factura where No_factura=@No_factura
go






