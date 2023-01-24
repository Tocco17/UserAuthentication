using Serilog;
using UserAuthentication.api.Contexts;
using UserAuthentication.api.Repositories;

var builder = WebApplication.CreateBuilder(args);

#region LOG
Log.Logger = new LoggerConfiguration()
	.MinimumLevel.Debug()
	.WriteTo.Console()
	.WriteTo.File("logs/userauth.txt", rollingInterval: RollingInterval.Day)
	.CreateLogger();

builder.Host.UseSerilog();
#endregion

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
#region SERVICES
builder.Services
	.AddControllers(options =>
	{
		options.ReturnHttpNotAcceptable = true;
	})
	.AddNewtonsoftJson();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddSingleton<UserAuthenticationContext>();
builder.Services.AddSingleton<IContext, UserAuthenticationContext>();

builder.Services.AddSingleton<IUserRepository, UserRepository>();
#endregion

#region APP
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();
#endregion