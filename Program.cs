var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => 
{
    // --- C# GEDEELTE START ---
    // Hier vragen we de server om de huidige tijd en de naam van de computer
    var serverTijd = DateTime.Now.ToString("HH:mm:ss");
    var datum = DateTime.Now.ToString("dd-MM-yyyy");
    var serverNaam = Environment.MachineName; // De naam van de SmarterASP server
    // --- C# GEDEELTE EIND ---

    // We stoppen die C# variabelen in een stukje HTML
    var html = $@"
    <!DOCTYPE html>
    <html>
    <head>
        <title>C# Test Geslaagd</title>
        <style>
            body {{ font-family: Arial, sans-serif; background-color: #222; color: white; text-align: center; padding-top: 50px; }}
            .box {{ border: 4px solid #00ff00; padding: 20px; display: inline-block; border-radius: 10px; background-color: #333; }}
            h1 {{ color: #00ff00; }}
            .data {{ font-size: 24px; font-weight: bold; margin: 10px 0; }}
            .small {{ color: #aaa; font-size: 14px; }}
        </style>
    </head>
    <body>
        <div class='box'>
            <h1>✅ C# WERKT!</h1>
            <p>Deze pagina is gegenereerd door C# code.</p>
            <hr>
            <p>Huidige Server Tijd:</p>
            <div class='data'>{serverTijd}</div>
            <p class='small'>Datum: {datum}</p>
            <br>
            <p class='small'>Server Naam: {serverNaam}</p>
        </div>
        <p>Ververs de pagina om de tijd te zien veranderen.</p>
    </body>
    </html>";

    // Dit vertelt de browser: 'Behandel dit als een webpagina'
    return Results.Content(html, "text/html");
});

app.Run();
