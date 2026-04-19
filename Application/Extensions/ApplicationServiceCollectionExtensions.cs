using Application.Abstractions.Services;
using Application.CustomerService;
using Application.Faq;
using Microsoft.Extensions.DependencyInjection;

namespace Application.Extensions;

public static class ApplicationServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        ArgumentNullException.ThrowIfNull(services);

        services.AddScoped<IContactRequestService, ContactRequestService>();
        services.AddScoped<IFaqService, FaqService>();

        return services;
    }
}
