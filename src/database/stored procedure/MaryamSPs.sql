--Get Student Name By Student Id
CREATE PROCEDURE GetStudentName
     @StudentID INT
AS
BEGIN
    SELECT UserName
    FROM Users
    WHERE UserID = @StudentID;
END;

EXEC GetStudentName @StudentID =1;

--Get Course Exams By Department
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

--Get Exam Grades By Student ID
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

--Get Grades By Student ID
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

--Get Question Choices By Exam Id
Create PROCEDURE [dbo].[GetQuestionChoices]
    @ExamID INT  
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        EQ.QuestionID,
        QP.Title,
        Choices = STRING_AGG(QC.Choice, ', ')
    FROM
        ExamQuestions EQ
    INNER JOIN
        QuestionPools QP ON EQ.QuestionID = QP.QuestionID
    INNER JOIN
        QuestionChoices QC ON EQ.QuestionID = QC.QuestionID
    WHERE EQ.ExamID = @ExamID  
    GROUP BY
        EQ.QuestionID,
        QP.Title;
END


EXEC [dbo].[GetQuestionChoices] @ExamID = 5;

--Insert And Update Answer
create PROCEDURE [dbo].[InsertOrUpdateSelectedAnswerIndex]
    @StudentID INT,
    @ExamID INT,
    @QuestionID INT,
    @SelectedAnswerIndex INT
AS
BEGIN
    BEGIN TRANSACTION;

    -- Check if the record already exists
    IF EXISTS (SELECT 1 FROM StudentExamQuestions WHERE StudentID = @StudentID AND ExamID = @ExamID AND QuestionID = @QuestionID)
    BEGIN
        -- Update the existing record
        UPDATE StudentExamQuestions
        SET SelectedAnswerIndex = @SelectedAnswerIndex
        WHERE StudentID = @StudentID AND ExamID = @ExamID AND QuestionID = @QuestionID;
    END
    ELSE
    BEGIN
        -- Insert a new record
        INSERT INTO StudentExamQuestions (StudentID, ExamID, QuestionID, SelectedAnswerIndex)
        VALUES (@StudentID, @ExamID, @QuestionID, @SelectedAnswerIndex);
    END

    COMMIT TRANSACTION;
END

EXEC [dbo].[InsertOrUpdateSelectedAnswerIndex] @StudentID = 1, @ExamID = 5, @QuestionID = 41, @SelectedAnswerIndex = 3;
EXEC [dbo].[InsertOrUpdateSelectedAnswerIndex] @StudentID = 1, @ExamID = 5, @QuestionID = 42, @SelectedAnswerIndex = 2;
EXEC [dbo].[InsertOrUpdateSelectedAnswerIndex] @StudentID = 1, @ExamID = 5, @QuestionID = 43, @SelectedAnswerIndex = 3;
EXEC [dbo].[InsertOrUpdateSelectedAnswerIndex] @StudentID = 1, @ExamID = 5, @QuestionID = 51, @SelectedAnswerIndex = 3;
EXEC [dbo].[InsertOrUpdateSelectedAnswerIndex] @StudentID = 1, @ExamID = 5, @QuestionID = 54, @SelectedAnswerIndex = 3;
EXEC [dbo].[InsertOrUpdateSelectedAnswerIndex] @StudentID = 1, @ExamID = 5, @QuestionID = 56, @SelectedAnswerIndex = 3;
EXEC [dbo].[InsertOrUpdateSelectedAnswerIndex] @StudentID = 1, @ExamID = 5, @QuestionID = 57, @SelectedAnswerIndex = 1;
EXEC [dbo].[InsertOrUpdateSelectedAnswerIndex] @StudentID = 1, @ExamID = 5, @QuestionID = 58, @SelectedAnswerIndex = 3;
EXEC [dbo].[InsertOrUpdateSelectedAnswerIndex] @StudentID = 1, @ExamID = 5, @QuestionID = 60, @SelectedAnswerIndex = 3;
EXEC [dbo].[InsertOrUpdateSelectedAnswerIndex] @StudentID = 1, @ExamID = 5, @QuestionID = 64, @SelectedAnswerIndex = 3;


EXEC [dbo].[GetQuestionChoices] @ExamID = 5;

--Get Student Exam Details By Student Id and Exam Id
Create PROCEDURE [dbo].[GetStudentExamDetails]
    @StudentID INT,
    @ExamID INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        QP.Title AS [Question Title],
        SEQ.SelectedAnswerIndex,
        QP.CorrectAnswerIndex,
        QP.Grade AS [Question Grade]
    FROM
        StudentExamQuestions SEQ
    INNER JOIN
        QuestionPools QP ON SEQ.QuestionID = QP.QuestionID
    WHERE 
        SEQ.StudentID = @StudentID 
        AND SEQ.ExamID = @ExamID;
END

EXEC [dbo].[GetStudentExamDetails] @StudentID = 1, @ExamID = 5;

--Get Student Grades By Student Id and Exam Id

Create PROCEDURE [dbo].[GetStudentGrades]
    @StudentID INT,
    @ExamID INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @TotalGrade INT;
	DECLARE @StudentGrades INT;

    -- Fetch the student exam details using the GetStudentExamDetails stored procedure
    DECLARE @StudentExamDetails TABLE (
        [Question Title] NVARCHAR(200),
        [SelectedAnswerIndex] INT,
        [CorrectAnswerIndex] INT,
        [Question Grade] INT
    );

    INSERT INTO @StudentExamDetails EXEC [dbo].[GetStudentExamDetails] @StudentID, @ExamID;

    SELECT @StudentGrades = SUM(CASE WHEN SelectedAnswerIndex = CorrectAnswerIndex THEN [Question Grade] ELSE 0 END)
	 , @TotalGrade = SUM(CASE WHEN 1=1 THEN [Question Grade] ELSE 0 END)
    FROM @StudentExamDetails;

    SELECT @StudentGrades AS [Student Grade], @TotalGrade AS [Total Grade] ;
END

EXEC [dbo].[GetStudentGrades] @StudentID = 1, @ExamID = 5;
