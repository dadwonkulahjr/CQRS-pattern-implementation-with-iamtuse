using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyAppCQRSPattern.Application.Courses.Commands.CreateCourse;
using MyAppCQRSPattern.Application.Courses.Commands.UpdateCourse;
using MyAppCQRSPattern.Application.Courses.Queries.GetCourses;
using MyAppCQRSPattern.Application.ViewModels;

namespace MyAppCQRSPattern.UI.Pages.Admin.Courses
{
    public class UpsertModel : PageModel
    {
        private readonly IMediator _mediatorQuery;

        [BindProperty]
        public CourseVM CourseVM { get; set; }
        public UpsertModel(IMediator mediator)
        {
            _mediatorQuery = mediator;
        }
        public async Task<IActionResult> OnGet(int? id)
        {

            if (id == null)
            {
                CourseVM = new();
                return Page();
            }

            if (id.HasValue)
            {
                CourseVM = new();

                CourseVM.CourseObj.CourseId = id.Value;
                CourseVM.CourseObj = await _mediatorQuery.Send(new GetFirstOrDefaultCourseQuery(CourseVM.CourseObj));
                return Page();
            }

            return Page();


        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid) { return Page(); }

            if (CourseVM.CourseObj.CourseId == 0)
            {
                //Create

                await _mediatorQuery.Send(new CreateCourseListCommand(CourseVM.CourseObj));
                return RedirectToPage("./Index");

            }
            else
            {
                //Update
                await _mediatorQuery.Send(new UpdateCourseListCommand(CourseVM.CourseObj));
                return RedirectToPage("./Index");
                
            }

        }

    }
}
