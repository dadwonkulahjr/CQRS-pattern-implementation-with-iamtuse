using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyAppCQRSPattern.Application.MainMenuItems.Queries.GetMainMenuItems;
using System.Threading.Tasks;

namespace MyAppCQRSPattern.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainMenuItemsController : Controller
    {
        private readonly IMediator _mediatorQuery;
        public MainMenuItemsController(IMediator mediator)
        {
            _mediatorQuery = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var listOfMainMenuItems = await _mediatorQuery.Send(new GetMainMenuItemListQuery());
            return Json(new { data = listOfMainMenuItems });
        }



    }
}
