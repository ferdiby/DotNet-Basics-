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

