--SELECT 'Hello World';

--SELECT 2 + 2;

--SELECT SYSDATETIME();

--SELECT Firstname, Lastname FROM Customer;

--all columns
--SELECT * FROM Customer;
--SELECT * FROM Employee;

--columns to concat names together
--SELECT Firstname + ' ' + Lastname FROM Customer;

--column alias (see differnce in the output)
--SELECT Firstname + ' ' + Lastname AS Fullname From Customer;

--two syntaxs for adding spaces
--SELECT Firstname + ' ' + Lastname AS "Full Name" From Customer;
--SELECT Firstname + ' ' + Lastname AS [Full Name] From Customer;

-- filtering with WHERE

--in SQL, line breaks and spacing DO NOT MATTER
-- semicolon DON'T MATTER either

-- SELECT *
-- From Customer
-- Where Len(FirstName) > 5;

-- SELECT *
-- From Customer
-- Where Country = 'Brazil';

-- every customer with firstname that starts with B
-- SELECT *
-- From Customer
-- Where Firstname >= 'B' and Firstname <'C';

--case insensitvity is pretty broad
-- SELECT *
-- From CustomER
-- Where Firstname >= 'b' and FIRSTNAME <'C';

-- SELECT *
-- From CustomER
-- Where Firstname >= 'b' and FIRSTNAME <'C';
-- in SQL, indexes start with one, not zero like C#

--aggregate functions
-- Select Count(*)
-- From Customer

--other bulit in aggregate functions...SUM, MIN, MAX, AVG
-- SELECT Sum(Total)
-- From Invoice

-- SELECT BillingCountry, COUNT(*)
-- FROM Invoice
-- GROUP By BillingCountry

-- the GROUP BY clause will group rows together when they have the same values for all of the 
-- columns in the GROUP BY list

--how much has each customer bought in total
-- SELECT CustomerId, Sum(Total)
-- From Invoice
-- GROUP BY CustomerId

--all customers that have got more than $40 worth of product
-- SELECT CustomerId, Sum(Total)
-- From Invoice
-- GROUP BY CustomerId
-- Having SUM (Total) > 40

--sorting with ORDER By

--all customer IDs that have got more than $40 worth of product OUTSIDE the US
-- SELECT CustomerId
-- From Invoice
-- WHERE BillingCountry != 'USA'
-- GROUP By CustomerId
-- HAVING SUM(Total) > 40
-- ORDER BY SUM(Total) DESC, CustomerId

-- ascending order (default) is from 0 to infinity, or from A to Z
-- descending order (default) is from infinity to 0, or from Z to A

--Exercise 1
-- SELECT Firstname + ' ' + Lastname As 'Full Name ' , Country, CustomerId From Customer
-- WHERE Country != 'USA'

--Exercise 2
-- SELECT * FROM Customer
-- Where Country = 'Brazil'

--Exercise 3
-- SELECT * FROM Employee
-- WHERE Title >= 'Sales'

--Exercise 4
--SELECT BillingCountry From Invoice

--Exercise 5
-- SELECT InvoiceDate From Invoice
-- Where InvoiceDate => '2009'

-- JOINS

-- SELECT * From Artist
-- Select * FROM Album

-- every album by Various Artists, without Joins
-- DECLARE @id INT
-- SELECT @id = Artistid
-- From Artist 
-- Where Name = 'Various Artists'

-- Select *
-- From Album
-- Where ArtistId = @id

--Join Exercise 1
-- SELECT * FROM Customer
-- Inner JOIN Invoice 
-- ON Customer.Customerid = Invoice.Customerid
-- Where Country = 'Brazil'

--Join Exercise 2
--select * From Employee
-- Where Title >= 'Sales'

-- select * From Playlist
-- select * from PlaylistTrack





--UNION: gives you all the rows found in either query, without duplicates
--UNION ALL: gives you all the rows found in either query, with duplicates
-- SELECT Firstname FROM Employee
-- UNION
-- Select Firstname From Customer

--INTERSECT: All rows that are in both queries, it also removes dulplicates
-- SELECT Firstname FROM Employee
-- INTERSECT
-- Select Firstname From Customer

--EXCEPT or MINUS: "set differnce", all rows that are on the first query but not in the second query
-- SELECT Firstname FROM Employee
-- EXCEPT
-- Select Firstname From Customer


--SUBQUERIES

--Operators for subqueries: IN, NOT IN, EXISTS, ANY, ALL:

--every track that has never been purchaed:

-- join version:
-- SELECT * From Track 
-- Left Join InvoiceLine 
-- On Track.TrackId = InvoiceLine.TrackId
-- Where InvoiceLine.TrackId IS NULL

--subquery version:
-- SELECT * From Track 
-- Where Trackid
-- NOT IN (Select TrackId From InvoiceLine)

-- CTE: Common Table Expression, lets you run one query in advance, put it in a temp var,
-- and use it in the "main query" 

-- Subquery Exercise 1:
--  SELECT Name From Artist 
--  Left JOIN Album 
--  ON Artist.Artistid = Album.Artistid
--  WHERE Album.Artistid IS NULL

-- Subquery Exercise 2:
-- Select 
--(SELECT GenreId FROM Genre)

--SELECT * from Employee
--INSERT INTO Employee VALUES (9, 'Williams', 'Jermaine', 'Full Stack Engineneer', 1, '1994-03-28 00:00:00.000', '2002-08-14 00:00:00.000', '11120 Jasper Ave NW', 'Edmonton', 'AB', 'Canada', 'T5K 2N1', '+1 (780) 428-9482', '+1 (780) 428-3457', 'andrew@chinookcorp.com' )

--SELECT * from Customer
-- Update Customer
-- Set Firstname = 'Robert'
-- WHERE Firstname = 'Aaron'


 