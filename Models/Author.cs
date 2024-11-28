using System.ComponentModel.DataAnnotations;

namespace BookApi.Models;

public class Author
{
    [Key] public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Book> Books { get; set; }
}