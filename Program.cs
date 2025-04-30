
namespace MOD10_103022300125
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // menambahkan layanan untuk controller  HTTP
            builder.Services.AddControllers();
            // menambahkan layanan untuk eksplorasi endpoint API dan dokumentasi Swagger
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // CMengonfigurasi pipeline permintaan HTTP
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection(); // mengalihkan semua permintaan HTTP ke HTTPS

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
