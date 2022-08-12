use myDB_SQL;
--drop table Grocery_category;
Create table Grocery_Category(CatID int primary key,Catname varchar(30));
insert into Grocery_Category values(1,'Soap');
insert into Grocery_Category values(2,'Biscuits');
insert into Grocery_Category values(3,'Edible Oil');
insert into Grocery_Category values(4,'Grain');
insert into Grocery_Category values(5,'Handwash');
insert into Grocery_Category values(6,'Pulses');
insert into Grocery_Category values(7,'Shampoo');
insert into Grocery_Category values(8,'Detergent');
select * from Grocery_Category;


create table Grocery_Product(ProID int primary key,ProductName varchar(30),Price decimal(4,2),Quantity int,MFD Date);
insert into Grocery_Product values(1,'LifeBoy','45.3',3,'2021-11-18');
insert into Grocery_Product values(2,'happyhappy','45.6',9,'2021-12-3');
--insert into Grocery_Product values (3,'WalnutOil','110.88',1,'2021-10-6');

select * from Grocery_Product;

--inner join

select Grocery_Category.CatID,Grocery_Product.ProductName,Grocery_Product.Price,Grocery_Product.MFD,Grocery_Product.Quantity,Grocery_Category.Catname
from Grocery_Category 
inner join Grocery_Product on Grocery_Category.CatID=Grocery_Product.ProID;
