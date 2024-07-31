USE [master]
GO

/****** Object:  Database [Fruteria]    Script Date: 14/04/2021 07:53:46 p. m. ******/
CREATE DATABASE [Fruteria]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Fruteria', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSQLSERVER2016\MSSQL\DATA\Fruteria.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Fruteria_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSQLSERVER2016\MSSQL\DATA\Fruteria_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

ALTER DATABASE [Fruteria] SET COMPATIBILITY_LEVEL = 130
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Fruteria].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Fruteria] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [Fruteria] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [Fruteria] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [Fruteria] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [Fruteria] SET ARITHABORT OFF 
GO

ALTER DATABASE [Fruteria] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [Fruteria] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [Fruteria] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Fruteria] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Fruteria] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [Fruteria] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [Fruteria] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Fruteria] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [Fruteria] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Fruteria] SET  DISABLE_BROKER 
GO

ALTER DATABASE [Fruteria] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Fruteria] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Fruteria] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Fruteria] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Fruteria] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Fruteria] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [Fruteria] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Fruteria] SET RECOVERY FULL 
GO

ALTER DATABASE [Fruteria] SET  MULTI_USER 
GO

ALTER DATABASE [Fruteria] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Fruteria] SET DB_CHAINING OFF 
GO

ALTER DATABASE [Fruteria] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [Fruteria] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [Fruteria] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [Fruteria] SET QUERY_STORE = OFF
GO

USE [Fruteria]
GO

ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO

ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO

ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO

ALTER DATABASE [Fruteria] SET  READ_WRITE 
GO

