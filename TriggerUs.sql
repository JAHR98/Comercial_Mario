
/* Creación de Trigger que elimina del sistema 
el usuraio de un empleado, al cambiar su estado;
De empleado a Desempleado*/

Create Trigger Eliminar_Usuario
on Usuario
After Alter Table Empleados Alter Column estado varchar(20)
As
Begin

Declare @Us Varchar(20)

Select @Us = E.usuario
From Empleados E
Inner Join inserted I On (E.usuario = I.usuario)

Delete From Usuario
Where E.usuario=I.usuario
