namespace WebApplication1.Core.Models
{
    public class ElektrinisAutomobilis : Automobilis
    {
        public decimal BaterijosTalpa { get; set; }
        public int NuvaziuojamasAtstumas { get; set; }
        public decimal IkrovimoLaikas { get; set; }
        public ElektrinisAutomobilis(int id, string pavadinimas, int metai, decimal nuomosKaina, decimal baterijosTalpa, int nuvaziuojamasAtstumas, decimal ikrovimoLaikas)
        : base(id, pavadinimas, metai, nuomosKaina)
        {
            BaterijosTalpa = baterijosTalpa;
            NuvaziuojamasAtstumas = nuvaziuojamasAtstumas;
            IkrovimoLaikas = ikrovimoLaikas;
        }
        public ElektrinisAutomobilis()
        {

        }
    }
}
