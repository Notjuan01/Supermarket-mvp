use Supermarket
create table Categories
(
 Categories_Id int identity (100000,1)primary key,
 Categories_Name nvarchar (50) not null,
 Categories_Decription nvarchar (50) not null,
)
go
insert into Categories values('Lacteos', 'carnes')
insert into Categories values('Verduras', 'Frutas')
