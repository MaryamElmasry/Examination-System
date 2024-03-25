USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[InitializeDepartments]    Script Date: 3/25/2024 8:06:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InitializeDepartments]
AS
BEGIN
    INSERT INTO Departments (DeptName, BranchID)
    VALUES ('PD', 1), ('AI', 1), ('OS', 1); -- Assign Branch 1 to all departments
END
GO
