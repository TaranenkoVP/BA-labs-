/* DELETE */
Use master
GO
Drop Database Lab_1_7_3
GO

/* CREATE */
Create Database Lab_1_7_3 on
(
	NAME ='Lab_1_7_3',
	Filename = 'E:\OneDrive\c#\BA\Lab Work 1.7.3 DDB\Lab_1_7_3.mdf',
	Size = 10mb,
	Maxsize = 100mb,
	FileGrowth = 10mb
)
Log on
(
	NAME ='Lab_1_7_3_log',
	Filename = 'E:\OneDrive\c#\BA\Lab Work 1.7.3 DDB\Lab_1_7_3_log.ldf',
	Size = 10mb,
	Maxsize = 50mb,
	FileGrowth = 5mb
)
collate Cyrillic_General_CI_AS

use Lab_1_7_3
GO

/* ADD TABLES */
CREATE TABLE ProductTypes
(
	ProductTypeID int IDENTITY NOT NULL ,
	ProductTypeName VARCHAR (40) NOT NULL,
)
GO
CREATE TABLE Products
(
	ProductID int IDENTITY NOT NULL ,
	ProductName VARCHAR (40) NOT NULL,
	ProductPrice  money NULL,
	ProductDescription VARCHAR (60) NULL,
	ProductTypeID int NOT NULL,
	SupplierID  int NOT NULL
)
GO
CREATE TABLE Customers
(
	CustomerID int IDENTITY NOT NULL,
	CustomerName VARCHAR (40) NOT NULL, 
	CustomerPhone char(12) NULL,
	CustomerEmail VARCHAR (21) NULL,
	CustomerDetails VARCHAR (60) NULL
)
GO
CREATE TABLE Orders
(
	OrderID int IDENTITY NOT NULL,
	CustomerID int NOT NULL,
	OrderStatusID int NOT NULL,
	OrderDetails VARCHAR (60) NULL,
	OrderDate date DEFAULT GETDATE()
)
GO
CREATE TABLE OrderList
(
	OrderListID int IDENTITY NOT NULL,
	OrderID int NOT NULL,
	ProductID int NOT NULL,
	ProductQuantity DECIMAL (10, 3) NOT NULL
)
GO
CREATE TABLE Suppliers
(
	SupplierID int IDENTITY NOT NULL,
	supplierName VARCHAR (40),
	suplierPhone char(12) NULL,
	supplierEmail VARCHAR (21) NULL
)
GO
CREATE TABLE OrderStatus
(
	OrderStatusID int IDENTITY NOT NULL,
	OrderStatusName VARCHAR (40) NULL,
)
GO

/* DELETE TABLES */
DROP TABLE OrderList
DROP TABLE OrderStatus
DROP TABLE Orders
DROP TABLE Products
DROP TABLE ProductTypes
DROP TABLE Suppliers
DROP TABLE Customers

/* CONSTRAINTS */
ALTER TABLE Suppliers ADD
	CONSTRAINT PK_SupplierID PRIMARY KEY CLUSTERED (SupplierID ASC)
GO
ALTER TABLE ProductTypes ADD
	CONSTRAINT PK_ProductTypeID PRIMARY KEY CLUSTERED (ProductTypeID ASC)
GO
ALTER TABLE Products ADD 
	CONSTRAINT PK_ProductID PRIMARY KEY CLUSTERED (ProductID ASC),
	CONSTRAINT FK_SupplierID FOREIGN KEY(SupplierId) REFERENCES Suppliers(SupplierID), 
	CONSTRAINT FK_ProductTypeID FOREIGN KEY(ProductTypeID) REFERENCES ProductTypes(ProductTypeID) 
GO
ALTER TABLE Customers ADD
	CONSTRAINT PK_CustomerID PRIMARY KEY CLUSTERED (CustomerID ASC),
	CHECK (CustomerPhone LIKE '([0-9][0-9][0-9])[0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
GO
ALTER TABLE OrderStatus ADD
	CONSTRAINT PK_OrderStatusID PRIMARY KEY CLUSTERED (OrderStatusID ASC)
GO
ALTER TABLE Orders ADD
	CONSTRAINT PK_OrderID PRIMARY KEY CLUSTERED (OrderID ASC), 
	CONSTRAINT FK_CustomerID FOREIGN KEY(CustomerId) REFERENCES Customers(CustomerID),
	CONSTRAINT FK_OrderStatusID FOREIGN KEY(OrderStatusId) REFERENCES OrderStatus(OrderStatusID)
GO
ALTER TABLE OrderList ADD
	CONSTRAINT PK_OrderListID  PRIMARY KEY CLUSTERED (OrderListID ASC,OrderID ASC),
	CONSTRAINT FK_OrderID FOREIGN KEY(OrderID) REFERENCES Orders(OrderID),
	CONSTRAINT FK_ProductID FOREIGN KEY(ProductID) REFERENCES Products(ProductID)
GO

/*  CREATE ROWS */
INSERT Customers(CustomerName, CustomerPhone, CustomerEmail, CustomerDetails)
VALUES
	('Customer1', '(091)3212211', 'Customer1@example.com', 'Details1'),
	('Customer2', '(092)3212211', 'Customer2@example.com', 'Details2'),
	('Customer3', NULL, 'Customer3@example.com', 'Details3'),
	('Customer4', '(094)3212211', NULL, NULL),
	('Customer5', NULL, 'Customer5@example.com', NULL),
	('Customer6', NULL, 'Customer6@example.com', NULL);
GO
INSERT Suppliers(supplierName,suplierPhone,supplierEmail)
VALUES
	('Supplier1','(091)3214567', 'Supplier1@example.com'),
	('Supplier2','(092)3214567', 'Supplier2@example.com'),
	('Supplier3', NULL, NULL),
	('Supplier4', '(094)3214567', NULL),
	('Supplier5', '(095)3214567', 'Supplier5@example.com'),
	('Supplier6', NULL, NULL);
GO
INSERT ProductTypes(ProductTypeName)
VALUES
	('milk'),
	('tea'),
	('beer'),
	('wine'),
	('whisky'),
	('shake'),
	('whisky');
GO
INSERT Products(ProductName, ProductPrice, ProductDescription, ProductTypeID, SupplierID )
VALUES
	('Product1', 100, 'new', 1, 4),
	('Product2', 200, 'old', 3, 3),
	('Product3', 32.2512, 'oldest',4, 2),
	('Product4', 400, NULL, 6,1),
	('Product5', 4580.67, NULL, 2, 5),
	('Product6', NULL, NULL, 1,3),
	('Product7', 230, 'fresh', 4, 4);
GO
INSERT OrderStatus( OrderStatusName)
VALUES
	('waiting'),
	('prepare'),
	('ready');
GO
INSERT Orders(CustomerID, OrderStatusID, OrderDetails, OrderDate )
VALUES
	(4,1, NULL, '11/20/2015'),
	(3,2, 'high price', '11/20/2014'),
	(1,3, 'free', NULL),
	(5,2, NULL, '11/20/2013'),
	(2,3, NULL, '11/20/2013'),
	(3,1, NULL, '11/20/2013'),
	(3,2, NULL, NULL),
	(2,1, NULL, NULL);
GO
INSERT OrderList(OrderID, ProductID, ProductQuantity )
VALUES
	(4, 3, 5.6),
	(3, 2, 6.54),
	(1, 5, 34.4),
	(5, 1, 47),
	(5, 2, 4),
	(1, 3, 6),
	(1, 4, 9),
	(8, 5, 78.7);
GO

/* UPDATE */
UPDATE Orders
SET OrderDetails = 'for me' 
WHERE OrderDetails is NULL
GO
UPDATE Products
SET  ProductPrice = 33
WHERE (ProductName = 'Product3' or ProductName = 'Product5') and ProductPrice is NULL
GO

/* DELETE */
TRUNCATE TABLE OrderList;
GO
TRUNCATE TABLE Orders;
GO
TRUNCATE TABLE Products;
GO
TRUNCATE TABLE ProductTypes;
GO
DELETE Orders
WHERE OrderStatusID = 3
GO

/* READ */
SELECT * FROM Orders
SELECT * FROM Customers
SELECT * FROM Suppliers
SELECT * FROM Products
SELECT * FROM OrderList
SELECT * FROM ProductTypes

-- orders lines
SELECT
	 Orders.OrderID as number,
	 OrderList.OrderListID as item,
	 OrderStatusName as [current status],
	 CustomerName as customer,
	 ProductName as product,
	 SupplierName as supplier,
	 ProductTypeName as [type], 
	 ProductQuantity as quantity,
	 ProductPrice as price,
	 CAST(ProductQuantity * ProductPrice as DEC(14,2)) as [sum]
FROM Orders 
	LEFT JOIN OrderList 
			JOIN Products
				JOIN Suppliers
					ON	Products.SupplierID = Suppliers.SupplierID
				JOIN ProductTypes
					ON	Products.ProductTypeID = ProductTypes.ProductTypeID
			ON	OrderList.ProductID = Products.ProductID
		ON  Orders.OrderID = OrderList.OrderID
	JOIN OrderStatus
		ON	Orders.OrderStatusID = OrderStatus.OrderStatusID
	JOIN Customers
		ON	Orders.CustomerID = Customers.CustomerID

-- Products by day
SELECT OrderList.ProductID as ProductID , ProductName, sum(ProductQuantity) as Quantity, sum(CAST(ProductQuantity * ProductPrice as DEC(14,2))) as [sum]
From OrderList
	JOIN Orders
		ON Orders.OrderID = OrderList.OrderID
	JOIN Products
		ON	OrderList.ProductID = Products.ProductID
WHERE OrderDate = '11/20/2013'
GROUP BY OrderList.ProductID, ProductName
ORDER BY [sum] DESC