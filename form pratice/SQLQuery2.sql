select * from marc4lyf
alter table marc4lyf drop column wholesome
alter table marc4lyf add wholesome text
insert into marc4lyf (wholesome) values('cheese')
SELECT COLUMN_NAME
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'marc4lyf'
ORDER BY ORDINAL_POSITION