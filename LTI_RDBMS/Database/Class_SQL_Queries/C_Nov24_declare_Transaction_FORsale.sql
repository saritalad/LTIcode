declare @productid int=2,@qtyforsale int =300,@qty int;
begin transaction
select @qty = qty from tblproducts where productid=@productid;
update tblproducts set qty=qty-@qtyforsale where productid = @productid;
insert into tblsales(productid,qtysold)values(@productid,@qtyforsale);
if(@qty<@qtyforsale)
begin
rollback transaction
print 'transaction failed'
end
else
begin
commit transaction
print 'transaction success'
end
