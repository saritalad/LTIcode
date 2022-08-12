use myDB_SQL;
--drop table E_BookCategory;
Create table E_BookCategory(CatID int primary key,Catname varchar(40));
select * from E_BookCategory;

------product table-----
create table E_BookProduct(ID int primary key,Bookname varchar(30),Price decimal,PublishedDate date,
CatID int Foreign key References E_BookCategory(CatID));
select * from  E_BookProduct;

--CREATE TABLE Orders (
  --  OrderID int NOT NULL PRIMARY KEY,
    --OrderNumber int NOT NULL,
    --PersonID int FOREIGN KEY REFERENCES Persons(PersonID)
--);