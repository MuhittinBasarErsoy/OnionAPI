using FluentValidation.AspNetCore;
using OnionAPI.API.Extensions;
using OnionAPI.Application;
using OnionAPI.Application.Validators.Products;
using OnionAPI.Infrastructure.Filters;
using OnionAPI.Persistence;
using Serilog;
using Serilog.Core;
using Serilog.Events;
using Serilog.Sinks.MSSqlServer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddPersistenceServices();
builder.Services.AddApplicationServices();
builder.Services.AddControllers(opt=>opt.Filters.Add<ValidationFilter>()).AddFluentValidation(conf=>conf.RegisterValidatorsFromAssemblyContaining<CreateProductValidator>()).ConfigureApiBehaviorOptions(opt=>opt.SuppressModelStateInvalidFilter =true);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
Logger log = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File("logs/log.txt")
    .WriteTo.MSSqlServer(builder.Configuration.GetConnectionString("SQLServer"), sinkOptions: new MSSqlServerSinkOptions { TableName = "Log", AutoCreateSqlTable = true }
    , null, null, LogEventLevel.Verbose, null, null, null, null)
    .CreateLogger();
builder.Host.UseSerilog(log);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.ConfigureExceptionHandler(log);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
