CREATE DATABASE RetailStore;
USE RetailStore;

CREATE TABLE Customers
(
    CustomerID INT PRIMARY KEY,
    CustomerName VARCHAR(100),
    Region VARCHAR(50)
);

CREATE TABLE Products
(
    ProductID INT PRIMARY KEY,
    ProductName VARCHAR(100),
    Category VARCHAR(50)
);

CREATE TABLE Orders
(
    OrderID INT PRIMARY KEY,
    CustomerID INT,
    FOREIGN KEY(CustomerID) REFERENCES Customers(CustomerID)
);

CREATE TABLE OrderDetails
(
    OrderDetailID INT PRIMARY KEY,
    OrderID INT,
    ProductID INT,
    Quantity INT,
    FOREIGN KEY(OrderID) REFERENCES Orders(OrderID),
    FOREIGN KEY(ProductID) REFERENCES Products(ProductID)
);

INSERT INTO Customers VALUES
(1,'Akanksha','West'),
(2,'Abhay','North'),
(3,'Mital','West');

INSERT INTO Products VALUES
(101,'Laptop','Electronics'),
(102,'Mobile','Electronics'),
(103,'Shoes','Fashion');

INSERT INTO Orders VALUES
(1,1),
(2,2),
(3,3);

INSERT INTO OrderDetails VALUES
(1,1,101,2),
(2,1,103,1),
(3,2,102,3),
(4,3,101,1),
(5,3,103,2);
