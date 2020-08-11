﻿/* CORS TABLE */
IF NOT EXISTS (SELECT * FROM sysobjects WHERE [name]='CORS' and xtype='U')
BEGIN  
	CREATE TABLE [dbo].[CORS](
		[ID] int IDENTITY(1,1) PRIMARY KEY,
		[ADDRESS] varchar(250) NULL,
		[COMMENT] varchar(250) NULL,
		[ACTIVE] bit NOT NULL DEFAULT 1
	) ON [PRIMARY]
END


/* CATEGORY TABLE */
IF NOT EXISTS (SELECT * FROM sysobjects WHERE [name]='CATEGORY' and xtype='U')
BEGIN  
	CREATE TABLE [dbo].[CATEGORY](
		[PRODUCT_ID] int IDENTITY(1,1) PRIMARY KEY,
		[PROJECT_ID] int NULL,
		[TITLE] varchar(250) NOT NULL,
		[DESCRIPTION] varchar(MAX) NOT NULL,
		[SORT_ORDER] int NOT NULL,		
		[TYPE_ID] int NULL,
		[PARENT_ID] int NULL FOREIGN KEY REFERENCES CATEGORY([PRODUCT_ID]),
		[REDIRECT_TO_ID] int NULL FOREIGN KEY REFERENCES CATEGORY([PRODUCT_ID]),
		[ACTIVE] bit NOT NULL DEFAULT 1
	) ON [PRIMARY]
END


IF NOT EXISTS (SELECT * FROM sysobjects WHERE [name]='PRODUCT' and xtype='U')
BEGIN  
	CREATE TABLE [dbo].[PRODUCT](
		[PRODUCT_ID] int IDENTITY(1,1) PRIMARY KEY,
		[NAME] varchar(250) NOT NULL,
		[DESCRIPTION] varchar(MAX) NOT NULL,
		[PRICE] int NOT NULL,		
		[EXTRA_PRICE] int NULL,
		[EXTRA_PRICE_ACTIVE] bit NOT NULL DEFAULT 1
	) ON [PRIMARY]
END