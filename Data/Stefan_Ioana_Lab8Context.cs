using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Stefan_Ioana_Lab8.Models;

namespace Stefan_Ioana_Lab8.Data
{
    public class Stefan_Ioana_Lab8Context : DbContext
    {
        public Stefan_Ioana_Lab8Context (DbContextOptions<Stefan_Ioana_Lab8Context> options)
            : base(options)
        {
        }

        //tabel
        public DbSet<Stefan_Ioana_Lab8.Models.Book> Book { get; set; }

        //tabel
        public DbSet<Stefan_Ioana_Lab8.Models.Publisher> Publisher { get; set; }

        //tabel
        public DbSet<Stefan_Ioana_Lab8.Models.Category> Category { get; set; }
    }
}
