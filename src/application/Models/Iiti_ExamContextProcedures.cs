﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using application.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace application.Models
{
    public partial interface Iiti_ExamContextProcedures
    {
        Task<int> addCourseDepartmentAsync(int? courseID, int? deptID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> addCourseTopicAsync(int? courseId, string topicName, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> AddInstructorToCourseAsync(int? CourseID, int? InstructorID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> AddNewBranchAsync(string branchName, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> AddNewDepartmentAsync(string deptName, int? branchId, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> AddQuestionAsync(string qtext, string choice1, string choice2, string choice3, string choice4, int? qtyep, int? CorrectIndex, int? Grade, int? CourseId, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> AddStudentAsync(string UserName, string Email, string Address, string Password, string Phone, string Gender, int? DeptID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> AuthenticateUserAsync(string Email, string Password, OutputParameter<string> UserType, OutputParameter<int?> UserID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> DeleteAllDataFromTablesAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> DeleteBranchAsync(int? id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> deleteCourseDepartmentAsync(int? courseID, int? deptID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> deleteCourseTopicAsync(int? courseId, string topicName, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> DeleteDepartmentByIdAsync(int? id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> deleteExamAsync(int? eid, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> DeleteInstructorAsync(int? UserID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<EditInstructorResult>> EditInstructorAsync(int? UserID, string UserName, string Email, string Address, string Password, string Phone, string Gender, int? BranchID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> EditStudentAsync(int? UserID, string UserName, string Email, string Address, string Password, string Phone, string Gender, int? DeptID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<ExamReportResult>> ExamReportAsync(int? examid, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> GenerateExamAsync(int? courseId, int? deptId, DateTime? date, int? mcqCount, int? TFcount, int? duration, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetAllBranchesResult>> GetAllBranchesAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<getAllCoursesResult>> getAllCoursesAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetAllCoursesInBranchByInstructorIDResult>> GetAllCoursesInBranchByInstructorIDAsync(int? InstructorID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetAllDepartmentsResult>> GetAllDepartmentsAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetAllDeptCoursesResult>> GetAllDeptCoursesAsync(int? deptid, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<getAllExamQuestionsResult>> getAllExamQuestionsAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<getAllExamsResult>> getAllExamsAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<getallinstructorsResult>> getallinstructorsAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<getAllQuestionChoicesResult>> getAllQuestionChoicesAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<getAllQuestionPoolsResult>> getAllQuestionPoolsAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetAllQuestionsResult>> GetAllQuestionsAsync(int? crsId, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<getAllStudentExamQuestionsResult>> getAllStudentExamQuestionsAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<getAllStudentsResult>> getAllStudentsAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<getallusersResult>> getallusersAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<getBranchByNameResult>> getBranchByNameAsync(string name, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetBrancheByIDResult>> GetBrancheByIDAsync(int? branchId, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<getBranchesDepartmentsResult>> getBranchesDepartmentsAsync(int? id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> GetBranchIDByInstructorIDAsync(int? InstructorID, OutputParameter<int?> BranchID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<getBranchNameResult>> getBranchNameAsync(int? id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<getCourseDepartmentResult>> getCourseDepartmentAsync(int? courseID, int? deptID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<getCourseDepartmentsResult>> getCourseDepartmentsAsync(int? id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<getCourseDepartmentsAllInfoResult>> getCourseDepartmentsAllInfoAsync(int? courseId, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetCourseExamsResult>> GetCourseExamsAsync(int? DeptID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<getCourseIdByExamIDResult>> getCourseIdByExamIDAsync(int? ExamID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetCourseInfoResult>> GetCourseInfoAsync(int? CourseID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<getCourseInstructorsResult>> getCourseInstructorsAsync(int? id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetCoursesByInstructorIDResult>> GetCoursesByInstructorIDAsync(int? InstructorID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetCoursesInBranchResult>> GetCoursesInBranchAsync(int? BranchID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetCoursesInsResult>> GetCoursesInsAsync(int? insId, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<getCourseTopicsResult>> getCourseTopicsAsync(int? id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetDepartmentByNameAndBranchIDResult>> GetDepartmentByNameAndBranchIDAsync(string name, int? id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetDeptsforInsResult>> GetDeptsforInsAsync(int? insId, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<getExamResult>> getExamAsync(int? deptid, int? crsid, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<getExambyIdResult>> getExambyIdAsync(int? id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetExamGradesByStudentIDResult>> GetExamGradesByStudentIDAsync(int? StudentID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetExamsDeptCourseResult>> GetExamsDeptCourseAsync(int? crsid, int? deptid, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetExamTableResult>> GetExamTableAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetGradesByStudentIDResult>> GetGradesByStudentIDAsync(int? StudentID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetInstructorByidResult>> GetInstructorByidAsync(int? id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetInstructorsByBranchIDResult>> GetInstructorsByBranchIDAsync(int? BranchID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetQuestionChoicesResult>> GetQuestionChoicesAsync(int? ExamID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> GetRandomQuestionsAsync(int? mcqCount, int? TFcount, int? courseId, int? examId, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetStudentExamDetailsResult>> GetStudentExamDetailsAsync(int? StudentID, int? ExamID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetStudentGradesResult>> GetStudentGradesAsync(int? StudentID, int? ExamID, int? CourseID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetStudentsByDeptResult>> GetStudentsByDeptAsync(int? deptid, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetStudentsByDeptIDResult>> GetStudentsByDeptIDAsync(int? DeptID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<getStudentsPerCourseResult>> getStudentsPerCourseAsync(int? insid, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<getTopicByNameAndCourseIDResult>> getTopicByNameAndCourseIDAsync(int? courseId, string topicName, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> InitializeBranchesAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> InitializeCoursesAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> InitializeDepartmentsAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> InitializeExamQuestionsAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> InitializeExamsAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> InitializeInstructorsAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> InitializeQuestionChoicesAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> InitializeQuestionPoolsAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> InitializeStudentExamQuestionsAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> InitializeStudentsAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> InitializeUsersAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> InsertOrUpdateSelectedAnswerIndexAsync(int? StudentID, int? ExamID, int? QuestionID, int? SelectedAnswerIndex, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> InsertSelectedAnswerIndexAsync(int? StudentID, int? ExamID, int? QuestionID, int? SelectedAnswerIndex, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> RemoveInstructorCoursesAsync(int? InstructorID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> RemoveInstructorFromCourseAsync(int? CourseID, int? InstructorID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<ReseedResult>> ReseedAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> updateBranchNameAsync(int? id, string newName, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> UpdateDepartmentAsync(int? deptId, string deptName, int? BranchID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> UpdateInstructorAsync(int? UserID, string UserName, string Email, string Address, string Password, string Phone, string Gender, int? BranchID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> UpdateStudentAsync(int? UserID, string UserName, string Email, string Address, string Password, string Phone, string Gender, int? DeptID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
    }
}
