﻿using Kreata.Backend.Controllers.Base;
using Kreata.Backend.Repos;
using Kreta.Shared.Assemblers;
using Kreta.Shared.Dtos;
using Kreta.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kreata.Backend.Controllers
{
    public partial class StudentController : BaseController<Student, StudentDto>
    {
        private IStudentRepo _studentRepo;
        public StudentController(StudentAssembler? assambler, IStudentRepo? repo) : base(assambler, repo)
        {
            _studentRepo = repo ?? throw new ArgumentNullException(nameof(repo));
        }

        [HttpGet("getstudentbyfullname")]
        public async Task<IActionResult> GetStudentByFullName([FromQuery] FullNameQueryDto fullNameDto)
        {
            return Ok(await _studentRepo.GetByNameAsync(fullNameDto.FirstName, fullNameDto.LastName));
        }

        [HttpGet("getstudentnumber")]
        public async Task<IActionResult> GetNumberOfStudentAsync()
        {
            return Ok(await _studentRepo.GetNumberOfStudentAsync());
        }

        [HttpGet("GetNumberOfWoman")]
        public async Task<IActionResult> GetNumberOfWomanAsync()
        {
            return Ok(await _studentRepo.GetNumberOfWomanAsync());
        }

        [HttpGet("GetNumberOfMan")]
        public async Task<IActionResult> GetNumberOfManAsync()
        {
            return Ok(await _studentRepo.GetNumberOfManAsync());
        }

        [HttpGet("GetNumberOfStudentByBirthYear")]
        public async Task<IActionResult> GetNumberOfStudentBirthIn2021Async()
        {
            return Ok(await _studentRepo.GetNumberOfStudentBirthIn2021Async());
        }

        [HttpGet("GetNumberOfStudentBornInApril")]
        public async Task<IActionResult> GetNumberOfStudentBornInAprilAsync()
        {
            return Ok(await _studentRepo.GetNumberOfStudentBornInAprilAsync());
        }

        [HttpGet("NumberOfStudentByYear/{year}")]
        public async Task<IActionResult> GetNumberOfStudentByYearAsync(int year)
        {
            return Ok(await _studentRepo.GetNumberOfStudentByYearAsync(year));
        }

        [HttpGet("NumberOfStudentByYearAndMonth/{year}/{month}")]
        public async Task<IActionResult> GetNumberOfStudentByYearAndMonthAsync(int year, int month)
        {
            return Ok(await _studentRepo.GetNumberOfStudentByYearAndMonthAsync(year, month));
        }
    }
}
