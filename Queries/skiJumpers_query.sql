﻿DBCC CHECKIDENT ('[SkiJumper]', RESEED, 0);
GO
DELETE FROM SkiJumper;
GO
INSERT INTO SkiJumper(CouchId,Name,Surname,Country,DateBirth,Height,Weight)
Values
('1','Adam','Malysz','Poland','1970-10-23', '172.45','45.1'),
('2','Kamil','Stoch','Poland','1981-07-12', '162.25','65.21'),
('3','Daniel', 'Andre Tande','Norway','1983-12-21', '182.45','75.1'),
('2','Stefan','Kraft','Austria','1979-05-12', '165.20','65.23');
GO
