using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GlamCart.Models;

namespace GlamCart.Pages.Reviews
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public IList<Review> Review { get; set; } = new List<Review>();

        public async Task OnGetAsync(int? productId)
        {
            if (productId == null)
            {
                Review = await _context.Reviews
                    .Include(r => r.Product)
                    .ToListAsync();
            }
            else
            {
                Review = await _context.Reviews
                    .Include(r => r.Product)
                    .Where(r => r.ProductID == productId)
                    .ToListAsync();
            }
        }
    }
}
