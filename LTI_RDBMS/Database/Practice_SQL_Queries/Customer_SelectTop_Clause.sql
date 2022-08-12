use northwind
select*from customers;
select top 3 * from customers;
select postalcode from customers;--column select 
select country,city from customers;
select CompanyName from customers
order by CompanyName
SELECT TOP 50 PERCENT * FROM Customers;
--SELECT * FROM Customers
--FETCH FIRST 50 PERCENT ROWS ONLY;
SELECT TOP 3 * FROM Customers
WHERE Country='Germany';
--SELECT * FROM Customers
--WHERE Country='Germany'
--LIMIT 3;


