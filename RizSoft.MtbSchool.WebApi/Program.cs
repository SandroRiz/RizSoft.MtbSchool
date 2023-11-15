using Microsoft.EntityFrameworkCore;
using RizSoft.MtbSchool.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContextFactory<MtbSchoolContext>(o => o.UseSqlServer(connectionString));

builder.Services.AddScoped<TourService>();
builder.Services.AddScoped<CourseService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/toptours", async (TourService svc) =>
  { return await svc.TopListAsync(5); }
);

app.MapGet("/courses", async (CourseService svc) =>
  { return await svc.ListAsync(); }
);

app.Run();