USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[InitializeExams]    Script Date: 3/25/2024 8:06:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InitializeExams]
AS
BEGIN

    INSERT INTO Exams (ExamDate, Duration, CourseID, DeptID)
    VALUES ('2024-03-21', 120, 4, 1);
END
GO
