using Microsoft.AspNetCore.OData;
using OData_Learning;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
                .AddJsonOptions(x=> x.JsonSerializerOptions.ReferenceHandler=ReferenceHandler.IgnoreCycles)
                .AddOData(cfg =>
                {
                    //cfg.Select().Filter().OrderBy(); //istenilen data emeliyyati
                    cfg.EnableQueryFeatures(); //bu ise butun data emeliyyatlarini eyni anda aktiv edir.

                });
builder.Services.AddApplicationServices(builder.Configuration);


// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/", context =>
{
    context.Response.Redirect("/swagger");
    return Task.CompletedTask;
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
