--create table customers (id int identity(1,1),name varchar(10),age int,
--address varchar(10), salary decimal(12,2));
--insert into customers values('Ramesh',32,'Mumbai',2000.00);
--insert into customers values('Rupesh',23,'Nagpur',1500.00);
--insert into customers values('komal',27,'Bhopal',3000.00);
--insert into customers values('Muffy',45,'MP',3000.00);
--create table Orders (OrdId int ,Orddate Datetime,customerId int ,amount decimal(12,2))
--insert into orders values (107,'2009-10-08 00:00:00',3,3000)
--insert into orders values (101,'2009-10-08 00:00:00',3,1500)
--insert into orders values (103,'2009-05-08 00:00:00',2,1500)
--insert into orders values (104,'2003-11-08 00:00:00',3,2060)
--insert into orders values (105,'2009-12-08 00:00:00',4,3000)
select Id,ordid,name , orddate from orders inner join customers on orders.customerid=customers.id;
-- left outer join
select Id, ordId,name,orddate from orders right join customers on orders.customerid=customers.id 