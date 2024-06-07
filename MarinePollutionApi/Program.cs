using MarinePollutionApi.Data;
using MarinePollutionApi.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseOracle(builder.Configuration.GetConnectionString("OracleDbConnection")));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/pollution", async (AppDbContext db) => await db.PollutionRecords.ToListAsync());
app.MapPost("/pollution", async (PollutionRecords record, AppDbContext db) =>
{
    db.PollutionRecords.Add(record);
    await db.SaveChangesAsync();
    return Results.Created($"/pollution/{record.Id}", record);
});

app.Run();
    