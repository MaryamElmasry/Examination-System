USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[AddStudent]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddStudent]
    @UserName NVARCHAR(50),
    @Email NVARCHAR(50),
    @Address NVARCHAR(100),
    @Password NVARCHAR(50),
    @Phone NVARCHAR(20),
    @Gender CHAR(1),
    @DeptID INT
AS
BEGIN
    INSERT INTO Users (UserName, Email, Address, Password, Phone, Gender)
    VALUES (@UserName, @Email, @Address, @Password, @Phone, @Gender)

    DECLARE @UserID INT
    SET @UserID = SCOPE_IDENTITY()

    INSERT INTO Students (StudentID, DeptID)
    VALUES (@UserID, @DeptID)
END
GO
