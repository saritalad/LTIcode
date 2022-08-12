use SQL_DB
set ansi_nulls off
select * from child where parentID<>null
select * from child
set quoted_identifier on
select "parent_name" from "parent" where parentid<10;
--when it on,column ,sp name,table,name view name can be used as quated""
set quoted_identifier off
select "parent_name" from "parent" where parentid<10;----when quoted_identifier off " " is treated as a data . syntax error occur
set nocount off -----when nocount is on 'affected message 'not display
select * from child where parentID<>null
select * from child