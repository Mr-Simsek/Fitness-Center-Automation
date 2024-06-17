USE [gym]
GO

/****** Object:  Table [dbo].[YeniPersonel]    Script Date: 17.06.2024 21:40:32 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[YeniPersonel]') AND type in (N'U'))
DROP TABLE [dbo].[YeniPersonel]
GO

/****** Object:  Table [dbo].[YeniPersonel]    Script Date: 17.06.2024 21:40:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[YeniPersonel](
	[SID] [int] IDENTITY(1,1) NOT NULL,
	[Fad] [varchar](150) NOT NULL,
	[Lsoyad] [varchar](150) NOT NULL,
	[Cinsiyet] [varchar](20) NOT NULL,
	[Dob] [varchar](100) NOT NULL,
	[Telefon] [bigint] NOT NULL,
	[Email] [varchar](150) NULL,
	[Üyeliktarihi] [varchar](100) NOT NULL,
	[Ülke] [varchar](100) NOT NULL,
	[Şehir] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

