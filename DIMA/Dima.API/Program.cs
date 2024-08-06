using Dima.API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var cnnStr = builder.Configuration.GetConnectionString("DefaultConnection") ?? string.Empty;

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(x=> x.CustomSchemaIds(n => n.FullName));
builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(cnnStr));

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/", () => "Hello");
app.MapPost("/", () => "Hello");
app.MapPut("/", () => "Hello");
app.MapDelete("/", () => "Hello");


app.Run();
