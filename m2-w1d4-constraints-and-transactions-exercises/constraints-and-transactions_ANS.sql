-- Write queries to return the following:

--inclusive versus exclusive 

-- Make the following changes in the "world" database.

-- 1. Add Superman's hometown, Smallville, Kansas to the city table. The 
-- countrycode is 'USA', and population of 45001. (Yes, I looked it up on 
-- Wikipedia.)
--Step 1 Check
SELECT c.*
FROM city c
WHERE c.countrycode = 'USA' AND c.district = 'Kansas' AND name = 'Smallville' AND population = 45001

--Step 2 pull table scripting and select insert option
--INSERT INTO [dbo].[city]
--           ([id]
--           ,[name]
--           ,[countrycode]
--           ,[district]
--           ,[population])
--     VALUES
--           (<id, int,>
--           ,<name, varchar(64),>
--           ,<countrycode, char(3),>
--           ,<district, varchar(64),>
--           ,<population, int,>)

--Step 3: Adjust above code to what shown below for reflecting desired changes

INSERT INTO [city]
           ([id] 
		   ,[name]
           ,[countrycode]
           ,[district]
           ,[population])

     VALUES
      (4087
	  ,'Smallville'
      ,'USA'
      ,'Kansas'
      , 45001)

--Step 4: Modify Select Statement for Insert Function 
SELECT c.*
FROM city c
INSERT INTO [city]
           ([name]
           ,[countrycode]
           ,[district]
           ,[population])

     VALUES
      ('Smallville'
      ,'USA'
      ,'Kansas'
      , 45001)

SELECT c.*
FROM city c
WHERE c.countrycode = 'USA' AND c.district = 'Kansas' AND name = 'Smallville' AND population = 45001

--Step 5: Rerun the original select statement to verify accurcy of changes
SELECT c.*
FROM city c
WHERE c.countrycode = 'USA' AND c.district = 'Kansas' AND name = 'Smallville' AND population = 45001


-- 2. Add Kryptonese to the countrylanguage table. Kryptonese is spoken by 0.0001
-- percentage of the 'USA' population.
--Step 1: 
Select col.*
FROM countrylanguage col

WHERE col.countrycode = 'USA' AND col.language = 'Kryptonese' AND col.percentage = 0.0001

--Step 2:
--USE [World]
--GO

--INSERT INTO [dbo].[countrylanguage]
--           ([countrycode]
--           ,[language]
--           ,[isofficial]
--           ,[percentage])
--     VALUES
--           (<countrycode, char(3),>
--           ,<language, varchar(64),>
--           ,<isofficial, bit,>
--           ,<percentage, real,>)
--GO

--Step 3: 
INSERT INTO [countrylanguage]
           ([countrycode]
           ,[isofficial]
		   ,[language]
           ,[percentage])
          
     VALUES
           ('USA', 0, 'Kryptonese', 0.0001)

--Step 4
Select col.*
FROM countrylanguage col

WHERE col.countrycode = 'USA' AND col.language = 'Kryptonese' AND col.percentage = 0.0001

-- 3. After heated debate, "Kryptonese" was renamed to "Krypto-babble", change 
-- the appropriate record accordingly.
--Step 1:
Select col.*
FROM countrylanguage col
WHERE col.countrycode = 'USA' AND col.language = 'Kryptonese' AND col.percentage = 0.0001

WHERE col.countrycode = 'USA' AND col.language = 'Krypto-babble' AND col.percentage = 0.0001

--Step 2:
--USE [World]
--GO

--UPDATE [dbo].[countrylanguage]
--   SET [countrycode] = <countrycode, char(3),>
--      ,[language] = <language, varchar(64),>
--      ,[isofficial] = <isofficial, bit,>
--      ,[percentage] = <percentage, real,>
-- WHERE <Search Conditions,,>
--GO
--Step 3: 

--Step 4: Run Code
UPDATE [countrylanguage]
SET [language] = 'Krypto-babble'
WHERE countrycode = 'USA' AND language = 'Kryptonese' AND percentage = 0.0001    


--Step 5: check work!
Select col.*
FROM countrylanguage col
WHERE col.language = 'Krypto-babble' 

WHERE col.countrycode = 'USA' AND col.language = 'Krypto-babble' AND col.percentage = 0.0001


WHERE col.countrycode = 'USA' AND col.language = 'Kryptonesee' AND col.percentage = 0.0001

-- 4. Set the US captial to Smallville, Kansas in the country table.
--Step 1: 
SELECT c.*
FROM city c
WHERE name = 'Washington' AND c.id = 3813

SELECT co.*
FROM country co
WHERE code ='USA'

--Step 2
--UPDATE [country]
--   SET [code] = <code, char(3),>
--      ,[name] = <name, varchar(64),>
--      ,[continent] = <continent, varchar(64),>
--      ,[region] = <region, varchar(64),>
--      ,[surfacearea] = <surfacearea, real,>
--      ,[indepyear] = <indepyear, smallint,>
--      ,[population] = <population, int,>
--      ,[lifeexpectancy] = <lifeexpectancy, real,>
--      ,[gnp] = <gnp, numeric(10,2),>
--      ,[gnpold] = <gnpold, numeric(10,2),>
--      ,[localname] = <localname, varchar(64),>
--      ,[governmentform] = <governmentform, varchar(64),>
--      ,[headofstate] = <headofstate, varchar(64),>
--      ,[capital] = <capital, int,>
--      ,[code2] = <code2, char(2),>
--WHERE <Search Conditions,,>

--Step 3: 
SELECT co.*
FROM country co
WHERE co.capital = 3813

UPDATE [country]
   SET [capital] = 4087
WHERE code ='USA' AND capital = 3813

--Step 4:
SELECT co.*
FROM country co
WHERE co.capital = 4087


-- 5. Delete Smallville, Kansas from the city table. (Did it succeed? Why?)
--Step 1
SELECT c.*
FROM city c
WHERE c.countrycode = 'USA' AND c.district = 'Kansas' AND name = 'Smallville' AND population = 45001

--Step 2
--USE [World]
--GO

--DELETE FROM [dbo].[city]
--      WHERE <Search Conditions,,>
--GO

--Step 3
DELETE FROM [city]
WHERE countrycode = 'USA' AND district = 'Kansas' AND name = 'Smallville' AND population = 45001

--Step 4: Run Code
DELETE c.*
FROM city c
WHERE c.countrycode = 'USA' AND c.district = 'Kansas' AND name = 'Smallville' AND population = 45001

--Step 5: Check Work
SELECT c.*
FROM city c
WHERE c.countrycode = 'USA' AND c.district = 'Kansas' AND name = 'Smallville' AND population = 45001

-- 6. Return the US captial to Washington.
--Step 1
SELECT co.*
FROM country co
WHERE co.capital = 4087
--Step 2
UPDATE [country]
   SET [capital] = 3813
WHERE capital = 4087
--Step 3- Check Work
SELECT co.*
FROM country co
WHERE co.capital = 4087

SELECT co.*
FROM country co
WHERE co.capital = 3813

-- 7. Delete Smallville, Kansas from the city table. (Did it succeed? Why?)
SELECT c.*
FROM city c
WHERE c.countrycode = 'USA' AND c.district = 'Kansas' AND name = 'Smallville' AND population = 45001

-- Cannot perform a delete action on something that does not already exist... Once deleted, it is permanent and we already did this in question 5.
--Run query to verify


-- 8. Reverse the "is the official language" setting for all languages where the
-- country's year of independence is within the range of 1800 and 1972 
-- (exclusive). 
-- (590 rows affected)
--Step 1
SELECT co.*, cl.isofficial, cl.language
FROM country co
JOIN countrylanguage as cl ON cl.countrycode = co.code
WHERE co.indepyear > 1800 AND co.indepyear < 1972 
ORDER BY co.indepyear DESC
--rows 590 total

SELECT co.*, cl.isofficial
FROM country co
JOIN countrylanguage as cl ON cl.countrycode = co.code
WHERE co.indepyear > 1800 AND co.indepyear < 1972 AND cl.isofficial = 1
ORDER BY co.indepyear DESC
--rows 132 total

SELECT co.*, cl.isofficial
FROM country co
JOIN countrylanguage as cl ON cl.countrycode = co.code
WHERE co.indepyear > 1800 AND co.indepyear < 1972 AND cl.isofficial = 0
ORDER BY co.indepyear DESC
--rows 458


--Step 2
--USE [World]
--GO

--UPDATE [dbo].[country]
--   SET [code] = <code, char(3),>
--      ,[name] = <name, varchar(64),>
--      ,[continent] = <continent, varchar(64),>
--      ,[region] = <region, varchar(64),>
--      ,[surfacearea] = <surfacearea, real,>
--      ,[indepyear] = <indepyear, smallint,>
--      ,[population] = <population, int,>
--      ,[lifeexpectancy] = <lifeexpectancy, real,>
--      ,[gnp] = <gnp, numeric(10,2),>
--      ,[gnpold] = <gnpold, numeric(10,2),>
--      ,[localname] = <localname, varchar(64),>
--      ,[governmentform] = <governmentform, varchar(64),>
--      ,[headofstate] = <headofstate, varchar(64),>
--      ,[capital] = <capital, int,>
--      ,[code2] = <code2, char(2),>
-- WHERE <Search Conditions,,>
--GO

--Step 3
BEGIN TRAN 
SELECT TOP 10 isofficial 
FROM countrylanguage
UPDATE [countrylanguage]
   SET 
      [isofficial] = ~isofficial
SELECT TOP 10 isofficial 
FROM countrylanguage
ROLLBACK TRAN

--step 4
BEGIN TRAN 
SELECT isofficial 
FROM countrylanguage 
UPDATE [countrylanguage] 
   SET 
      [isofficial] = ~isofficial
FROM countrylanguage cl 
JOIN country as c ON cl.countrycode = c.code
WHERE c.indepyear > 1800 AND c.indepyear < 1972 
ROLLBACK TRAN

--Step 5
SELECT isofficial 
FROM countrylanguage 
UPDATE [countrylanguage] 
   SET 
      [isofficial] = ~isofficial
FROM countrylanguage cl 
JOIN country as c ON cl.countrycode = c.code
WHERE c.indepyear > 1800 AND c.indepyear < 1972 

--(985 row(s) affected)

--(590 row(s) affected)

-- 9. Convert population so it is expressed in 1,000s for all cities. (Round to
-- the nearest integer value greater than 0.)
-- (4079 rows affected)

--Step 1: Initial query

SELECT c.population
FROM city c
WHERE c.population >1000 
ORDER BY c.population DESC
-- 4068; set appropriately based on dividing by 1000

SELECT c.population
FROM city c
WHERE c.population <1000 
ORDER BY c.population DESC

--rows 11 that are to equal 1

SELECT (c.population/c.population)
FROM city c
WHERE  c.population <1000
--set to value 1

SELECT ROUND((c.population/1000),0) as population_rounded, c.*
FROM city c
WHERE c.population >1000 
ORDER BY c.population 

--Step 2
--USE [World]
--GO

--UPDATE [dbo].[city]
--   SET [id] = <id, int,>
--      ,[name] = <name, varchar(64),>
--      ,[countrycode] = <countrycode, char(3),>
--      ,[district] = <district, varchar(64),>
--      ,[population] = <population, int,>
-- WHERE <Search Conditions,,>
--GO

--Step 3



BEGIN TRAN
SELECT population =  (population / population)
FROM city
WHERE population <1000
UPDATE [city]
SET [population] = (population / population)
WHERE  population <1000
ROLLBACK TRAN

--Step 4
SELECT population =  (population / population)
FROM city
WHERE population <1000
UPDATE [city]
SET [population] = (population / population)
WHERE  population <1000
(11 row(s) affected)

(11 row(s) affected)

--Step 5: Check Results
SELECT c.population
FROM city c
ORDER BY c.population ASC

--Step 6
BEGIN TRAN
SELECT (population/1000)
FROM city
WHERE population >1000
UPDATE [city]
SET [population] = (population/1000)
WHERE population > 1000 
ROLLBACK TRAN

--Step 7
SELECT (population/1000)
FROM city
WHERE population >1000
UPDATE [city]
SET [population] = (population/1000)
WHERE population > 1000 

--Step 8: Check Results
SELECT c.population
FROM city c
ORDER BY c.population ASC

-- 10. Assuming a country's surfacearea is expressed in miles, convert it to 
-- meters for all countries where French is spoken by more than 20% of the 
-- population.
-- (7 rows affected)
--Step 1
SELECT co.surfacearea
FROM country co
--239 rows

SELECT cl.*, co.*
FROM countrylanguage cl
JOIN country as co ON co.code = cl.countrycode 
--985 rows

SELECT cl.*
FROM countrylanguage cl
WHERE cl.percentage > 20 AND cl.language = 'French'
--7 rows

SELECT cl.*, co.surfacearea
FROM countrylanguage cl
JOIN country as co ON co.code = cl.countrycode 
WHERE cl.percentage > 20 AND cl.language = 'French'

--7rows

--Step 2: Update Data
SELECT cl.*, (co.surfacearea * 1609.34) as surfacearea_meters
FROM countrylanguage cl
JOIN country as co ON co.code = cl.countrycode 
WHERE cl.percentage > 20 AND cl.language = 'French' 

SELECT surfacearea as surfacearea_miles, (surfacearea * 1609.34) as surfacearea_meters
FROM countrylanguage cl
JOIN country as co ON co.code = cl.countrycode 
WHERE cl.percentage > 20 AND cl.language = 'French' 

SELECT surfacearea as surfacearea_miles, (surfacearea * 1609.34) as surfacearea_meters
FROM countrylanguage cl
JOIN country as co ON co.code = cl.countrycode 
WHERE cl.percentage > 20 AND cl.language = 'French' 

-- Step 3: Update Option
--USE [World]
--GO

--UPDATE [dbo].[country]
--   SET [code] = <code, char(3),>
--      ,[name] = <name, varchar(64),>
--      ,[continent] = <continent, varchar(64),>
--      ,[region] = <region, varchar(64),>
--      ,[surfacearea] = <surfacearea, real,>
--      ,[indepyear] = <indepyear, smallint,>
--      ,[population] = <population, int,>
--      ,[lifeexpectancy] = <lifeexpectancy, real,>
--      ,[gnp] = <gnp, numeric(10,2),>
--      ,[gnpold] = <gnpold, numeric(10,2),>
--      ,[localname] = <localname, varchar(64),>
--      ,[governmentform] = <governmentform, varchar(64),>
--      ,[headofstate] = <headofstate, varchar(64),>
--      ,[capital] = <capital, int,>
--      ,[code2] = <code2, char(2),>
-- WHERE <Search Conditions,,>
--GO

--Step 3
BEGIN TRAN
SELECT surfacearea
FROM country
UPDATE [country]
SET [surfacearea] = surfacearea * 1609.34 
FROM country co
JOIN countrylanguage as cl ON cl.countrycode = co.code
WHERE cl.percentage > 20 AND cl.language = 'French'
ROLLBACK TRAN

-- Step 4
SELECT surfacearea
FROM country
UPDATE [country]
SET 
[surfacearea] = surfacearea * 1609.34 
FROM country co
JOIN countrylanguage as cl ON cl.countrycode = co.code
WHERE cl.percentage > 20 AND cl.language = 'French'

--Step 5 Verify

--(239 row(s) affected)

--(7 row(s) affected)