Create PROCEDURE GetGradesByStudentID
    @StudentID INT
AS
BEGIN
    SELECT Courses.CourseName, StudentGrades.Grade
    FROM Courses
 
    INNER JOIN StudentGrades ON Courses.CourseID = StudentGrades.CourseID
    WHERE StudentGrades.StudentID = @StudentID
END;

EXEC GetGradesByStudentID @StudentID = 1;