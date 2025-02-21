USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[DeleteAllDataFromTables]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteAllDataFromTables]
AS
BEGIN
    DECLARE @tableName NVARCHAR(MAX)
    DECLARE tableCursor CURSOR FOR
        SELECT TABLE_NAME
        FROM INFORMATION_SCHEMA.TABLES
        WHERE TABLE_TYPE = 'BASE TABLE'
        AND TABLE_NAME NOT IN ('sysdiagrams') -- Exclude system tables if necessary

    OPEN tableCursor
    FETCH NEXT FROM tableCursor INTO @tableName

    WHILE @@FETCH_STATUS = 0
    BEGIN
        DECLARE @sql NVARCHAR(MAX)
        SET @sql = 'DELETE FROM ' + @tableName
        EXEC sp_executesql @sql

        FETCH NEXT FROM tableCursor INTO @tableName
    END

    CLOSE tableCursor
    DEALLOCATE tableCursor
END
GO
