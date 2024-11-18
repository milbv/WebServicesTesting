using System;
using WebApplication1.Core.Repositories;
using WebApplication1.Core.Services;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            DarbuotojasRepository darbuotojasRepository = new DarbuotojasRepository("Server=MIL;Database=AutomobiliuNuoma;Trusted_Connection=True;TrustServerCertificate=true;");
            KlientasRepository klientasRepository = new KlientasRepository("Server=MIL;Database=AutomobiliuNuoma;Trusted_Connection=True;TrustServerCertificate=true;");
            ElektrinisAutomobilisRepository elektrinisAutomobilisRepository = new ElektrinisAutomobilisRepository("Server=MIL;Database=AutomobiliuNuoma;Trusted_Connection=True;TrustServerCertificate=true;");
            NaftosAutomobilisRepository naftosAutomobilisRepository = new NaftosAutomobilisRepository("Server=MIL;Database=AutomobiliuNuoma;Trusted_Connection=True;TrustServerCertificate=true;");
            NuomosUzsakymasRepository nuomosUzsakymasRepository = new NuomosUzsakymasRepository("Server=MIL;Database=AutomobiliuNuoma;Trusted_Connection=True;TrustServerCertificate=true;");
            AutomobiliaiService automobiliaiService = new AutomobiliaiService(elektrinisAutomobilisRepository, naftosAutomobilisRepository);
            OrderService orderService = new OrderService(darbuotojasRepository, klientasRepository, nuomosUzsakymasRepository);

            builder.Services.AddTransient<DarbuotojasRepository>(x => new DarbuotojasRepository("Server=MIL;Database=AutomobiliuNuoma;Trusted_Connection=True;TrustServerCertificate=true;"));
            builder.Services.AddTransient<KlientasRepository>(x => new KlientasRepository("Server=MIL;Database=AutomobiliuNuoma;Trusted_Connection=True;TrustServerCertificate=true;"));
            builder.Services.AddTransient<ElektrinisAutomobilisRepository>(x => new ElektrinisAutomobilisRepository("Server=MIL;Database=AutomobiliuNuoma;Trusted_Connection=True;TrustServerCertificate=true;"));
            builder.Services.AddTransient<NaftosAutomobilisRepository>(x => new NaftosAutomobilisRepository("Server=MIL;Database=AutomobiliuNuoma;Trusted_Connection=True;TrustServerCertificate=true;"));
            builder.Services.AddTransient<NuomosUzsakymasRepository>(x => new NuomosUzsakymasRepository("Server=MIL;Database=AutomobiliuNuoma;Trusted_Connection=True;TrustServerCertificate=true;"));
            builder.Services.AddTransient<AutomobiliaiService>();
            builder.Services.AddTransient<OrderService>();
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
