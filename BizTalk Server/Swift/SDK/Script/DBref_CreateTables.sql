GO
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CountryCode_List]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CountryCode_List]
GO
/****** Object:  Table [dbo].[CountryCode_List]    Script Date: 09/22/2007 02:25:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CountryCode_List](
	[CountryCode] [nvarchar](2) NOT NULL,
 CONSTRAINT [PK_CountryCode_List] PRIMARY KEY CLUSTERED 
(
	[CountryCode] ASC
)
) ON [PRIMARY]


GO
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[CurrencyCode_List]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[CurrencyCode_List]
GO
/****** Object:  Table [dbo].[CurrencyCode_List]    Script Date: 09/22/2007 02:25:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CurrencyCode_List](
	[CurrencyCode] [nvarchar](3) NOT NULL,
	[CurrencyAmtPrecission] [int] NOT NULL CONSTRAINT [DF_CurrencyCode_List_CurrencyAmtPrecission]  DEFAULT ((6)),
 CONSTRAINT [PK_CurrencyCode_List] PRIMARY KEY CLUSTERED 
(
	[CurrencyCode] ASC
)
) ON [PRIMARY]


GO
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[LegacyCurrencyCode_List]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[LegacyCurrencyCode_List]
GO
/****** Object:  Table [dbo].[LegacyCurrencyCode_List]    Script Date: 09/22/2007 02:25:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LegacyCurrencyCode_List](
	[CurrencyCode] [nvarchar](3) NOT NULL,
	[ValidDate] [nvarchar](10) NOT NULL CONSTRAINT [DF_LegacyCurrencyCode_List_ValidDate]  DEFAULT ((6)),
 CONSTRAINT [PK_LegacyCurrencyCode_List] PRIMARY KEY CLUSTERED 
(
	[CurrencyCode] ASC
)
) ON [PRIMARY]

