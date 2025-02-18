﻿using Kreata.Backend.Repos.Base;
using Kreta.Shared.Enums;
using Kreta.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kreata.Backend.Repos
{
    public interface IStudentRepo : IBaseRepo<Student>
    {
        public Task<Student> GetByNameAsync(string firstName, string lastName);
        public Task<List<Student>> GetStudentByClass(int schoolYear, SchoolClassType schoolClassType);
        public Task<int> GetNumberOfStudentAsync();
        public Task<int> GetNumberOfWomanAsync();
        public Task<int> GetNumberOfManAsync();
        public Task<int> GetNumberOfStudentBirthIn2021Async();
        public Task<int> GetNumberOfStudentBornInAprilAsync();
        public Task<int> GetNumberOfStudentByYearAsync(int year);
        
        public Task<int> GetNumberOfStudentByYearAndMonthAsync(int year, int month);
    }
}
