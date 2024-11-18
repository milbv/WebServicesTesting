namespace WebApplication1.Core.Models
{
    public class Automobilis
    {
        public int Id { get; set; }
        public string Pavadinimas { get; set; }
        public int Metai { get; set; }
        public decimal NuomosKaina { get; set; }

        public Automobilis(int id, string pavadinimas, int metai, decimal nuomosKaina)
        {
            Id = id;
            Pavadinimas = pavadinimas;
            Metai = metai;
            NuomosKaina = nuomosKaina;
        }
        public Automobilis()
        {

        }
    }
}
