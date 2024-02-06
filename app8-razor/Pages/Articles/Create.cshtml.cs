using app8_razor.Data;
using app8_razor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace app8_razor.Pages.Articles
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public CreateModel(ApplicationDbContext db)
        {
            _db=db;
        }
        [BindProperty]
        public Article Article { get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _db.Articles.AddAsync(Article);
                await _db.SaveChangesAsync();
                return RedirectToPage("/Index");
            }
            else
            {
                return Page();
            }
        }

    }
}
