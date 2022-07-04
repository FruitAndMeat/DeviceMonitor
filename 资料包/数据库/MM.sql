use master
go

--�ж����ݿ��Ƿ����
if exists(select * from sysdatabases where name='MM') 
	drop database MM --����Ѿ��������ݿ���ɾ��
go
--�������ݿ�
create database MM
on primary
(
	name='MM_data',--���ݿ��ļ��߼�����
	filename='D:\DB\MM_data.mdf',--���ݿ��ļ��ľ���·��
	size=10MB,--���ݿ��ļ���ʼ��С
	filegrowth=10%--���ݿ�������ٶȣ����˾���10%
)
--������־�ļ�
log on
(
	name='MM_log', --��־�ļ��߼�����
	filename='D:\DB\MM_log.ldf',--��־�ļ��ľ���·��
	size=2MB,--��־�ļ��ĳ�ʼ��С
	filegrowth=10%--��־�ļ��������ٶ�
)
go

use MM
go
--�ж����ݱ��Ƿ���ڣ���������ɾ��
--�����豸�嵥��
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

--���� ְ�Ʊ�
if	exists(select * from sysobjects where name='Ranks')
	drop table Ranks
go
create table Ranks
(
	RankID int identity(1,1) primary key,
	RankRemark varchar(20) unique not null,
)
go

--����������Ա��
if	exists(select * from sysobjects where name='Admins')
	drop table Admins
go
create table Admins 
(
	LoginID int unique, --��¼�ţ�����
	LoginPwd varchar(20) not null, --��¼����
	LoginName varchar(20) not null, --��Ա����
	Gender char(2) not null check(Gender='��' or Gender='Ů'),--��Ա�Ա�
	RankID int foreign key references Ranks(RankID),--��Աְ��
)
go

----���������嵥��
--if exists(select * from sysobjects where name='Variables')
--	drop table Variables
--go
--create table Variables
--(
--	VariableID int identity(1,1) primary key, --����ID
--	VarName varchar(20) not null,--��������
--	VarAddr int unique not null, --������ַ
--	MachineID int foreign key references Devices(DeviceID) not null,--�����������豸
--	VarRemark varchar(50),--����ע��
--)
--go
--����������¼��
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



--����������¼��
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

-------------------------------------------------------------------��������---------------------------------------------------------------
use MM
go

--���ְ��
insert into Ranks(RankRemark) values('ϵͳ����Ա')
insert into Ranks(RankRemark) values('����ʦ')
insert into Ranks(RankRemark) values('����Ա')
go

--����û�
insert into Admins(LoginID,LoginPwd,LoginName,Gender,RankID)
values (10001,'123456','����Ա��','��',1)
--����豸

go


select * from Variables
select * from AlarmRecord
select * from Ranks