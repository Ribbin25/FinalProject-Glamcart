using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GlamCart.Models;


namespace FinalProject_Glamcart.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public IList<Product> Products { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Products = await _context.Products.ToListAsync();
        }
    }
}
