using WebApplication1.Database;
using WebApplication1.Models;

namespace WebApplication1.EndPoints;

public static class AnimalsEndPoints
{
    public static void MapAnimalsEndPoints(this WebApplication app)
    {
        app.MapGet("/animals", () => Results.Ok(StaticData.animals));

        app.MapGet("/animals/{id}", (int id) =>
        {
            var animal = StaticData.animals.FirstOrDefault(a => a.Id == id);
            if (animal == null)
            {
                return Results.NotFound();
            }
            return Results.Ok(animal);
        });

        app.MapPost("/animals", (Animals animal) =>
        {
            StaticData.animals.Add(animal);
            return Results.Created($"/animals/{animal.Id}", animal);
        });

        app.MapPut("/animals/{id}", (int id, Animals updatedAnimal) =>
        {
            var animal = StaticData.animals.FirstOrDefault(a => a.Id == id);
            if (animal == null)
            {
                return Results.NotFound();
            }
            animal.Name = updatedAnimal.Name;
            animal.Category = updatedAnimal.Category;
            animal.Weight = updatedAnimal.Weight;
            animal.FurColor = updatedAnimal.FurColor;
            return Results.Ok(animal);
        });

        app.MapDelete("/animals/{id}", (int id) =>
        {
            var animal = StaticData.animals.FirstOrDefault(a => a.Id == id);
            if (animal == null)
            {
                return Results.NotFound();
            }
            StaticData.animals.Remove(animal);
            return Results.Ok();
        });

        app.MapGet("/animals/{id}/visits", (int id) =>
        {
            var visits = StaticData.visits.Where(v => v.AnimalId == id).ToList();
            return Results.Ok(visits);
        });

        app.MapPost("/animals/{id}/visits", (int id, Visit visit) =>
        {
            visit.AnimalId = id;
            StaticData.visits.Add(visit);
            return Results.Created($"/animals/{id}/visits/{visit.Id}", visit);
        });
    }
}