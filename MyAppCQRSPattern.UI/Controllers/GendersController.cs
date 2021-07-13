using MediatR;
using Microsoft.AspNetCore.Mvc;
using MyAppCQRSPattern.Application.Genders.Commands.DeleteGender;
using MyAppCQRSPattern.Application.Genders.Queries.GetGenders;
using MyAppCQRSPattern.Domain.Entities;
using System.Threading.Tasks;

namespace MyAppCQRSPattern.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GendersController : Controller
    {
        private readonly IMediator _mediatorQuery;

        public GendersController(IMediator mediator)
        {
            _mediatorQuery = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var listOfCourses = await _mediatorQuery.Send(new GetGenderListQuery());
            return Json(new { data = listOfCourses });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var genderObj = new Gender
            {
                GenderId = id
            };

            if (genderObj.GenderId > 0)
            {
                _mediatorQuery.Send(new DeleteGenderListCommand(genderObj)).GetAwaiter().GetResult();
                return Json(new { success = true, message = "Delete successful" });
            }
            else
            {
                return Json(new { success = false, message = "Error why deleting." });
            }


        }
    }
}
