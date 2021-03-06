---------------------------------------------------------------------
-- TK 70-461 - Chapter 01 - Querying Foundations
-- Code
---------------------------------------------------------------------

---------------------------------------------------------------------
-- Lesson 01 - Understanding the Foundations of T-SQL
---------------------------------------------------------------------

---------------------------------------------------------------------
-- Using T-SQL in a Relational Way
---------------------------------------------------------------------

USE TSQL2012;

SELECT country
FROM HR.Employees;

SELECT DISTINCT country
FROM HR.Employees;

SELECT empid, lastname
FROM HR.Employees;

SELECT empid, lastname
FROM HR.Employees
ORDER BY empid;

SELECT empid, lastname
FROM HR.Employees
ORDER BY 1;

SELECT empid, firstname + ' ' + lastname
FROM HR.Employees;

SELECT empid, firstname + ' ' + lastname AS fullname
FROM HR.Employees;

---------------------------------------------------------------------
-- Lesson 02 - Logical Query Processing
---------------------------------------------------------------------

---------------------------------------------------------------------
-- T-SQL as a Declarative English-Like Language
---------------------------------------------------------------------

SELECT shipperid, phone, companyname
FROM Sales.Shippers;


-- Group

select * from HR.Employees;

select country
from HR.Employees;

select country, count(*)
from HR.Employees
group by country;

select country, firstname
from HR.Employees
group by country;


select country, min(birthdate), max(birthdate), min(city)
from HR.Employees
group by country;

select country, hiredate, max(birthdate)
from HR.Employees
group by country, hiredate;


---------------------------------------------------------------------
-- Logical Query Processing Phases
---------------------------------------------------------------------

SELECT country, YEAR(hiredate) AS yearhired, COUNT(*) AS numemployees
FROM HR.Employees
WHERE hiredate >= '20030101'
GROUP BY country, YEAR(hiredate)
HAVING COUNT(*) > 1
ORDER BY country, yearhired DESC;

-- fails
SELECT country, YEAR(hiredate) AS yearhired
FROM HR.Employees
WHERE yearhired >= 2003;

-- fails
SELECT empid, country, YEAR(hiredate) AS yearhired, yearhired - 1 AS prevyear
FROM HR.Employees;
