using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using APIContactList.Server.Data;
using APIContactList.Server.Areas.Identity.Data;
namespace APIContactList.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("APIContactListServerContextConnection") ?? throw new InvalidOperationException("Connection string 'APIContactListServerContextConnection' not found.");
                
            builder.Services.AddDbContext<APIContactListServerContext>(options => options.UseSqlServer(connectionString));

            builder.Services.AddDefaultIdentity<APIContactListServerUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<APIContactListServerContext>();

            // Add services to the container.

            builder.Services.AddControllers();

            var app = builder.Build();

            app.UseDefaultFiles();
            app.UseStaticFiles();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.MapFallbackToFile("/index.html");

            app.Run();
        }
    }
}
