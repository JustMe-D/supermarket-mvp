use Supermarket
create table Product
(
 Product_Id int identity (100000,1) primary key,
 Product_Name nvarchar (50) not null,
 Product_Price decimal (10, 2) not null,
)
go
insert into Product (Product_Name, Product_Price) values ('Apple', 1.50)
insert into Product (Product_Name, Product_Price) values ('Banana', 0.75)
insert into Product (Product_Name, Product_Price) values ('Orange', 1.20)
insert into Product (Product_Name, Product_Price) values ('Grapes', 2.60)
