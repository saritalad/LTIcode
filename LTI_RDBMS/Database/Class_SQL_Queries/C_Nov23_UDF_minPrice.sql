
create function minpricebycategory(@catid int)
returns money
as
begin
declare @minimumprice decimal;
select @minimumprice=  min(price)from product where catid=@catid;
return @minimumprice;
end;
select dbo.minpricebycategory(2);
