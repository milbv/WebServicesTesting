using Dapper;
using Microsoft.Data.SqlClient;
using WebApplication1.Core.Models;

namespace WebApplication1.Core.Repositories
{
    public class NuomosUzsakymasRepository
    {
        private readonly string _connectionString;
        public NuomosUzsakymasRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public NuomosUzsakymas GetById(int id)
        {
            NuomosUzsakymas result = new NuomosUzsakymas();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                result = connection.QueryFirst<NuomosUzsakymas>("SELECT * FROM NuomosUzsakymai WHERE Id = @id", new { id });
            }
            return result;
        }
        public List<NuomosUzsakymas> GetAll()
        {
            List<NuomosUzsakymas> result = new List<NuomosUzsakymas>();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                result = connection.Query<NuomosUzsakymas>("SELECT * FROM NuomosUzsakymai").ToList();
            }
            return result;
        }
        public void Add(NuomosUzsakymas order)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.Execute("INSERT INTO NuomosUzsakymai (KlientasId, DarbuotojasId, NaftosAutomobilisId, ElektrinisAutomobilisId, PradziosData, PabaigosData, Kaina) VALUES (@KlientasId, @DarbuotojasId, @NaftosAutomobilisId, @ElektrinisAutomobilisId, @PradziosData, @PabaigosData, @Kaina)", order);
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.Execute("DELETE FROM NuomosUzsakymai WHERE Id = @id", new { id });
            }
        }

        public void Update(NuomosUzsakymas order)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.Execute("UPDATE NuomosUzsakymai (KlientasId, DarbuotojasId, NaftosAutomobilisId, ElektrinisAutomobilisId, PradziosData, PabaigosData, Kaina) VALUES (@KlientasId, @DarbuotojasId, @NaftosAutomobilisId, @ElektrinisAutomobilisId, @PradziosData, @PabaigosData, @Kaina) WHERE Id = @id", order);
            }
        }
    }
}
