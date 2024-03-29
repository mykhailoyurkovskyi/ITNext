﻿using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Shop.MVC.Interfaces;
using Shop.MVC.Services;
using WebProjectOnAzure.Data;
using WebProjectOnAzure.Services;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ConfigServiceCollectionExtensions
        {
           public static IServiceCollection AddConfig(this IServiceCollection services, IConfiguration config)
            {
                services.Configure<IdentityOptions>(options =>
                {
                    // Password settings.
                    options.Password.RequireDigit = true;
                    options.Password.RequireLowercase = true;
                    options.Password.RequireNonAlphanumeric = true;
                    options.Password.RequireUppercase = true;
                    options.Password.RequiredLength = 6;
                    options.Password.RequiredUniqueChars = 1;

                    // Lockout settings.
                    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                    options.Lockout.MaxFailedAccessAttempts = 5;
                    options.Lockout.AllowedForNewUsers = true;

                    // User settings.
                    options.User.AllowedUserNameCharacters =
                    "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                    options.User.RequireUniqueEmail = false;
                });

            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(5);

                options.LoginPath = "/Identity/Account/Login";
                options.AccessDeniedPath = "/Identity/Account/AccessDenied";
                options.SlidingExpiration = true;
            });

            return services;
            }
        public static IServiceCollection AddDependencyGroup(
             this IServiceCollection services)
        {
            services.AddScoped<ITShopService>();
            services.AddScoped<IProductService, ProductService>();
            
       
            return services;
        }

    }
    }

