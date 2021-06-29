﻿using AspNetCoreRateLimit;
using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;
using System.Text;
using WP.NetCore.Common;
using WP.NetCore.Common.Helper;
using WP.NetCore.Extensions.ServicesRegistration;

namespace WP.NetCore.Extensions
{

    public static class ServiceInfo
    {
        public static void AddConfigureServices(this IServiceCollection services, IConfiguration Configuration, IWebHostEnvironment Env)
        {
            var basePath = AppContext.BaseDirectory;
            services.AddSingleton(new Appsettings(Env.ContentRootPath));
            services.AddRedisCache();
            services.AddIpRateLimit(Configuration);
            services.AddEFCore();
            services.AddAutoMapper(typeof(ServiceInfo));
            services.AddSwagger();
            services.AddCorsPolicy();
            services.AddJwtAuthentication();
            services.AddHealthChecks().AddMySql(Appsettings.app(new string[] { "DBConnection" })); ;
            services.AddSignalRService();
            services.AddControllers(o =>
            {
                // 全局异常过滤
                o.Filters.Add(typeof(GlobalExceptionsFilter));
            })
            //全局配置Json序列化处理
            .AddNewtonsoftJson(options =>
            {
                //忽略循环引用
                options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                //不使用驼峰样式的key
                //options.SerializerSettings.ContractResolver = new DefaultContractResolver();
                options.SerializerSettings.ContractResolver = new CustomContractResolver();
                //设置时间格式
                options.SerializerSettings.DateFormatString = "yyyy-MM-dd HH:mm:ss";
                options.SerializerSettings.StringEscapeHandling = StringEscapeHandling.EscapeNonAscii;
            });
            services.AddSingleton<IRateLimitConfiguration, RateLimitConfiguration>();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

        }
    }
}