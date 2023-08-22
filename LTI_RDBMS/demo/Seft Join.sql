--The following SQL statement matches customers that are from the same city
-- self join

SELECT A.contactName AS CustomerName1, B.contactName AS CustomerName2, A.City
FROM Customers A, Customers B
WHERE A.CustomerID <> B.CustomerID
AND A.City = B.City
ORDER BY A.City;