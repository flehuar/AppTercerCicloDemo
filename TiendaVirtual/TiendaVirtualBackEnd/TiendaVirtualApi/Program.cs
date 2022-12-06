using Microsoft.OpenApi.Models;
using System.Reflection;
using Utilitarios;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "mis origenes",
                      builder =>
                      {
                          builder.AllowAnyMethod();
                          builder.AllowAnyOrigin();
                          builder.AllowAnyHeader();

                      });
});




// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "API TIENDA VIRTUAL",
        Description = "Tiene la documentación de un proyecto de tienda virtual",
        TermsOfService = new Uri("https://example.com/terms"),

        Contact = new OpenApiContact
        {
            Name = "Franklin Huaman",
            Url = new Uri("https://example.com/contact"),
            Email="fhuaman@continental.edu.pe"
        },
        License = new OpenApiLicense
        {
            Name = "Example License",
            Url = new Uri("https://example.com/license")
            
        }
    });
    // using System.Reflection;
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

//para utilizar nuestro mapper a nivel de todo el proyecto ==> inyección de dependencias
builder.Services.AddAutoMapper(typeof(IStartup).Assembly, typeof(AutoMapperProfiles).Assembly);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors(x =>
{
    x.AllowAnyHeader();
    x.AllowAnyOrigin();
    x.AllowAnyMethod();
});

app.Run();
