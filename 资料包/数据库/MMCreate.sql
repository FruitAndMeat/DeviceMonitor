USE [master]
GO
/****** Object:  Database [MM]    Script Date: 2022/5/25 10:42:48 ******/
CREATE DATABASE [MM]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MM_data', FILENAME = N'D:\DB\MM_data.mdf' , SIZE = 10240KB , MAXSIZE = UNLIMITED, FILEGROWTH = 10%)
 LOG ON 
( NAME = N'MM_log', FILENAME = N'D:\DB\MM_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [MM] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MM].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MM] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MM] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MM] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MM] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MM] SET ARITHABORT OFF 
GO
ALTER DATABASE [MM] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [MM] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MM] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MM] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MM] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MM] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MM] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MM] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MM] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MM] SET  ENABLE_BROKER 
GO
ALTER DATABASE [MM] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MM] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MM] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MM] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MM] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MM] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MM] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MM] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MM] SET  MULTI_USER 
GO
ALTER DATABASE [MM] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MM] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MM] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MM] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MM] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MM] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [MM] SET QUERY_STORE = OFF
GO
USE [MM]
GO
/****** Object:  Table [dbo].[Admins]    Script Date: 2022/5/25 10:42:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admins](
	[LoginID] [int] NULL,
	[LoginPwd] [varchar](20) NOT NULL,
	[LoginName] [varchar](20) NOT NULL,
	[Gender] [char](2) NOT NULL,
	[RankID] [int] NULL,
UNIQUE NONCLUSTERED 
(
	[LoginID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AlarmRecord]    Script Date: 2022/5/25 10:42:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AlarmRecord](
	[AlarmID] [int] IDENTITY(1,1) NOT NULL,
	[VariableID] [int] NOT NULL,
	[AlarmDate] [smalldatetime] NOT NULL,
	[AlarmValue] [real] NOT NULL,
	[TypeID] [int] NOT NULL,
	[StateID] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AlarmState]    Script Date: 2022/5/25 10:42:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AlarmState](
	[StateID] [int] NOT NULL,
	[StateRemark] [varchar](20) NOT NULL,
UNIQUE NONCLUSTERED 
(
	[StateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AlarmType]    Script Date: 2022/5/25 10:42:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AlarmType](
	[TypeID] [int] NOT NULL,
	[TypeDescribe] [varchar](20) NOT NULL,
UNIQUE NONCLUSTERED 
(
	[TypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DataTypes]    Script Date: 2022/5/25 10:42:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DataTypes](
	[DataTypeID] [int] IDENTITY(1,1) NOT NULL,
	[DataType] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DataTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[DataType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Machines]    Script Date: 2022/5/25 10:42:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Machines](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MachineIP] [varchar](20) NOT NULL,
	[MachineName] [varchar](20) NOT NULL,
	[MachineRemark] [varchar](50) NULL,
	[IPPort] [int] NOT NULL,
	[MachineID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_Machines_MachineID] UNIQUE NONCLUSTERED 
(
	[MachineID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ranks]    Script Date: 2022/5/25 10:42:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ranks](
	[RankID] [int] IDENTITY(1,1) NOT NULL,
	[RankRemark] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RankID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[RankRemark] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Variables]    Script Date: 2022/5/25 10:42:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Variables](
	[VariableID] [int] IDENTITY(1,1) NOT NULL,
	[VarAddr] [int] NOT NULL,
	[VarName] [varchar](20) NOT NULL,
	[MachineID] [int] NOT NULL,
	[VarRemark] [varchar](50) NULL,
	[IsAlarm] [varchar](10) NULL,
	[IsFilling] [varchar](10) NULL,
	[IsReport] [varchar](10) NULL,
	[DataTypeID] [int] NOT NULL,
	[AlarmStr] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[VariableID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[VarAddr] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VarRecord]    Script Date: 2022/5/25 10:42:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VarRecord](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[VariableID] [int] NULL,
	[InsertDate] [smalldatetime] NOT NULL,
	[VarValue] [real] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Machines] ADD  DEFAULT ((502)) FOR [IPPort]
GO
ALTER TABLE [dbo].[Variables] ADD  DEFAULT ('NO') FOR [IsAlarm]
GO
ALTER TABLE [dbo].[Variables] ADD  DEFAULT ('NO') FOR [IsFilling]
GO
ALTER TABLE [dbo].[Variables] ADD  DEFAULT ('NO') FOR [IsReport]
GO
ALTER TABLE [dbo].[Admins]  WITH CHECK ADD FOREIGN KEY([RankID])
REFERENCES [dbo].[Ranks] ([RankID])
GO
ALTER TABLE [dbo].[AlarmRecord]  WITH CHECK ADD FOREIGN KEY([StateID])
REFERENCES [dbo].[AlarmState] ([StateID])
GO
ALTER TABLE [dbo].[AlarmRecord]  WITH CHECK ADD FOREIGN KEY([TypeID])
REFERENCES [dbo].[AlarmType] ([TypeID])
GO
ALTER TABLE [dbo].[AlarmRecord]  WITH CHECK ADD FOREIGN KEY([VariableID])
REFERENCES [dbo].[Variables] ([VariableID])
GO
ALTER TABLE [dbo].[Variables]  WITH CHECK ADD FOREIGN KEY([DataTypeID])
REFERENCES [dbo].[DataTypes] ([DataTypeID])
GO
ALTER TABLE [dbo].[Variables]  WITH CHECK ADD  CONSTRAINT [FK__Variables__Machi__2E1BDC42] FOREIGN KEY([MachineID])
REFERENCES [dbo].[Machines] ([MachineID])
GO
ALTER TABLE [dbo].[Variables] CHECK CONSTRAINT [FK__Variables__Machi__2E1BDC42]
GO
ALTER TABLE [dbo].[VarRecord]  WITH CHECK ADD FOREIGN KEY([VariableID])
REFERENCES [dbo].[Variables] ([VariableID])
GO
ALTER TABLE [dbo].[Admins]  WITH CHECK ADD CHECK  (([Gender]='男' OR [Gender]='女'))
GO
ALTER TABLE [dbo].[Variables]  WITH CHECK ADD CHECK  (([IsAlarm]='NO' OR [IsAlarm]='YES'))
GO
ALTER TABLE [dbo].[Variables]  WITH CHECK ADD CHECK  (([IsFilling]='NO' OR [IsFilling]='YES'))
GO
ALTER TABLE [dbo].[Variables]  WITH CHECK ADD CHECK  (([IsReport]='NO' OR [IsReport]='YES'))
GO
USE [master]
GO
ALTER DATABASE [MM] SET  READ_WRITE 
GO

Use MM
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
insert into Machines(MachineIP,IPPort,MachineName,MachineRemark) values('192.168.0.52',502,'PLC','这是一个1500PLC')
 go

 --插入报警的三种状态
insert into AlarmState(StateID,StateRemark) values (1,'到达')
insert into AlarmState(StateID,StateRemark) values (2,'离开')
insert into AlarmState(StateID,StateRemark) values (3,'已确认')
--插入报警的四种类型 LoLo Low High HiHi
insert into AlarmType(TypeID, TypeDescribe) values (1,'LoLo')
insert into AlarmType(TypeID, TypeDescribe) values (2,'Low')
insert into AlarmType(TypeID, TypeDescribe) values (3,'High')
insert into AlarmType(TypeID, TypeDescribe) values (4,'HiHi')

--对变量列表清单添加数据类型列以及是否有报警、报表和存档列
alter table Variables add IsAlarm varchar(10) default 'NO'  check(IsAlarm='NO' or IsAlarm='YES')
alter table Variables add IsFilling varchar(10) default 'NO'  check(IsFilling='NO' or IsFilling='YES')
alter table Variables add IsReport varchar(10) default 'NO'  check(IsReport='NO' or IsReport='YES')
alter table Variables add DataTypeID int foreign key references DataTypes(DataTypeID) not null
alter table Variables add AlarmStr varchar(max) 

insert into DataTypes(DataType) values('Real')
insert into DataTypes(DataType) values('Int')
insert into DataTypes(DataType) values('Bool')
insert into DataTypes(DataType) values('DInt')