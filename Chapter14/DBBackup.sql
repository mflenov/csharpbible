if (not exists (select null from sys.databases where Name = 'TestDb'))
   create database TestDb;
GO

use TestDb
go

if (not exists (select null from sys.tables where Name = 'City'))
	create table City (
		CityId int not null primary key identity(1, 1), 
		CityName nvarchar(20)
	)
GO

truncate table City;
insert into City (CityName) values ('Toronto');
insert into City (CityName) values ('Vancouver');
insert into City (CityName) values ('Montreal');
insert into City (CityName) values ('Ottawa');
insert into City (CityName) values ('Calgary');