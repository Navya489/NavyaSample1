using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;

namespace NavyaPortfolio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Register Razor Pages service
            builder.Services.AddRazorPages();

            var app = builder.Build();

            // Use static files (for CSS, JS, images)
            app.UseStaticFiles();

            // Routing setup
            app.UseRouting();

            // Redirect root URL to /Index
            app.MapGet("/", context =>
            {
                context.Response.Redirect("/Index");
                return Task.CompletedTask;
            });

            // Map Razor Pages
            app.MapRazorPages();

            // Run the application
            app.Run();
        }
    }
}
