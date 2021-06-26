
CREATE PROCEDURE ActualizarClientes
@id_cliente INT,
@nombre_cliente VARCHAR(30),
@apellido_cliente VARCHAR(30),
@identidad_cliente VARCHAR(16),
@rtn_cliente VARCHAR(20),
@telefono INT,
@correo_electronico VARCHAR (20)
AS
BEGIN
UPDATE Cliente
SET 
	nombre_cliente=@nombre_cliente,
	apellido_cliente=@apellido_cliente,
	identidad_cliente=@identidad_cliente,
	rtn_cliente=@rtn_cliente,
	telefono=@telefono,
	correo_electronico=@correo_electronico
WHERE id_cliente=@id_cliente
END
