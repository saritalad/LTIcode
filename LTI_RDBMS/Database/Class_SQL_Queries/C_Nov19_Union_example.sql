use myDB;
select firstname,lastname from student
union
select fname ,lname from Employee;
