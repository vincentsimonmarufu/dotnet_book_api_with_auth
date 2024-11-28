using BookApi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookApi.Data;

public class BookContext : IdentityDbContext<ApplicationUser>
{
    public BookContext(DbContextOptions<BookContext> options) : base(options)
    {
    }

    public DbSet<Author> Authors { get; set; }
    public DbSet<Book> Books { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Author>().HasData(new Author { Id = 1, Name = "Author One" },
            new Author { Id = 2, Name = "Author Two" });
        modelBuilder.Entity<Book>().HasData(new Book { Id = 1, Title = "Book One", AuthorId = 1 },
            new Book { Id = 2, Title = "Book Two", AuthorId = 2 });
    }
}