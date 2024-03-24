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