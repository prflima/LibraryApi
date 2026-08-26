using LibraryAPI.Application.Author.CreateAuthorUseCase;
using LibraryAPI.Data;
using Microsoft.EntityFrameworkCore;
using FluentValidation;
using LibraryAPI.Domain.Interfaces.Author;

var builder = WebApplication.CreateBuilder(args);

// Configure dbContext
builder.Services.AddDbContext<LibraryDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("LibraryConnection")));

// Configuring all validator in the assembly
builder.Services.AddValidatorsFromAssemblyContaining<CreateAuthorCommand>();

// Register the use case
builder.Services.AddScoped<ICreateAuthorUseCase, CreateAuthorUseCase>();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();

