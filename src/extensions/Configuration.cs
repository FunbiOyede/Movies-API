

using Carter;

public static class Configuration
{
    public static void RegisterServices(this WebApplicationBuilder builder)
    {
        builder.Services
                .AddCarter()
               .AddEndpointsApiExplorer()
               .AddSwaggerGen();
    }
    public static void RegisterMiddlewares(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger()
               .UseSwaggerUI();
        }
        app.MapCarter();
        app.UseHttpsRedirection();
    }

}