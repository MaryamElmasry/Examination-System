USE [iti_exam]
GO
/****** Object:  StoredProcedure [dbo].[InitializeQuestionChoices]    Script Date: 3/25/2024 8:06:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[InitializeQuestionChoices]
AS
BEGIN
    -- Insert choices for each question

    -- Question 0: What is JavaScript?
    INSERT INTO QuestionChoices (Choice, QuestionID, ChoiceIndex)
    VALUES ('JavaScript is a scripting language.', 0, 0),
           ('JavaScript is a markup language.', 0, 1),
           ('JavaScript is a programming language.', 0, 2),
           ('JavaScript is a styling language.', 0, 3);
    
    -- Question 1: What are the data types in JavaScript?
    INSERT INTO QuestionChoices (Choice, QuestionID, ChoiceIndex)
    VALUES ('Number', 1, 0),
           ('String', 1, 1),
           ('Boolean', 1, 2),
           ('All of the above', 1, 3);

    -- Question 2: What is the purpose of the "use strict" directive in JavaScript?
    INSERT INTO QuestionChoices (Choice, QuestionID, ChoiceIndex)
    VALUES ('To enable strict mode, which catches common coding mistakes and "unsafe" actions.', 2, 0),
           ('To enable lax mode, which relaxes the rules of JavaScript.', 2, 1),
           ('To enable experimental mode, which enables experimental JavaScript features.', 2, 2),
           ('To enable debug mode, which allows debugging JavaScript code.', 2, 3);

    -- Question 3: What is event bubbling in JavaScript?
    INSERT INTO QuestionChoices (Choice, QuestionID, ChoiceIndex)
    VALUES ('Event bubbling is the propagation of an event from the target element to its ancestors in the DOM hierarchy.', 3, 0),
           ('Event bubbling is the propagation of an event from the ancestor elements to the target element in the DOM hierarchy.', 3, 1),
           ('Event bubbling is the propagation of an event in a circular manner between elements.', 3, 2),
           ('Event bubbling is the propagation of an event from the sibling elements to the target element in the DOM hierarchy.', 3, 3);

    -- Question 4: What is the difference between == and === in JavaScript?
    INSERT INTO QuestionChoices (Choice, QuestionID, ChoiceIndex)
    VALUES ('== checks only for equality in value, whereas === checks for both value and data type.', 4, 0),
           ('== checks for both value and data type, whereas === checks only for equality in value.', 4, 1),
           ('== and === are completely interchangeable.', 4, 2),
           ('== and === are both used for assigning values in JavaScript.', 4, 3);

    -- Question 5: What is the result of 2 + 2 in JavaScript?
    INSERT INTO QuestionChoices (Choice, QuestionID, ChoiceIndex)
    VALUES ('3', 5, 0),
           ('4', 5, 1),
           ('6', 5, 2),
           ('8', 5, 3);

    -- Question 6: How do you declare a variable in JavaScript?
    INSERT INTO QuestionChoices (Choice, QuestionID, ChoiceIndex)
    VALUES ('let myVar = value;', 6, 0),
           ('var myVar = value;', 6, 1),
           ('const myVar = value;', 6, 2),
           ('Both var and let are correct.', 6, 3);

    -- Question 7: What does NaN stand for?
    INSERT INTO QuestionChoices (Choice, QuestionID, ChoiceIndex)
    VALUES ('Negative and Null', 7, 0),
           ('Not a Number', 7, 1),
           ('New and Navigable', 7, 2),
           ('None of the above', 7, 3);

    -- Question 8: How do you write "Hello World" in an alert box?
    INSERT INTO QuestionChoices (Choice, QuestionID, ChoiceIndex)
    VALUES ('alert("Hello World");', 8, 0),
           ('prompt("Hello World");', 8, 1),
           ('confirm("Hello World");', 8, 2),
           ('console.log("Hello World");', 8, 3);

    -- Question 9: What is the output of console.log(typeof []); in JavaScript?
    INSERT INTO QuestionChoices (Choice, QuestionID, ChoiceIndex)
    VALUES ('object', 9, 0),
           ('array', 9, 1),
           ('string', 9, 2),
           ('undefined', 9, 3);

    -- Question 10: What is the purpose of the document.getElementById() method in JavaScript?
    INSERT INTO QuestionChoices (Choice, QuestionID, ChoiceIndex)
    VALUES ('To get the value of an element by its class name.', 10, 0),
           ('To get the value of an element by its ID.', 10, 1),
           ('To get the value of an element by its tag name.', 10, 2),
           ('To get the value of an element by its name attribute.', 10, 3);

    -- Question 11: What does the && operator do in JavaScript?
    INSERT INTO QuestionChoices (Choice, QuestionID, ChoiceIndex)
    VALUES ('Logical OR', 11, 0),
           ('Logical AND', 11, 1),
           ('Bitwise OR', 11, 2),
           ('Bitwise AND', 11, 3);

    -- Question 12: What does the || operator do in JavaScript?
    INSERT INTO QuestionChoices (Choice, QuestionID, ChoiceIndex)
    VALUES ('Logical OR', 12, 0),
           ('Logical AND', 12, 1),
           ('Bitwise OR', 12, 2),
           ('Bitwise AND', 12, 3);

    -- Question 13: What does the typeof operator return in JavaScript?
    INSERT INTO QuestionChoices (Choice, QuestionID, ChoiceIndex)
    VALUES ('The type of a variable or expression.', 13, 0),
           ('The value of a variable or expression.', 13, 1),
           ('The size of a variable or expression.', 13, 2),
           ('The length of a variable or expression.', 13, 3);

    -- Question 14: How do you round the number 7.25 to the nearest integer in JavaScript?
    INSERT INTO QuestionChoices (Choice, QuestionID, ChoiceIndex)
    VALUES ('Math.ceil(7.25)', 14, 0),
           ('Math.round(7.25)', 14, 1),
           ('Math.floor(7.25)', 14, 2),
           ('round(7.25)', 14, 3);

    -- Question 15: What is the correct way to write a JavaScript array?
    INSERT INTO QuestionChoices (Choice, QuestionID, ChoiceIndex)
    VALUES ('var colors = "red", "green", "blue";', 15, 0),
           ('var colors = ["red", "green", "blue"];', 15, 1),
           ('var colors = {"red", "green", "blue"};', 15, 2),
           ('var colors = ("red", "green", "blue");', 15, 3);

    -- Question 16: Which event occurs when the user clicks on an HTML element in JavaScript?
    INSERT INTO QuestionChoices (Choice, QuestionID, ChoiceIndex)
    VALUES ('onmouseover', 16, 0),
           ('onmouseout', 16, 1),
           ('onclick', 16, 2),
           ('onchange', 16, 3);

    -- Question 17: How do you add a comment in JavaScript?
    INSERT INTO QuestionChoices (Choice, QuestionID, ChoiceIndex)
    VALUES ('/* This is a comment */', 17, 0),
           ('// This is a comment', 17, 1),
           ('<-- This is a comment -->', 17, 2),
           ('<!-- This is a comment -->', 17, 3);

    -- Question 18: What is the output of console.log(1 + "1" + 1); in JavaScript?
    INSERT INTO QuestionChoices (Choice, QuestionID, ChoiceIndex)
    VALUES ('3', 18, 0),
           ('111', 18, 1),
           ('2', 18, 2),
           ('11', 18, 3);

    -- Question 19: What is the result of 10 > 9 in JavaScript?
    INSERT INTO QuestionChoices (Choice, QuestionID, ChoiceIndex)
    VALUES ('true', 19, 0),
           ('false', 19, 1),
           ('10', 19, 2),
           ('9', 19, 3);


END

GO
