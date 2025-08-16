using FarmaApi.Interfaces;
using FarmaApi.Service;

var builder = WebApplication.CreateBuilder(args);

// Adiciona serviços para a injeção de dependência
builder.Services.AddScoped<IClientService, ClientService>();

// Outras configurações da API (Swagger, Controllers, etc.)
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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