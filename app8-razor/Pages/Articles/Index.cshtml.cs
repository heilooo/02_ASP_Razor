using app8_razor.Data;
using app8_razor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace app8_razor.Pages.Articles
{
	public class IndexModel : PageModel
	{
		private readonly ApplicationDbContext _db;
		public IndexModel(ApplicationDbContext db)
		{
			_db = db;
		}
		public IEnumerable <Article> Articles { get; set; }
		public void OnGet()
		{
			Articles = _db.Articles;
		}
	}
}
