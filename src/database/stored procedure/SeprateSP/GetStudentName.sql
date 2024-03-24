CREATE PROCEDURE GetStudentName
     @StudentID INT
AS
BEGIN
    SELECT UserName
    FROM Users
    WHERE UserID = @StudentID;
END;

EXEC GetStudentName @StudentID =1;