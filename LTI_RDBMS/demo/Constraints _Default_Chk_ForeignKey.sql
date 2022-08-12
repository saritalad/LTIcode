drop tABLE EMP;
create table emp(id int identity(1,1) primary key,name varchar(10) not null, age int default(22) check (age>=20))
insert into emp(name)values('Bill');
DROP TABLE DEPARTMENT;
CREATE TABLE DEPARTMENT (ID INT IDENTITY(10,1) PRIMARY KEY,dEPT VARCHAR(10));

ALTER TABLE EMP ADD  DEPTID INT  FOREIGN KEY (DEPTID) REFERENCES DEPARTMENT(ID);

CREATE TABLE emp(id int identity(1,1) ,name varchar(10) not null, age int default(22) check (age>=20),
DEPTID INT,
PRIMARY KEY (ID),
fOREIGN KEY (DEPTID) REFERENCES DEPARTMENT(Id)
)



)