CREATE PROCEDURE CleanFromTables AS 
BEGIN;
delete from Client;
DBCC CHECKIDENT ('Client', RESEED, 0);
delete from Automobil;
DBCC CHECKIDENT ('Automobil', RESEED, 0);
delete from Sasiu;
DBCC CHECKIDENT ('Sasiu', RESEED, 0);
delete from Mecanic;
DBCC CHECKIDENT ('Mecanic', RESEED, 0);
delete from Material;
DBCC CHECKIDENT ('Material', RESEED, 0);
delete from Imagine;
DBCC CHECKIDENT ('Imagine', RESEED, 0);
delete from Operatie;
DBCC CHECKIDENT ('Operatie', RESEED, 0);
delete from Comanda;
DBCC CHECKIDENT ('Comanda', RESEED, 0);
delete from DetaliiComanda;
DBCC CHECKIDENT ('DetaliiComanda', RESEED, 0);
End;

EXEC CleanFromTables;