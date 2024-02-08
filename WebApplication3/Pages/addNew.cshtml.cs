using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication3.Pages
{
    public class addNewModel : PageModel
	{

		public IActionResult OnGet()
		{
			return Page();
		}

		[BindProperty]
		public New new1 { get; set; } = default!;

		public IActionResult OnPost()
		{
			if (!ModelState.IsValid || new1 == null)
			{
				return Page();
			}

			Program.db?.News.Add(new1);
			Program.db?.SaveChangesAsync();

			return RedirectToPage("./Index");
		}
	}
}
