/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [id]
      ,[pname]
      ,[price]
      ,[quantity]
      ,[catagory]
  FROM [myDB].[dbo].[product]
