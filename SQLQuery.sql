Create Database ExtraFP
go
use ExtraFP
go
CREATE TABLE Item (
  ItemID VARCHAR(10) PRIMARY KEY,
  ItemName NVARCHAR(50),
  Size VARCHAR(20),
  type NVARCHAR(20),
  ProductionDate DATE,
  Country VARCHAR(20)
);
go
CREATE TABLE Agent (
  AgentID VARCHAR(10) PRIMARY KEY,
  AgentName NVARCHAR(50),
  Address NVARCHAR(100)
);
go
CREATE TABLE [Order] (
  OrderID VARCHAR(10) PRIMARY KEY,
  OrderDate DATE,
  AgentID VARCHAR(10),
  FOREIGN KEY (AgentID) REFERENCES Agent(AgentID)
);
go
CREATE TABLE OrderDetail (
  ID VARCHAR(10) PRIMARY KEY,
  OrderID VARCHAR(10),
  ItemID VARCHAR(10),
  Quantity INT,
  UnitAmount money,
  FOREIGN KEY (OrderID) REFERENCES [Order](OrderID),
  FOREIGN KEY (ItemID) REFERENCES Item(ItemID)
)
GO
CREATE TABLE USERLOGIN(
  UserID VARCHAR(10),
  PassID VARCHAR(50),
  NameUser NVARCHAR(50)
)

Go

INSERT INTO Item VALUES
  ('I0001', 'T-shirt', 'M', 'Clothing', '2021-01-01', 'USA'),
  ('I0002', 'Jeans', 'L', 'Clothing', '2020-02-15', 'Mexico'),
  ('I0003', 'Sneakers', '9', 'Footwear', '2021-03-05', 'China'),
  ('I0004', 'Backpack', 'N/A', 'Accessories', '2020-10-22', 'USA'),
  ('I0005', 'Watch', 'One Size', 'Accessories', '2020-12-12', 'THAILAND'),
  ('I0006', 'Jacket', 'XL', 'Clothing', '2021-02-28', 'Canada'),
  ('I0007', 'Dress', 'S', 'Clothing', '2021-01-15', 'Italy'),
  ('I0008', 'Boots', '10', 'Footwear', '2020-11-30', 'USA'),
  ('I0009', 'Sunglasses', 'One Size', 'Accessories', '2020-09-18', 'France'),
  ('I0010', 'Hat', 'One Size', 'Accessories', '2021-02-10', 'USA'),
  ('I0011', 'Sweatshirt', 'M', 'Clothing', '2021-03-01', 'VIET NAM'),
  ('I0012', 'Shorts', 'L', 'Clothing', '2020-06-15', 'Brazil'),
  ('I0013', 'Sandals', '8', 'Footwear', '2021-03-30', 'India'),
  ('I0014', 'Gloves', 'One Size', 'Accessories', '2020-11-01', 'USA'),
  ('I0015', 'Umbrella', 'One Size', 'Accessories', '2021-04-01', 'China'),
  ('I0016', 'Scarf', 'One Size', 'Accessories', '2020-12-25', 'France'),
  ('I0017', 'Sweater', 'S', 'Clothing', '2021-02-01', 'VIET NAM'),
  ('I0018', 'Pants', 'M', 'Clothing', '2020-07-10', 'Mexico'),
  ('I0019', 'Flip Flops', '9', 'Footwear', '2021-03-15', 'Brazil'),
  ('I0020', 'Tote Bag', 'N/A', 'Accessories', '2020-10-01', 'USA');

Go

INSERT INTO Agent VALUES
	('A0001', 'John Smith', '123, Main St, USA'),
  ('A0002', 'Emma Davis', '456, Broadway, USA'),
  ('A0003', 'Sarah Johnson', '789, Maple St, FRANCE'),
  ('A0004', 'Michael Brown', '101, Oak St, ITALIA'),
  ('A0005', 'Ava Martinez', '222, Elm St, USA'),
  ('A0006', 'William Wilson', '333, Pine St, FRANCE'),
  ('A0007', 'Olivia Garcia', '444, Cedar St, USA'),
  ('A0008', 'James Hernandez', '555, Maple St, USA'),
  ('A0009', 'Sophia Perez', '666, Oak St, USA'),
  ('A0010', 'Liam Gonz', '1234, SAI GON, VIET NAM'),
  ('A0011', 'Shop Japan', '567, OOO, JAPAN'),
  ('A0012', 'Shop CP', '321, NongPenh, CAMPUCHIA'),
  ('A0013', 'TH LD', '147, Bangkok, THAILAND'),
  ('A0014', 'KO SHOP', '318, Quan 7, VIET NAM'),
  ('A0015', 'LKN SHOP', '624, Quan 6, VIET NAM'),
  ('A0016', 'SHOP VIP', '624, Quan 7, VIET NAM'),
  ('A0017', 'OMCX PRO', '582, Quan 5, VIET NAM')

GO
INSERT INTO [Order] (OrderID, OrderDate, AgentID)
VALUES
  ('OD001', '2023-04-06', 'A0001'),
  ('OD0002', '2023-04-06', 'A0014'),
  ('OD0003', '2023-04-08', 'A0011'),
  ('OD0004', '2023-04-06', 'A0011'),
  ('OD0005', '2023-04-10', 'A0001'),
  ('OD0006', '2023-04-11', 'A0009'),
  ('OD0007', '2023-04-12', 'A0005'),
  ('OD0008', '2023-04-13', 'A0014'),
  ('OD0009', '2023-04-14', 'A0016'),
  ('OD0010', '2023-04-15', 'A0011'),
  ('OD0011', '2023-04-16', 'A0001'),
  ('OD0012', '2023-04-17', 'A0009'),
  ('OD0013', '2023-04-18', 'A0014'),
  ('OD0014', '2023-04-19', 'A0006'),
  ('OD0015', '2023-04-20', 'A0005'),
  ('OD0016', '2023-04-21', 'A0001'),
  ('OD0017', '2023-04-22', 'A0006'),
  ('OD0018', '2023-04-23', 'A0002'),
  ('OD0019', '2023-04-24', 'A0014'),
  ('OD0020', '2023-04-25', 'A0002');

GO

INSERT INTO OrderDetail VALUES
	/* ID VARCHAR(10) PRIMARY KEY,
	  OrderID VARCHAR(10),
	  ItemID VARCHAR(10),
	  Quantity INT,
	  UnitAmount money,*/
	('ODD001', 'OD0001','I0001', 2, 100000),
	('ODD002', 'OD0001','I0002', 3, 200000),
	('ODD003', 'OD0001','I0003', 1, 150000),
	('ODD004', 'OD0001','I0004', 2, 250000),
	('ODD005', 'OD0001','I0007', 4, 630000),

	('ODD006', 'OD0002','I0014', 6, 831000),
	('ODD007', 'OD0002','I0009', 3, 230000),
	('ODD008', 'OD0002','I0003', 7, 963000),
	('ODD009', 'OD0002','I0008', 2, 250000),
	('ODD010', 'OD0002','I0002', 2, 250000),

	('ODD011', 'OD0002','I0014', 6, 831000),
	('ODD012', 'OD0002','I0009', 3, 230000),
	('ODD013', 'OD0002','I0003', 7, 963000),
	('ODD014', 'OD0002','I0008', 2, 250000),
	('ODD015', 'OD0002','I0015', 2, 748000)
	

insert into USERLOGIN VALUES
	('px4', '11111', N'Kiều Thành Phát'),
	('user01', '123456', N'Nguyễn Văn A'),	
	('user02', '654321', N'Nguyễn Văn B')


--drop database ExtraFP