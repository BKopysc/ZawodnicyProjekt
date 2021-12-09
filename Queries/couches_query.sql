DBCC CHECKIDENT ('[Coach]', RESEED, 0);
GO
DELETE FROM Coach;
GO
INSERT INTO Coach(Name,Surname,DateBirth)
Values
('Apoloniusz','Tajner','1954-10-04'),
('Mati','Hautameki','1962-09-13'),
('Wolfgang','Loitz','1971-03-25');
GO
