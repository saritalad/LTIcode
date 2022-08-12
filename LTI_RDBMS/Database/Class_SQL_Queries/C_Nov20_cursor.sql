--------cursor forward only------------
declare employeecursor cursor
for select * from Employee
open employeecursor
fetch next from employeecursor
--fetch relative -2 from employeecursor
close employeecursor
deallocate employeecursor
----------------------------------------------------
declare employeecursor cursor scroll
for select * from Employee
open employeecursor
fetch next from employeecursor
fetch first from employeecursor
fetch last from employeecursor
fetch prior from employeecursor
fetch relative -2 from employeecursor
close employeecursor
deallocate employeecursor