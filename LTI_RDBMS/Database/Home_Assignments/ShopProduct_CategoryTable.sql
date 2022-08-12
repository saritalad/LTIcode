use myDB_SQL;
create table Shop_category(CatID int primary key,Catname varchar(40));
select * from Shop_category;

create table Shop_product(ProductID int primary key,ProductName varchar(40),
Price decimal,MDF date,CatID int ,Foreign key(CatID)REFERENCES Shop_category(CatID));
 select * from Shop_product;
