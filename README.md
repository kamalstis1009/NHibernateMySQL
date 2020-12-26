# NHibernate MySQL8 MVC5 .NET Framework 4.5.2

Microsoft Visual Studio Community 2019
<p>MySQL Community Server v8.0.18</p>
<p>.NET Framework 4.5.2</p>
<p>NHibernate 4.1.2.4000</p>
<p>NHibernateX 1.3.1.4000</p>
<p>MySql Data 6.9.12</p>
<p>MySql Data Entity 6.9.12</p>



MS-SQL Server:
<code>
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[Brand] [nvarchar](max) NOT NULL,
	[CreateAt] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)
</code>


MySQL Table:
<code>
CREATE TABLE `products` (
  `Id` int(11) NOT NULL,
  `Name` varchar(45) DEFAULT NULL,
  `Brand` varchar(45) DEFAULT NULL,
  `CreateAt` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
</code>
