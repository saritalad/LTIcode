SELECT GETDATE(), MONTH(GETDATE()) as month , MONTH('20210101') as month
, MONTH('2021-05-30 15:46:19.277') as month;
-------------------
SELECT GETDATE(), DAY(GETDATE()) , DAY('20210101'), DAY('2021-05-30 15:46:19.277');
--------------------------------------
--Date Function EOMONTH()

SELECT EOMONTH(GETDATE()), EOMONTH('20210101'), EOMONTH('May 1, 2021');
--------------------
--Syntax: DATEADD(date part, units, date or datetime)
--Example of DATEADD():
SELECT DATEADD(DAY,1,'2021-01-01') as 'Add 1 Day',
   DATEADD(WEEK,1,'2021-01-01') as 'Add 1 Week',
   DATEADD(MONTH,1,'2021-01-01') as 'Add 1 Month',
   DATEADD(YEAR,1,'2021-01-01') as 'Add 1 Year';