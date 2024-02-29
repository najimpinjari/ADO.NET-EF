use ADODOTNET
GO
create table Student (
RollNumber int primary key identity ,
Name varchar(50),
Gender varchar(50),
TrainerId int foreign key references Trainer(Id)
)
go


select Id, Name , City , Experience from Trainer;select RollNumber, Name , Gender, TrainerId from Student
