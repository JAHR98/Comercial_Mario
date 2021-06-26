

CREATE PROCEDURE actualizar_factura
@No_factura int, 
@id_producto int, 
@cantidad int, 
@precio_venta money, 
@precio_unitario money,
@importe money, 
@isv money,
@subtotal money,
@total money 
AS
Begin
Update detalle_factura
   SET No_factura=@No_factura, 
       id_producto=@id_producto,
	   cantidad=@cantidad,
	   precio_venta=@precio_venta,
	   precio_unitario=@precio_unitario,
	   importe=@importe,
	   isv=@isv,
	   Subtotal=@subtotal,
	   Total=@total
	WHERE No_factura=@No_factura
END
       
       