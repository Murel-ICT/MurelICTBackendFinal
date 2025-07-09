using Microsoft.EntityFrameworkCore;
using MurelICTBackend.Data; 

var builder = WebApplication.CreateBuilder(args);

//Add services to the container.
builder.Services.AddControllers();

//Register the in-memory database
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("MurelICT"));

//Swagger/OpenAPI support with custom title
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "MurelICT",
        Version = "v1",
        Description = "API backend for MurelICT platform"
    });
});

var app = builder.Build();

//Always show Swagger UI (custom title)
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.DocumentTitle = "MurelICT"; //Browser tab title
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "MurelICT API v1"); // UI header
});

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();



