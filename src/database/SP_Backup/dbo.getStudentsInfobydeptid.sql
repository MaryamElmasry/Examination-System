CREATE PROCEDURE getStudentsInfobydeptid
    @DeptID INT
AS
BEGIN
    SELECT Users.UserID, Users.UserName, Users.Email, Users.Address, Branches.BranchName, Departments.DeptName, Users.Phone, Users.Gender
    FROM Branches
    INNER JOIN Departments ON Branches.BranchID = Departments.BranchID
    INNER JOIN Students ON Departments.DeptID = Students.DeptID
    INNER JOIN Users ON Students.StudentID = Users.UserID
    WHERE Departments.DeptID = @DeptID;
END;
