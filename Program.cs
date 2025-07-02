using Microsoft.EntityFrameworkCore;

using web_tarefas.Repository;
using web_tarefas.Services;

namespace web_tarefas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // Configurar Entity Framework
            builder.Services.AddDbContext<TarefaContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
         
            builder.Services.AddTransient<ITarefaService, TarefaService>();

            builder.Services.AddScoped<ITarefaRepository, TarefaRepositoryEF>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Tarefas}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
