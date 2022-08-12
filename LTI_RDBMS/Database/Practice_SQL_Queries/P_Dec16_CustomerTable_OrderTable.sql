create table customer(CustomerID int primary key identity(1,1),CustomerName varchar(50),ContactName varchar(50),Country varchar(40));
insert into customer values('Alfreds Futterkiste','Maria Anders','	Germany');
insert into customer values('Ana Trujillo','Ana','	Mexico');
insert into customer values ('Moreno Taquería','Antonio Moreno','Mexico');
select * from customer;
--order table
create table Orders(OrderId int,CustomerID int ,OrderDate varchar(30));
insert into Orders values(1120,2,'1990/03/15');
insert into Orders values (1123,3,'2002/05/16');
insert into Orders values (1133,1,'2004/06/26');
select * from Orders;

--join table 
select Orders.OrderId,customer.CustomerName,Orders.OrderDate 
from Orders
inner join customer on Orders.CustomerID=customer.CustomerID;