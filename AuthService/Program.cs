using Hagi.Robust; // nuget

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenApi();
builder.Services.AddHagiResilience(); // add rubostness from our nuget

var app = builder.Build();

app.Logger.LogInformation("AuthService v{Version} starting...", AuthService.ApiVersion.Current);

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapControllers();

// Ping endpoint
app.MapGet("/ping", () => "pong");

// Version endpoint
app.MapGet("/version", () => new { service = "AuthService", version = AuthService.ApiVersion.Current });

app.MapReadinessEndpoint(); // add end point readyness from our nuget

app.Run();