using Microsoft.EntityFrameworkCore;

namespace LMSMASTERDETAILPATTERNFOREXAM.Models
{
    public class LibraryDB:DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public LibraryDB(DbContextOptions opt) : base(opt)
        {

        }
    }
}
