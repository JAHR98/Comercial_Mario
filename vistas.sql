create view vista_proveedores
as
SELECT        id_proveedor AS codigo, nombre_prveedor AS proveedor, rtn_proveedor AS rtn, telefono, direccion_proveedor AS direccion
FROM            dbo.Proveedor

select*from vista_proveedores



create view vista_empleados
as
SELECT        cod_empleado AS codigo, nombre_empleado AS nombre, identidad_empleado AS identidad, telefono, correo_electronico AS correo, estado
FROM            dbo.Empleados

select*from vista_empleados



create view vista_pedidos
as
SELECT        dbo.Producto.id_producto AS codigo, dbo.Producto.nombre_producto AS producto, dbo.detalle_pedido.fecha_pedido AS [fecha pedido], dbo.detalle_pedido.fecha_entrega AS [fecha entrega], 
                         dbo.detalle_pedido.precio_compre AS [precio compra], dbo.detalle_pedido.cantidad, dbo.detalle_pedido.estado
FROM            dbo.Producto INNER JOIN
                         dbo.detalle_pedido ON dbo.Producto.id_producto = dbo.detalle_pedido.id_producto

select*from vista_pedidos
