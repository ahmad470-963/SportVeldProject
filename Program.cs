var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// 1. Dit zorgt dat het Software-team straks HTML-bestanden kan gebruiken
app.UseDefaultFiles();
app.UseStaticFiles();

// 2. DIT IS DE FIX: Een duidelijke boodschap op de startpagina ("/")
app.MapGet("/", () => "HOERA! De server werkt! 🟢\n\nInfra Team: De pipeline is geslaagd.\nSoftware Team: Jullie kunnen nu jullie eigen code pushen.");

app.Run();
