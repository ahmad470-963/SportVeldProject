var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// 1. Zorg dat de server in de wwwroot map mag kijken
app.UseStaticFiles();

// 2. (Optioneel) Als iemand geen bestandsnaam typt, zoek dan naar index.html of default.html
app.UseDefaultFiles(); 

app.Run();
