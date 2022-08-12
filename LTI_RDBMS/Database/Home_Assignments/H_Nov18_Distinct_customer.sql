use myDB_SQL;
create table customer(CustomerID int primary key,CustomerName varchar(20),ContactName varchar(20),Address varchar(20),City varchar(20),PostalCode int,Country varchar(20));
insert into customer values(1,'Alfreds Futterkiste','Maria Anders','Obere Str. 57','Berlin',12209,'Germany');
insert into customer values(2,'Ana Trujillo','Ana ',' Constitución 2222','México D.F.',05021,'Mexico');
insert into customer values(3,'Antonio Moreno ','Antonio','Mataderos 2312','México D.F.',05023,'Mexico');
insert into customer values(4,'Around the Horn','Thomas Hardy','120 Hanover Sq.','London',00986,'UK');
insert into customer values(5,'Berglunds snabbköp','Christina Berglund','Berguvsvägen 8','Luleå',95822,'Sweden');

--update customer set ContactName='Alfred Schmidt', City= 'Frankfurt' where CustomerID=1;
--update customer set ContactName='Harry'where Country='Mexico';
--update customer set ContactName='Jaun';
--delete  from customer where CustomerID=4;
--delete from customer where CustomerName='Ana Trujillo';
--select distinct CustomerName,Address from customer;
--delete  customer;
select distinct customername,address from customer;---Distinct is used for select different values 
select * from customer;
