using Domain.Interface;
using Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossCurtting.IOC
{
    public static class Injector
    {
        public static void AddDependencyInjectionConfig(this IServiceCollection services)
        {
            services.AddScoped(typeof(IDashboardService), typeof(DashboardService));
            services.AddScoped(typeof(IBaseRepository<>), typeof(IBaseRepository<>));
            services.AddScoped(typeof(IPatientService), typeof(PatientService));
            services.AddScoped(typeof(IPatientRepository), typeof(PatientRepository));
            services.AddScoped(typeof(ICarService), typeof(CarService));
            services.AddScoped(typeof(ICarRepostory), typeof(ICarRepository));
        }
    }
}