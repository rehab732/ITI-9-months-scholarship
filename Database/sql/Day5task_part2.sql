
----1.	Display the SalesOrderID, ShipDate of the SalesOrderHeader table (Sales schema) to show SalesOrders that occurred within
---the period ‘7/28/2002’ and ‘7/29/2014’
select SalesOrderID , ShipDate
from AdventureWorks2012.Sales.SalesOrderHeader
where ShipDate between '7/28/2002' and '7/29/2014';

---------2.	Display only Products(Production schema) with a StandardCost below $110.00 (show ProductID, Name only)
select ProductID, Name
from AdventureWorks2012.Production.Product
where ListPrice < 110;
----3.	Display ProductID, Name if its weight is unknown
select ProductID, Name
from AdventureWorks2012.Production.Product
where Weight is null;
---4.	 Display all Products with a Silver, Black, or Red Color
select *
from AdventureWorks2012.Production.Product
where Color in ('Silver','Black','Red');
----5.	 Display any Product with a Name starting with the letter B
select *
from AdventureWorks2012.Production.Product
where Name like 'B%'