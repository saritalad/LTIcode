create procedure getproductBYcatid(@catID int)
as
begin
select * from products where catid=@catID;
end
go
exec  getproductBYcatid(@catID int) 2
