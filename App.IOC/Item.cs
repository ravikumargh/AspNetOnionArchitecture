using App.Business;
using App.Domain.Interfaces.BusinessInterface;
using App.Domain.Interfaces.RepositoryInterfaces;
using App.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.IOC
{
    public static class Item
    {
        public static void RegisterService(IServiceCollection serviceCollection)
        {
            RegisterActivityService(serviceCollection);
            RegisterActivityReposter(serviceCollection);
        }

        private static void RegisterActivityService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IItemService, ItemService>();

        }

        private static void RegisterActivityReposter(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IItemRepository, ItemRepository>();

        }
       
    }
}
