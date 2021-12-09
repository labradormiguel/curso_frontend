USE TSQL2012;

SELECT *
	FROM HR.employees;

SELECT country
	FROM HR.employees;

SELECT DISTINCT country
	FROM HR.Employees;

SELECT empid, lastname
	FROM HR.Employees
	ORDER BY empid;

--SELECT empid, lastname
--	FROM HR.Employees
--	ORDER BY 1; // mejor usar nombre de la tabla

SELECT empid, firstname + ' ' + lastname
	FROM HR.Employees;

SELECT empid, firstname + ' ' + lastname AS "Full Name"
	FROM HR.Employees;