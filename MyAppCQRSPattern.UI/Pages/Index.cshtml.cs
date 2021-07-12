using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace MyAppCQRSPattern.UI.Pages
{
    public class IndexModel : PageModel
    {
        public IActionResult OnGet() { return RedirectToPage("./Admin/Students/Index"); }
        
    }
}
