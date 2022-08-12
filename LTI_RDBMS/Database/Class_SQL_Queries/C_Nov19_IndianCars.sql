
create table IndianCars(carid int primary key identity(12,1),carname varchar(20),brand varchar(20),model varchar(20),price int,model_year int);

insert into IndianCars values('Maruti car','Maruti','Alto K-10',400000,'1990');
insert into IndianCars values('swiftdezir','maruti','swift',600000,'2005');
insert into IndianCars values('tata indica','tata','indica',700000,'2001');
insert into IndianCars values('indica5','tata','tata indica',780000,'1987');
insert into IndianCars values('boolero7','Mahindra','boolero',98000,'1987');
insert into IndianCars values('tiago5','tata','tataTiago',908000,'1989');

select * from IndianCars;