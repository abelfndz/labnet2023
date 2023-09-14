/* EJERCICIO 36
Crear una nueva tabla de “Auditoria” con los siguientes campos:
ID (auto incremental),
Operación (si se hace un insert/delete/update)
Fecha
*/
CREATE TABLE Auditoria (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    Operacion VARCHAR(10),
    FECHA DATETIME
);
