using WebApplication1.Models;

namespace WebApplication1.Database;

public class MockDB
{
    public List<Animals> Animals { get; set; } = new List<Animals>();
    
    public MockDB()
    {
        Animals.Add(new Animals());
        Animals.Add(new Animals());
        Animals.Add(new Animals());
        Animals.Add(new Animals());
        
    }
}