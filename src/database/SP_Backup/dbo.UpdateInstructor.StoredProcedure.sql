USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[UpdateInstructor]    Script Date: 3/25/2024 8:06:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateInstructor]
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
    UPDATE Users
    SET UserName = @UserName,
        Email = @Email,
        Address = @Address,
        Password = @Password,
        Phone = @Phone,
        Gender = @Gender
    WHERE UserID = @UserID

    UPDATE Instructors
    SET BranchID = @BranchID
    WHERE InstructorID = @UserID
END
GO
