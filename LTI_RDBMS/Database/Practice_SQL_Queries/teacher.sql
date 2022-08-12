create table teacher(id int primary key,fname varchar(20),lname varchar(20),qualification varchar(20),institute varchar(20),category varchar(20));
insert into teacher values(1,'Ram','Sharma','BA','D.A.K','math');
insert into teacher values(2,'Shyam','Patel','Phd','G.N.T','Physics');
insert into teacher values(3,'Rani','Sahu','Mtec','sb.jain','Chemistry');
insert into teacher values(4,'krishna','Singh','BE','J.I.T','Java');
insert into teacher values(5,'ishita','Panday','Bsc','Anugman','math');
select fname,lname from  teacher;
--select fname,lname,category from teacher where category='ma%'; 
update teacher set fname='sani' where id=3;
select id,fname+''+lname as 'fullname'from teacher;
select id as teacherid,fname+''+lname as name,category as 'teacher category' from teacher;

select * from teacher;