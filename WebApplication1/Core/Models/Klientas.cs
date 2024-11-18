namespace WebApplication1.Core.Models
{
    public class Klientas
    {
        public int Id { get; set; }
        public string Vardas { get; set; }
        public string Pavarde { get; set; }
        public string ElPastas { get; set; }
        public string Telefonas { get; set; }

        public Klientas(int id, string vardas, string pavarde, string elPastas, string telefonas)
        {
            Id = id;
            Vardas = vardas;
            Pavarde = pavarde;
            ElPastas = elPastas;
            Telefonas = telefonas;
        }

        public Klientas()
        {
        }
    }
}
