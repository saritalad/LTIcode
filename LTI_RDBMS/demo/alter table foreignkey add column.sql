--use studydb
--alter table employee
--add dept_id int foreign key references department(dept_id)


create table tbl( id int identity(1,1) , name varchar(20))
insert into tbl values('Jill')
select * from tbl
delete from tbl 
truncate table tbl
-- select distinct fieldname from tablename avoid to display duplicate values , it will display only once 
select distinct city from employee
select firstname,city from employee
select distinct firstname from employee
select  salary from employee

select distinct name from tbl
select id,Name from  duplicatedata  group by id,Name having COUNT(*)>1
select * from duplicatedata
create table duplicatedata(id int, name varchar(30))
insert into duplicatedata values(1,'bill')


select E.city from employee E group by E.City having count(*)>1
