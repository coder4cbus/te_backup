-- Write queries to return the following:

--inclusive versus exclusive 

-- Make the following changes in the "world" database.

-- 1. Add Superman's hometown, Smallville, Kansas to the city table. The 
-- countrycode is 'USA', and population of 45001. (Yes, I looked it up on 
-- Wikipedia.)

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

--Rerun the original select statement to verify accurcy of changes
SELECT c.*
FROM city c
WHERE c.countrycode = 'USA' AND c.district = 'Kansas' AND name = 'Smallville' AND population = 45001


-- 2. Add Kryptonese to the countrylanguage table. Kryptonese is spoken by 0.0001
-- percentage of the 'USA' population.

INSERT INTO [countrylanguage]
           ([countrycode]
           ,[isofficial]
		   ,[language]
           ,[percentage])
          
     VALUES
           ('USA', 0, 'Kryptonese', 0.0001)
--Rerun the original select statement to verify accurcy of changes
Select col.*
FROM countrylanguage col

WHERE col.countrycode = 'USA' AND col.language = 'Kryptonese' AND col.percentage = 0.0001

-- 3. After heated debate, "Kryptonese" was renamed to "Krypto-babble", change 
-- the appropriate record accordingly.

UPDATE [countrylanguage]
SET [language] = 'Krypto-babble'
WHERE countrycode = 'USA' AND language = 'Kryptonese' AND percentage = 0.0001    


--Rerun the original select statement to verify accurcy of changes
Select col.*
FROM countrylanguage col
WHERE col.language = 'Krypto-babble' 

WHERE col.countrycode = 'USA' AND col.language = 'Krypto-babble' AND col.percentage = 0.0001


WHERE col.countrycode = 'USA' AND col.language = 'Kryptonesee' AND col.percentage = 0.0001

-- 4. Set the US captial to Smallville, Kansas in the country table.
UPDATE [country]
   SET [capital] = 4087
WHERE code ='USA' AND capital = 3813

--Rerun the original select statement to verify accurcy of changes
SELECT co.*
FROM country co
WHERE co.capital = 4087


-- 5. Delete Smallville, Kansas from the city table. (Did it succeed? Why?)

DELETE c.*
FROM city c
WHERE c.countrycode = 'USA' AND c.district = 'Kansas' AND name = 'Smallville' AND population = 45001

--Rerun the original select statement to verify accurcy of changes
SELECT c.*
FROM city c
WHERE c.countrycode = 'USA' AND c.district = 'Kansas' AND name = 'Smallville' AND population = 45001

-- 6. Return the US captial to Washington.

UPDATE [country]
   SET [capital] = 3813
WHERE capital = 4087
--Rerun the original select statement to verify accurcy of changes
SELECT co.*
FROM country co
WHERE co.capital = 4087

SELECT co.*
FROM country co
WHERE co.capital = 3813

-- 7. Delete Smallville, Kansas from the city table. (Did it succeed? Why?)

-- Cannot perform a delete action on something that does not already exist... Once deleted, it is permanent and we already did this in question 5.
--Run query to verify

SELECT c.*
FROM city c
WHERE c.countrycode = 'USA' AND c.district = 'Kansas' AND name = 'Smallville' AND population = 45001

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
--Process
SELECT population =  (population / population)
FROM city
WHERE population <1000
UPDATE [city]
SET [population] = (population / population)
WHERE  population <1000
(11 row(s) affected)

(11 row(s) affected)

--Check Results
SELECT c.population
FROM city c
ORDER BY c.population ASC

--Process
SELECT (population/1000)
FROM city
WHERE population >1000
UPDATE [city]
SET [population] = (population/1000)
WHERE population > 1000 

-- Check Results
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

SELECT cl.*, co.surfacearea
FROM countrylanguage cl
JOIN country as co ON co.code = cl.countrycode 
WHERE cl.percentage > 20 AND cl.language = 'French'

--7rows

--Update Data
SELECT cl.*, (co.surfacearea * 1609.34) as surfacearea_meters
FROM countrylanguage cl
JOIN country as co ON co.code = cl.countrycode 
WHERE cl.percentage > 20 AND cl.language = 'French' 



-- Process Data
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