create function TrackingItemsModified(@minID int) ----------temp table 
returns @trackingItems Table(
Id  int  not null,
Issued date  not null,
category int not null,
modified datetime null
)
as
begin
insert into @trackingItems(Id,Issued,category)
select ti.Id,ti.Issued,ti.category
from TrackingItem ti
where ti.id >= @minID;

update @trackingItems
set category = category + 1,
    modified = getdate()
	where category%2 = 0;

 return;
 end;
 ----------------------------------------------------------------------
 --use this following query in other window
 select * from dbo.TrackingItemsModified(2);