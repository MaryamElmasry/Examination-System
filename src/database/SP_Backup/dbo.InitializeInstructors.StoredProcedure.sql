USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[InitializeInstructors]    Script Date: 3/25/2024 8:06:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InitializeInstructors]
AS
BEGIN
    -- Insert instructors with ID 4 and 5
    INSERT INTO Instructors (BranchID, InstructorID)
    VALUES (1, 4), (1, 5);
END
GO
