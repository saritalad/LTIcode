declare @myTable table(weeknumber int,
                       dateStarting smalldatetime)
declare @n int = 0
declare @firstweek smalldatetime = '11/01/2021'

--loop through week
while @n<=4
begin
insert into @myTable values (@n,dateadd(wk,@n,@firstweek));
set @n = @n + 1
end
--show result
select weeknumber ,dateStarting from @myTable

					   