create database practiceDB
use practiceDB
create table Employee(EmployeeID int primary key identity(1,1),Employee_Name varchar(20),Employee_LastName varchar(30),
city varchar(20),Salary decimal(10,2),Gross_salary decimal(10,2));
insert into Employee values('Ram','Kapoor','Dehli',1000000,50000.00);
insert into Employee values('Jiya','Arora','Nagpur',50000,10000.00);
insert into Employee values('Sita','Kapoor','Dehli',30000,5000.00);
insert into Employee values('Jankii','singal','Mumbai',35000,7000.00);
insert into Employee values('Laxmi','veeramma','Tamil',42000,8000.00);
insert into Employee values('Durag','Chilkewaare','Nagpur',65000,9000.00);
insert into Employee values('Nita','Ambanii','Surat',18000,5600.00);
insert into Employee values('Rurabh','Khurana','Mumbai',8000,500.00);
insert into Employee values('Shyam','Patil','Hydrabaad',15000,700.00);
insert into Employee values('Priyank','Somkur','Aurgabaad',3000,365.00);
insert into Employee values('Navneet','Motghare','Hydrabaad',4000,389.00);
insert into Employee values('Shivani','Wanjari','Puna',7000,500.00);
insert into Employee values('Shewta','Bhad','Puna',7000,500.00);
insert into Employee values('Senahl','Ghorle','Indore',7000,500.00);
insert into Employee values('Radha','Borkar','Manali',80000,5000.00);
insert into Employee values('Shubham','Borkar','Manali',80000,5000.00);
insert into Employee values('Nanu','Pandey','Goa',80000,5000.00);
insert into Employee values('Priya','Pandey','Goa',53000,5450.00);
insert into Employee values('Suraj','Marbate','Jaypur',53000,5450.00);
insert into Employee values('Sujal','Marbate','Jaypur',53000,5450.00);


select * from Employee;