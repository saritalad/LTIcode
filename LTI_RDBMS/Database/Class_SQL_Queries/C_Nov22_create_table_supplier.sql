create table suppliers(supplierId int identity(1,1),Contact_Name varchar(20),city varchar(30))
insert into suppliers values('Raj singh','Dehli');
insert into suppliers values('krishna','Nagpur');
insert into suppliers values('vani','mumbai');
insert into suppliers values('madan','raipur');
insert into suppliers values('raju','indore');
insert into suppliers(Contact_Name,city)values('Asian Paints','Mumbai');
insert into suppliers(Contact_Name,city)values('Ambooja Cement','Ahmadabad');
insert into suppliers(Contact_Name,city)values('Amul Dairy Products','Gandhi Nagar');
insert into suppliers(Contact_Name,city)values('Tata Steels','Jamshetpur');
----------------------------------------------------------------------------------------
set nocount on;
declare @supplier_id int,
@supplier_name varchar(50),
@message varchar(80);
print '------------------supplier products report------------';
declare supplier_cursor cursor for
select supplierid,contact_name
from suppliers
where supplierId<5
order by supplierId;
open supplier_cursor
fetch next from supplier_cursor
into @supplier_id,@supplier_name
while @@FETCH_STATUS = 0
begin
print '  '
set @message = 'products from suppliers : '+@supplier_name
print @message
      --declare an inner cursor based
	  --on supplier_id from the outer cursor.

	  fetch next from supplier_cursor;

end
close supplier_cursor;
deallocate supplier_cursor;



