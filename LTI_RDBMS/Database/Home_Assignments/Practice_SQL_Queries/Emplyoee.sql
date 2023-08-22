--drop database myDB;
use myDB_SQL;
--drop table Employee;
create table Employee(Id int primary key identity(1,1) ,fname varchar(20),lname varchar(20),branch varchar(20),city varchar(20));
insert into Employee values(1,'Ishant','Sharma','ETC','Dehli');
insert into Employee values(2,'Krishna','Sharma','ME','Aurangabad');
insert into Employee values(3,'Shubh','Borkar','EE','indore');
insert into Employee values(4,'Ram','Sharma','Civil','hydrabad');
insert into Employee values(5,'Karishma','Kewat','EE','puna');
insert into Employee values(6,'Simmi','gill','CSE','Nagpur');
select fname,lname,city from Employee;
--select city from Employee;
select distinct city from Employee;
select count(city)from Employee;
select * from Employee where city='hydrabad';
select * from Employee where id=3;
select * from Employee order by city;--The ORDER BY keyword is used to sort the result-set in ascending or descending order.
select * from Employee order by city desc;--in decending order
select * from Employee order by city,fname;--fname sorted by cities aphabarical sequence;
insert into Employee(id,fname,lname)values(7,'jaya','shirin');
select * from Employee;