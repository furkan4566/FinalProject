select count(*) Adet from Products where CategoryID=1

select CategoryId,count(*) categoryLenght from Products where UnitPrice>20
group by CategoryID having count(*)<10                                                   --having select'ten sonra gelen count için uygunlandı--having ve group by alıştırma yap

select * from products inner join Categories on Products.CategoryID=Categories.CategoryID --joinler DTO(DATA TRANSFORMATİON OBJECT)

select * from products p left join [Order Details] od
on p.ProductId=od.ProductID
inner join Orders o 
on o.OrderID=od.OrderID

select *from Customers c left join Orders o 
on c.CustomerID=o.CustomerID
where o.CustomerID is null  --null mu primary key uygulamak daha mantıklı

--Her bir üründen ne kadar kazanıldıgını bulma
select Products.ProductName, SUM([Order Details].UnitPrice*Quantity) AS TotalPricePerProduct
from Products
inner join [Order Details] on Products.ProductID=[Order Details].ProductID
inner join Orders on Orders.OrderID=[Order Details].OrderID
group by  Products.ProductName 
---------------------------------
select ProductName as [ÜrünAd],UnitPrice as [ÜrünFiyat] from Products order by ProductName,UnitPrice asc

select FirstName,LastName,TitleOfCourtesy from Employees where TitleOfCourtesy like('%M')
select FirstName,LastName,TitleOfCourtesy from Employees where TitleOfCourtesy IN('MR.','Dr.')

select DISTINCT city from Employees
select FirstName,LastName from Employees where [Address] Like ('%house%')

select FirstName, LEFT(Extension,3) from Employees --ilk 3 karakter listeler

SELECT UPPER(ProductName) from Products

select ProductName from Products where UnitsInStock between 20 and 50

select ProductName,UnitPrice from Products where UnitPrice=--en pahalı ürün
(
select MAX(UnitPrice) from Products
)

select c.CategoryName,count(p.ProductID) as toplamadet
from Products p inner join Categories c on c.CategoryID=p.CategoryID group by CategoryName --kategori ve sayıları

select p.ProductName,c.CategoryName from Products p inner join Categories c on p.CategoryID=c.CategoryID group by ProductName,CategoryName --product ve kategorileri

select e.FirstName+ ' '+ e.LastName as caşılanadsoyad
from Employees e inner join Orders o on e.EmployeeID=o.EmployeeID group by e.FirstName+' '+e.LastName having COUNT(o.EmployeeID) > 100--satışı 100 den az olan çaşılanlar

select ProductName,UnitPrice,UnitsInStock from Products where UnitsInStock<15

select CompanyName from Customers where City in ('London' , 'Paris')

select ContactName from Customers where ContactName like('A%')

select ProductName,UnitPrice from Products where UnitPrice between 50 and 100 
select Count(Distinct Country) from Customers

