CREATE TABLE TrackingItem (
   Id       int  NOT NULL IDENTITY(1,1),
   Issued   date NOT NULL,
   Category int  NOT NULL
);
CREATE INDEX X_TrackingItem_Issued ON TrackingItem (Issued);
INSERT INTO TrackingItem (Issued, Category) VALUES ( DATEADD( day, 0, GETDATE()), 1);
INSERT INTO TrackingItem (Issued, Category) VALUES ( DATEADD( day, 1, GETDATE()), 2);
INSERT INTO TrackingItem (Issued, Category) VALUES ( DATEADD( day, 4, GETDATE()), 1);
INSERT INTO TrackingItem (Issued, Category) VALUES ( DATEADD( day, 4, GETDATE()), 2);
select * from TrackingItem