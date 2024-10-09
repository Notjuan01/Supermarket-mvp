use Supermarket
create table Customers
(
Customers_Id int identity (100000,1) primary key,
Customers_Document_number Nvarchar(15) Not Null unique,
Customers_first_name Nvarchar(50) Not Null,
Customers_last_name Nvarchar(50) Not Null,
Customers_address Nvarchar(80),
Customers_birthday date,
Customers_phone_numbers Nvarchar(16),
Customers_email Nvarchar(100),

)
go
insert into Customers values('16494028', 'Carlos','Martinez','Calle 60A #119-140','1968-12-26','3165833468','Mjuanpablo523@gmail.com')
insert into Customers values('1107841591', 'Luis','Mainguez','Calle 104 #15a-26','2005-10-31','320841591','Luismaiguez579@gmail.com')
