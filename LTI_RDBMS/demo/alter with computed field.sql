create table addiontable (num1 int not null,num2 int not null,total as num1+num2)
alter table additiontable add avgofnum as total/2