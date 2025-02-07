USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[EditStudent]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EditStudent]
    @UserID INT,
    @UserName NVARCHAR(50),
    @Email NVARCHAR(50),
    @Address NVARCHAR(100),
    @Password NVARCHAR(50),
    @Phone NVARCHAR(20),
    @Gender CHAR(1),
    @DeptID INT
AS
BEGIN
    IF EXISTS (SELECT * FROM Users WHERE UserID = @UserID)
    BEGIN
        EXEC UpdateStudent @UserID, @UserName, @Email, @Address, @Password, @Phone, @Gender, @DeptID
    END
    ELSE
    BEGIN
        EXEC AddStudent @UserName, @Email, @Address, @Password, @Phone, @Gender, @DeptID
    END
END
GO
