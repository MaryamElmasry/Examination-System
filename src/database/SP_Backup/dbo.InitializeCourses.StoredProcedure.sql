USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[InitializeCourses]    Script Date: 3/25/2024 8:06:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InitializeCourses]
AS
BEGIN
    INSERT INTO Courses (CourseName)
    VALUES ('Python'), 
           ('Java'), 
           ('C++'), 
           ('JavaScript'), 
           ('HTML and CSS');
END
GO
