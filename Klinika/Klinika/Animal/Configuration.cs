namespace Klinika.Animal
{
    public static class Configuration
    {
        public static void RegisterEndpointsForAnimals(this IEndpointRouteBuilder app)
        {
            app.MapGet("/api/v1/animals", (IAnimalService service) =>
            {
                var result = service.GetAnimals();

                return TypedResults.Ok(result);
            });

            app.MapGet("/api/v1/animals/{id:int}", (IAnimalService service, int id) =>
            {
                var result = service.GetAnimalById(id);

                return result == null ? Results.NotFound() : TypedResults.Ok(result);
            });

            app.MapPost("api/v1/animals", (IAnimalService service, Animal animal) =>
            { 
                service.AddAnimal(animal);

                return TypedResults.Created("GetAnimals", animal);
            });

            app.MapPatch("api/v1/animals/", (IAnimalService service, Animal animal) =>
            {
                var updatedAnimal = service.UpdateAnimal(animal);

                return updatedAnimal == null ? Results.NotFound() : TypedResults.Ok(updatedAnimal);
            });

            app.MapDelete("api/v1/animals/{id:int}", (IAnimalService service, int id) =>
            {
                service.DeleteAnimal(id);

                return Results.NoContent();
            });
        }
    }
}