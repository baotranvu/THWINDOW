USE [SuperMarket]
GO
/****** Object:  StoredProcedure [dbo].[sp_AddEmployee]    Script Date: 19/11/2020 8:05:05 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER proc [dbo].[sp_AddEmployee](@name nvarchar(25),@gender char(6),@birth datetime,@address nvarchar(100),@phone nvarchar(15), @pass nvarchar(max))
as 
begin
declare @t nvarchar(max)
declare @t1 nvarchar(max)
declare @t2 nvarchar(max)
SET @t =	'CREATE LOGIN ' + QUOTENAME(@name) + ' WITH PASSWORD = ' + QUOTENAME(@pass,'''') 
SET @t1 =	'CREATE USER ' + QUOTENAME(@name) +  'FOR LOGIN' + QUOTENAME(@name) 
SET @t2 =	'ALTER ROLE RoleForEmployee ADD MEMBER' + QUOTENAME(@name)
Insert into Employees(Name, Gender,  Date, Address, Phone) values(@name, @gender, @birth, @address, @phone)
EXEC(@t)
EXEC(@t1)
EXEC(@t2)
end

