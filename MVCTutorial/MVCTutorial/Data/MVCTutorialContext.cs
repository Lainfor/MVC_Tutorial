using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVCTutorial.Models
{
    public class MVCTutorialContext : DbContext
    {
        public MVCTutorialContext (DbContextOptions<MVCTutorialContext> options)
            : base(options)
        {
        }

        public DbSet<MVCTutorial.Models.Movie> Movie { get; set; }
    }
}
