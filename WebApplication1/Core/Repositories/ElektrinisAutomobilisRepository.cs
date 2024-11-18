using Dapper;
using Microsoft.Data.SqlClient;
using WebApplication1.Core.Models;

namespace WebApplication1.Core.Repositories
{
    public class ElektrinisAutomobilisRepository
    {
        private readonly string _connectionString;
        public ElektrinisAutomobilisRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public ElektrinisAutomobilis GetById(int id)
        {
            ElektrinisAutomobilis result = new ElektrinisAutomobilis();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                result = connection.QueryFirst<ElektrinisAutomobilis>("SELECT * FROM ElektriniaiAutomobiliai WHERE Id = @id", new { id });
            }
            return result;
        }
        public List<ElektrinisAutomobilis> GetAll()
        {
            List<ElektrinisAutomobilis> result = new List<ElektrinisAutomobilis>();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                result = connection.Query<ElektrinisAutomobilis>("SELECT * FROM ElektriniaiAutomobiliai").ToList();
            }
            return result;
        }
        public void Add(ElektrinisAutomobilis car)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.Execute("INSERT INTO ElektriniaiAutomobiliai (Pavadinimas, Metai, NuomosKaina, BaterijosTalpa, MaxNuvaziuojamasAtstumas, IkrovimoLaikas) VALUES (@Pavadinimas, @Metai, @NuomosKaina, @BaterijosTalpa, @MaxNuvaziuojamasAtstumas, @IkrovimoLaikas)", car);
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.Execute("DELETE FROM ElektriniaiAutomobiliai WHERE Id = @id", new { id });
            }
        }

        public void Update(ElektrinisAutomobilis car)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.Execute("UPDATE ElektriniaiAutomobiliai (Pavadinimas, Metai, NuomosKaina, BaterijosTalpa, MaxNuvaziuojamasAtstumas, IkrovimoLaikas) VALUES (@Pavadinimas, @Metai, @NuomosKaina, @BaterijosTalpa, @MaxNuvaziuojamasAtstumas, @IkrovimoLaikas) WHERE Id = @id", car);
            }
        }
    }
}
