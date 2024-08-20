using Business.Abstracts;
using Business.Concrete;
using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;

namespace API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //systemtext 
            //builder.Services.AddControllers()
            //    .AddNewtonsoftJson(opt =>
            //    {
            //        opt.SerializerSettings.Converters.Add(new StringEnumConverter());
            //    });
            builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
    });

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IUserServices, Services>();

            var app = builder.Build();

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
