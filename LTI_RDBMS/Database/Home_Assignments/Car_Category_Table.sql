use myDB_SQL;
--drop table Car_Category; 
--step1:create Category table
create table CCategory(CarID int primary key,Carname varchar(40));
select * from CCategory;

--step2:create Product table and use Foreign Key For CarID
create table CProduct(ProductID int primary key,ProductName varchar(40),
Price decimal,MDF date,CarID int ,Foreign key(CarID)REFERENCES CCategory(CarID));
 select * from CProduct;

--CREATE TABLE Orders (
  --  OrderID int NOT NULL,
    --OrderNumber int NOT NULL,
    --PersonID int,
    --PRIMARY KEY (OrderID),
    --CONSTRAINT FK_PersonOrder FOREIGN KEY (PersonID)
    --REFERENCES Persons(PersonID));
