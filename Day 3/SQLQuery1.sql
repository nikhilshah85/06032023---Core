create database shoppingAPP
use shoppingAPP
create table products
(
	pId int primary key, 
	pName varchar(20),
	pCategory varchar(20),
	pPrice int,
	pIsInStock bit
)

insert into products values(101,'Pepsi','Cold-Drinks',50,1)
insert into products values(102,'IPhone','Electronics',50,0)
insert into products values(103,'Nike','Shoes',50,1)
insert into products values(104,'Puma','Shoes',50,0)
insert into products values(105,'Appy','Cold-Drinks',50,1)


select * from products


create table customers
(
	cId int primary key,
	cName varchar(20),
	cCity varchar(20),
	cWalletBalance int,
	cIsActive bit
)
insert into customers values(501,'Priya','Mumbai',600,1)
insert into customers values(502,'Riya','Pune',600,0)
insert into customers values(503,'Jiya','Chennai',600,0)
insert into customers values(504,'Karthikeyan','Bangalore',600,1)





















