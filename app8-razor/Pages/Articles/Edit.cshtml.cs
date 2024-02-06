using app8_razor.Data;
using app8_razor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace app8_razor.Pages.Articles
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public EditModel(ApplicationDbContext db)
        {
            _db=db;
        }
        [BindProperty]
        public Article Article { get; set; }
        public void OnGet(int? id)
        {
            Article = _db.Articles.Find(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                _db.Articles.Update(Article);
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
