declare @afterhash varbinary(500) = HASHBYTES('SHA2_512', 'sarita')

select @afterhash as varbinaryValue
        ,convert(nvarchar(1000), @afterhash, 1) as nvarcharIncludePrefix
        ,convert(nvarchar(1000), @afterhash, 2) as nvarcharExcludePrefix