-- Tema 1


---------------------------------------------------------------------
-- Exercise 1: Fix Problem with Grouping
---------------------------------------------------------------------

-- 2.

-- fails
SELECT custid, orderid
FROM Sales.Orders
GROUP BY custid;

-- 3.

SELECT custid, MAX(orderid) AS maxorderid
FROM Sales.Orders
GROUP BY custid;

---------------------------------------------------------------------
-- Exercise 2: Fix Problem with Aliasing
---------------------------------------------------------------------

-- 1.

SELECT shipperid, SUM(freight) AS totalfreight
FROM Sales.Orders
WHERE freight > 20000.00
GROUP BY shipperid;

-- 2.

-- fails
SELECT shipperid, SUM(freight) AS totalfreight
FROM Sales.Orders
GROUP BY shipperid
HAVING totalfreight > 20000.00;

-- 3.

SELECT shipperid, SUM(freight) AS totalfreight
FROM Sales.Orders
GROUP BY shipperid
HAVING SUM(freight) > 20000.00;
