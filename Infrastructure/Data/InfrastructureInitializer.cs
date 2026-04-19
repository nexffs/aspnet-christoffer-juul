using Infrastructure.Persistence.Contexts;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Data;

public static class InfrastructureInitializer
{
    public static async Task InitializeAsync(IServiceProvider serviceProvider, IConfiguration configuration)
    {
        await PersistenceInitializer.InitializeDatabaseAsync(serviceProvider);

        await IdentityInitializer.InitilizeDefaultRolesAsync(serviceProvider);

        await IdentityInitializer.InitilizeDefaultAdminAccountsAsync(serviceProvider, configuration);
    }
}
