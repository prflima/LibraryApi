using FluentValidation;
using LibraryAPI.Application.Interfaces.Author;
using LibraryAPI.Application.Interfaces.Book;
using LibraryAPI.Application.Interfaces.Category;
using LibraryAPI.Application.UseCases.Authors.CreateAuthorUseCase;
using LibraryAPI.Application.UseCases.Authors.GetAuthorByIdUseCase;
using LibraryAPI.Application.UseCases.Books.CreateBookUseCase;
using LibraryAPI.Application.UseCases.Categories.CreateCategoryUseCase;
using LibraryAPI.Application.UseCases.Categories.GetCategoryByIdUseCase;

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
            return services;
        }
    }
}
