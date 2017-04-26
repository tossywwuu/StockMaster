USE [StockDB]
GO

/****** Object:  Table [dbo].[T_Stock_Main]    Script Date: 04/26/2017 17:39:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[T_Stock_Main](
	[Code] [varchar](100) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Price] [numeric](10, 2) NOT NULL,
	[Market] [varchar](50) NULL,
	[Plate] [varchar](50) NULL,
	[Status] [int] NULL,
	[MaxPrice] [numeric](10, 2) NULL,
	[MinPrice] [numeric](10, 2) NULL,
	[HistoryRecordDate] [datetime] NULL,
	[LocationPercent] [numeric](10, 4) NULL,
	[CreateTime] [datetime] NULL,
	[UpdateTime] [datetime] NULL,
 CONSTRAINT [PK_T_Stock_Main] PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'代码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_Stock_Main', @level2type=N'COLUMN',@level2name=N'Code'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_Stock_Main', @level2type=N'COLUMN',@level2name=N'Name'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'当前股价' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_Stock_Main', @level2type=N'COLUMN',@level2name=N'Price'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'沪A 深A' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_Stock_Main', @level2type=N'COLUMN',@level2name=N'Market'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'板块，创业板' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_Stock_Main', @level2type=N'COLUMN',@level2name=N'Plate'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'停牌，正常，退市' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_Stock_Main', @level2type=N'COLUMN',@level2name=N'Status'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'历史最高价' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_Stock_Main', @level2type=N'COLUMN',@level2name=N'MaxPrice'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'历史最低价' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_Stock_Main', @level2type=N'COLUMN',@level2name=N'MinPrice'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'记录历史价格的日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_Stock_Main', @level2type=N'COLUMN',@level2name=N'HistoryRecordDate'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'当前所属比例 (当前股价-历史最低价）/ (历史最高价-历史最低价)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_Stock_Main', @level2type=N'COLUMN',@level2name=N'LocationPercent'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_Stock_Main', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'最后修改日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'T_Stock_Main', @level2type=N'COLUMN',@level2name=N'UpdateTime'
GO


