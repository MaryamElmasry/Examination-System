USE ITI_EXAM;

DECLARE @tableName NVARCHAR(255);
DECLARE tableCursor CURSOR FOR
    SELECT table_name = t.name
    FROM sys.tables t
    INNER JOIN sys.schemas s ON t.schema_id = s.schema_id
    ORDER BY t.name;

OPEN tableCursor;
FETCH NEXT FROM tableCursor INTO @tableName;

WHILE @@FETCH_STATUS = 0
BEGIN
    DECLARE @sql NVARCHAR(MAX);

    -- Drop foreign key constraints
    DECLARE @constraintName NVARCHAR(255);
    DECLARE constraintCursor CURSOR FOR
        SELECT constraint_name = fk.name
        FROM sys.foreign_keys fk
        INNER JOIN sys.tables t ON fk.parent_object_id = t.object_id
        WHERE t.name = @tableName;

    OPEN constraintCursor;
    FETCH NEXT FROM constraintCursor INTO @constraintName;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        SET @sql = 'ALTER TABLE ' + QUOTENAME(@tableName) + ' DROP CONSTRAINT ' + QUOTENAME(@constraintName);
        EXEC sp_executesql @sql;

        FETCH NEXT FROM constraintCursor INTO @constraintName;
    END

    CLOSE constraintCursor;
    DEALLOCATE constraintCursor;

    -- Drop the table if it exists
    IF OBJECT_ID(@tableName, 'U') IS NOT NULL
    BEGIN
        SET @sql = 'DROP TABLE ' + QUOTENAME(@tableName);
        EXEC sp_executesql @sql;
    END

    FETCH NEXT FROM tableCursor INTO @tableName;
END

CLOSE tableCursor;
DEALLOCATE tableCursor;
