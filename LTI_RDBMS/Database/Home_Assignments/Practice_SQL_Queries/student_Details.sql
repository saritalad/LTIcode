use SQL_DB;
--drop table student_Details;
create table student_Details(rollno int primary key,Student_Fname varchar(20),Student_lname varchar(20),English int,Science int ,Maths int);
insert into student_Details(rollno,Student_fname,Student_lname)values(1,'Ram','Sharma');
insert into student_Details(rollno,Student_fname,Student_lname,English)values(2,'Vani','Sharma',67);
insert into student_Details(rollno,Student_Fname,Student_lname,Maths)values(3,'Ishant','Krishn',59);
insert into student_Details(rollno,Student_Fname,Student_lname,Science)values(4,'Ranu','Bansali',78);
update student_Details set Student_lname='Borkar'where rollno=2;
update student_Details set English=65 where rollno=1;
update student_Details set Science=49,Maths=78 where rollno=2;
update student_Details set Science=60,Maths=67 where rollno=1;
update student_Details set English=76,Science=65 where rollno=3;
update student_Details set English=88,Maths=80 where rollno=4;
update student_Details set SCience=Science;


select * from student_Details;