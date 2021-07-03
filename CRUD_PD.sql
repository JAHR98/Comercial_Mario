--- Crud Pedidos y detalle de pedidos ---

---Procedimiento Almacenado Mostrar el Pedido y su detalle---
Create Procedure Mostrar_Pedido_Detalle
As
SELECT dbo.Pedidos.id_pedido, dbo.Pedidos.cod_empleado, dbo.detalle_pedido.id_producto, dbo.detalle_pedido.fecha_pedido, dbo.detalle_pedido.fecha_entrega, dbo.detalle_pedido.precio_compre, dbo.detalle_pedido.cantidad
FROM     dbo.Pedidos INNER JOIN
                  dbo.detalle_pedido ON dbo.Pedidos.id_pedido = dbo.detalle_pedido.id_pedido

Exec Mostrar_Pedido_Detalle

---Procedimiento Almacenado Buscar Pedido---
Create Procedure Buscar_Pedido
@idbuscar nvarchar(50)
As
Select*From Pedidos
Where id_pedido like @idbuscar + '%' or cod_empleado like @idbuscar + '%'
go

---Procedimiento Almacenado Agregar Pedido---
Create Procedure Agregar_Pedido
@id_proveedor int,
@cod_empleado int
As
Insert Into Pedidos values(@id_proveedor,@cod_empleado)
Go

---Procedimiento Almacenado Eliminar Pedido---
Create Procedure Eliminar_Pedido
@id_pedido int
As
Begin 
Delete
From Pedidos
Where id_pedido=@id_pedido

END
Go

---Procedimiento Almacenado Que Actualice Detalle Pedido---
Create Procedure Actualizar_DP
@id_pedido int,
@id_producto int,
@fecha_pedido datetime,
@fecha_entrega datetime,
@precio_compre money,
@cantidad int,
@estado varchar(20)
As
Begin 
Update detalle_pedido
Set id_pedido = @id_pedido,
	id_producto = @id_producto,
	fecha_pedido = @fecha_pedido,
	fecha_entrega = @fecha_entrega,
	precio_compre = @precio_compre,
	cantidad = @cantidad,
	estado = @estado
Where id_pedido = @id_pedido
End
Go