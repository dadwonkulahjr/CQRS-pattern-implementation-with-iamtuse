using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyAppCQRSPattern.Application.Services.Repository.IRepository;
using MyAppCQRSPattern.Application.Students.Commands.CreateStudent;
using MyAppCQRSPattern.Application.Students.Commands.UpdateStudent;
using MyAppCQRSPattern.Application.Students.Queries.GetStudents;
using MyAppCQRSPattern.Application.ViewModels;
using System.Threading.Tasks;

namespace MyAppCQRSPattern.UI.Pages.Admin.Students
{
    public class UpsertModel : PageModel
    {
        private readonly IGenderRepository _genderRepo;
        private readonly IMediator _mediatorQuery;

        [BindProperty]
        public StudentVM StudentVM { get; set; }

        public UpsertModel(IGenderRepository studentRepository, IMediator mediator)
        {
            _genderRepo = studentRepository;
            _mediatorQuery = mediator;
        }
        public async Task<IActionResult> OnGet(int? id)
        {

            if (id == null)
            {
                StudentVM = new();

                StudentVM.StudentLists = await _mediatorQuery.Send(new GetStudentListQuery());
                StudentVM.StudentSelectListItemDropdown = _genderRepo.GetDropdownSelectListItemsForGender();


                return Page();
            }

            if (id.HasValue)
            {
                StudentVM = new();

                StudentVM.StudentObj.StudentId = id.Value;

                StudentVM.StudentObj = await _mediatorQuery.Send(new GetFirstOrDefaultListQuery(StudentVM.StudentObj));

                StudentVM.StudentSelectListItemDropdown = _genderRepo.GetDropdownSelectListItemsForGender();

                return Page();
            }

            return Page();

        }
        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid) { return Page(); }


            if (StudentVM.StudentObj.StudentId == 0)
            {
                //Create
                await _mediatorQuery.Send(new CreateStudentListCommand(StudentVM.StudentObj));
                return RedirectToPage("./Index");
            }
            else
            {
                //Update
                await _mediatorQuery.Send(new UpdateStudentListCommand(StudentVM.StudentObj));
                return RedirectToPage("./Index");
            }

        }
    }
}
