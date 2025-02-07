USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[AddNewBranch]    Script Date: 3/25/2024 8:06:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[AddNewBranch] 
    @branchName NVARCHAR(255)
AS
BEGIN
    -- Check if the branchName length is more than 2 characters
    IF LEN(@branchName) > 1
    BEGIN
        -- Insert into Branches only if the condition is met
        INSERT INTO Branches VALUES (@branchName)
    END
    ELSE
    BEGIN
        -- Optionally, you can raise an error or handle the case where the branch name is too short
        RAISERROR('Branch name must be at least 2 characters long.', 16, 1)
        RETURN; -- Optional: Exit the stored procedure
    END
END
GO
