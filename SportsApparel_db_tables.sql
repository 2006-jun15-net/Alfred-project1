--creating new tables

--create Customer table

create table Customer(custID INT NOT NULL IDENTITY(1,1), FirstName NVARCHAR(20) NOT NULL, LastName NVARCHAR(20) NOT NULL,
Sex NCHAR(1) NOT NULL, PRIMARY KEY(custID));


--create Product table
create table Product(ProdID INT NOT NULL IDENTITY(100, 100), Name NVARCHAR(15) NOT NULL, PRIMARY KEY(ProdID));

--Order table
create table Orders(OrderID INT NOT NULL IDENTITY(1000, 1), CustID INT NOT NULL, PRIMARY KEY(OrderID), FOREIGN KEY(CustID) REFERENCES Customer(custID));


--create order_details table
create table Order_Details(OrderID INT NOT NULL, ProdID INT NOT NULL, QTY INT, FOREIGN KEY(OrderID) REFERENCES Orders(OrderID),
FOREIGN KEY(ProdID) REFERENCES Product(ProdID));

--Store table
create table Store(StoreID INT NOT NULL IDENTITY(80,5), Location NVARCHAR(20) NOT NULL,
PRIMARY KEY(StoreID));

--inventory stocked
create table Inventory_Stocked(StoreID INT NOT NULL, ProdID INT NOT NULL,
Stock INT DEFAULT 0, FOREIGN KEY(StoreID) REFERENCES Store(StoreID), FOREIGN KEY(ProdID) REFERENCES Product(ProdID));

--ALTERING THE TABLES
alter table Product
alter column Name NVARCHAR (35);

--adding customers
--INSERTING VALLUES IN THE TABLES

--Inserting into Customer
insert into Customer
values('Jacob', 'Smith', 'M'),
('Michael', 'Madison', 'M'),
('Ethan', 'Elizabeth', 'F'),
('Dylan', 'Elizabeth', 'F'),
('Diana', 'McCarthy', 'F'),
('Raul', 'Gomez', 'M');

--adding products
insert into Product
values('adidas boots'), ('Venture Runner'), ('Jordan Aero'), ('Air Jodan'), ('Crew socks'),
('Atletico madrid Jersey'), ('PSG Jersey'), ('FC Barcelona Jersey'), ('England Jersey'),
('Tottenham Jersey'), ('Manchester United Jersey'), ('Chelsea Jersey'), ('Arsenal Jersey'),
('Bayern Munich Jersey'), ('Dortmund Jersey'), ('Liverpool Jersey'), ('Soccer Cleat'),
('soccer pants'), ('Training Duffel bag');

--inserting into Order table
insert into Orders
values(1),(2),(4),(5), (1), (3), (4);


--inserting into Order_details
insert into Order_Details
values(1000,1800, 10), (1004, 1700, 23), (1006, 1500, 2), (1000, 1800, 7),
(1005, 2500, 56), (1005, 1200, 4);

--inserting into store
insert into Store
values('California'), ('New York'), ('Detroit'),
('Seattle'), ('Richmond'), ('London'),
('Chicago'),('Tokyo'), ('Sydney'), ('Lagos'),('Pretoria'), ('Johannesburg'),
('Manchester'), ('Glassgow'), ('Granada'), ('Catalona'), ('New Jersey'), ('Canberra'),('Nairobi'),
('Moscow'), ('Tunis'), ('Freetown');

--inserting into Inventory_stocked
insert into Inventory_Stocked
values(95, 1200, 67), (85, 3000, 34), (90, 1500, 12),(110, 2000,9), (80, 2700, 2),
(105, 2600, 5), (95, 2000, 10), (100, 2300, 14), (100, 1800, 45), (185, 2000, 67),
(145, 2900, 76), (100, 2400, 23), (185, 1900, 34), (145, 2000, 23);



