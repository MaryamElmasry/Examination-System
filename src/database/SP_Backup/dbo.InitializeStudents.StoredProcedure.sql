USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[InitializeStudents]    Script Date: 3/25/2024 8:06:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InitializeStudents]
AS
BEGIN

    INSERT INTO Students (DeptID, StudentID)
    VALUES (1, 1), (1, 2); 
END
GO
