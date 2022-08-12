-- CONSTRAINSTS
--
--primary key - 
--identity (start,step)
--unique   (one record can have null value )
-- default (default value assign)
-- check   (condition for data)
-- not null (compulsary field
-- foreign key ( data coming from other table in same databse and not from other database)
create table showconstraints(Id int primary key identity(11,1),firstname varchar(20) not null,lastname varchar(20) default('Kumar'));
insert into showconstraints(firstname,salary)values('Shiv',4000);
select * from showconstraints;
alter table showconstraints 
alter column firstname varchar(1);

alter table showconstraints alter column lastname varchar(20) not null;-- possible because default value is taken if no entry
alter table showconstraints add salary decimal(12,2);
alter table showconstraints alter column salary decimal(12,2) not null;-- not possible because already null value is there in some  records 
alter table showconstraints alter column salary decimal(12,0)check(salary>12000.0);
alter table showconstraints drop column salary;

drop table showconstraints;
-----------------

create table showconstraints(Id int primary key identity(11,1),firstname varchar(20) not null,lastname varchar(20) 
default('Kumar'),salary decimal(12,0)check(salary>10000));
create table IndianCars(carid int primary key identity(12,1),carname varchar(30) unique,
brand varchar(30)check(brand  in ('Maruti','Mahindra','Tata','Hero','Bajaj')) , model varchar(10),price decimal(12,0)check(price>50000));
insert into indiancars(carname,brand,model,price)values('Tata Indica','Tata','Indica',700000);
select * from IndianCars;
select * from customers;
create table category(catid int primary key identity(1,1),catname varchar(25) unique check(catname in
('Soap','Shampoo','Detergent','oil','handwash','grains','biscuit','pulses','edible oil')));
insert into category(catname)values('Soap');
insert into category(catname)values('Shampoo');
insert into category(catname)values('Detergent');
insert into category(catname)values('oil');
insert into category(catname)values('handwash');
insert into category(catname)values('grains');
insert into category(catname)values('biscuit');
insert into category(catname)values('pulses');
insert into category(catname)values('edible oil');
insert into category(catname)values(null);
delete from category where catname =null;
select * from category order by catid;
select * from products;
create table products (id int primary key identity(1,1),productname varchar(20),price decimal(10,2) check (price>0.0),mfd date,
catId int foreign key   references category(catid));
insert into products (productname,price,mfd,catid)values('wheet',40,getdate(),6);
insert into products (productname,price,mfd,catid)values('bajara',40,'2021-10-17',6);
insert into products (productname,price,mfd,catid)values('rice',68,'2021-10-8',6);
insert into products (productname,price,mfd,catid)values('Nachani',68,'2020-10-8',6);
insert into products (productname,price,mfd,catid)values('Moti',67,getdate(),1);
insert into products (productname,price,mfd,catid)values('Mysore Sandal Soap',40,'2021-1-17',1);
insert into products (productname,price,mfd,catid)values('Cynthol',45,'2021-10-8',1);
insert into products (productname,price,mfd,catid)values('Life Bouy',68,'2020-10-8',1);
insert into products (productname,price,mfd,catid)values('Dove Shampoo',168,'2020-10-8',1);
insert into products (productname,price,mfd,catid)values('Treseeme Shampoo',168,'2020-10-8',2);
insert into products (productname,price,mfd,catid)values('coconut',168,'2020-2-8',4);
insert into products (productname,price,mfd,catid)values('Almond Hair oil',168,'2020-2-8',4);

select * from products;