declare @i int;
set @i = 1;
while @i<=10
begin
print concat('i = ...',@i)
set @i = @i+1;
end