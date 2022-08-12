declare @count int;
execute  dbo.SPFindCarByBrand @brand='maruti',
                          @car_count =@count out;
	select @count as 'count of cars';