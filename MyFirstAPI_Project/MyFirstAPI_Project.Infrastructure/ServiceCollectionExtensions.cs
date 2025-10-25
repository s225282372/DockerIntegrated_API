using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using MyFirstAPI_Project.Infrastructure;

namespace MyFirstAPI_Project.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection collection)
        {
            collection.AddDbContext<DBContext>();
            return collection;
        }
    }
}
