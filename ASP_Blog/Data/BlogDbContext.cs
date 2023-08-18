using ASP_Blog.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace ASP_Blog.Data
{
    //DBContext class functions as API w/ CRUD operations for DB communication
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions options) : base(options)
        {
        }

        //set DB tables
        public DbSet<BlogPost> BlogPosts { get; set; }

        public DbSet<Tag> Tags { get; set; }
    }
}
