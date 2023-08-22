--drop table person;
create table person(id int identity(100,1)
,fname varchar(20)
,lname varchar(20)
,Datehired datetime not null);
insert into person values('Ram','Sharma',getdate());

alter table person
add salary decimal(12,2)
update person set salary=34899.45;
select * from person;