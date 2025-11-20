var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => 
{
    var serverTijd = DateTime.Now.ToString("HH:mm:ss");
    var datum = DateTime.Now.ToString("dd-MM-yyyy");
    var serverNaam = Environment.MachineName;

    var html = $@"
    <!DOCTYPE html>
    <html>
    <head>
        <title>Update Test</title>
        <style>
            body {{ font-family: Arial, sans-serif; background-color: #222; color: white; text-align: center; padding-top: 50px; }}
            .box {{ border: 4px solid #FFA500; padding: 20px; display: inline-block; border-radius: 10px; background-color: #333; }}
            h1 {{ color: #FFA500; }} /* Oranje voor de verandering */
            .data {{ font-size: 24px; font-weight: bold; margin: 10px 0; }}
            .small {{ color: #aaa; font-size: 14px; }}
        </style>
    </head>
    <body>
        <div class='box'>
            <h1>🚀 VERSIE 2 IS LIVE!</h1>
            <p>Als je dit ziet, werkt de GitHub Pipeline automatisch.</p>
            <hr>
            <p>Huidige Server Tijd:</p>
            <div class='data'>{serverTijd}</div>
            <p class='small'>Datum: {datum}</p>
            <br>
            <p class='small'>Server Naam: {serverNaam}</p>
        </div>
    </body>
    </html>";

    // Let op: charset=utf-8 toegevoegd voor de emoji's!
    return Results.Content(html, "text/html; charset=utf-8");
});

app.Run();
