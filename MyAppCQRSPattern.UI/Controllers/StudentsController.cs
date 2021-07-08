using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyAppCQRSPattern.Application.Students.Queries.GetStudents;
using MyAppCQRSPattern.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyAppCQRSPattern.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : Controller
    {
        public StudentsController()
        {

        }
        [HttpGet]
        public async Task<IEnumerable<Student>> Get([FromServices]
        IGetStudentListQuery query)
        {
            return await query.Handle();
        }
    }
}
