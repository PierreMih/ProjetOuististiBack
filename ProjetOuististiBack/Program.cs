using ProjetOuististiDomain.Calcul;
using ProjetOuististiEntityFramework.Repositories;

var builder = WebApplication.CreateBuilder(args);

string corsName = "OuististiCors";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: corsName,
                        policy =>
                        {
                            policy.AllowAnyOrigin();
                            policy.AllowAnyHeader();
                        });
});
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<ICalculRepository,CalculRepository>();
builder.Services.AddTransient<CalculManager>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(corsName);

app.UseAuthorization();

app.MapControllers();

app.Run();
