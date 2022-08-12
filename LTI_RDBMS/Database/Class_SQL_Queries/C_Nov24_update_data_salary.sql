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
select * from employee_Test
	update employee_Test set emp_sal=15000 where emp_id=14;
	select * from employee_Test_audit