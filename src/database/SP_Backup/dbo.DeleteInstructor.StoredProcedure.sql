USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[DeleteInstructor]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteInstructor]
    @UserID INT
AS
BEGIN
    DELETE FROM Instructors WHERE InstructorID = @UserID
    DELETE FROM Users WHERE UserID = @UserID
END
GO
