namespace WebApplication1.Models;

public class Visit
{
    public int Id { get; set; }
    public int AnimalId { get; set; }
    public DateTime VisitDate { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
}