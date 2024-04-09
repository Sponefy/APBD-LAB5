using WebApplication1.Models;

namespace WebApplication1.Database;

public class StaticData
{
    public static List<Animals> animals = new List<Animals>()
    {
        new Animals(),
        new Animals(),
        new Animals(),
    };
}