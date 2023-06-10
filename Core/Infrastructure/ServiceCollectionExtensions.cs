using Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddTransient<IEntryReceiptRepository, EntryReceiptRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
