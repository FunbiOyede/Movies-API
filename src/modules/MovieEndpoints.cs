using Carter;

public class MovieEndpoints : CarterModule

{
    public override void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/movies", () => "Movies API up and running");
        app.MapGet("/year/{release_year}", (int release_year) => $"Release Year is {release_year}");
        app.MapGet("/overview/{movie_name}", (string movie_name) => $" Movie Name is  {movie_name}");
    }
}