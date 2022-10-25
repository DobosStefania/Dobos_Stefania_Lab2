using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Dobos_Stefania_Lab2.Models;

namespace Dobos_Stefania_Lab2.Data
{
    public class Dobos_Stefania_Lab2Context : DbContext
    {
        public Dobos_Stefania_Lab2Context (DbContextOptions<Dobos_Stefania_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Dobos_Stefania_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Dobos_Stefania_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Dobos_Stefania_Lab2.Models.Author> Authors { get; set; }
    }
}
