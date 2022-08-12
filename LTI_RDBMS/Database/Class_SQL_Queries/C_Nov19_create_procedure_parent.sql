create  procedure parentbyparentId(@parentID int)
as
begin
select parent_name from parent where parentID=@parentID
end
go
exec parentbyparentId 3
------------------------------------------------

