using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyAppCQRSPattern.Application.Courses.Commands.DeleteCourse;
using MyAppCQRSPattern.Application.Courses.Queries.GetCourses;
using MyAppCQRSPattern.Domain.Entities;
using System.Collections;
using System.Threading.Tasks;

namespace MyAppCQRSPattern.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : Controller
    {
        private readonly IMediator _mediatorQuery;

        public CoursesController(IMediator mediator)
        {
            _mediatorQuery = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var listofCourseData = await _mediatorQuery.Send(new GetCourseListQuery());
            return Json(new { data = listofCourseData });
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var courseObj = new Course
            {
                CourseId = id
            };

            if (courseObj.CourseId > 0)
            {
                _mediatorQuery.Send(new DeleteCourseListCommand(courseObj)).GetAwaiter().GetResult();
                return Json(new { success = true, message = "Delete successful" });
            }
            else
            {
                return Json(new { success = false, message = "Error why deleting." });
            }


        }
    }
}
