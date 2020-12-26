# NHibernateMySQL

Microsoft Visual Studio Community 2019
.NET Framework 4.5.2
NHibernate 4.1.2.4000
NHibernateX 1.3.1.4000
MySql Data 6.9.12
MySql Data Entity 6.9.12
MySQL Community Server v8.0.18


MS-SQL Server:
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[Brand] [nvarchar](max) NOT NULL,
	[CreateAt] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)



MySQL Table:
CREATE TABLE `products` (
  `Id` int(11) NOT NULL,
  `Name` varchar(45) DEFAULT NULL,
  `Brand` varchar(45) DEFAULT NULL,
  `CreateAt` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

