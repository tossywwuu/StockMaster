USE [master] 
GO 
IF EXISTS(SELECT * FROM sysdatabases WHERE NAME=N'StockDB') 
BEGIN 
DROP DATABASE StockDB --������ݿ������ɾ�����ݿ� 
END 
GO 
CREATE DATABASE StockDB 
ON 
PRIMARY --���������ݿ��ļ� 
( 
NAME='stockdb', 
FILENAME='D:\Program Files\Microsoft SQL Server\MSSQL10.TOSSY\MSSQL\DATA\StockDB.mdf', 
SIZE=5MB, 
MaxSize=20MB, 
FileGrowth=1MB 
) 
LOG ON --������־�ļ� 
( 
NAME='stockdbLog', 
FileName='D:\Program Files\Microsoft SQL Server\MSSQL10.TOSSY\MSSQL\DATA\StockDB.ldf', 
Size=2MB, 
MaxSize=20MB, 
FileGrowth=1MB 
) 
GO 
