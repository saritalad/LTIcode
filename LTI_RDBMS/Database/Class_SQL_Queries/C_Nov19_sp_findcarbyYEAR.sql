create procedure spfindcarbyyear( @model_year int ,@car_count int output)
as
begin
  select carname,price from IndianCars where model_year=@model_year;
  select @car_count=@@ROWCOUNT;
  end;
  declare @count int;
  execute spfindcarbyyear @model_year=1987 ,@car_count=@count output;
  select @count as 'count of cars';