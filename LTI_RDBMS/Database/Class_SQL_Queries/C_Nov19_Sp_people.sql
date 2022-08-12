use myDB
create procedure SPShowEmployeeSalary
(@sal decimal)
as
begin
select * from person where salary <@sal;
end
go
execute SPShowEmployeeSalary 34899.45