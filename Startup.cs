using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;

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
                            await context.Response.WriteAsync("<html><body><h1>Hello, world!!!!</h1>\n<h2>Heading</h2>\n<p>Gardening is my favourite hobby. I own a small plot of land next to our house. I cultivate gardening there. Every day, I spend half an hour gardening. After returning from my morning walk, I go to my garden with a spade and a bucket of water. I prepare the soil, prune the plants, and water them. I also use insecticides and fertilisers. My heart leaps with joy when I see the plants swaying in the wind. I feel heavenly pleasure as I watch them grow day by day.</p></body></html>");
                        });
                    });
                });
            });
}