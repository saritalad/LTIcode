create trigger trgempDelete on dbo.employee_test
instead of delete --delete from employee_test where id=2
as
declare @empid int,@empname varchar(55),@empsal decimal(10,2),@audit_action varchar(100);
select @empid=d.Emp_id from deleted d;
select @empname=d.Emp_name from deleted d;
select @empsal=d.Emp_sal from deleted d;
begin tran
if(@empsal>1200)
begin
raiserror('cannot delete where salary >1200 ',16,1);
rollback;
end
else
begin
delete from employee_Test where emp_id=@empid;
commit;
insert into employee_Test_audit(emp_id,emp_name,emp_sal,audit_action)
values(@empid,@empname,@empsal,'delete --instead Of Delete Trigger .');
print 'Record Deleted --instead of delete trigger.'
end