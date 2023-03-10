USE [master]
GO
/****** Object:  Database [Gorsel]    Script Date: 7.01.2020 20:36:55 ******/
CREATE DATABASE [Gorsel]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Gorsel', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Gorsel.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Gorsel_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Gorsel_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Gorsel] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Gorsel].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Gorsel] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Gorsel] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Gorsel] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Gorsel] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Gorsel] SET ARITHABORT OFF 
GO
ALTER DATABASE [Gorsel] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Gorsel] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Gorsel] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Gorsel] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Gorsel] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Gorsel] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Gorsel] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Gorsel] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Gorsel] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Gorsel] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Gorsel] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Gorsel] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Gorsel] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Gorsel] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Gorsel] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Gorsel] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Gorsel] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Gorsel] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Gorsel] SET  MULTI_USER 
GO
ALTER DATABASE [Gorsel] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Gorsel] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Gorsel] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Gorsel] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Gorsel] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Gorsel] SET QUERY_STORE = OFF
GO
USE [Gorsel]
GO
/****** Object:  Table [dbo].[doktor]    Script Date: 7.01.2020 20:36:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[doktor](
	[doktorNo] [int] IDENTITY(1,1) NOT NULL,
	[doktorAd] [nvarchar](50) NULL,
	[doktorSoyAd] [nvarchar](50) NULL,
	[doktorTcNO] [nchar](11) NULL,
	[doktorTel] [nvarchar](50) NULL,
	[doktorDtarihi] [datetime] NULL,
	[doktorDyeri] [nvarchar](50) NULL,
	[doktorEmail] [nvarchar](50) NULL,
	[doktorCinsiyet] [nchar](5) NULL,
	[klinikNo] [int] NULL,
	[klinikAd] [nvarchar](50) NULL,
 CONSTRAINT [PK_doktor] PRIMARY KEY CLUSTERED 
(
	[doktorNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hasta]    Script Date: 7.01.2020 20:36:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hasta](
	[hastaNo] [int] IDENTITY(1,1) NOT NULL,
	[hastaTcNo] [nchar](11) NULL,
	[hastaAdi] [nchar](15) NULL,
	[hastoSoyadi] [nchar](15) NULL,
	[hastaTel] [nchar](11) NULL,
	[hastaCinsiyet] [nchar](5) NULL,
	[hastaDogumYeri] [nchar](100) NULL,
	[hastaAnneAdi] [nchar](10) NULL,
	[hastaBabaAdi] [nchar](10) NULL,
	[hastaAdres] [nchar](10) NULL,
	[hastaKanGrubu] [nchar](10) NULL,
	[hastaMedeniHali] [nchar](10) NULL,
 CONSTRAINT [PK_Hasta] PRIMARY KEY CLUSTERED 
(
	[hastaNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ilac]    Script Date: 7.01.2020 20:36:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ilac](
	[ilacNo] [int] IDENTITY(1,1) NOT NULL,
	[ilacAdı] [nvarchar](50) NULL,
	[ilacTuruNo] [int] NULL,
 CONSTRAINT [PK_ilac] PRIMARY KEY CLUSTERED 
(
	[ilacNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ilacTuru]    Script Date: 7.01.2020 20:36:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ilacTuru](
	[ilacTuruNo] [int] IDENTITY(1,1) NOT NULL,
	[ilacTuru] [nvarchar](50) NULL,
 CONSTRAINT [PK_ilacTuru] PRIMARY KEY CLUSTERED 
(
	[ilacTuruNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kisi]    Script Date: 7.01.2020 20:36:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kisi](
	[kisiId] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nchar](10) NULL,
	[Soyad] [nchar](10) NULL,
	[tcNo] [nchar](11) NULL,
	[telefonNo] [nchar](12) NULL,
	[rolNo] [int] NULL,
 CONSTRAINT [PK_Kisi] PRIMARY KEY CLUSTERED 
(
	[kisiId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[klinik]    Script Date: 7.01.2020 20:36:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[klinik](
	[klinikNo] [int] IDENTITY(1,1) NOT NULL,
	[klinikAd] [nvarchar](50) NULL,
	[klinikKapasite] [int] NULL,
 CONSTRAINT [PK_klinik] PRIMARY KEY CLUSTERED 
(
	[klinikNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kullanici]    Script Date: 7.01.2020 20:36:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanici](
	[KullaniciID] [int] IDENTITY(1,1) NOT NULL,
	[KisiId] [int] NOT NULL,
	[RolId] [int] NULL,
	[KullaniciAd] [nchar](10) NULL,
	[Sifre] [nchar](10) NULL,
	[doktorNo] [int] NULL,
 CONSTRAINT [PK_Kullanici] PRIMARY KEY CLUSTERED 
(
	[KullaniciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[randevu]    Script Date: 7.01.2020 20:36:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[randevu](
	[randevuId] [int] IDENTITY(1,1) NOT NULL,
	[randevuSaat] [nvarchar](60) NULL,
	[randevuTarih] [nvarchar](60) NULL,
	[randevuKlinik] [nvarchar](50) NULL,
	[hastaNo] [int] NULL,
	[doktorNo] [int] NULL,
 CONSTRAINT [PK_randevu] PRIMARY KEY CLUSTERED 
(
	[randevuId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rol]    Script Date: 7.01.2020 20:36:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rol](
	[RolID] [int] IDENTITY(1,1) NOT NULL,
	[RolAd] [nchar](10) NULL,
	[RolKod] [nchar](10) NULL,
 CONSTRAINT [PK_Rol] PRIMARY KEY CLUSTERED 
(
	[RolID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sonislemhasta]    Script Date: 7.01.2020 20:36:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sonislemhasta](
	[hastaSSSNo] [int] IDENTITY(1,1) NOT NULL,
	[hastaAdss] [nvarchar](50) NULL,
	[hastaSoyadss] [nvarchar](50) NULL,
	[hastaTcNo] [nvarchar](50) NULL,
	[hastaSikayetss] [nvarchar](max) NULL,
	[hastailacss] [nvarchar](max) NULL,
	[hastaislemss] [nvarchar](max) NULL,
 CONSTRAINT [PK_Sonislemhasta] PRIMARY KEY CLUSTERED 
(
	[hastaSSSNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sonSecimHasta]    Script Date: 7.01.2020 20:36:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sonSecimHasta](
	[ssHastaNo] [int] IDENTITY(1,1) NOT NULL,
	[hastaNoS] [int] NOT NULL,
	[hastaAdS] [nvarchar](50) NOT NULL,
	[hastaSoyadS] [nvarchar](50) NOT NULL,
	[doktorAdS] [nvarchar](50) NOT NULL,
	[doktorNoS] [int] NULL,
	[hastaSikayetS] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_sonSecimHasta_1] PRIMARY KEY CLUSTERED 
(
	[ssHastaNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[doktor] ON 

INSERT [dbo].[doktor] ([doktorNo], [doktorAd], [doktorSoyAd], [doktorTcNO], [doktorTel], [doktorDtarihi], [doktorDyeri], [doktorEmail], [doktorCinsiyet], [klinikNo], [klinikAd]) VALUES (2, N'guven', N'asdas', N'21312      ', N'1231', NULL, N'asdas', N'asdasd', N'asdas', NULL, N'Nöroloji')
SET IDENTITY_INSERT [dbo].[doktor] OFF
SET IDENTITY_INSERT [dbo].[Hasta] ON 

INSERT [dbo].[Hasta] ([hastaNo], [hastaTcNo], [hastaAdi], [hastoSoyadi], [hastaTel], [hastaCinsiyet], [hastaDogumYeri], [hastaAnneAdi], [hastaBabaAdi], [hastaAdres], [hastaKanGrubu], [hastaMedeniHali]) VALUES (1, N'3115698978 ', N'Güven          ', N'Karabulut      ', NULL, N'Bay  ', N'Isparta                                                                                             ', N'Ayşe      ', N'Muharrem  ', N'Isparta   ', N'A Rh+     ', N'Bekar     ')
INSERT [dbo].[Hasta] ([hastaNo], [hastaTcNo], [hastaAdi], [hastoSoyadi], [hastaTel], [hastaCinsiyet], [hastaDogumYeri], [hastaAnneAdi], [hastaBabaAdi], [hastaAdres], [hastaKanGrubu], [hastaMedeniHali]) VALUES (2, N'1231241    ', N'Güvena         ', N'Ka             ', NULL, N'Bay  ', N'dasda                                                                                               ', N'dasds     ', N'asdas     ', N'dasda     ', N'0 Rh-     ', N'Evli      ')
INSERT [dbo].[Hasta] ([hastaNo], [hastaTcNo], [hastaAdi], [hastoSoyadi], [hastaTel], [hastaCinsiyet], [hastaDogumYeri], [hastaAnneAdi], [hastaBabaAdi], [hastaAdres], [hastaKanGrubu], [hastaMedeniHali]) VALUES (3, N'asd        ', N'Uygar          ', N'Başboğa        ', N'asd        ', N'Erkek', NULL, N'asd       ', N'asd       ', N'asda      ', N'0 Rh-     ', N'Bekar     ')
SET IDENTITY_INSERT [dbo].[Hasta] OFF
SET IDENTITY_INSERT [dbo].[ilac] ON 

INSERT [dbo].[ilac] ([ilacNo], [ilacAdı], [ilacTuruNo]) VALUES (1, N'Aspirin', 1)
INSERT [dbo].[ilac] ([ilacNo], [ilacAdı], [ilacTuruNo]) VALUES (2, N'Arveles', 1)
INSERT [dbo].[ilac] ([ilacNo], [ilacAdı], [ilacTuruNo]) VALUES (3, N'anti1', 2)
INSERT [dbo].[ilac] ([ilacNo], [ilacAdı], [ilacTuruNo]) VALUES (4, N'anti2', 2)
SET IDENTITY_INSERT [dbo].[ilac] OFF
SET IDENTITY_INSERT [dbo].[ilacTuru] ON 

INSERT [dbo].[ilacTuru] ([ilacTuruNo], [ilacTuru]) VALUES (1, N'Ağrı Kesici')
INSERT [dbo].[ilacTuru] ([ilacTuruNo], [ilacTuru]) VALUES (2, N'Antibiyotik')
SET IDENTITY_INSERT [dbo].[ilacTuru] OFF
SET IDENTITY_INSERT [dbo].[Kisi] ON 

INSERT [dbo].[Kisi] ([kisiId], [Ad], [Soyad], [tcNo], [telefonNo], [rolNo]) VALUES (1, N'Vezne     ', N'Vezne     ', NULL, NULL, NULL)
INSERT [dbo].[Kisi] ([kisiId], [Ad], [Soyad], [tcNo], [telefonNo], [rolNo]) VALUES (2, N'Yonetim   ', N'Yonetim   ', NULL, NULL, NULL)
INSERT [dbo].[Kisi] ([kisiId], [Ad], [Soyad], [tcNo], [telefonNo], [rolNo]) VALUES (3, N'Doktor    ', N'Doktor    ', N'           ', NULL, 3)
INSERT [dbo].[Kisi] ([kisiId], [Ad], [Soyad], [tcNo], [telefonNo], [rolNo]) VALUES (4, N'Doktor2   ', N'Doktor2   ', NULL, NULL, 3)
SET IDENTITY_INSERT [dbo].[Kisi] OFF
SET IDENTITY_INSERT [dbo].[klinik] ON 

INSERT [dbo].[klinik] ([klinikNo], [klinikAd], [klinikKapasite]) VALUES (1, N'Psikiyatri', 20)
INSERT [dbo].[klinik] ([klinikNo], [klinikAd], [klinikKapasite]) VALUES (2, N'Nöroloji', 20)
INSERT [dbo].[klinik] ([klinikNo], [klinikAd], [klinikKapasite]) VALUES (3, N'Kardiyoloji', 20)
INSERT [dbo].[klinik] ([klinikNo], [klinikAd], [klinikKapasite]) VALUES (4, N'Beyin-ve-Sinir-Cerrahisi', 50)
SET IDENTITY_INSERT [dbo].[klinik] OFF
SET IDENTITY_INSERT [dbo].[Kullanici] ON 

INSERT [dbo].[Kullanici] ([KullaniciID], [KisiId], [RolId], [KullaniciAd], [Sifre], [doktorNo]) VALUES (1, 1, 1, N'yonetim   ', N'1234      ', NULL)
INSERT [dbo].[Kullanici] ([KullaniciID], [KisiId], [RolId], [KullaniciAd], [Sifre], [doktorNo]) VALUES (2, 2, 3, N'vezne     ', N'4321      ', NULL)
INSERT [dbo].[Kullanici] ([KullaniciID], [KisiId], [RolId], [KullaniciAd], [Sifre], [doktorNo]) VALUES (3, 3, 2, N'doktor1   ', N'1234      ', 2)
INSERT [dbo].[Kullanici] ([KullaniciID], [KisiId], [RolId], [KullaniciAd], [Sifre], [doktorNo]) VALUES (4, 4, 2, N'seydi     ', N'1234      ', 3)
SET IDENTITY_INSERT [dbo].[Kullanici] OFF
SET IDENTITY_INSERT [dbo].[randevu] ON 

INSERT [dbo].[randevu] ([randevuId], [randevuSaat], [randevuTarih], [randevuKlinik], [hastaNo], [doktorNo]) VALUES (1, N'10:30', N'25 Ocak 2020 Cumartesi', N'Nöroloji', 2, NULL)
INSERT [dbo].[randevu] ([randevuId], [randevuSaat], [randevuTarih], [randevuKlinik], [hastaNo], [doktorNo]) VALUES (2, N'11:30', N'11 Ocak 2020 Cumartesi', N'Psikiyatri', 2, NULL)
INSERT [dbo].[randevu] ([randevuId], [randevuSaat], [randevuTarih], [randevuKlinik], [hastaNo], [doktorNo]) VALUES (4, N'11:00', N'24 Ocak 2020 Cuma', N'Nöroloji', 2, 2)
SET IDENTITY_INSERT [dbo].[randevu] OFF
SET IDENTITY_INSERT [dbo].[Rol] ON 

INSERT [dbo].[Rol] ([RolID], [RolAd], [RolKod]) VALUES (1, N'Yonetim   ', N'Yonetim   ')
INSERT [dbo].[Rol] ([RolID], [RolAd], [RolKod]) VALUES (2, N'Doktor    ', N'Doktor    ')
INSERT [dbo].[Rol] ([RolID], [RolAd], [RolKod]) VALUES (3, N'Sekreter  ', N'Sekreter  ')
INSERT [dbo].[Rol] ([RolID], [RolAd], [RolKod]) VALUES (8, NULL, N'          ')
SET IDENTITY_INSERT [dbo].[Rol] OFF
SET IDENTITY_INSERT [dbo].[Sonislemhasta] ON 

INSERT [dbo].[Sonislemhasta] ([hastaSSSNo], [hastaAdss], [hastaSoyadss], [hastaTcNo], [hastaSikayetss], [hastailacss], [hastaislemss]) VALUES (1, N'Güvena         ', N'Ka             ', N'1231241    ', N'İğne vuruldu', N'3', NULL)
INSERT [dbo].[Sonislemhasta] ([hastaSSSNo], [hastaAdss], [hastaSoyadss], [hastaTcNo], [hastaSikayetss], [hastailacss], [hastaislemss]) VALUES (2, N'Güvena         ', N'Ka             ', N'1231241    ', N'sadsda', N'Aspirin', NULL)
SET IDENTITY_INSERT [dbo].[Sonislemhasta] OFF
SET IDENTITY_INSERT [dbo].[sonSecimHasta] ON 

INSERT [dbo].[sonSecimHasta] ([ssHastaNo], [hastaNoS], [hastaAdS], [hastaSoyadS], [doktorAdS], [doktorNoS], [hastaSikayetS]) VALUES (1, 1231241, N'Güvena         ', N'Ka             ', N'guven asdas', 2, N'adasdasd                                                                                                                                              ')
INSERT [dbo].[sonSecimHasta] ([ssHastaNo], [hastaNoS], [hastaAdS], [hastaSoyadS], [doktorAdS], [doktorNoS], [hastaSikayetS]) VALUES (2, 1231241, N'Güvena         ', N'Ka             ', N'guven asdas', 2, N'asdasdasd                                                                                                                                             ')
INSERT [dbo].[sonSecimHasta] ([ssHastaNo], [hastaNoS], [hastaAdS], [hastaSoyadS], [doktorAdS], [doktorNoS], [hastaSikayetS]) VALUES (3, 1231241, N'Güvena         ', N'Ka             ', N'guven asdas', 2, N'Karın Ağrısı                                                                                                                                          ')
INSERT [dbo].[sonSecimHasta] ([ssHastaNo], [hastaNoS], [hastaAdS], [hastaSoyadS], [doktorAdS], [doktorNoS], [hastaSikayetS]) VALUES (4, 1231241, N'Güvena         ', N'Ka             ', N'guven asdas', 2, N'sadasdas                                                                                                                                              ')
INSERT [dbo].[sonSecimHasta] ([ssHastaNo], [hastaNoS], [hastaAdS], [hastaSoyadS], [doktorAdS], [doktorNoS], [hastaSikayetS]) VALUES (5, 1231241, N'Güvena         ', N'Ka             ', N'guven asdas', 2, N'Karın ağrısı                                                                                                                                          ')
INSERT [dbo].[sonSecimHasta] ([ssHastaNo], [hastaNoS], [hastaAdS], [hastaSoyadS], [doktorAdS], [doktorNoS], [hastaSikayetS]) VALUES (6, 1231241, N'Güvena         ', N'Ka             ', N'guven asdas', 2, N'Kalp Ağrısı                                                                                                                                           ')
SET IDENTITY_INSERT [dbo].[sonSecimHasta] OFF
ALTER TABLE [dbo].[doktor]  WITH CHECK ADD  CONSTRAINT [FK_doktor_klinik] FOREIGN KEY([klinikNo])
REFERENCES [dbo].[klinik] ([klinikNo])
GO
ALTER TABLE [dbo].[doktor] CHECK CONSTRAINT [FK_doktor_klinik]
GO
ALTER TABLE [dbo].[ilac]  WITH CHECK ADD  CONSTRAINT [FK_ilac_ilacTuru] FOREIGN KEY([ilacTuruNo])
REFERENCES [dbo].[ilacTuru] ([ilacTuruNo])
GO
ALTER TABLE [dbo].[ilac] CHECK CONSTRAINT [FK_ilac_ilacTuru]
GO
ALTER TABLE [dbo].[Kullanici]  WITH CHECK ADD  CONSTRAINT [FK_Kullanici_Kisi1] FOREIGN KEY([KisiId])
REFERENCES [dbo].[Kisi] ([kisiId])
GO
ALTER TABLE [dbo].[Kullanici] CHECK CONSTRAINT [FK_Kullanici_Kisi1]
GO
ALTER TABLE [dbo].[Kullanici]  WITH CHECK ADD  CONSTRAINT [FK_Kullanici_Rol] FOREIGN KEY([RolId])
REFERENCES [dbo].[Rol] ([RolID])
GO
ALTER TABLE [dbo].[Kullanici] CHECK CONSTRAINT [FK_Kullanici_Rol]
GO
ALTER TABLE [dbo].[randevu]  WITH CHECK ADD  CONSTRAINT [FK_randevu_doktor] FOREIGN KEY([doktorNo])
REFERENCES [dbo].[doktor] ([doktorNo])
GO
ALTER TABLE [dbo].[randevu] CHECK CONSTRAINT [FK_randevu_doktor]
GO
ALTER TABLE [dbo].[randevu]  WITH CHECK ADD  CONSTRAINT [FK_randevu_Hasta] FOREIGN KEY([hastaNo])
REFERENCES [dbo].[Hasta] ([hastaNo])
GO
ALTER TABLE [dbo].[randevu] CHECK CONSTRAINT [FK_randevu_Hasta]
GO
USE [master]
GO
ALTER DATABASE [Gorsel] SET  READ_WRITE 
GO
