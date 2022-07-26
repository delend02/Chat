using Chat.DAL.Interfaces;
using Chat.DAL.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Chat.BLL.Infrastucture
{
    public static class Module
    {
        public static IServiceCollection AddUnitOfWork(this IServiceCollection services)
        {
            services.AddSingleton<IUnitOfWork, UnitOfWork>();
            return services;
        }

    }
}
