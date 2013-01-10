using System.Collections.Generic;

namespace Antykwariat.Models
{
    public partial class Gatunek
    {
        public int GatunekId { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public List<Ksiazka> Ksiazki { get; set; }
    }
}
