using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using WebApi.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Variable para la cadena de conexión a la base de datos
var connectionString = builder.Configuration.GetConnectionString("Connection");
//Registrar el servicio para la conexión
builder.Services.AddDbContext<AppDBContext>(options =>options.UseSqlServer(connectionString));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
        options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
        options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
    }); 
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder => builder.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader());
});
builder.Services.AddControllers();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
 

app.UseHttpsRedirection();

app.UseRouting();

app.UseCors("AllowSpecificOrigin"); // Agregar el uso de la política CORS

app.UseAuthorization();

app.MapControllers();

app.Run();