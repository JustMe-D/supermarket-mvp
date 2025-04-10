use Supermarket
create table Category
(
 Category_Id int identity (1000,1) primary key,
 Category_Name nvarchar (50) not null,
 Category_Description nvarchar (50) not null
)
go
INSERT INTO Category (Category_Name, Category_Description) VALUES ('Fruits', 'Fresh fruits')
INSERT INTO Category (Category_Name, Category_Description) VALUES ('Vegetables', 'Fresh vegetables')
INSERT INTO Category (Category_Name, Category_Description) VALUES ('Dairy', 'Milk and dairy products')
