USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[AuthenticateUser]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[AuthenticateUser]
    @Email NVARCHAR(255),
    @Password NVARCHAR(255),
    @UserType NVARCHAR(50) OUTPUT,
    @UserID INT OUTPUT
AS
BEGIN
    SET @UserID  = (SELECT UserID FROM [Users] WHERE Email = @Email AND Password = @Password);
    
    IF @UserID IS NULL
    BEGIN
        SET @UserType = 'Invalid';
        SET @UserID = -1;
    END
    ELSE
    BEGIN
        IF EXISTS (SELECT 1 FROM [Students] WHERE StudentID = @UserID)
        BEGIN
            SET @UserType = 'Student';
        END
        ELSE
        BEGIN
            SET @UserType = 'Instructor';
        END
    END
END
GO
