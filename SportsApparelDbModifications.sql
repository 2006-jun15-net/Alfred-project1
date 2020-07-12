alter table Orders
add  datecreated datetime default(getdate());

--removing contraints
alter table Orders drop constraint [DF__Orders__datecrea__5AEE82B9]
alter table Orders drop column datecreated;

--adding a defualt datetime column
alter table Orders
add Datecreated datetime not null default(getdate());

--altering table order_details to include price
alter table Product
add Price decimal(5,2);

--updating the Price in Products
update Product
set Price = 50.00
where Price is null

--making the prices different
update Product
set Price = 100
where ProdID > 2700;

update Product
set Price = 166
where ProdID >= 3000 and ProdID <=3200;


--adding final amount to the order table
alter table Orders
add  FinalAmount decimal(10,2) default(0);

--adding unit price and total to the order details
alter table Order_Details
add UnitPrice decimal(5,2)

alter table Order_Details
add TotalCost decimal(7,2)

select * from Order_Details