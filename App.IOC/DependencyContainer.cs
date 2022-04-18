using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.IOC
{
    public class DependencyContainer
    {
        public static void RegisterService(IServiceCollection serviceCollection)
        {
            Item.RegisterService(serviceCollection);
        }
    }
}
