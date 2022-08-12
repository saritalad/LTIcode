IF OBJECT_ID('studydb.tablemember') IS NOT NULL
BEGIN
    DROP TABLE tablemember
END

CREATE TABLE tablemember
(
    first_name VARCHAR(50),
    last_name VARCHAR(50),
    ssn VARCHAR(9) CONSTRAINT ssn_unique UNIQUE
)

ALTER TABLE tablemember
DROP COLUMN first_name