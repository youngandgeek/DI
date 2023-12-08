using DI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using DI.Repository;

namespace DI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class StudentController : Controller
    {


        //DIP
        IStudent studentRepository;//Tigh Couple ==>lossly couple
        IDepartmentRepository departmentRepository;
        //DI
        public StudentController(IStudent _stdRepo, IDepartmentRepository _Deptrepo)
        {
            studentRepository = _stdRepo;//new StudentMockREspotory();
            departmentRepository = _Deptrepo;//new DepartmentRepository();
        }

        public IActionResult GetAll()
        {
            try
            {
                List<Student> students = studentRepository.GetAll();
                return Ok(students);
            }
            catch (Exception ex)
            {
                // Log the exception or handle it accordingly
                return StatusCode(500, "Internal server error");
            }
        }
    

    }
}
