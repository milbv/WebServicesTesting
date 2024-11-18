namespace WebApplication1.Core.Models
{
    public class NuomosUzsakymas
    {
        public int Id { get; set; }
        public int KlientasId { get; set; }
        public int DarbuotojasId { get; set; }
        public int AutomobilisId { get; set; }
        public DateTime PradziosData { get; set; }
        public DateTime PabaigosData { get; set; }
        public decimal Kaina { get; set;}
        public NuomosUzsakymas(int id, int klientasId, int darbuotojasId, int automobilisId, DateTime pradziosData, DateTime pabaigosData, decimal kaina)
        {
            Id = id;
            KlientasId = klientasId;
            DarbuotojasId = darbuotojasId;
            AutomobilisId = automobilisId;
            PradziosData = pradziosData;
            PabaigosData = pabaigosData;
            Kaina = kaina;
        }

        public NuomosUzsakymas()
        {
        }
    }
}
