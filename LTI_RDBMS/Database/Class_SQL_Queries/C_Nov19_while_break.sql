declare @i int;
set @i = 1;
while @i<=10
begin
if @i=5 break;
print concat('i = ...',@i)
set @i = @i+1;
end