using DOMS.Interface.Repository;
using DOMS.Interface.Service;
using DOMS.Repository;
using DOMS.Service;
using Microsoft.Extensions.DependencyInjection;

namespace Microsoft.AspNetCore.Mvc
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDomsRepositories(this IServiceCollection services)
        {
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IBrandRepository, BrandRepository>();
            services.AddScoped<IFamilyRepository, FamilyRepository>();
            services.AddScoped<ICatalogueRepository, CatalogueRepository>();
            services.AddScoped<IDeliveryRepository, DeliveryRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<ICountryRepository, CountryRepository>();
            services.AddScoped<ICourierRepository, CourierRepository>();

            return services;
        }

        public static IServiceCollection AddDomsServices(this IServiceCollection services)
        {
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IBrandService, BrandService>();
            services.AddScoped<IFamilyService, FamilyService>();
            services.AddScoped<ICatalogueService, CatalogueService>();
            services.AddScoped<IDeliveryService, DeliveryService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<ICourierService, CourierService>();
            services.AddScoped<ICountryService, CountryService>();

            return services;
        }

    }
}