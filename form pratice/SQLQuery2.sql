select * from marc4lyf
alter table marc4lyf drop column wholesome
alter table marc4lyf add wholesome text
insert into marc4lyf (wholesome) values('cheese')