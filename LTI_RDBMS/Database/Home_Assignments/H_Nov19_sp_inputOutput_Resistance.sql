use SQL_DB
create procedure CurrentAndVoltage
@current int
@voltage int 
@resistance int output

as
if(@current = 0)
begin 
select @current = 0;

