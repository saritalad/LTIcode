create trigger trgAfterInsert on [dbo].[employee_test]
for insert
as
    declare @empid int;
	declare @empname varchar(100);
	declare @empsal decimal(10,2);
	declare @audit_action varchar(100);
	declare @oldsal decimal(10,2);
	declare @oldname varchar(30);


    select @oldsal=d.emp_sal from deleted d;
	select @oldname=d.emp_name from deleted d;

	select @empid=i.emp_id from inserted i;
	select @empname=i.emp_name from inserted i;
	select @empsal=i.emp_sal from inserted i;
	set @audit_action= 'Inserted old_salary and old_name in table in update query ---after insert trigger .';

	insert into employee_test_audit
	(emp_id,emp_name,emp_sal,audit_action,oldSalary)
	values(@empid,@empname,@empsal,@audit_action,@oldsal);

	print 'AFTER INSERT trigger fired .'

GO
 ---------  ----------------------------------------------------------------------------------
create table employee_Test(emp_id int identity(1,1) ,emp_name varchar(20),emp_sal decimal(10,2));
insert into employee_Test values('vani',15550);
insert into employee_Test values('tara',34500);
insert into employee_Test values('jaya',23000);
insert into employee_Test values('viru',24000);
insert into employee_Test values('sujal',35000);
insert into employee_Test values('suraj',36000);
select * from employee_Test;
------------------------------------------------------------------------------------------
create table employee_Test_audit(emp_id int ,emp_name varchar(20),emp_sal decimal(10,2),audit_action varchar(20),audit_timestamp timestamp);
alter table employee_test_audit alter column audit_action varchar(50);


