declare customer_cursor cursor for
select customerid,country
from customer
open customer_cursor;
fetch next from customer_cursor;
while @@FETCH_STATUS = 0
begin
print 'fetch status '+cast(@@fetch_status as varchar(3))
 fetch next from customer_cursor;
 end;
 print 'fetch status '+cast(@@fetch_status as varchar(3))
 close customer_cursor;
 deallocate customer_cursor;
 go