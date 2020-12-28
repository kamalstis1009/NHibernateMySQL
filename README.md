# NHibernate MySQL8 MVC5 .NET Framework 4.5.2

Necessary Tools:
 <ul>
  <li>Microsoft Visual Studio Community 2019</li>
  <li>.NET Framework 4.5.2</li>
  <li>MySQL Community Server v8.0.22</li>
</ul> 


NuGet Packages:
 <ul>
  <li>NHibernate 4.1.2.4000</li>
  <li>NHibernateX 1.3.1.4000</li>
  <li>MySql Data 6.9.12</li>
  <li>MySql Data Entity 6.9.12</li>
</ul> 




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
