USE [gym]
GO

/****** Object:  Table [dbo].[Ekipman]    Script Date: 17.06.2024 21:40:00 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Ekipman]') AND type in (N'U'))
DROP TABLE [dbo].[Ekipman]
GO

/****** Object:  Table [dbo].[Ekipman]    Script Date: 17.06.2024 21:40:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Ekipman](
	[EID] [int] IDENTITY(1,1) NOT NULL,
	[EkipmanAdı] [varchar](250) NOT NULL,
	[Acıklama] [varchar](250) NOT NULL,
	[CKaslar] [varchar](250) NOT NULL,
	[TTarihi] [varchar](250) NOT NULL,
	[Tutar] [bigint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

