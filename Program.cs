using API_Psychologist.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


// Получаем строку подключения из файла конфигурации
string? connection = builder.Configuration.GetConnectionString("Default");
// Получаем версию сервера. Только для MySQL.
ServerVersion serverVerstion = ServerVersion.AutoDetect(connection);
// Добавляем контекст ApplicationContext  качестве сервиса в приложение
builder.Services.AddDbContext<ApplicationContext>(
        dbContextOption => dbContextOption
            .UseMySql(connection, serverVerstion)
            // The following three options help with debagging, but should
            // be changed or removed for production
            .LogTo(Console.WriteLine, LogLevel.Information)
            .EnableSensitiveDataLogging()
            .EnableDetailedErrors()
);


// Add services to the container.
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

// устанавливаем сопоставление маршрутов с контроллерами
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Users}/{action=Get}/{id?}"
    );

app.Run();
