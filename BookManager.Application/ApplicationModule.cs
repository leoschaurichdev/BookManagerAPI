using BookManager.Application.Commands.InsertBook;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;


namespace BookManager.Application
{
   public static class ApplicationModule
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddHandlers()
                    .AddValidation();
            return services;
        }
              

        private static IServiceCollection AddHandlers(this IServiceCollection services)
        {
            services.AddMediatR(config => 
                config.RegisterServicesFromAssemblyContaining<InsertBookCommand>());
            return services;
        }

        //fluent validations

        private static IServiceCollection AddValidation(this IServiceCollection services)
        {
            services
                .AddFluentValidationAutoValidation()
                .AddValidatorsFromAssemblyContaining<InsertBookCommand>();
            return services;
        }
    }
}
