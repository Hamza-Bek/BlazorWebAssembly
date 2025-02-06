using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MasteringBlazor.Models;

public class SubmitBook
{
    [Required]
    [StringLength(80 , MinimumLength = 3)]
    [DisplayName("Book Title is required")]
    public string? Title { get; set; }
    
    [StringLength(5000)]
    public string? Description { get; set; }
    
    [Required]
    [StringLength(80, MinimumLength = 3)]
    public string? Author { get; set; }
    
    [Required]
    [StringLength(10, MinimumLength = 3)]
    public string? ISBN { get; set; }
    
    [Required]
    public int PageCount { get; set; }
    
    [Required]
    [Range(typeof(decimal), "0.01", "1000.00")]
    public decimal Price { get; set; }
    
    [Required]
    [StringLength(20 , MinimumLength = 2)]
    public string Category { get; set; }

    public TimeOnly Time { get; set; }
}