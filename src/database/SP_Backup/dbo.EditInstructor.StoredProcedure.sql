USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[EditInstructor]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EditInstructor]
    @UserID INT,
    @UserName NVARCHAR(50),
    @Email NVARCHAR(50),
    @Address NVARCHAR(100),
    @Password NVARCHAR(50),
    @Phone NVARCHAR(20),
    @Gender CHAR(1),
    @BranchID INT
AS
BEGIN
    IF EXISTS (SELECT * FROM Users WHERE UserID = @UserID)
    BEGIN
        EXEC UpdateInstructor @UserID, @UserName, @Email, @Address, @Password, @Phone, @Gender, @BranchID
    END
    ELSE
    BEGIN
        EXEC AddInstructor @UserName, @Email, @Address, @Password, @Phone, @Gender, @BranchID
    END
END
GO
