using Microsoft.EntityFrameworkCore;
using PointX.Migrations;
using PointX.Properties.DTO;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<PointXContext>(options =>
                                                options.UseSqlServer
                                                (builder.Configuration.GetConnectionString("DefaultConnection")));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//Wanna get provinces of nation ? use include
app.MapGet("/GetNations", async (PointXContext context, CancellationToken cancellationToken) 
    => await context.Nations.Include(x => x.Provinces).ToListAsync(cancellationToken)).WithName("GetNations");

app.MapPost("/CreateNation", async (PointXContext context, UpNationDTO nationDTO, CancellationToken cancellationToken) => {
    var nation = await context.Nations.AddAsync(nationDTO);
    await context.Provinces.AddRangeAsync(nationDTO.Provinces);
    return nation is not null ? Results.Ok(nation)
                              : Results.NotFound();
}).WithName("CreateNation");
app.Run();

//internal record WeatherForecast(DateTime Date, int TemperatureC, string? Summary)
//{
//    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
//}