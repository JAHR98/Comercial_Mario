
--Trigger que debita el Stock--
Create Trigger Deditar_Existencia
on [detalle_pedido]
for Insert
as
Update P set P.Existencia=P.Existencia-D.Cantidad
from Producto as P inner join 
inserted as D on D.id_producto=P.id_producto

--Trigger que regresa el Stock--
Create Trigger Regresar_Existencia
on [detalle_pedido]
for Delete
as
Update P set P.Existencia=P.Existencia+D.Cantidad
from Producto as P inner join 
Deleted as D on D.id_producto=P.id_producto

--Trigger que actualiza el Stock--
Create Trigger Actualizar_Existencia
on[detalle_pedido]
for Update
as
Update P set P.Existencia=P.Existencia+D.Cantidad
from Producto as P inner join 
Deleted as D on D.id_producto=P.id_producto

Update P set P.Existencia=P.Existencia-D.Cantidad
from Producto as P inner join 
inserted as D on D.id_producto=P.id_producto