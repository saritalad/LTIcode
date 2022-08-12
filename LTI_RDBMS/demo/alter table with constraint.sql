use studydb
CREATE TABLE dbo.Employee
(
EmployeeID INT IDENTITY (1,1) NOT NULL
,FirstName VARCHAR(50) NULL
,MiddleName VARCHAR(50) NULL
,LastName VARCHAR(50) NULL
,DateHired datetime NOT NULL
)
alter table dbo.employee
add salary decimal(10,2)

-- Change the datatype to support 100 characters and make NOT NULL
ALTER TABLE dbo.Employee
ALTER COLUMN FirstName VARCHAR(100) NOT NULL

ALTER TABLE dbo.Employee
add  default (1000.00)for salary 
-- Rename column
exec sp_rename 'employee.Firstname', 'fname','column' 