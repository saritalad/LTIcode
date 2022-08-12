select convert (int ,9.95) as result;--float to int 
select convert (money ,9) result;--int to money
select convert(smalldatetime ,'01/13/2020') result;--string to datetime
select convert(datetime,'01/13/2020')result;--string to smalldatetime
select convert (varchar(13),'2020-01-20 00:00:00:000')result
select convert (varchar(13),getdate())result--curent date to varchar