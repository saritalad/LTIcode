use myDB
select Max(salary) from person  where salary not in (select max(salary) from person)

