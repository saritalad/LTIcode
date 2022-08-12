use Sql_db
create table sales (id int identity(1,1),itemname varchar(20),price decimal(12,0),qty int);
 insert into sales(itemname,price,qty)values('RedMe 10S',500,10);
 insert into sales(itemname,price,qty)values('Samsung Laptop',100,20);
 insert into sales(itemname,price,qty)values('Canon Photo Coppier',300,2);
 ----------------------------------------------------------------------------------
 begin 
 declare @sales int;
 select @sales=sum(price*qty)from sales;----select sum(price*qty)from sales
 print @sales;
 if @sales>8000
 begin
 print 'Great ! the sales amount is more that 3000';
 end
 else
 print 'oh ! the sales is below expected'
 end