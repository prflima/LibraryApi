using FluentValidation;
using Library.Application.Interfaces.Commands.Authors;
using Library.Application.Interfaces.Commands.BookLoans;
using Library.Application.Interfaces.Commands.Books;
using Library.Application.Interfaces.Commands.Categories;
using Library.Application.Interfaces.Queries.Authors;
using Library.Application.Interfaces.Queries.Categories;
using Library.Application.Interfaces.Users;
using Library.Application.UseCases.Commands.Authors.CreateAuthor;
using Library.Application.UseCases.Commands.BookLoans.CreateBookLoan;
using Library.Application.UseCases.Commands.Books.CreateBook;
using Library.Application.UseCases.Commands.Categories.CreateCategory;
using Library.Application.UseCases.Queries.Authors.GetAuthorById;
using Library.Application.UseCases.Queries.Categories.GetCategoryById;
using LibraryAPI.Application.UseCases.Users.CreateUser;
using Microsoft.Extensions.DependencyInjection;

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
