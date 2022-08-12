create function sumN(@n int)--while function used here i=1;i<10;i++ and there sum 
returns int
as
begin
declare @s int=0,@i int=1; ---declaration
while @i<=@n --condition
begin
set @s=@s+@i;  --sum=sum+1
set @i=@i+1  --i++
end
return @s;
end

select dbo.sumN(10);