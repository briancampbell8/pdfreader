var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Map the OAuth redirect endpoint.
app.MapGet("/redirect", (string code) =>
{
    // Optionally, use the 'code' to fetch an access token.
    return $"Redirect successful. Code received: {code}";
});

app.Run();
