using Hagi.Robust; // nuget

string GetApplicationVersion()
{
    const string versionFilePath = "version.txt";
    const string fallbackVersion = AuthService.ApiVersion.Current;

    try
    {
        if (File.Exists(versionFilePath))
        {
            return File.ReadAllText(versionFilePath).Trim();
        }
    }
    catch (Exception)
    {
        // If reading fails, fall back to ApiVersion
    }

    return fallbackVersion;
}

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOpenApi();
builder.Services.AddHagiResilience(); // add rubostness from our nuget

var app = builder.Build();

var applicationVersion = GetApplicationVersion();
app.Logger.LogInformation("AuthService v{Version} starting...", applicationVersion);

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapControllers();

// Ping endpoint
app.MapGet("/ping", () => "pong");

// Version endpoint
app.MapGet("/version", () => new { service = "AuthService", version = applicationVersion });

app.MapReadinessEndpoint(); // add end point readyness from our nuget

app.Run();