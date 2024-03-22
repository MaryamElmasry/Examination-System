use iti_exam
CREATE PROCEDURE GetCourseList @InsId INT
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
//-------------------------------------------------------


CREATE PROCEDURE GetCourseTopics @CourseID INT
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

-------------------------------------------------------------------------------------------------------------------------------------------------
Create PROCEDURE GetExamForStdReport
    @ExamID INT,
    @StudentID INT
AS
BEGIN

    SELECT 
        qp.Title AS Question,
        qc.Choice AS [Correct Answer],
        CASE 
            WHEN seq.SelectedAnswerIndex = qp.CorrectAnswerIndex THEN 'Correct'
            ELSE 'Incorrect'
        END AS AnswerStatus,
        qc_student.Choice AS StudentAnswer
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


EXEC GetExamForStdReport  1, 2;



