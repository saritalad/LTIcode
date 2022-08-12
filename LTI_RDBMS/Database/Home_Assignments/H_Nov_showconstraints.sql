--constrainsts
--
primary key
--identity(start,step)
--unique(one record can have null value)
--default(default value assign)
--check(condition for date)
--not null(compulsary field)
--foreign key(data coming from table in same database and not from other database)(
create table showconstraints(ID int primary key identity(11,1),fname varchar(20) not null,lname varchar(20)default('kumar'),salary decimal(12,2)check (salary>10000));
insert into showconstraints(fname)values('shiv');--it take kumare as a lastname because we set lname(default).
insert into showconstraints(fname,lname,salary)values('roshan','thakre',34000.34);--possible bez default value is taken if no entry
alter table  showconstraints add salary decimal(12,2);
alter table showconstraints
alter column fname varchar(30);
alter table showconstraints add salary decimal(12,2)not null;--not possible bez already null value is there  in some record
select * from showconstraints;
drop table showconstraints;

create table Indiancars(carid int primary key identity(12,1),carname varchar(30) unique,
brand varchar(30)check(brand in('Maruti','Mahindra','Tata','Hero','Bajaj')),model varchar(20),price decimal(12,2)check(price>50000));
insert into Indiancars(carname,brand,model,price)values('Tata Indica','Tata','Indica',700000);
insert into Indiancars(carname,brand,model,price)values(null,'Maruti','Swift',600000);
insert into Indiancars(carname,brand,model,price)
select * from Indiancars;



create table mymath(a int,b int);
insert into mymath values(12,11);
select * from mymath;
alter table mymath add constraint pk primary key;