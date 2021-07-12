using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyAppCQRSPattern.Application.Students.Commands.CreateStudent;
using MyAppCQRSPattern.Application.Students.Commands.DeleteStudent;
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
        private readonly IMediator _mediatorQuery;
        public StudentsController(IMediator mediator)
        {
            _mediatorQuery = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var listOfStudentsData = await _mediatorQuery.Send(new GetStudentListQuery());
            return Json(new { data = listOfStudentsData });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var studentObj = new Student
            {
                StudentId = id
            };

            if (studentObj.StudentId > 0)
            {
                _mediatorQuery.Send(new DeleteStudentListCommand(studentObj)).GetAwaiter().GetResult();
                return Json(new { success = true, message = "Delete successful" });
            }
            else
            {
                return Json(new { success = false, message = "Error why deleting." });
            }
            

        }

    }
}
