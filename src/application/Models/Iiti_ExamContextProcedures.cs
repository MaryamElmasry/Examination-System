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
        Task<int> addCourseTopicAsync(int? courseId, string topicName, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> AddNewBranchAsync(string branchName, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> AddNewDepartmentAsync(string deptName, int? branchId, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> DeleteBranchAsync(int? id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> deleteCourseTopicAsync(int? courseId, string topicName, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> DeleteDepartmentByIdAsync(int? id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetAllBranchesResult>> GetAllBranchesAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<getAllCoursesResult>> getAllCoursesAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetAllDepartmentsResult>> GetAllDepartmentsAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<getBranchByNameResult>> getBranchByNameAsync(string name, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetBrancheByIDResult>> GetBrancheByIDAsync(int? branchId, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<getBranchesDepartmentsResult>> getBranchesDepartmentsAsync(int? id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<getBranchNameResult>> getBranchNameAsync(int? id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<getCourseDepartmentsResult>> getCourseDepartmentsAsync(int? id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<getCourseInstructorsResult>> getCourseInstructorsAsync(int? id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<getCourseTopicsResult>> getCourseTopicsAsync(int? id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<GetDepartmentByNameAndBranchIDResult>> GetDepartmentByNameAndBranchIDAsync(string name, int? id, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<getTopicByNameAndCourseIDResult>> getTopicByNameAndCourseIDAsync(int? courseId, string topicName, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> updateBranchNameAsync(int? id, string newName, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> UpdateDepartmentAsync(int? deptId, string deptName, int? BranchID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
    }
}
