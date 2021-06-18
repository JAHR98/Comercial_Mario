CREATE PROCEDURE EmpleadosActualizar
@cod_empleado INT,
@nombre_empleado VARCHAR (30),
@identidad_empleado VARCHAR (50),
@telefono INT,
@correo_electronico VARCHAR (20),
@estado VARCHAR (20)
AS
BEGIN
UPDATE empleados
SET 
    Nombre=@nombre_empleado,
	Identidad=@identidad_empleado,
	Telefono=@telefono,
	Correo=@correo_electronico,
	Estado=@estado
WHERE Codigo=@cod_empleado
END

