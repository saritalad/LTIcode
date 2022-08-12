declare @counter int = 1;
while @counter<= 5
begin
print @counter;
set @counter = @counter + 1;
end