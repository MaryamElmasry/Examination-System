USE ITI_EXAM;

CREATE TABLE Users
(
  UserID INT NOT NULL,
  UserName NVARCHAR(255) NOT NULL,
  Email NVARCHAR(255) NOT NULL,
  Address NVARCHAR(255) NOT NULL,
  Password NVARCHAR(255) NOT NULL,
  Phone NVARCHAR(20) NOT NULL,
  Gender CHAR(1) NOT NULL,
  PRIMARY KEY (UserID)
);

CREATE TABLE Branches
(
  BranchID INT NOT NULL,
  BranchName NVARCHAR(255) NOT NULL,
  PRIMARY KEY (BranchID)
);

CREATE TABLE Departments
(
  DeptID INT NOT NULL,
  DeptName NVARCHAR(255) NOT NULL,
  BranchID INT,
  PRIMARY KEY (DeptID),
  FOREIGN KEY (BranchID) REFERENCES Branches(BranchID)
);

CREATE TABLE Students
(
  DeptID INT,
  StudentID INT NOT NULL,
  PRIMARY KEY (StudentID),
  FOREIGN KEY (DeptID) REFERENCES Departments(DeptID),
  FOREIGN KEY (StudentID) REFERENCES Users(UserID)
);

CREATE TABLE Instructors
(
  DeptID INT,
  InstructorID INT NOT NULL,
  PRIMARY KEY (InstructorID),
  FOREIGN KEY (DeptID) REFERENCES Departments(DeptID),
  FOREIGN KEY (InstructorID) REFERENCES Users(UserID)
);

CREATE TABLE Courses
(
  CourseID INT NOT NULL,
  CourseName NVARCHAR(255) NOT NULL,
  DeptID INT NOT NULL,
  InstructorID INT NOT NULL,
  PRIMARY KEY (CourseID),
  FOREIGN KEY (DeptID) REFERENCES Departments(DeptID),
  FOREIGN KEY (InstructorID) REFERENCES Instructors(InstructorID)
);

CREATE TABLE Exams
(
  ExamID INT NOT NULL,
  ExamDate DATETIME NOT NULL,
  Duration INT NOT NULL,
  CourseID INT,
  PRIMARY KEY (ExamID),
  FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);

CREATE TABLE QuestionPools
(
  QuestionID INT NOT NULL,
  Title NVARCHAR(255) NOT NULL,
  QuestionType INT NOT NULL,
  CorrectAnswerIndex INT NOT NULL,
  Grade INT NOT NULL,
  CourseID INT NOT NULL,
  PRIMARY KEY (QuestionID),
  FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);

CREATE TABLE StudentExamQuestions
(
  SelectedAnswerIndex INT NOT NULL,
  ExamID INT NOT NULL,
  QuestionID INT NOT NULL,
  StudentID INT NOT NULL,
  PRIMARY KEY (ExamID, QuestionID, StudentID),
  FOREIGN KEY (ExamID) REFERENCES Exams(ExamID),
  FOREIGN KEY (QuestionID) REFERENCES QuestionPools(QuestionID),
  FOREIGN KEY (StudentID) REFERENCES Students(StudentID)
);

CREATE TABLE ExamQuestions
(
  ExamID INT NOT NULL,
  QuestionID INT NOT NULL,
  PRIMARY KEY (ExamID, QuestionID),
  FOREIGN KEY (ExamID) REFERENCES Exams(ExamID),
  FOREIGN KEY (QuestionID) REFERENCES QuestionPools(QuestionID)
);

CREATE TABLE CourseTopics
(
  Topic NVARCHAR(255) NOT NULL,
  CourseID INT NOT NULL,
  PRIMARY KEY (Topic, CourseID),
  FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
);

CREATE TABLE QuestionChoices
(
  Choice NVARCHAR(255) NOT NULL,
  QuestionID INT NOT NULL,
  PRIMARY KEY (Choice, QuestionID),
  FOREIGN KEY (QuestionID) REFERENCES QuestionPools(QuestionID)
);
