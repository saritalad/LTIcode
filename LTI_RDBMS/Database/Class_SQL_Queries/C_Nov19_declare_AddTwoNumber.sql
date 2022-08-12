DECLARE	@return_value int,
		@Result int

EXEC	@return_value = [dbo].[AddTwoNumber]
		@p1 = 24,
		@p2 = 20,
		@Result = @Result OUTPUT

SELECT	@Result as N'@Result'

SELECT	'Return Value' = @return_value

GO