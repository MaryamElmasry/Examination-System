USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[GetInstructorsByBranchID]    Script Date: 3/25/2024 8:06:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetInstructorsByBranchID]
    @BranchID INT
AS
BEGIN
    SELECT Users.*
    FROM Instructors
    INNER JOIN Users ON Instructors.InstructorID = Users.UserID
    WHERE Instructors.BranchID = @BranchID;
END
GO
