using app8_razor.Data;
using app8_razor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace app8_razor.Pages.Articles
{
    public class DetailsModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public DetailsModel(ApplicationDbContext context)
        {
            _context = context;
        }

		public Article? Artilce { get; set; }

		public void OnGet(int? id)
        {
			Artilce = _context.Articles.Find(id);
        }
    }
}
