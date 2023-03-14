using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day7
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        //add services to di container for using inside app by injection
        //contain all services [form json files + some services from startup]
        public void ConfigureServices(IServiceCollection services)
        {
            //contain around 81 services [built in] 
            //add service to work app as MVC
            //services.AddMvc();


            //like services.AddMvc() but have dataannotation and views 
            services.AddControllersWithViews();//became 280 service


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //first middelware in our pipline for any exception
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();//Middelware for "Error Handling"
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            
            }

            /*
            //To add spacific page

            DefaultFilesOptions options= new DefaultFilesOptions();
            options.DefaultFileNames.Clear();
            options.DefaultFileNames.Add("page1.html");
            app.UseDefaultFiles(options);*/



            app.UseDefaultFiles();//middelware to allow to open the app with default page as startup page   or index   or spacefic page
            app.UseStaticFiles();//middelware for use static files -> Look at wwwroot folder

            ///Middelware for routing 
            app.UseRouting();//create routing table , Contains from endpoints 

           // app.UseAuthorization();

            app.UseEndpoints(endpoints =>//Add Routs 
            {
                //MVC Way
                endpoints.MapDefaultControllerRoute();//add endpoint to route table work as mvc   controller/action name/{id}


                //Ka2eny 3amel action 3aleha httpget and get it by default route
                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello Basma :)");
                //});
            });
        }

    }
}
