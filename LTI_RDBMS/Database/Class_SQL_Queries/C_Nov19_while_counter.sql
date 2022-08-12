declare @counter int = 1;
while @counter<= 5
begin
if @counter = 4
continue;
print @counter;
set @counter = @counter + 1;
end