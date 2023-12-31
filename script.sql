USE [master]
GO
/****** Object:  Database [FoodShopWeb]    Script Date: 11/16/2023 5:59:40 AM ******/
CREATE DATABASE [FoodShopWeb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FoodShopWeb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\FoodShopWeb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FoodShopWeb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\FoodShopWeb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [FoodShopWeb] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FoodShopWeb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FoodShopWeb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FoodShopWeb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FoodShopWeb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FoodShopWeb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FoodShopWeb] SET ARITHABORT OFF 
GO
ALTER DATABASE [FoodShopWeb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FoodShopWeb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FoodShopWeb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FoodShopWeb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FoodShopWeb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FoodShopWeb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FoodShopWeb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FoodShopWeb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FoodShopWeb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FoodShopWeb] SET  ENABLE_BROKER 
GO
ALTER DATABASE [FoodShopWeb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FoodShopWeb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FoodShopWeb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FoodShopWeb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FoodShopWeb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FoodShopWeb] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [FoodShopWeb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FoodShopWeb] SET RECOVERY FULL 
GO
ALTER DATABASE [FoodShopWeb] SET  MULTI_USER 
GO
ALTER DATABASE [FoodShopWeb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FoodShopWeb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FoodShopWeb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FoodShopWeb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FoodShopWeb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [FoodShopWeb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'FoodShopWeb', N'ON'
GO
ALTER DATABASE [FoodShopWeb] SET QUERY_STORE = ON
GO
ALTER DATABASE [FoodShopWeb] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [FoodShopWeb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 11/16/2023 5:59:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Adv]    Script Date: 11/16/2023 5:59:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Adv](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](150) NOT NULL,
	[Description] [nvarchar](500) NULL,
	[Image] [nvarchar](500) NULL,
	[Link] [nvarchar](500) NULL,
	[Type] [int] NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[Modifiedby] [nvarchar](max) NULL,
 CONSTRAINT [PK_tb_Adv] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Category]    Script Date: 11/16/2023 5:59:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](150) NOT NULL,
	[Alias] [nvarchar](max) NULL,
	[Link] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[SeoTitle] [nvarchar](150) NULL,
	[SeoDescription] [nvarchar](250) NULL,
	[SeoKeywords] [nvarchar](150) NULL,
	[IsActive] [bit] NULL,
	[Position] [int] NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[Modifiedby] [nvarchar](max) NULL,
 CONSTRAINT [PK_tb_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Contact]    Script Date: 11/16/2023 5:59:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Contact](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](150) NOT NULL,
	[Email] [nvarchar](150) NULL,
	[Website] [nvarchar](max) NULL,
	[Message] [nvarchar](4000) NULL,
	[IsRead] [bit] NOT NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[Modifiedby] [nvarchar](max) NULL,
 CONSTRAINT [PK_tb_Contact] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Favourite]    Script Date: 11/16/2023 5:59:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Favourite](
	[ModifiedDate] [datetime2](7) NOT NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
	[Modifiedby] [nvarchar](max) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_tb_Favourite] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_FeedBack]    Script Date: 11/16/2023 5:59:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_FeedBack](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Content] [nvarchar](150) NOT NULL,
	[ProductID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
	[Modifiedby] [nvarchar](max) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_tb_FeedBack] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_News]    Script Date: 11/16/2023 5:59:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_News](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](150) NOT NULL,
	[Alias] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[Detail] [nvarchar](max) NULL,
	[Image] [nvarchar](max) NULL,
	[CategoryId] [int] NULL,
	[SeoTitle] [nvarchar](max) NULL,
	[SeoDescription] [nvarchar](max) NULL,
	[SeoKeywords] [nvarchar](max) NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[Modifiedby] [nvarchar](max) NULL,
 CONSTRAINT [PK_tb_News] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Order]    Script Date: 11/16/2023 5:59:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Order](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](max) NOT NULL,
	[CustomerName] [nvarchar](max) NOT NULL,
	[Phone] [nvarchar](max) NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NULL,
	[TotalAmount] [decimal](18, 2) NULL,
	[Quantity] [int] NULL,
	[TypePayment] [int] NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[Modifiedby] [nvarchar](max) NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_tb_Order] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_OrderDetail]    Script Date: 11/16/2023 5:59:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_OrderDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NULL,
	[ProductId] [int] NULL,
	[Price] [decimal](18, 2) NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK_tb_OrderDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Posts]    Script Date: 11/16/2023 5:59:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Posts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](150) NOT NULL,
	[Alias] [nvarchar](150) NULL,
	[Description] [nvarchar](max) NULL,
	[Detail] [nvarchar](max) NULL,
	[Image] [nvarchar](250) NULL,
	[CategoryId] [int] NULL,
	[SeoTitle] [nvarchar](250) NULL,
	[SeoDescription] [nvarchar](500) NULL,
	[SeoKeywords] [nvarchar](250) NULL,
	[IsActive] [bit] NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[Modifiedby] [nvarchar](max) NULL,
 CONSTRAINT [PK_tb_Posts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Product]    Script Date: 11/16/2023 5:59:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](250) NOT NULL,
	[Alias] [nvarchar](250) NULL,
	[ProductCode] [nvarchar](50) NULL,
	[Description] [nvarchar](max) NULL,
	[Detail] [nvarchar](max) NULL,
	[Image] [nvarchar](250) NULL,
	[OriginalPrice] [decimal](18, 2) NULL,
	[Price] [decimal](18, 2) NULL,
	[PriceSale] [decimal](18, 2) NULL,
	[Quantity] [int] NULL,
	[ViewCount] [int] NULL,
	[IsHome] [bit] NULL,
	[IsSale] [bit] NULL,
	[IsFeature] [bit] NULL,
	[IsHot] [bit] NULL,
	[IsActive] [bit] NULL,
	[ProductCategoryId] [int] NULL,
	[SeoTitle] [nvarchar](250) NULL,
	[SeoDescription] [nvarchar](500) NULL,
	[SeoKeywords] [nvarchar](250) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[Modifiedby] [nvarchar](max) NULL,
 CONSTRAINT [PK_tb_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_ProductCategory]    Script Date: 11/16/2023 5:59:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_ProductCategory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](150) NOT NULL,
	[Alias] [nvarchar](150) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Icon] [nvarchar](250) NULL,
	[SeoTitle] [nvarchar](250) NULL,
	[SeoDescription] [nvarchar](500) NULL,
	[SeoKeywords] [nvarchar](250) NULL,
	[CreatedBy] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
	[Modifiedby] [nvarchar](max) NULL,
 CONSTRAINT [PK_tb_ProductCategory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_ProductImage]    Script Date: 11/16/2023 5:59:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_ProductImage](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NULL,
	[Image] [nvarchar](max) NULL,
	[IsDefault] [bit] NULL,
 CONSTRAINT [PK_tb_ProductImage] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Subscribe]    Script Date: 11/16/2023 5:59:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Subscribe](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[CreatedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_tb_Subscribe] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_SystemSetting]    Script Date: 11/16/2023 5:59:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_SystemSetting](
	[SettingKey] [nvarchar](50) NOT NULL,
	[SettingValue] [nvarchar](4000) NULL,
	[SettingDescription] [nvarchar](4000) NULL,
 CONSTRAINT [PK_tb_SystemSetting] PRIMARY KEY CLUSTERED 
(
	[SettingKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_ThongKe]    Script Date: 11/16/2023 5:59:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_ThongKe](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ThoiGian] [datetime2](7) NULL,
	[SoTruyCap] [bigint] NULL,
 CONSTRAINT [PK_tb_ThongKe] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_User]    Script Date: 11/16/2023 5:59:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Email] [nvarchar](250) NOT NULL,
	[Enable] [bit] NULL,
	[Firrtname] [nvarchar](250) NOT NULL,
	[Gender] [bit] NOT NULL,
	[ImageUrl] [nvarchar](250) NULL,
	[IsLockout] [bit] NULL,
	[Lastname] [nvarchar](250) NOT NULL,
	[Password] [nvarchar](250) NOT NULL,
	[Role] [int] NULL,
 CONSTRAINT [PK_tb_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [IX_tb_News_CategoryId]    Script Date: 11/16/2023 5:59:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_tb_News_CategoryId] ON [dbo].[tb_News]
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_tb_OrderDetail_OrderId]    Script Date: 11/16/2023 5:59:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_tb_OrderDetail_OrderId] ON [dbo].[tb_OrderDetail]
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_tb_OrderDetail_ProductId]    Script Date: 11/16/2023 5:59:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_tb_OrderDetail_ProductId] ON [dbo].[tb_OrderDetail]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_tb_Posts_CategoryId]    Script Date: 11/16/2023 5:59:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_tb_Posts_CategoryId] ON [dbo].[tb_Posts]
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_tb_Product_ProductCategoryId]    Script Date: 11/16/2023 5:59:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_tb_Product_ProductCategoryId] ON [dbo].[tb_Product]
(
	[ProductCategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_tb_ProductImage_ProductId]    Script Date: 11/16/2023 5:59:40 AM ******/
CREATE NONCLUSTERED INDEX [IX_tb_ProductImage_ProductId] ON [dbo].[tb_ProductImage]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tb_Adv] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [CreatedDate]
GO
ALTER TABLE [dbo].[tb_Adv] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [ModifiedDate]
GO
ALTER TABLE [dbo].[tb_Category] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [CreatedDate]
GO
ALTER TABLE [dbo].[tb_Category] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [ModifiedDate]
GO
ALTER TABLE [dbo].[tb_Contact] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [CreatedDate]
GO
ALTER TABLE [dbo].[tb_Contact] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [ModifiedDate]
GO
ALTER TABLE [dbo].[tb_Favourite] ADD  CONSTRAINT [DF_tb_Favourite_ModifiedDate]  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [ModifiedDate]
GO
ALTER TABLE [dbo].[tb_Favourite] ADD  CONSTRAINT [DF_tb_Favourite_CreatedDate]  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [CreatedDate]
GO
ALTER TABLE [dbo].[tb_FeedBack] ADD  CONSTRAINT [DF_tb_FeedBack_CreatedDate]  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [CreatedDate]
GO
ALTER TABLE [dbo].[tb_FeedBack] ADD  CONSTRAINT [DF_tb_FeedBack_ModifiedDate]  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [ModifiedDate]
GO
ALTER TABLE [dbo].[tb_News] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsActive]
GO
ALTER TABLE [dbo].[tb_News] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [CreatedDate]
GO
ALTER TABLE [dbo].[tb_News] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [ModifiedDate]
GO
ALTER TABLE [dbo].[tb_Order] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [CreatedDate]
GO
ALTER TABLE [dbo].[tb_Order] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [ModifiedDate]
GO
ALTER TABLE [dbo].[tb_Posts] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [CreatedDate]
GO
ALTER TABLE [dbo].[tb_Posts] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [ModifiedDate]
GO
ALTER TABLE [dbo].[tb_Product] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [CreatedDate]
GO
ALTER TABLE [dbo].[tb_Product] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [ModifiedDate]
GO
ALTER TABLE [dbo].[tb_ProductCategory] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [CreatedDate]
GO
ALTER TABLE [dbo].[tb_ProductCategory] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [ModifiedDate]
GO
ALTER TABLE [dbo].[tb_Favourite]  WITH CHECK ADD  CONSTRAINT [FK_tb_Favourite_tb_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[tb_Product] ([Id])
GO
ALTER TABLE [dbo].[tb_Favourite] CHECK CONSTRAINT [FK_tb_Favourite_tb_Product]
GO
ALTER TABLE [dbo].[tb_Favourite]  WITH CHECK ADD  CONSTRAINT [FK_tb_Favourite_tb_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[tb_User] ([Id])
GO
ALTER TABLE [dbo].[tb_Favourite] CHECK CONSTRAINT [FK_tb_Favourite_tb_User]
GO
ALTER TABLE [dbo].[tb_FeedBack]  WITH CHECK ADD  CONSTRAINT [FK_tb_FeedBack_tb_Product] FOREIGN KEY([ProductID])
REFERENCES [dbo].[tb_Product] ([Id])
GO
ALTER TABLE [dbo].[tb_FeedBack] CHECK CONSTRAINT [FK_tb_FeedBack_tb_Product]
GO
ALTER TABLE [dbo].[tb_FeedBack]  WITH CHECK ADD  CONSTRAINT [FK_tb_FeedBack_tb_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[tb_User] ([Id])
GO
ALTER TABLE [dbo].[tb_FeedBack] CHECK CONSTRAINT [FK_tb_FeedBack_tb_User]
GO
ALTER TABLE [dbo].[tb_News]  WITH CHECK ADD  CONSTRAINT [FK_tb_News_tb_Category_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[tb_Category] ([Id])
GO
ALTER TABLE [dbo].[tb_News] CHECK CONSTRAINT [FK_tb_News_tb_Category_CategoryId]
GO
ALTER TABLE [dbo].[tb_OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_tb_OrderDetail_tb_Order_OrderId] FOREIGN KEY([OrderId])
REFERENCES [dbo].[tb_Order] ([Id])
GO
ALTER TABLE [dbo].[tb_OrderDetail] CHECK CONSTRAINT [FK_tb_OrderDetail_tb_Order_OrderId]
GO
ALTER TABLE [dbo].[tb_OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_tb_OrderDetail_tb_Product_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[tb_Product] ([Id])
GO
ALTER TABLE [dbo].[tb_OrderDetail] CHECK CONSTRAINT [FK_tb_OrderDetail_tb_Product_ProductId]
GO
ALTER TABLE [dbo].[tb_Posts]  WITH CHECK ADD  CONSTRAINT [FK_tb_Posts_tb_Category_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[tb_Category] ([Id])
GO
ALTER TABLE [dbo].[tb_Posts] CHECK CONSTRAINT [FK_tb_Posts_tb_Category_CategoryId]
GO
ALTER TABLE [dbo].[tb_Product]  WITH CHECK ADD  CONSTRAINT [FK_tb_Product_tb_ProductCategory_ProductCategoryId] FOREIGN KEY([ProductCategoryId])
REFERENCES [dbo].[tb_ProductCategory] ([Id])
GO
ALTER TABLE [dbo].[tb_Product] CHECK CONSTRAINT [FK_tb_Product_tb_ProductCategory_ProductCategoryId]
GO
ALTER TABLE [dbo].[tb_ProductImage]  WITH CHECK ADD  CONSTRAINT [FK_tb_ProductImage_tb_Product_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[tb_Product] ([Id])
GO
ALTER TABLE [dbo].[tb_ProductImage] CHECK CONSTRAINT [FK_tb_ProductImage_tb_Product_ProductId]
GO
/****** Object:  StoredProcedure [dbo].[sp_ThongKe]    Script Date: 11/16/2023 5:59:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[sp_ThongKe]
as
BEGIN
	DECLARE @SoTruyCapGanNhat int
	DECLARE @Count int
	SELECT @Count=COUNT(*) FROM tb_ThongKe
	IF @Count IS NULL SET @Count=0
	IF @Count=0
		INSERT INTO tb_ThongKe(ThoiGian,SoTruyCap)
		Values(GETDATE(),1)
	ELSE
		BEGIN
			DECLARE @ThoiGianGanNhat datetime
			SELECT @SoTruyCapGanNhat=tk.SoTruyCap,@ThoiGianGanNhat=tk.ThoiGian FROM tb_ThongKe tk
			WHERE tk.id=(SELECT MAX(tk1.Id) FROM tb_ThongKe tk1)
			IF @SoTruyCapGanNhat IS NULL SET @SoTruyCapGanNhat=0
			IF @ThoiGianGanNhat IS NULL SET @ThoiGianGanNhat=GETDATE()
			--Nếu chuyển sang ngày  mới chưa (sau 12h đêm)
			-- nếu chưa chuyển sang ngày mới thì update
			IF DAY(@ThoiGianGanNhat)=DAY(GETDATE())
				BEGIN
					UPDATE tb_ThongKe
					SET 
					SoTruyCap=@SoTruyCapGanNhat+1,
					ThoiGian=GETDATE()
					WHERE Id=(SELECT MAX(tk1.Id) FROM tb_ThongKe tk1)
				END
			-- Nếu đã sang ngày mới rồi thì chúng thêm 1 bản ghi mới
			ELSE
				INSERT INTO tb_ThongKe(ThoiGian,SoTruyCap)
				Values(GETDATE(),1)
		END

			-- Thống kê Hom nay, Hom qua, Tuan nay, Tuan Truoc, Thang nay, Thang Truoc
		DECLARE @HomNay int
		SET @HomNay=DATEPART(DW,GETDATE());
		SELECT @SoTruyCapGanNhat=SoTruyCap,@ThoiGianGanNhat=ThoiGian FROM tb_ThongKe 
		WHERE Id=(SELECT MAX(Id) FROM tb_ThongKe)

		--so truy cap ngay hqua
		DECLARE @TruyCapHomQua bigint
		SELECT @TruyCapHomQua=ISNULL(SoTruyCap,0) FROM tb_ThongKe 
		Where CONVERT(nvarchar(20),ThoiGian,103)=CONVERT(nvarchar(20),GETDATE()-1,103)
		IF @TruyCapHomQua IS NULL SET @TruyCapHomQua=0

		--truy cap dau tuan này
		DECLARE @DauTuanNay datetime
		SET @DauTuanNay= DATEADD(wk, DATEDIFF(wk, 6, GetDate()), 6)
		-- Tính Ngày đầu của tuần trước Tính từ thời điểm 00:00:))
		DECLARE @NgayDauTuanTruoc datetime
		SET @NgayDauTuanTruoc = Cast(CONVERT(nvarchar(30),DATEADD(dd, -(@HomNay+6), GetDate()),101) AS datetime)
		-- Tính ngày cuối tuần trước tính đến 24h ngày cuối tuần 
		DECLARE @NgayCuoiTuanTruoc datetime
		SET @NgayCuoiTuanTruoc = Cast(CONVERT(nvarchar(30),DATEADD(dd, -@HomNay, GetDate()),101) +' 23:59:59' AS datetime)

		-- so truy cap tuan nay
		DECLARE @TruyCapTuanNay bigint
		SELECT @TruyCapTuanNay=ISNULL(sum(SoTruyCap),0) FROM tb_ThongKe
		Where ThoiGian BETWEEN @DauTuanNay AND GETDATE()

		-- Tính số truy cập tuần trước
		DECLARE @SoLanTruyCapTuanTruoc bigint
		SELECT @SoLanTruyCapTuanTruoc=isnull(sum(SoTruyCap),0)  FROM tb_ThongKe ttk 
			WHERE ttk.ThoiGian BETWEEN @NgayDauTuanTruoc AND @NgayCuoiTuanTruoc
		
		-- Tính số truy cập tháng này
		DECLARE @SoTruyCapThangNay bigint 
		SELECT @SoTruyCapThangNay=isnull(Sum(SoTruyCap),0)
			FROM tb_ThongKe ttk WHERE MONTH(ttk.ThoiGian)=MONTH(GETDATE())
		
		-- Tính số truy cập tháng trước
		DECLARE @SoTruyCapThangTruoc bigint 
		SELECT @SoTruyCapThangTruoc=isnull(Sum(SoTruyCap),0)
			FROM tb_ThongKe ttk WHERE MONTH(ttk.ThoiGian)=MONTH(GETDATE())-1
		
		-- Tính tổng số
		DECLARE @TongSo bigint
		SELECT  @TongSo=isnull(Sum(SoTruyCap),0) FROM tb_ThongKe ttk
		
		SELECT @SoTruyCapGanNhat AS Today, 
		@TruyCapHomQua AS Yesterday,
		@TruyCapTuanNay AS ThisWeek, 
		@SoLanTruyCapTuanTruoc AS LastWeek, 
		@SoTruyCapThangNay AS ThisMonth, 
		@SoTruyCapThangTruoc AS LastMonth,
		@TongSo AS AllDay
END
GO
USE [master]
GO
ALTER DATABASE [FoodShopWeb] SET  READ_WRITE 
GO
