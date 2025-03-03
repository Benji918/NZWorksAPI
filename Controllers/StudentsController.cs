using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NZWorksAPI.Controllers
{
    // https://localhost:5001/api/students
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            string[] Students = { "Student 1", "Student 2", "Student 3" };
            List<int> ints = new List<int>() { 2, 4 };
            return Ok(ints);
        }
    }
}
