using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DogRazor.Data;
using DogRazor.Models;

namespace DogRazor.Pages.Dogs
{
    public class CreateModel : PageModel
    {
        private readonly DogRazor.Data.DogRazorContext _context;

        public CreateModel(DogRazor.Data.DogRazorContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Dog Dog { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Dog == null || Dog == null)
            {
                return Page();
            }

            _context.Dog.Add(Dog);
            await _context.SaveChangesAsync();

            return RedirectToPage("../Gestion");
        }
    }
}
