---CRUD Factura,Detalle Factura,Termino_Pago


---CRUD Factura

---Insertar Factura
CREATE PROCEDURE insertar_factura
@Fecha date,
@cod_termino int,
@id_cliente int,
@cod_empleado int
AS
INSERT INTO Factura(Fecha,cod_termino,id_cliente,cod_empleado) VALUES (@Fecha,@cod_termino,@id_cliente,@cod_empleado)
GO


---Editar Factura
CREATE PROCEDURE editar_detallefactura
@Fecha date,
@cod_termino int,
@id_cliente int,
@cod_empleado int
AS
UPDATE Factura SET Fecha=@Fecha,cod_termino=@cod_termino,id_cliente=@id_cliente,cod_empleado=@cod_empleado
GO

---Eliminar Factura
CREATE PROCEDURE eliminar_factura
@No_factura int
AS
DELETE FROM Factura WHERE No_factura=@No_factura
GO


---Mostrar Facturas
CREATE PROCEDURE mostrar_factura
AS
SELECT * from Factura


---Buscar x Factura
CREATE PROCEDURE buscar_factura
@numfactura int
AS
SELECT * FROM Factura
WHERE No_factura LIKE @numfactura + '%'
GO


---CRUD Detalle Factura


---Mostrar detalle factura

CREATE PROCEDURE mostrar_detallefactura
AS
SELECT * from detalle_factura

---Buscar x Detalle

CREATE PROCEDURE buscar_detallefactura
@numfactura int
AS
SELECT * FROM detalle_factura
WHERE No_factura LIKE @numfactura + '%'
GO

---Insertar Detalle Factura

CREATE PROCEDURE insertar_detallefactura
@No_factura int,
@id_producto int,
@cantidad int,
@precio_venta money,
@precio_unitario money,
@importe money,
@ISV money,
@Subtotal money,
@Total money
AS
INSERT INTO detalle_factura VALUES (@No_factura,@id_producto,@cantidad,@precio_venta,@precio_unitario,@importe,@ISV,@Subtotal,@Total)
GO


---Editar Detalle Factura
CREATE PROCEDURE editar_detallefactura
@No_factura int,
@id_producto int,
@cantidad int,
@precio_venta money,
@precio_unitario money,
@importe money,
@ISV money,
@Subtotal money,
@Total money
AS
UPDATE detalle_factura SET No_factura=@No_factura,id_producto=@id_producto,cantidad=@cantidad,precio_venta=@precio_venta,precio_unitario=@precio_unitario,importe=@importe,ISV=@ISV,Subtotal=@Subtotal,Total=@Total
GO

---CRUD TERMINO_PAGO

---Insertar Termino_Pago

CREATE PROCEDURE insertar_termino
@Descripcion varchar(100)
AS
INSERT INTO Termino_pago(Descripcion) VALUES (@Descripcion) 
GO

---Editar Termino_Pago
CREATE PROCEDURE editar_termino
@cod_termino int,
@Descripcion varchar(100)
AS
UPDATE Termino_pago SET cod_termino=@cod_termino,Descripcion=@Descripcion
GO

---Eliminar Termino_pago
CREATE PROCEDURE eliminar_termino
@cod_termino int
AS
DELETE FROM Termino_pago WHERE cod_termino=@cod_termino
GO

---Mostrar terminos

CREATE PROCEDURE mostrar_termino
AS
SELECT * from Termino_pago

---Buscar x termino

CREATE PROCEDURE buscar_termino
@cod_termino int
AS
SELECT * FROM Termino_pago
WHERE cod_termino LIKE @cod_termino + '%'
GO

