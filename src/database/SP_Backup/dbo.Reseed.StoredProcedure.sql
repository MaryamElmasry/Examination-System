USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[Reseed]    Script Date: 3/25/2024 8:06:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Reseed]
AS
BEGIN
    EXEC sp_MSforeachtable 'DBCC CHECKIDENT (''?'', RESEED, 0)'
END
GO
