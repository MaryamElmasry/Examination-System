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
