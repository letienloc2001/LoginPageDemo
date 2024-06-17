using Microsoft.EntityFrameworkCore;

namespace LoginPageDemo;

public class Products
{
    public int Id { get; set; }

    public string Name { get; set; } = "";

    public string Brand { get; set; } = "";

    public string Category { get; set; } = "";

    [Precision(16,2)]
    public double Price { get; set; } 

    public string Description { get; set; } = "";

    public DateTime CreatedAt { get; set; }
}
