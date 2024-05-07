using Carter;

public class MovieEndpoints : CarterModule

{
    public override void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/shoe", () => "Movies API up and running");
        app.MapGet("/ball", () => "Ball is up and running");
    }
}