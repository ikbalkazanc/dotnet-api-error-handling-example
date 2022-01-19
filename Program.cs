using dotnet_api_error_handling_example.Extensions;
using dotnet_api_error_handling_example.Filter;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.

builder.Services.AddControllers(opt =>
{
    opt.Filters.Add(new ValidateModelFilter());
}).ConfigureApiBehaviorOptions(opt =>
{
    opt.InvalidModelStateResponseFactory = context =>
    {
        return null;
    };
});

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseErrorHandling();

app.UseAuthorization();

app.MapControllers();

app.Run();
