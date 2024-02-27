create database ADODOTNET	
USE ADODOTNET	

create table Trainer(
id int primary key identity,
name varchar(50),
city varchar(56),
Experience int
)
go
insert into Trainer values ('vikul', 'pune',14),
('usha', 'pune', 2)

select * from Trainer