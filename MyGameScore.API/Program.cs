using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MyGameScore.Application.Commands.CreateMatch;
using MyGameScore.Application.Validators;
using MyGameScore.Core.Repositories;
using MyGameScore.Infrastructure.Persistence;
using MyGameScore.Infrastructure.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("MyGameScoreCs");
builder.Services.AddDbContext<MyGameScoreDbContext>(options => options.UseSqlServer(connectionString));

// Add services to the container.
builder.Services.AddScoped<IMatchRepository, MatchRepository>();
builder.Services.AddScoped<IPlayerRepository, PlayerRepository>();

builder.Services.AddControllers()
    .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<CreateMatchCommandValidator>());

builder.Services.AddMediatR(typeof(CreateMatchCommand));

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
