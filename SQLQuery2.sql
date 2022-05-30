
-- SQL case insensitivedir (büyük/küçük harf duyarsızdır).
--Select
SELECT ContactName Adi, CompanyName SirketAdi, City Sehir FROM Customers

SELECT * FROM Customers WHERE City = 'London'
SELECT * FROM Products

SELECT * FROM Products WHERE CategoryID= 1 OR CategoryID=3 
SELECT * FROM Products WHERE CategoryID= 1 AND UnitPrice> 10 

--categoryId 1 olan ve fiyatı 10' dan farklı olanları getirir:
SELECT * FROM Products WHERE CategoryID= 1 AND UnitPrice<> 10 

--ProductName'e göre datayı sıralar:
SELECT * FROM Products ORDER BY ProductName

--Önce categoryId ye categoryId icinde de  ada göre sıralar:
SELECT* FROM Products ORDER BY CategoryID,ProductName

SELECT * FROM Products ORDER BY UnitPrice ASC --ascending: aşağı doğru artan
SELECT * FROM Products ORDER BY UnitPrice DESC --descending: aşağı dogru azalan/düşen

-- categoryID 1 olanları fiyata göre düşen şekilde getirir:
SELECT * FROM Products WHERE CategoryID=1 ORDER BY UnitPrice DESC 

-- Ürün tablosundaki tüm satırların sayısını getirir
SELECT COUNT(*) FROM Products --count tek bir satır ve tek bir sutun getirir.

--categoryId' si 2 olan ürünlerin sayısını getirir.
SELECT COUNT(*) FROM Products WHERE CategoryID=2

--Hangi kategoride kaç farklı ürün var?
--Group by kullanıldıgında select edilen kolon sadece groupby da yazılan data olabilir..
--Group by yapıldıgında arka planda herbir grup için bir tablo oluşturuluyormuş gibi düşünülebilir..
SELECT CategoryID , COUNT(*) FROM Products GROUP BY CategoryID

--içinde 10 adetten daha az olan ürün çeşidi olan kategorileri getirir.
SELECT CategoryID, COUNT(*) FROM Products GROUP BY CategoryID HAVING COUNT(*) <10
--birim fiyatı 20' den fazla olan urunleri categoryId 'ye göre grupla.bunlardan da sayısı her grupta 10 'dan az olanalrı getir
 SELECT CategoryID, COUNT(*) FROM Products WHERE UnitPrice>20 GROUP BY CategoryID HAVING COUNT(*) <10

 --Joıns
 --Kolonları birleştirmek için kullanılır. Son kulllanıcıya categoryıd yerine adını getirmek amacıyla
 
 --Hem ürünler hem de kategorilerin bir araya getirilmiş hali:

 SELECT * 
 FROM Products JOIN Categories
 ON Products.CategoryID=Categories.CategoryID

 SELECT Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
 FROM Products INNER JOIN Categories 
 ON Products.CategoryID=Categories.CategoryID


--DTO Data Transformation Object
--INNER JOIN: Sadece iki tabloda da eşleşenleri getirir.Eşleşmeyen datayı getirmez..
SELECT * FROM Products p INNER JOIN [Order Details] od
ON p.ProductID=od.ProductID

--Bu yazıma göre solda olup sağda olmayanları getir. 
--Products' da olup hiç satışı olmayanları getirir

SELECT * FROM Products p LEFT JOIN [Order Details] od
ON p.ProductID=od.ProductID 

--Müşteride olup siparişte olmayanları da getirir:
SELECT * FROM Customers c LEFT JOIN Orders o
ON c.CustomerID=o.CustomerID 

 --Bu yazıma göre sağda olup solda olmayanları getir. 
 --Products' da olup hiç satışı olmayanları getirir
SELECT * FROM Products p RIGHT JOIN [Order Details] od
ON p.ProductID=od.ProductID 

--İkiden fazla tablo join edilmek istendiğinde :
SELECT * FROM Products p INNER JOIN [Order Details] od
ON p.ProductID=od.ProductID INNER JOIN Orders o ON o.OrderID= od.OrderID

--Üye olup hiç ürün satın almayanlar:
SELECT * FROM Customers c LEFT JOIN Orders o
ON c.CustomerID=o.CustomerID WHERE o.CustomerID IS NULL
















