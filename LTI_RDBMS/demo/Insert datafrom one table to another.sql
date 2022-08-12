use studydb
CREATE TABLE TestTable (FirstName VARCHAR(100), LastName VARCHAR(100))
----INSERT INTO TestTable using SELECT
INSERT INTO TestTable (FName, LastName)
SELECT FirstName, LastName
FROM Person
WHERE personid =1
----Verify that Data in TestTable
SELECT FName, LastName
FROM TestTable
----Clean Up Database

GO
