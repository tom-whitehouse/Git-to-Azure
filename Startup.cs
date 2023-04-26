using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using System.IO;

namespace MyWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.Configure(app =>
                    {
                        app.UseRouting();

                        app.UseEndpoints(endpoints =>
                        {
                            endpoints.MapGet("/", async context =>
                            {
                                var fileProvider = new PhysicalFileProvider(Directory.GetCurrentDirectory());
                                var fileInfo = fileProvider.GetFileInfo("index.html");
                                using (var stream = fileInfo.CreateReadStream())
                                {
                                    context.Response.ContentType = "text/html";
                                    await stream.CopyToAsync(context.Response.Body);
                                }
                            });
                        });
                    });
                });
    }
}