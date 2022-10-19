using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile($"configuration.json", optional: false, reloadOnChange: true);

// Add services to the container

builder.Services.AddOcelot();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseOcelot().Wait();

app.UseHttpsRedirection();

app.Run();
