create table Product(ProductID int primary key identity(1,1),ProductName varchar(50),SupplierID int,CategoryID int,	Unit varchar(40),Price decimal(12,2));
insert into Product values('Chais',1,1,'10 boxes x 20 bags',18);
insert into Product values('Chang',1,1,'24 - 12 oz bottles',13.45);
insert into Product values('Aniseed Syrup',1,2,'12 - 550 ml bottles',19);
insert into Product values('Mishi Kobe Niku',2,3,'18-500 g pkgs.',98);
insert into Product values('Ikura',4,2,'12 - 200 ml jars',112.34);
insert into Product values('Konbu',1,3,'2 kg box',45.6);
insert into Product values('Carnarvon Tigers',1,3,'16 kg pkg',62.4);
insert into Product values('Sir Rodneys Scones',5,6,'24 pkgs. x 4 pieces',33.32);
insert into Product values('Geitost',14,3,'	500 g',78.67);
insert into Product values('Inlagd Sill',11,11,'24 - 250 g jars',100);
insert into Product values('Gravad lax',11,12,'12 - 500 g pkgs.',26);
insert into Product values('Ipoh Coffee',4,5,'6 - 500 g tins',46);
insert into Product values('Filo Mix',3,6,'16 - 2 kg boxes',7);
insert into Product values('Perth Pasties',24,6,'48 pieces',88);
insert into Product values('Chocolade',21,12,'10 pkgs.',56);
insert into Product values('Filo Mix',24,5,'16 - 2 kg boxes',32.4);
select * from product where Price=18;
select * from product where price >18;
select * from product where price<30;
select * from product where price<=30;
select * from product where price>=18;
select * from product where price<>18;--18 will remove in the table
select * from product where price  between 50 and 100;-- between a certain range 
select * from product where productname like'm%';-- starting alphabet 'M' productname serach a pattern
select * from Product where ProductName like '%x';--ending alphabet 'x' in productName
select * from product where ProductName like '%ix%';---in hole  word 'ix' in productname
select * from Product where SupplierID in (7,21,12);--to specifi multiple possible values for a column
select * from Product;