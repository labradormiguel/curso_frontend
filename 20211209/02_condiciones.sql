USE TSQL2012;

SELECT country, count(*) AS cantidad
	FROM HR.Employees
	GROUP BY country;

--SELECT country, firstname
--	FROM HR.Employees
--	GROUP BY country;

SELECT country, min(birthdate), max(birthdate), min(city) -- min(city) coge la primera ciudad por orden alfabético
	FROM HR.Employees
	GROUP BY country;

SELECT country, hiredate, max(birthdate), count(*) -- hay dos que se contrataron el mismo día
	FROM HR.Employees
	GROUP BY country, hiredate;

SELECT country, YEAR(hiredate) AS yearhired, COUNT(*) AS numemployees
	FROM HR.Employees
	WHERE hiredate >= '20030101'
	GROUP BY country, YEAR(hiredate)
	HAVING COUNT(*) > 1
	ORDER BY country, yearhired DESC;

SELECT country,  YEAR(hiredate) AS yearhired
	FROM HR.Employees
	WHERE yearhired >= 2003; -- esto casca porque se ejecuta el WHERE antes que el SELECT

-- el orden de ejecución sería FROM -> WHERE -> GROUP BY -> HAVING -> SELECT -> ORDER BY
