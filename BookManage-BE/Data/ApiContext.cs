using BookManage_BE.Models;
using Microsoft.EntityFrameworkCore;

namespace BookManage_BE.Data
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options) { }

        public DbSet<BookDTO> Books { get; set; }
    }
}
