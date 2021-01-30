--Select



select * from Customers where City='Berlin'

--case insensitive
sELECt *from Products Where CategoryID=1 or CategoryID=3

sELECt *from Products Where CategoryID=1 and UnitPrice>=10

select * from Products where CategoryID=1 order by UnitPrice desc --ascending  --descending

Select count (*) Adet from Products where CategoryID=2


Select CategoryID, count(*) from Products group by CategoryID

Select CategoryID, count(*) from Products where UnitPrice>20
group by CategoryID having count(*)<10

select Products.ProductID, Products.ProductName, Products.UnitPrice,Categories.CategoryName
from Products inner join Categories
on Products.CategoryID=Categories.CategoryID
Where Products.UnitPrice>10

--DTO Data Transformation Object

select *from Products p inner join [Order Details] od
on p.ProductID=od.ProductID

select *from Products p left join [Order Details] od
on p.ProductID=od.ProductID

select * from Customers c inner join Orders o
on c.CustomerID=o.CustomerID

select * from Customers c left join Orders o
on c.CustomerID=o.CustomerID
where o.CustomerID is null

select * from Products p inner join [Order Details] od
on c.ProductId =o.ProductID
inner join Orders o
on o.OrderID=od.OrderId