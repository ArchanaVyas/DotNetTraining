using NetTrainingJan.Middleware;
using NetTrainingJan.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddService();
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddSingleton<IWeatherService, WeatherService>();
//builder.Services.AddSingleton<IWeatherService, WeatherService>();
//builder.Services.AddTransient<IEmployeeService, EmployeeService>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();
app.UseCustomMiddlewares();

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
