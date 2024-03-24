use iti_exam
---------------------------------------------------------------------------
------------------------- GET INSTRUCTOR COURSES --------------------------
---------------------------------------------------------------------------
create or alter PROCEDURE GetCourseList @InsId INT
AS
BEGIN
    SELECT c.CourseName, c.CourseID
    FROM
        Courses	C
		inner join Instructor_Courses IC
		on c.CourseID = ic.CourseID
    WHERE
        Ic.InstructorID = @InsId
END

exec GetCourseList 1
---------------------------------------------------------------------------
----------------------GET COURSE TOPIC-------------------------------------
---------------------------------------------------------------------------
create or alter PROCEDURE GetCourseTopics @CourseID INT
AS
BEGIN
    SELECT
        Topic
     FROM
        CourseTopics
    WHERE
        CourseID = @CourseID;
END

exec GetCourseTopics 1

---------------------------------------------------------------------------
------------------------DETAILED EXAM--------------------------------------
---------------------------------------------------------------------------
create or alter PROCEDURE GetExamForStdReport
    @ExamID INT,
    @StudentID INT
AS
BEGIN

    SELECT 
        qp.Title AS Question,
        qc.Choice AS [Correct Answer],
        qc_student.Choice AS StudentAnswer,
        CASE 
            WHEN seq.SelectedAnswerIndex = qp.CorrectAnswerIndex THEN 'Correct'
            ELSE 'Incorrect'
        END AS AnswerStatus
    FROM
		QuestionPools qp
    INNER JOIN 
		ExamQuestions eq ON eq.QuestionID = qp.QuestionID
    INNER JOIN 
        QuestionChoices qc ON eq.QuestionID = qc.QuestionID
                            AND qc.ChoiceIndex = qp.CorrectAnswerIndex
    INNER JOIN 
        StudentExamQuestions seq ON eq.ExamID = seq.ExamID
                                   AND eq.QuestionID = seq.QuestionID
                                   AND seq.StudentID = @StudentID
    LEFT JOIN 
        QuestionChoices qc_student ON seq.QuestionID = qc_student.QuestionID
                                      AND seq.SelectedAnswerIndex = qc_student.ChoiceIndex
    WHERE 
        eq.ExamID = @ExamID;
END;
go
EXEC GetExamForStdReport  1, 2;
---------------------------------------------------------------------------
-------------------------------GET EXAM INFO ------------------------------
---------------------------------------------------------------------------

create or alter PROCEDURE GetExamInfo
    @ExamId INT,
    @StdId INT
AS
BEGIN
    DECLARE @CourseName NVARCHAR(100)
    DECLARE @Grade FLOAT

    -- Retrieve Course Name
    SELECT @CourseName = c.CourseName
    FROM Exams ex
    INNER JOIN Courses c ON ex.CourseID = c.CourseID
    WHERE ExamID = @ExamId

    -- Retrieve Grade
    SELECT @Grade = sg.Grade
    FROM StudentGrades sg
    WHERE sg.CourseID = (SELECT CourseID FROM Exams WHERE ExamID = @ExamId)
    AND sg.StudentID = @StdId

    -- Return Course Name and Grade
    SELECT @CourseName AS CourseName, @Grade AS Grade
END

exec GetExamInfo 1,2
