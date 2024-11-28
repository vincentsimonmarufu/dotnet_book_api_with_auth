using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookApi.Models;

public class Book
{
    [Key] public int Id { get; set; }
    public string Title { get; set; }
    
    [ForeignKey("Author")] public int AuthorId { get; set; }
    public Author Author { get; set; }
}