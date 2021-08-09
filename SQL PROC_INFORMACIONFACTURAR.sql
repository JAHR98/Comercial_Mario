
--Mostrar Informacion de Producto
create proc informacion_producto
@cod_producto int
as
SELECT       dbo.Producto_Proveedor.id_proveedor, dbo.Producto_Proveedor.cod_producto AS Cod_Producto, dbo.Proveedor.nombre_prveedor, dbo.Producto.nombre_producto, dbo.Producto.existencia, dbo.Producto.precio_actual, 
                         dbo.Producto.descripcion, dbo.Producto.marca_producto, dbo.Producto.imagen
FROM            dbo.Producto INNER JOIN
                         dbo.Producto_Proveedor ON dbo.Producto.cod_producto = dbo.Producto_Proveedor.cod_producto INNER JOIN
                         dbo.Proveedor ON dbo.Producto_Proveedor.id_proveedor = dbo.Proveedor.id_proveedor
where dbo.Producto.cod_producto=@cod_producto

