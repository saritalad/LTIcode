use myDB_SQL;
--drop table  HiredPerson;
create table HiredPerson(ID int primary key,fullname varchar(40),Gender varchar(30),Age int,EmailAddress varchar(40),
Doj date,Salary int);
insert into HiredPerson values(1,'Rajiv Sharma','Male',25,'rajivsharma@gmail.com','2021-12-3',25600);
select * from HiredPerson;