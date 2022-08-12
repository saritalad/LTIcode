declare @name varchar(50)--database name
declare @path varchar (256)--path for backup files
declare @filename varchar(256)--file name for backup
declare @filedate varchar(20)--used for file name

set @path = 'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\Backup\'

select @filedate = convert(varchar(20),getdate(),112)

declare db_cursor cursor for
select name 
from master.dbo.sysdatabases
where name not in ('master','model','msdb','tempdb')
 
 open db_cursor
 fetch next from db_cursor into @name

 while @@FETCH_STATUS = 0
 begin 
    set @filename = @path + @name + ' '+ @filedate + '.bak'
	backup database @name to disk = @filename
	fetch next from db_cursor into @name
	end

close db_cursor
deallocate db_cursor