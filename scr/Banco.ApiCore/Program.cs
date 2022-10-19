using Banco.ApiCore.Configuration;
using Data.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.ResolveDependencies();

builder.Services.AddDbContext<MeuDbContext>(options =>
{
   
    options.UseMySql("server=localhost;initial catalog=BancoBB;uid=root;pwd=Root",
    Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.31-mysql"));


});

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
