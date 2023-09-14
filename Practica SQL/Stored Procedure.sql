/* EJERCICIO 35
Crear el Procedimiento almacenado &quot;sp_GetNombreAntiguedad&quot; que retorne el primer
nombre y el apellido separados por una coma y en la segunda columna la antiguedad en año. Usar
la función creada en el punto anterior.
Ordenar por antiguedad descendiente (mas antiguo primero)
*/
CREATE PROCEDURE sp_GetNombreAntiguedad
AS
BEGIN
    SELECT
        CONCAT(e.FIRST_NAME, ', ', e.LAST_NAME) AS 'NOMBRE COMPLETO',
		dbo.CalcularAntiguedad(e.id) AS 'ANTIGUEDAD'
    FROM
        TEST.EMPLOYEES e
    ORDER BY
        Antiguedad DESC;
END;