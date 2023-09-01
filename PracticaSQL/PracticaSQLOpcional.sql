/*Recuperación básica de datos*/

/* EJERCICIO 1
Recuperar id, apellido, fecha de contratación, salario de los empleados.
Tip: notar presencia de valores nulos
*/
SELECT ID, LAST_NAME as 'APELLIDO', HIRE_DATE as 'FECHA DE CONTATACION', SALARY as 'SALARIO'
FROM TEST.EMPLOYEES
ORDER BY ID ASC;

/* EJERCICIO 2
Recuperar id, apellido, fecha de contratación, salario anual de los empleados.
*/
SELECT ID, LAST_NAME as 'APELLIDO', HIRE_DATE as 'FECHA DE CONTATACION', SALARY * 12 as 'SALARIO ANUAL'
FROM TEST.EMPLOYEES
ORDER BY ID ASC;
/* EJERCICIO 4
Recuperar id, apellido y nombre, fecha de contratación, salario anual de los
empleados.
*/
SELECT ID, CONCAT(LAST_NAME, ' ', FIRST_NAME) AS 'APELLIDO Y NOMBRE', HIRE_DATE, SALARY * 12 as 'SALARIO ANUAL'
FROM TEST.EMPLOYEES
ORDER BY ID ASC;
/* EJERCICIO 5
Recuperar lista de departamentos que tienen empleados:
*/
/*
	a. Recuperar lista de departamentos de los empleados
*/
SELECT D.DEPARTMENT_NAME as 'NOMBRE DEPARTAMENTO'
FROM TEST.EMPLOYEES AS E
JOIN TEST.DEPARTMENTS AS D ON E.DEPARTMENT_ID = D.ID
ORDER BY D.DEPARTMENT_NAME ASC;
/*
	b. Recuperar lista no repetida de departamentos de los empleados
*/
SELECT DISTINCT D.DEPARTMENT_NAME as 'NOMBRE DEPARTAMENTO'
FROM TEST.EMPLOYEES AS E
JOIN TEST.DEPARTMENTS AS D ON E.DEPARTMENT_ID = D.ID
ORDER BY D.DEPARTMENT_NAME ASC;





/* EJERCICIO 5
Recuperar máximo, mínimo, promedio, y suma total de fecha de contratación de
los empleados.
*/

SELECT
  MAX([HIRE_DATE]) AS MAX_HIRE_DATE,
  MIN([HIRE_DATE]) AS MIN_HIRE_DATE,
  AVG(CAST([HIRE_DATE] AS FLOAT)) AS AVG_HIRE_DATE,
  SUM(DATEDIFF(DAY, '2000-01-01', [HIRE_DATE])) AS TOTAL_DAYS
FROM [TEST].[EMPLOYEES];
