using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyAppCQRSPattern.Application.Genders.Commands.CreateGender;
using MyAppCQRSPattern.Application.Genders.Commands.UpdateGender;
using MyAppCQRSPattern.Application.Genders.Queries.GetGenders;
using MyAppCQRSPattern.Domain.Entities;
using System.Threading.Tasks;

namespace MyAppCQRSPattern.UI.Pages.Admin.Genders
{
    public class UpsertModel : PageModel
    {
        private readonly IMediator _mediatoQuery;

        [BindProperty]
        public Gender GenderObj { get; set; }
        public UpsertModel(IMediator mediator)
        {
            _mediatoQuery = mediator;
        }
        public async Task<IActionResult> OnGet(int? id)
        {
            if (id == null)
            {
                GenderObj = new();

                return Page();
            }

            GenderObj = new()
            {
                GenderId = id.Value
            };

            GenderObj = await _mediatoQuery.Send(new GetFirstOrDefaultGenderQuery(GenderObj));

            if (GenderObj != null)
            {
                return Page();
            }


            return Page();
        }
        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid) { return Page(); }


            if (GenderObj.GenderId == 0)
            {
                //Create
                await _mediatoQuery.Send(new CreateGenderListCommand(GenderObj));
                return RedirectToPage("./Index");
            }
            else
            {
                //Update
                await _mediatoQuery.Send(new UpdateGenderListCommand(GenderObj));
                return RedirectToPage("./Index");
            }
        }
    }
}
