select 1 + '1'as result;--implicit conversion

select 1 + cast(1 as int )result;---explicit conversion

select 100 + cast('abc50' as int)result;--can not covert explicityly also because it is not a pure number (abc50)

select cast(5.95 as int )result;--float to int

select cast('3.13495' as dec(10,2))result;--string to decimal

select cast('1/15/2021' as smalldatetime)result--string to date