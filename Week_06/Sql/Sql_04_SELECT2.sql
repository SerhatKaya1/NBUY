
--USE Northwind
--SELECT * FROM Products
--ORDER BY UnitPrice DESC

--USE Northwind
--SELECT * FROM Products 
--WHERE UnitPrice>=100

--Kategorisi 7 ve 8 olan �r�nleri listeleyiniz.

--USE Northwind
--SELECT * FROM Products
--WHERE CategoryID=7 OR CategoryID=8

--


--Kategorisi 7 ve 8 oanlardan stok miktar� (UnitsInStock) <=10 olan �r�nleri listeleyiniz
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

--Germany'den tedarik edilen �r�nlerin listesini(Product Name g�z�kse yeter)

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

/* �ay Sat��ar�n�n Toplam Tutar */
--Select SUM(OD.UnitPrice * OD.Quantity)
--FROM Products P INNER JOIN [Order Details] OD
--ON P.ProductID = OD.ProductID
--WHERE P.ProductName='Chai'

--Germany'e yap�m�� olan chai sat��lar�n�n toplam tutar�

--Select SUM(OD.UnitePrice * OD.Quantity)
--FROM Orders O INNER JOIN [Order Details] OD
--ON O.OrderID = OD.OrderID INNER JOIN Products P 
--ON OD.ProductID = P.ProductID
--WHERE P.ProductName='Chai' AND O.ShipCountry='Germany'


--Erns Handel m��terisine yap�lan sat�� tutar� toplam�

SELECT SUM(UnitPrice*Quantity)
FROM [Order Details] OD INNER JOIN Orders O
ON OD.OrderID = O.OrderID INNER JOIN Customers C
ON O.CompanyName='Antonio Moreno Taqueria'



