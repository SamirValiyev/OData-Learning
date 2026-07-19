using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using OData_Learning.Services.Abstract;

namespace OData_Learning.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TestStudentController(IStudentService studentService) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllStudents()
        {
            var students = studentService.GetAllStudents();
            return Ok(students);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStudentsFilter()
        {
            var students = studentService.GetAllStudentsFilter();
            return Ok(students);
        }

        [HttpGet]
        public async Task<IActionResult> GetStudentsById(int id)
        {
            var student = studentService.GetStudentsById(id);
            return Ok(student);
        }

        [HttpGet]
        [EnableQuery]
        public async Task<IActionResult> GetStudents()
        {
            var students = studentService.GetStudents();
            return Ok(students);
        }


        [HttpGet]
        [EnableQuery]
        public async Task<IActionResult> GetStudentsWithGrade()
        {
            var students = studentService.GetStudentGrade();
            return Ok(students);
        }
    }
}
