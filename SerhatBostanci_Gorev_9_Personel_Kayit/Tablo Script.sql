USE [Gorev_9_PersonelKayitDB]
GO

/****** Object:  Table [dbo].[PersonelBilgileri]    Script Date: 1.09.2019 11:47:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PersonelBilgileri](
	[PersonelID] [int] IDENTITY(1,1) NOT NULL,
	[TCKimlikNo] [bigint] NOT NULL,
	[Ad] [nvarchar](30) NOT NULL,
	[Soyad] [nvarchar](20) NOT NULL,
	[Unvan] [nvarchar](15) NULL,
	[Cinsiyet] [nvarchar](10) NULL,
	[MedeniHali] [nvarchar](10) NULL,
	[DogumTarihi] [datetime] NULL,
	[IseGirisTarihi] [datetime] NULL,
	[Telefon] [nvarchar](20) NULL,
	[E-Posta] [nvarchar](50) NULL,
	[Adres] [nvarchar](50) NULL,
	[Ehliyet] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[PersonelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[TCKimlikNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

