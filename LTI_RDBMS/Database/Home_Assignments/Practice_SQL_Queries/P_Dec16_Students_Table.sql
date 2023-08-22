use practiceDB;
create table students(rollno int primary key identity(1,1),First_name varchar(30),Last_name varchar(30),
Eng int,Maths int ,Sci int);
insert into students (First_name,Last_name,Eng,Maths,Sci)values('Ram','Kapoor',45,56,78);
insert into students values('priya','sharma',56,78,87);
insert into students values('Diya','Verma',65,13,34);
insert into students values('sujal','veer',66,88,77);
insert into students values('gopal','shahu',50,38,17);
insert into students values('Kirshna','Vasudeva',78,78,87);
insert into students values('Koohu','maari',76,48,37);
insert into students values('janvi','Birla',57,48,67);
insert into students values('meet','Hooda',56,78,80);
insert into students values('kailash','yadhav',66,38,27);
insert into students values('deepa','pandey',76,55,33);
insert into students values('Shubh','Borkar',76,70,80);
insert into students values('Nawab','Ali',56,78,87);
select top 5 * from students ;
SELECT TOP 50 PERCENT * FROM students;
select min(Maths)as min_Marks_Maths
from students;
select max(Eng)as max_Marks_Eng from students;
select count(eng) from students;
select AVG(eng) as AverageMarks from students;
select * from students 
where First_name like '_a%';--second alphabet is 'a' in the name 
select Last_name from students where maths in (78);
select First_name,Eng from students where eng between 40 and 78;
select eng as English_Marks from students; -- Aliases ::tempaory name of column 
                                           --An alias only exists for the duration of that query.
                                           --An alias is created with the AS keyword.
select * from students;