using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cozma_Alexandra_Lab2.Models;

namespace Cozma_Alexandra_Lab2.Data
{
    public class Cozma_Alexandra_Lab2Context : DbContext
    {
        public Cozma_Alexandra_Lab2Context (DbContextOptions<Cozma_Alexandra_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Cozma_Alexandra_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Cozma_Alexandra_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Cozma_Alexandra_Lab2.Models.Author> Authors { get; set; }

        public DbSet<Cozma_Alexandra_Lab2.Models.Category> Category { get; set; }

        public DbSet<Cozma_Alexandra_Lab2.Models.Member> Member { get; set; }

        public DbSet<Cozma_Alexandra_Lab2.Models.Borrowing> Borrowing { get; set; }
    }
}
