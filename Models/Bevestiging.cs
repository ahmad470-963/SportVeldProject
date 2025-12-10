using System.ComponentModel.DataAnnotations;

namespace Central_Sports.Models
{
    public class Bevestiging
    {
        public string Baan { get; set; }
        public string Tijd { get; set; }
     
        public string Betaalmethode { get; set; }
        public string Gebruikersnaam { get; set; }
    }
}
