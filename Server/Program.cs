using Shared.Contracts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGrpcClient<IGreeterService>(o =>
{
    o.Address = new Uri("https://localhost:7218");
});

var app = builder.Build();
app.MapControllers();
app.Run();
