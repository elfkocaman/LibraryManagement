using LibraryManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext() : base("LibraryDbConnection") { }

        public DbSet<Book> Books { get; set; }
    }
}
