using Microsoft.EntityFrameworkCore;
using Nttd2410900020_exam.Models;
namespace Nttd2410900020_exam
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Đăng ký DbContext đọc từ appsettings.json
            var connectionString = builder.Configuration.GetConnectionString("Nttd2410900020ExamDpContext");
            builder.Services.AddDbContext<Nttd2410900020ExamDpContext>(options =>
                options.UseSqlServer(connectionString));

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}

    