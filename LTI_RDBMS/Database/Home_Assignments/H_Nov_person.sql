create table person(CustomerID int primary key identity(1,1),CustomerName varchar(50),ContactName varchar(30),Address varchar(30)
,City varchar(30),PostalCode int ,Country varchar(30));

insert into person values('Alfreds Futterkiste','Maria Anders','Obere Str. 57','Berlin',12209,'Germany');
insert into person values('Ana Trujillo Emparedados y helados','Ana Trujillo','Constituci�n 2222','M�xico D.F.',05021,'Mexico');
insert into person values('Antonio Moreno Taquer�a','Antonio Moreno','Mataderos 2312','M�xico D.F.',05023,'Mexico');
insert into person values('Around the Horn','Thomas Hardy','120 Hanover Sq.','London',0011,'UK');
insert into person values('Berglunds snabbk�p','Christina Berglund','Berguvsv�gen 8','Lule�',95822,'Sweden');
select customerName,Address from person where  Country='mexico';
select postalcode,city,country from person where CustomerID=4;

 
 select * from person;

