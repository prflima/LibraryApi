using FluentValidation;
using LibraryAPI.Application.Interfaces.Author;
using LibraryAPI.Application.Interfaces.Book;
using LibraryAPI.Application.Interfaces.BookLoans;
using LibraryAPI.Application.Interfaces.Category;
using LibraryAPI.Application.Interfaces.Users;
using LibraryAPI.Application.UseCases.Authors.CreateAuthor;
using LibraryAPI.Application.UseCases.Authors.GetAuthorById;
using LibraryAPI.Application.UseCases.BookLoans.CreateBookLoan;
using LibraryAPI.Application.UseCases.Books.CreateBook;
using LibraryAPI.Application.UseCases.Categories.CreateCategory;
using LibraryAPI.Application.UseCases.Categories.GetCategoryById;
using LibraryAPI.Application.UseCases.Users.CreateUser;

namespace LibraryAPI.Application.DependencyInjection
{
    public static class ApplicationDependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            // Configuring all validator in the assembly
            services.AddValidatorsFromAssemblyContaining<CreateAuthorCommand>();

            // Register the use cases
            services.AddScoped<ICreateAuthorUseCase, CreateAuthorUseCase>();
            services.AddScoped<IGetAuthorByIdUseCase, GetAuthorByIdUseCase>();
            services.AddScoped<ICreateCategoryUseCase, CreateCategoryUseCase>();
            services.AddScoped<IGetCategoryByIdUseCase, GetCategoryByIdUseCase>();
            services.AddScoped<ICreateBookUseCase, CreateBookUseCase>();
            services.AddScoped<ICreateUserUseCase, CreateUserUseCase>();
            services.AddScoped<ICreateBookLoanUseCase, CreateBookLoanUseCase>();

            return services;
        }
    }
}
