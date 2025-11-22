--SELECT KOMUTU VE ALIAS KULLANIMI

--select * from Production.Product
--select Name as Ýsim,Color as Renk from Production.Product
--select Name [Ürün Adý]from Production.Product
--select Name as [Ürün Adý]from Production.Product
--select Name [Ürün Adý]from Production.Product
--select Name as 'Ürün Adý' from Production.Product
--select Name 'Ürün Adý' from Production.Product
--select count(*) as 'Toplam Renk Sayýsý' from Production.Product where color = 'black'
--select distinct JobTitle from HumanResources.Employee
--select distinct JobTitle 'Meslekler' from HumanResources.Employee
--select distinct color from Production.Product
--select COUNT(*)  from Production.Product where color = 'yellow'


--********************************************************************************
--WHERE KOÞULU 

--select  Name 'Ýsim', Color from Production.Product where MakeFlag = 1 and FinishedGoodsFlag = 1 
--select * from Production.Product where color = 'black'
--select * from Production.Product where color <> 'black'
--select * from Production.Product where color = 'red' and SafetyStockLevel = 500
--select * from Production.Product where color = 'red' and SafetyStockLevel = 500

--select * from Production.Product where SafetyStockLevel = 500 or SafetyStockLevel =  4 
--select * from Production.Product where SafetyStockLevel in (500, 4) -- or a tekabül eder
 --select * from Production.Product where color in('red','silver')

--select * from Production.Product where SafetyStockLevel between 4 and 500 --and a tekabül eder

-- LIKE 
-- % herhangi bir þekilde devam eden
-- _ o karakterin ne olduðunun bir önemi yok

--select * from Production.Product where ProductNumber like 'ar%' --ar ile baþlayan ve devamýnýn önemi olmayan
--select * from Production.Product where ProductNumber like '%7'   --sonu 7 ile biten
--select * from Production.Product where ProductID like '%65%'--içinde 65 geçen
--select * from Production.Product where ProductNumber like 'bk-_9%'

-- NULL KULLANIMI

--select * from production.Product where color is null
--select * from Production.Product where color is not null


--ORDER BY

--select * from Production.Product order by Name asc -- default asc olur 
--select * from Production.Product order by Name desc
--select * from Production.Product order by Name asc
--select * from Production.Product where Color = 'silver' order by ListPrice desc
--select top 25 * from Production.Product where Color = 'silver' order by ListPrice desc

--GENEL TEKRAR

--select * from HumanResources.Employee 
--where MaritalStatus = 'm' and 
--JobTitle in ('Janitor', 'Buyer', 'Sales Representative') 
--order by BusinessEntityID desc

--select distinct city from Person.Address  
--select * from Person.Address where city like 'b_a%'

--select CONCAT(FirstName,' ',LastName) as 'Ad / Soyad'  from Person.Person
--select * from Person.Person where FirstName like '%i' and LastName like '%ram'
--select top 5 *  from Sales.SalesOrderHeader where SalesPersonID = 279 order by TotalDue desc

-- FONKSÝYONLAR

--select FirstName,len(FirstName) as 'Karakter Uzunluðu' from Person.Person 
--select FirstName,left(FirstName,2) as 'Ýlk 2 karakter' from Person.Person 
--select FirstName,right(FirstName,2) as 'Sondan 2 karakter' from Person.Person 
--select Name,SUBSTRING(name,2,3) as '2. karakterden itibaren 3 karakter' from Production.Product
--select  EmailAddress,REPLACE(EmailAddress,'com','net') as 'Email yeni domain' from Person.EmailAddress
--select lower(FirstName) from Person.Person
--select lower(FirstName) as 'ad küçük',UPPER(FirstName) as 'soyad BÜYÜK' from Person.Person
--select FirstName,LOWER(LastName) from Person.Person
--select CONCAT(UPPER(SUBSTRING(FirstName,1,10)),' ',lower(substring(LastName,1,15)))  from Person.Person
--select '        ferdi    ' ,ltrim('        ferdi    ')
--select '        ferdi    ' ,rtrim('        ferdi    ')
--*************************************************************************

--select sum(ListPrice) from Production.Product where color = 'red'
--select sum(SafetyStockLevel) from Production.Product where color  = 'grey'
--select avg(ListPrice) from Production.Product where color in('white','silver') 
--select min(ListPrice) from Production.Product where ListPrice > 500 
--select max(ListPrice) from Production.Product 
--select COUNT(*) from Production.Product
--select COUNT(Color) from Production.Product -- count null deðeri saymaz
--select COUNT(distinct color) from Production.Product --null hariç 9 deðer var
--*************************************************************************

--select GETDATE()  --þuanki zaman bilgisini verdi

--select DATEADD(day,55,GETDATE())
--select DATEADD(MONTH,3,GETDATE())
--select DATEADD(YEAR,53,GETDATE())
--select DATEADD(HOUR,34,GETDATE())
--select datediff(day,'2023-05-01',getdate())
--select datediff(YEAR,'2023-05-01',getdate())
--select GETDATE(),YEAR(GETDATE()) as 'Yýl',MONTH(GETDATE()) as 'Ay',DAY(GETDATE()) as 'Gün'
--select * from HumanResources.Employee order by BirthDate
--select (YEAR(HireDate)- YEAR(BirthDate)) as 'Kaç yýldýr çalýþýyor' from HumanResources.Employee order by YEAR(HireDate)- YEAR(BirthDate) desc
--select DATEDIFF(year,BirthDate,HireDate) as 'Kaç yýldýr çalýþýyor' from HumanResources.Employee -- yukarýdaki fonksiyonun aynýsý

--GROUP BY

--select Color as 'Renk',COUNT(color) as 'Sayýsý' from Production.Product group by Color
--select color as 'Renk',count(SafetyStockLevel) as 'Stok Sayýsý' from Production.Product where color is not null group by Color 
--select color,count(ProductID) from Production.Product where color is not null group by Color having count(ProductID)>8


--select color as 'Renk',
--year(SellStartDate) as 'Satýþa çýktýðý tarih (2011 sonrasý)',
--YEAR(SellEndDate) as 'Satýþýn bittiði tarih',
--sum(ProductID) as 'Toplam ürün',
--min(ListPrice) as 'Min Fiyat',
--max(ListPrice) as 'Max Fiyat',
--avg(ListPrice) as 'Ortalama Satýþ Fiyatý'
--from Production.Product 
--where color is not null 
--group by Color,YEAR(SellStartDate),YEAR(SellEndDate)
--having YEAR(SellStartDate) > 2011

--select SalesPersonID as 'Personel Numara', 
--YEAR(OrderDate) as 'Yýl' ,
--count(SalesOrderID) as 'Sipariþ sayýsý'
--from Sales.SalesOrderHeader
--where SalesPersonID is not null
--group by YEAR(OrderDate),SalesPersonID
--order by SalesPersonID

-- JOIN: iki veya daha fazla tabloyu ortak olana göre birleþtirir ve sadece eþleþen tablolarý getirir!

--select * from Production.Product
--select * from Production.ProductSubcategory

--select 
--Production.Product.Name,
--Production.Product.ProductNumber,
--Production.Product.SafetyStockLevel,
--Production.Product.ListPrice,
--Production.ProductSubcategory.Name
--from Production.Product inner join Production.ProductSubcategory 
--on Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID

--select * from Person.Person
--select * from HumanResources.Employee

--select 
--PP.FirstName,
--pp.LastName,
--pp.EmailPromotion,
--he.BirthDate,
--he.VacationHours
--from Person.Person as PP inner join HumanResources.Employee as HE on 
--pp.BusinessEntityID =he.BusinessEntityID
--where pp.PersonType = 'sp'
--order by he.VacationHours desc
