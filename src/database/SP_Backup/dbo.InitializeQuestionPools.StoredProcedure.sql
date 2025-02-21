USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[InitializeQuestionPools]    Script Date: 3/25/2024 8:06:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InitializeQuestionPools]
AS
BEGIN
    INSERT INTO QuestionPools (Title, QuestionType, CorrectAnswerIndex, Grade, CourseID)
    VALUES 
        ('What is JavaScript?', 1, 0, 10, 4),
        ('What are the data types in JavaScript?', 1, 2, 10, 4),
        ('What is the purpose of the "use strict" directive in JavaScript?', 1, 1, 10, 4),
        ('What is event bubbling in JavaScript?', 1, 3, 10, 4),
        ('What is the difference between == and === in JavaScript?', 1, 0, 10, 4),
        ('What is the result of 2 + 2 in JavaScript?', 1, 3, 10, 4),
        ('How do you declare a variable in JavaScript?', 1, 2, 10, 4),
        ('What does NaN stand for?', 1, 0, 10, 4),
        ('How do you write "Hello World" in an alert box?', 1, 1, 10, 4),
        ('What is the output of console.log(typeof []); in JavaScript?', 1, 3, 10, 4),
        ('What is the purpose of the document.getElementById() method in JavaScript?', 1, 2, 10, 4),
        ('What does the && operator do in JavaScript?', 1, 1, 10, 4),
        ('What does the || operator do in JavaScript?', 1, 2, 10, 4),
        ('What does the typeof operator return in JavaScript?', 1, 3, 10, 4),
        ('How do you round the number 7.25 to the nearest integer in JavaScript?', 1, 0, 10, 4),
        ('What is the correct way to write a JavaScript array?', 1, 3, 10, 4),
        ('Which event occurs when the user clicks on an HTML element in JavaScript?', 1, 1, 10, 4),
        ('How do you add a comment in JavaScript?', 1, 2, 10, 4),
        ('What is the output of console.log(1 + "1" + 1); in JavaScript?', 1, 0, 10, 4),
        ('What is the result of 10 > 9 in JavaScript?', 1, 3, 10, 4);
END
GO
