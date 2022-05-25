using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DogRazor.Models;

namespace DogRazor.Data
{
    public class DogRazorContext : DbContext
    {
        public DogRazorContext (DbContextOptions<DogRazorContext> options)
            : base(options)
        {
        }

        public DbSet<DogRazor.Models.Dog>? Dog { get; set; }
    }
}
