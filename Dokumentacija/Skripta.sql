USE [master]
GO
/****** Object:  Database [T08_DB]    Script Date: 1.9.2014. 10:57:32 ******/
CREATE DATABASE [T08_DB] ON  PRIMARY 
( NAME = N'T08_DB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\T08_DB.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'T08_DB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\T08_DB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [T08_DB] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [T08_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [T08_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [T08_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [T08_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [T08_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [T08_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [T08_DB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [T08_DB] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [T08_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [T08_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [T08_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [T08_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [T08_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [T08_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [T08_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [T08_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [T08_DB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [T08_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [T08_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [T08_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [T08_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [T08_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [T08_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [T08_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [T08_DB] SET RECOVERY FULL 
GO
ALTER DATABASE [T08_DB] SET  MULTI_USER 
GO
ALTER DATABASE [T08_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [T08_DB] SET DB_CHAINING OFF 
GO
USE [T08_DB]
GO
/****** Object:  User [T08_User]    Script Date: 1.9.2014. 10:57:33 ******/
CREATE USER [T08_User] FOR LOGIN [T08_User] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [T08_User]
GO
ALTER ROLE [db_datareader] ADD MEMBER [T08_User]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [T08_User]
GO
/****** Object:  Table [dbo].[cjelina]    Script Date: 1.9.2014. 10:57:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cjelina](
	[ID_cjelina] [int] IDENTITY(1,1) NOT NULL,
	[ID_korisnik] [int] NULL,
	[naziv] [nchar](30) NULL,
	[opis] [nchar](300) NULL,
	[ID_predmet] [int] NULL,
	[bodovi] [float] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dogadjaj]    Script Date: 1.9.2014. 10:57:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dogadjaj](
	[ID_dogadjaj] [int] IDENTITY(1,1) NOT NULL,
	[kreirao] [int] NULL,
	[napomene] [text] NULL,
	[datum] [datetime] NULL,
	[ID_grupa] [int] NULL,
	[napomena] [nchar](100) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[grupa]    Script Date: 1.9.2014. 10:57:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[grupa](
	[ID_grupa] [int] IDENTITY(1,1) NOT NULL,
	[ID_cjelina] [int] NULL,
	[predavac] [nvarchar](50) NULL,
	[odradeno] [bit] NULL,
	[ID_korisnik] [int] NULL,
	[id_predmet] [int] NULL,
	[ID_dogadjaj] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ispit]    Script Date: 1.9.2014. 10:57:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ispit](
	[ID_ispit] [int] IDENTITY(1,1) NOT NULL,
	[ID_grupa] [int] NULL,
	[datum] [date] NULL,
	[napomena] [text] NULL,
	[trajanje] [nchar](10) NULL,
	[otvoren_zatvoren] [nchar](10) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Kat_grupe]    Script Date: 1.9.2014. 10:57:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kat_grupe](
	[ID_kategorija] [int] NOT NULL,
	[ID_grupa] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Kategorije]    Script Date: 1.9.2014. 10:57:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Kategorije](
	[ID] [int] NOT NULL,
	[Kategorija] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[korisnik]    Script Date: 1.9.2014. 10:57:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[korisnik](
	[ID_korisnik] [int] IDENTITY(1,1) NOT NULL,
	[ime] [nchar](30) NULL,
	[prezime] [nchar](30) NULL,
	[korisnicko_ime] [nchar](30) NULL,
	[lozinka] [nchar](30) NULL,
	[OIB] [nchar](11) NULL,
	[mail] [nchar](40) NULL,
	[telefon] [nchar](20) NULL,
	[ID_korisnikTip] [int] NULL,
	[ID_dogadjaj] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[korisnik_dogadjaj]    Script Date: 1.9.2014. 10:57:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[korisnik_dogadjaj](
	[ID_dogadjaj] [int] NULL,
	[ID_korisnik] [int] NULL,
	[dolazak] [bit] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[korisnik_grupa]    Script Date: 1.9.2014. 10:57:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[korisnik_grupa](
	[ID_grupa] [int] NULL,
	[ID_korisnik] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[korisnik_ispit]    Script Date: 1.9.2014. 10:57:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[korisnik_ispit](
	[ID_korisnik_ispit] [int] IDENTITY(1,1) NOT NULL,
	[ID_korisnik] [int] NULL,
	[ID_ispit] [int] NULL,
	[bodovi] [float] NULL,
	[prolaz] [bit] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[korisnikTip]    Script Date: 1.9.2014. 10:57:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[korisnikTip](
	[ID_korisnikTip] [int] IDENTITY(1,1) NOT NULL,
	[naziv] [nchar](20) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[materijal]    Script Date: 1.9.2014. 10:57:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[materijal](
	[ID_materijal] [int] IDENTITY(1,1) NOT NULL,
	[ID_cjelina] [int] NULL,
	[opis] [nchar](100) NULL,
	[srcMaterijal] [nchar](50) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[odgovor]    Script Date: 1.9.2014. 10:57:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[odgovor](
	[ID_odgovor] [int] IDENTITY(1,1) NOT NULL,
	[ID_pitanja] [int] NULL,
	[tekst] [text] NULL,
	[tocno] [bit] NULL,
	[srcOdgovor] [text] NULL,
	[bodovi] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[odgovor_ispit]    Script Date: 1.9.2014. 10:57:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[odgovor_ispit](
	[ID_korisnik_ispit] [int] NULL,
	[ID_odgovor] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[pitanja]    Script Date: 1.9.2014. 10:57:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pitanja](
	[ID_pitanja] [int] IDENTITY(1,1) NOT NULL,
	[ID_cjelina] [int] NULL,
	[tekst] [text] NULL,
	[srcPitanja] [text] NULL,
	[bodovi] [float] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[pitanja_ispit]    Script Date: 1.9.2014. 10:57:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pitanja_ispit](
	[ID_ispit] [int] NOT NULL,
	[ID_pitanja] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Predmet]    Script Date: 1.9.2014. 10:57:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Predmet](
	[ID_predmet] [int] IDENTITY(1,1) NOT NULL,
	[opis] [nchar](300) NULL,
	[naziv] [nchar](30) NULL,
	[Kategorija] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [T08_DB] SET  READ_WRITE 
GO
