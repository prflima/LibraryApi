using LibraryAPI.Application.Author.CreateAuthorUseCase;
using LibraryAPI.Data;
using Microsoft.EntityFrameworkCore;
using FluentValidation;
using LibraryAPI.Application.Interfaces.Author;
using LibraryAPI.Application.Author.GetAuthorByIdUseCase;
using LibraryAPI.Application.Interfaces.Category;
using LibraryAPI.Application.Category.CreateCategoryUseCase;
using LibraryAPI.Application.Category.GetCategoryByIdUseCase;
using LibraryAPI.Application.Interfaces.Book;
using LibraryAPI.Application.Books.CreateBookUseCase;

var builder = WebApplication.CreateBuilder(args);

// Configure dbContext
builder.Services.AddDbContext<LibraryDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("LibraryConnection")));

// Configuring all validator in the assembly
builder.Services.AddValidatorsFromAssemblyContaining<CreateAuthorCommand>();

// Register the use case
builder.Services.AddScoped<ICreateAuthorUseCase, CreateAuthorUseCase>();
builder.Services.AddScoped<IGetAuthorByIdUseCase, GetAuthorByIdUseCase>();
builder.Services.AddScoped<ICreateCategoryUseCase, CreateCategoryUseCase>();
builder.Services.AddScoped<IGetCategoryByIdUseCase, GetCategoryByIdUseCase>();
builder.Services.AddScoped<ICreateBookUseCase, CreateBookUseCase>();

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

