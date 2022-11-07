
--USE Northwind
--SELECT * FROM Products
--ORDER BY UnitPrice DESC

--USE Northwind
--SELECT * FROM Products 
--WHERE UnitPrice>=100

--Kategorisi 7 ve 8 olan ürünleri listeleyiniz.

--USE Northwind
--SELECT * FROM Products
--WHERE CategoryID=7 OR CategoryID=8

--


--Kategorisi 7 ve 8 oanlardan stok miktarý (UnitsInStock) <=10 olan ürünleri listeleyiniz
  --USE Northwind
  --SELECT * FROM Products
  --WHERE (CategoryID=7 OR CategoryID=8) AND UnitsInStock<=10

--INNER JOIN 
--SELECT  P.ProductName,ProductName, C.CategoryName
--FROM Products P INNER JOIN Categories C
--ON P.CategoryID=C.CategoryID
--WHERE CategoryName='Beverages' AND P.UnitPrice<=40
--ORDER BY P.UnitPrice DESC	

--USE Northwind
--SELECT P.ProductName, S.CompanyName
--FROM Products P INNER
--ON P.SupplierID = S.SupplierID

--Germany'den tedarik edilen ürünlerin listesini(Product Name gözükse yeter)

--USE Northwind
--SELECT *
--FROM Products P INNER JOIN Suppliers S
--ON P.SupplierID = S.SupplierID
--WHERE S.Country='GERMANY'

--USE Northwind
--SELECT SUM(P.UnitPrice * P.UnitsInStock) as 'Toplam Tutar'
--FROM Products P INNER JOIN Suppliers S
--ON P.SupplierID = S.SupplierID
--WHERE S.Country='Sweden'

/* Çay Satýþarýnýn Toplam Tutar */
--Select SUM(OD.UnitPrice * OD.Quantity)
--FROM Products P INNER JOIN [Order Details] OD
--ON P.ProductID = OD.ProductID
--WHERE P.ProductName='Chai'

--Germany'e yapýmýþ olan chai satýþlarýnýn toplam tutarý

--Select SUM(OD.UnitePrice * OD.Quantity)
--FROM Orders O INNER JOIN [Order Details] OD
--ON O.OrderID = OD.OrderID INNER JOIN Products P 
--ON OD.ProductID = P.ProductID
--WHERE P.ProductName='Chai' AND O.ShipCountry='Germany'


--Erns Handel müþterisine yapýlan satýþ tutarý toplamý

SELECT SUM(UnitPrice*Quantity)
FROM [Order Details] OD INNER JOIN Orders O
ON OD.OrderID = O.OrderID INNER JOIN Customers C
ON O.CompanyName='Antonio Moreno Taqueria'



