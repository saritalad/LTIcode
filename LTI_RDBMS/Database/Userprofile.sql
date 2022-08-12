use myDB_SQL;
--drop table  UserProfile;
Create table UserProfile(UserId int primary Key,Username varchar(30)not null unique ,Password varchar(30)not null,IsActive BIT null);
insert into UserProfile values(1,'JayShree','JAy@112',1);
select * from UserProfile;
