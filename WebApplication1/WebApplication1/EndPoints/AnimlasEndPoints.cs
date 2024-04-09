using WebApplication1.Database;
using WebApplication1.Models;

namespace WebApplication1.EndPoints;

public static class AnimlasEndPoints
{
    public static void MapAnimalsEndPoints(this WebApplication app)
    {
        app.MapGet("/animals", () =>
        {
            //200 - Ok
            //201 - Created
            //400 - Bad Request
            //401 - Unauthorized
            //403 - Forbidden
            //404 - Not Fount
            var animals = StaticData.animals;


            return Results.Ok(animals);
        });

        app.MapGet("/animals/{id}", (int id) =>
        {
            return Results.Ok(id);
        });

        app.MapPost("/animals", (Animals animals) =>
        {
            return Results.Created("", animals);
        });
    }
}