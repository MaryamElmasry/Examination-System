Create PROCEDURE GetCourseExams
    @DeptID INT
AS
BEGIN
    SELECT Exams.ExamID, Courses.CourseName, Exams.ExamDate,Exams.Duration
    FROM Courses
    INNER JOIN Exams ON Courses.CourseID = Exams.CourseID
    WHERE Exams.DeptID = @DeptID;
END;

EXEC GetCourseExams @DeptID = 3;