USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[GetStudentName]    Script Date: 3/25/2024 8:06:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[GetStudentName]
    @studentID INT
AS
BEGIN
    SELECT UserName
    FROM Users
    WHERE UserID = @studentID;
END;
GO
