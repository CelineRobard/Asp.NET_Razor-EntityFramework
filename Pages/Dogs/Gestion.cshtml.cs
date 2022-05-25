using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DogRazor.Data;
using DogRazor.Models;

namespace DogRazor.Pages.Dogs
{
    public class GestionModel : PageModel
    {
        private readonly DogRazor.Data.DogRazorContext _context;

        public GestionModel(DogRazor.Data.DogRazorContext context)
        {
            _context = context;
        }

        public IList<Dog> Dog { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Dog != null)
            {
                Dog = await _context.Dog.ToListAsync();
            }
        }
    }
}
