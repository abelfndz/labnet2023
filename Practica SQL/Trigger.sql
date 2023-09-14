/* EJERCICIO 37
Crear un trigger sobre la tabla de empleados que al hacer un insert/delete/update registre en la
nueva tabla de auditoria la operación realizada.
*/

CREATE TRIGGER tr_AuditoriaEmpleados
ON TEST.EMPLOYEES
AFTER INSERT, DELETE, UPDATE
AS
BEGIN
    DECLARE @Operacion VARCHAR(10);
    
    IF EXISTS (SELECT * FROM inserted)
    BEGIN
        SET @Operacion = 'INSERT';
    END
    ELSE IF EXISTS (SELECT * FROM deleted)
    BEGIN
        SET @Operacion = 'DELETE';
    END
    ELSE
    BEGIN
        SET @Operacion = 'UPDATE';
    END
    
    INSERT INTO Auditoria (Operacion, Fecha)
    VALUES (@Operacion, GETDATE());
END;