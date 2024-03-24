Create PROCEDURE GetExamGradesByStudentID
    @StudentID INT
AS
BEGIN
    SELECT Exams.ExamID, Courses.CourseName, Exams.ExamDate, StudentGrades.Grade
    FROM Courses
    INNER JOIN Exams ON Courses.CourseID = Exams.CourseID
    INNER JOIN StudentGrades ON Courses.CourseID = StudentGrades.CourseID
    WHERE StudentGrades.StudentID = @StudentID
END;

EXEC GetExamGradesByStudentID @StudentID = 1;