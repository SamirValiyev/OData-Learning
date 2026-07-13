using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

    }
}
