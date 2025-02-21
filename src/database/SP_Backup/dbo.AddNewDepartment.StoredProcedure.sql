USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[AddNewDepartment]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[AddNewDepartment] @deptName nvarchar(255), @branchId int
as
begin
	IF LEN(@deptName) > 1
    BEGIN
        -- Insert into Branches only if the condition is met
        INSERT INTO Departments VALUES (@deptName, @branchId)
    END
    ELSE
    BEGIN
        -- Optionally, you can raise an error or handle the case where the branch name is too short
        RAISERROR('Branch name must be at least 2 characters long.', 16, 1)
        RETURN; -- Optional: Exit the stored procedure
    END
end
GO
