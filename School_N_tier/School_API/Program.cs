using Microsoft.EntityFrameworkCore;
using School_DataAccess.Interfaces;
using School_DataAccess.Service;
using School_Modles.Models;
using School_Services;
using School_Services.Interface;
using School_Services.Repository;

var builder = WebApplication.CreateBuilder(args);
IConfiguration configuration = builder.Configuration;
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<SchoolContext>((optionsBuilder) =>
{
    optionsBuilder.UseSqlServer(configuration.GetConnectionString("Default"));
    optionsBuilder.EnableDetailedErrors();
});

//Add DataAccess Layer services
builder.Services.AddScoped<IStudentActionManager, StudentDataActions>();
builder.Services.AddScoped<IGradeActionManager, GradeDataActions>();
builder.Services.AddScoped<ITeacherActionManager, TeacherDataActions>();
//Add Service Layer Services
builder.Services.AddScoped<IGradeServiceHandler, GradeServiceHandlerRepository>();
builder.Services.AddScoped<IStudentServiceHandler, StudentServiceHandlerRepository>();
builder.Services.AddScoped<ITeacherServiceHandler, TeacherServiceHandlerRepository>();
builder.Services.AddScoped<IMapperClass, ConvertEntityToDTO>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseStaticFiles();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
