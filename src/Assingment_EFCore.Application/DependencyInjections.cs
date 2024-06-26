﻿using Assingment_EFCore.Application.Core.Services;
using Assingment_EFCore.Application.Interfaces;
using Assingment_EFCore.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Assingment_EFCore.Application
{
    public class DependencyInjections
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IEmployeeSerivce, EmployeeService>();
            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<ISalaryService, SalaryService>();
            services.AddScoped<IProjectService, ProjectService>();
        }
    }
}