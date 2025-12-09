using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GlamCart.Models;

namespace GlamCart.Pages.Reviews
{
    public class CreateModel : PageModel
    {
        private readonly AppDbContext _context;

        public CreateModel(AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Review Review { get; set; }

        public SelectList ProductList { get; set; }

        public async Task OnGetAsync()
        {
            ProductList = new SelectList(
                await _context.Products.ToListAsync(),
                "ProductID",
                "Name"
            );
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                ProductList = new SelectList(
                    await _context.Products.ToListAsync(),
                    "ProductID",
                    "Name"
                );
                return Page();
            }

            _context.Reviews.Add(Review);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Reviews/Index");
        }
    }
}
