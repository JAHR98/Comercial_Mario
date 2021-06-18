

--Vista Factura
create view Vista_Factura as
SELECT        dbo.Factura.No_factura, dbo.Producto.id_producto, dbo.Producto.nombre_producto, dbo.Producto.descripcion, dbo.Cliente.nombre_cliente, dbo.detalle_factura.cantidad, dbo.Factura.Fecha
FROM            dbo.Cliente INNER JOIN
                         dbo.Factura ON dbo.Cliente.id_cliente = dbo.Factura.id_cliente INNER JOIN
                         dbo.detalle_factura ON dbo.Factura.No_factura = dbo.detalle_factura.No_factura INNER JOIN
                         dbo.Producto ON dbo.detalle_factura.id_producto = dbo.Producto.id_producto


select * from Vista_Factura
--------------------------------------------------------------------------------------------------------------------------------
--Vista Inventario
create view Vista_Inventario as
SELECT        id_producto, nombre_producto, descripcion, existencia
FROM            dbo.Producto

select * from Vista_Inventario

-------------------------------------------------------------------------------------------------------------------------------
--vista devoluciones
Create view Vista_Devoluciones as
SELECT        dbo.detalle_devoluciones.fecha_devolucion, dbo.Devoluciones.id_proveedor, dbo.detalle_devoluciones.id_producto, dbo.Producto.nombre_producto, dbo.detalle_devoluciones.id_devolucion, 
                         dbo.motivo_devolucion.descripcion
FROM            dbo.detalle_devoluciones INNER JOIN
                         dbo.Devoluciones ON dbo.detalle_devoluciones.fecha_devolucion = dbo.Devoluciones.fecha_devolucion INNER JOIN
                         dbo.motivo_devolucion ON dbo.detalle_devoluciones.id_devolucion = dbo.motivo_devolucion.id_devolucion INNER JOIN
                         dbo.Producto ON dbo.detalle_devoluciones.id_producto = dbo.Producto.id_producto INNER JOIN
                         dbo.Producto_Proveedor ON dbo.Producto.id_producto = dbo.Producto_Proveedor.id_producto

select * from Vista_Devoluciones


-----------------------------------------------------------------------------------------------------------------------------------
--Vista clientes
Create view Vista_Clientes as
SELECT        id_cliente, nombre_cliente, apellido_cliente, identidad_cliente, rtn_cliente, telefono, correo_electronico
FROM            dbo.Cliente

Select * from Vista_Clientes

-------------------------------------------------------------------------------------------------------------------------
--vista factura física
Create view Vista_Factura_FISICA as
SELECT        dbo.Cliente.nombre_cliente, dbo.Cliente.apellido_cliente, dbo.Cliente.identidad_cliente, dbo.Cliente.rtn_cliente, dbo.Cliente.telefono, dbo.Cliente.correo_electronico, dbo.Factura.No_factura, dbo.Factura.Fecha, 
                         dbo.Cliente.id_cliente, dbo.Termino_pago.Descripcion, dbo.detalle_factura.id_producto, dbo.Producto.nombre_producto, dbo.detalle_factura.cantidad, dbo.detalle_factura.precio_unitario, dbo.detalle_factura.importe, 
                         dbo.detalle_factura.ISV, dbo.detalle_factura.Subtotal, dbo.detalle_factura.Total
FROM            dbo.Cliente INNER JOIN
                         dbo.Factura ON dbo.Cliente.id_cliente = dbo.Factura.id_cliente INNER JOIN
                         dbo.detalle_factura ON dbo.Factura.No_factura = dbo.detalle_factura.No_factura INNER JOIN
                         dbo.Producto ON dbo.detalle_factura.id_producto = dbo.Producto.id_producto INNER JOIN
                         dbo.Termino_pago ON dbo.Factura.cod_termino = dbo.Termino_pago.cod_termino

select * from Vista_Factura_FISICA
