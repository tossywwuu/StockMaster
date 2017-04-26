USE [master] 
GO 
IF EXISTS(SELECT * FROM sysdatabases WHERE NAME=N'StockDB') 
BEGIN 
DROP DATABASE StockDB --如果数据库存在先删掉数据库 
END 
GO 
CREATE DATABASE StockDB 
ON 
PRIMARY --创建主数据库文件 
( 
NAME='stockdb', 
FILENAME='D:\Program Files\Microsoft SQL Server\MSSQL10.TOSSY\MSSQL\DATA\StockDB.mdf', 
SIZE=5MB, 
MaxSize=20MB, 
FileGrowth=1MB 
) 
LOG ON --创建日志文件 
( 
NAME='stockdbLog', 
FileName='D:\Program Files\Microsoft SQL Server\MSSQL10.TOSSY\MSSQL\DATA\StockDB.ldf', 
Size=2MB, 
MaxSize=20MB, 
FileGrowth=1MB 
) 
GO 
