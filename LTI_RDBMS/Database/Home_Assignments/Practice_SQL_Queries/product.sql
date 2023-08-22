use myDB;
create table product(id int primary key,pname varchar(20),price decimal(12,00),quantity int,catagory varchar(20));
insert into product values(1,'sop',34.45,2,'natural');
insert into product values(2,'oil',110.34,1,'oliv oil');
select * from product;