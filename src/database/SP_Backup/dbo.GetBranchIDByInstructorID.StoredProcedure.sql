USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[GetBranchIDByInstructorID]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetBranchIDByInstructorID]
    @InstructorID INT,
    @BranchID INT OUTPUT  -- Add output parameter for BranchID
AS
BEGIN
    SELECT @BranchID = BranchID
    FROM Instructors
    WHERE InstructorID = @InstructorID
END
GO
