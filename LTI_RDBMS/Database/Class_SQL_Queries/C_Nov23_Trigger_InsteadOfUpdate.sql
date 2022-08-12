--create trigger on table employee_test for update statement
alter trigger trgInsteadOfUpdate on dbo.employee_test
instead of update
as
		declare @emp_id int, @emp_name varchar(55),
		@emp_sal decimal(10,2),@audit_action varchar(100);

		select @emp_id=i.Emp_Id from inserted i;
		select @emp_name=i.Emp_name from inserted i;
		select @emp_sal=i.Emp_sal from inserted i;

		set @audit_action= 'updated data using trigger.';

		begin
		     begin tran
			  if(@emp_sal<1000)
			  begin
			  raiserror('you can not enter value of salary < 1000',16,1);
			  rollback;
			  end
			  else
			  begin
			  insert into employee_Test_audit(emp_id,emp_name,emp_sal,audit_action)values(@emp_id,@emp_name,@emp_sal,@audit_action);
			  update employee_Test set emp_name=@emp_name,emp_sal=@emp_sal where emp_id=@emp_id
			  commit;
			  print 'Record updated -- Instead of Update Trigger .';
			  end
			  END
			  alter table employee_test_audit add oldSalary int,old_name varchar (30);
			  truncate table employee_test_audit;
