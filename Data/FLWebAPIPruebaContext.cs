using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FLWebAPIPrueba.Models;

namespace FLWebAPIPrueba.Data
{
    public class FLWebAPIPruebaContext : DbContext
    {
        public FLWebAPIPruebaContext (DbContextOptions<FLWebAPIPruebaContext> options)
            : base(options)
        {
        }

        public DbSet<FLWebAPIPrueba.Models.Book> Book { get; set; } = default!;
    }
}
