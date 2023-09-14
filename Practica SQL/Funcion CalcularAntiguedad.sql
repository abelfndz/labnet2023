/* EJERCICIO 34
Crear la función &quot;fn_AntiguedadEmpleado&quot; que retorne la antiguedad en años de cada
empleado donde el parametro de ingreso es el id del empleado.
*/

CREATE FUNCTION CalcularAntiguedad(@numero INT)
RETURNS int
AS
BEGIN
 
	DECLARE @fechaContratacion date;
	DECLARE @antiguedad int;


	SELECT @fechaContratacion = HIRE_DATE
	FROM TEST.EMPLOYEES
	WHERE ID = @numero;
   
    SET @antiguedad = DATEDIFF(YEAR, @fechaContratacion, GETDATE());

	RETURN @antiguedad;
END;
