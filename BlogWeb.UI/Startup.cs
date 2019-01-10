using Application.Interfaces;
using Application.Queries.GetAllPosts;
using Application.Queries.Services;
using AutoMapper;
using BlogWeb.UI.StartupConfig;
using Infrastructure.RepositoryService;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Data;
using System.Collections.Generic;
using System.Reflection;

namespace BlogWeb.UI
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddCookiePolicy();
            services.AddDatabase();
            services.AddAutoMapper();
            services.AddMediatR(typeof(GetAllPostsQueryHandler).GetTypeInfo().Assembly);
            services.AddScoped(typeof(IPostRepository), typeof(PostRepository));
            services.AddScoped(typeof(IPostRepositoryMediator), typeof(GetPostQueryService));
           
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, PostContext context)
        {

            context.Database.EnsureCreated();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "PostRoute",
                    template: "{controller}/{action}/{id?}",
                    defaults: new { controller = "Post", action = "Index" },
                    constraints: new { id = "[0-9]+" });
                    
            });
        }
    }
}
