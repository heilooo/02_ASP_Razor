using app8_razor.Data;
using app8_razor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace app8_razor.Pages.Articles
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public Article Article { get; set; }

        public void OnGet(int? id)
        {
            Article= _db.Articles.Find(id);
        }
        public async Task<IActionResult> OnPost(int? id)
        {
            if (ModelState.IsValid)
            {
                var article = await _db.Articles.FindAsync(id);
                _db.Articles.Remove(article);
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
