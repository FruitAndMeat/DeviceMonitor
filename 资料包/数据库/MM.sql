use master
go

--判断数据库是否存在
if exists(select * from sysdatabases where name='MM') 
	drop database MM --如果已经存在数据库则删除
go
--创建数据库
create database MM
on primary
(
	name='MM_data',--数据库文件逻辑名称
	filename='D:\DB\MM_data.mdf',--数据库文件的绝对路径
	size=10MB,--数据库文件初始大小
	filegrowth=10%--数据库的增长速度，满了就涨10%
)
--创建日志文件
log on
(
	name='MM_log', --日志文件逻辑名称
	filename='D:\DB\MM_log.ldf',--日志文件的绝对路径
	size=2MB,--日志文件的初始大小
	filegrowth=10%--日志文件的增长速度
)
go

use MM
go
--判断数据表是否存在，若存在则删除
--创建设备清单表
if	exists(select * from sysobjects where name='Devices')
	drop table Devices
go
create table Devices 
(
	ID int identity(1,1),
	DeviceID int primary key,
	DeviceIP varchar(20) not null,
	IPPort int not null default 502,
	DeviceName varchar(20) not null,
	DeviceRemark varchar(50)
	
)
GO

--创建 职称表
if	exists(select * from sysobjects where name='Ranks')
	drop table Ranks
go
create table Ranks
(
	RankID int identity(1,1) primary key,
	RankRemark varchar(20) unique not null,
)
go

--创建管理人员表
if	exists(select * from sysobjects where name='Admins')
	drop table Admins
go
create table Admins 
(
	LoginID int unique, --登录号，工号
	LoginPwd varchar(20) not null, --登录密码
	LoginName varchar(20) not null, --人员名称
	Gender char(2) not null check(Gender='男' or Gender='女'),--人员性别
	RankID int foreign key references Ranks(RankID),--人员职称
)
go

----创建变量清单表
--if exists(select * from sysobjects where name='Variables')
--	drop table Variables
--go
--create table Variables
--(
--	VariableID int identity(1,1) primary key, --变量ID
--	VarName varchar(20) not null,--变量名称
--	VarAddr int unique not null, --变量地址
--	MachineID int foreign key references Devices(DeviceID) not null,--变量的来自设备
--	VarRemark varchar(50),--变量注释
--)
--go
--创建变量记录表
if	exists(select * from sysobjects where name='VarRecord')
	drop table VarRecord
go
create table VarRecord
(
	ID int identity(1,1),
	VarName varchar(20) not null,
	InsertTime datetime not null,
	VarValue real not null,
)
go



--创建报警记录表
if	exists(select * from sysobjects where name='AlarmRecord')
	drop table AlarmRecord
go
create table AlarmRecord
(
	AlarmID int identity(10000,1),
	AlarmDate datetime not null,
	VarName varchar(20) not null,
	AlarmState nvarchar(20) not null,
	[Priority] int default 0,
	AlarmType nvarchar(20) not null,
	ActualValue float not null,
	AlarmValue float not null,
	AlarmNote nvarchar(150)
)

-------------------------------------------------------------------插入数据---------------------------------------------------------------
use MM
go

--添加职级
insert into Ranks(RankRemark) values('系统管理员')
insert into Ranks(RankRemark) values('工程师')
insert into Ranks(RankRemark) values('操作员')
go

--添加用户
insert into Admins(LoginID,LoginPwd,LoginName,Gender,RankID)
values (10001,'123456','管理员儿','男',1)
--添加设备

go


select * from Variables
select * from AlarmRecord
select * from Ranks