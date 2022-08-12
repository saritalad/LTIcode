create table MY_table(fcol varchar(20),secondcol tinyint)
exec sp_rename 'My_table.fcol','FirstCol' ,'column'

INSERT INTO My_Table (FirstCol, SecondCol)
SELECT 'First' ,1
UNION ALL
SELECT 'Second' ,2
UNION ALL
SELECT 'Third' ,3
UNION ALL
SELECT 'Fourth' ,4
UNION ALL
SELECT 'Fifth' ,5

