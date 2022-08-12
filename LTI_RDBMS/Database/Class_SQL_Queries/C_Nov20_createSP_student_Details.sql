
create procedure SpAddStudent
(@studentName varchar(20),
@studentLast varchar(20),@ROLL int)
as
begin
insert into student_details(rollno,student_fname,student_lname)values(@Roll,@studentName,@studentLast);
end

exec  SpAddStudent 'Rajni''singlal'where rollno=1;