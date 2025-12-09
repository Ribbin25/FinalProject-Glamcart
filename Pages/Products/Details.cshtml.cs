using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GlamCart.Models;

namespace FinalProject_Glamcart.Pages_Products__referenceScriptLibraries
{
    public class DetailsModel : PageModel
    {
        private readonly GlamCart.Models.AppDbContext _context;

        public DetailsModel(GlamCart.Models.AppDbContext context)
        {
            _context = context;
        }

        public Product Product { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FirstOrDefaultAsync(m => m.ProductID == id);

            if (product is not null)
            {
                Product = product;

                return Page();
            }

            return NotFound();
        }
    }
}
