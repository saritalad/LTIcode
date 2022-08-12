DECLARE @parentid INT, @parentname varchar(20),
@childid int, @childname varchar(20), @age int;

declare parent_cursor cursor 
for
select parentid,parent_name from parent 

open parent_cursor;

fetch next from parent_cursor into @parentid,@parentname;

select @parentid;
while @@FETCH_STATUS = 0

begin

declare child_cursor cursor
for 
select id,child_name,age from child

where parentid=@parentid;
open child_cursor;

fetch next from child_cursor into @childid, @childname, @age;

             while @@FETCH_STATUS=0

			begin
			if (@age>15)
			print ' college Going Child: '
			else
			print 'School Going Child: '
		
			print ' parentid: '+convert(varchar(20),@parentid)+' Parent Name: ' 
			+@parentname+' Child id: ' +convert(varchar(20),@childid)+ ' Child Name: ' +@childname+' Age of Child: ' +convert(varchar(20),
			@age);


fetch next from child_cursor into @childid, @childname, @age;
              end
			  close child_cursor;
			  deallocate child_cursor;


fetch next from parent_cursor into @parentid,@parentname;
print convert(varchar(20),@parentid) +@parentname;
end
  deallocate parent_cursor;