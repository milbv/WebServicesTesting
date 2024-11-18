using Dapper;
using Microsoft.Data.SqlClient;
using WebApplication1.Core.Models;

namespace WebApplication1.Core.Repositories
{
    public class KlientasRepository
    {
        private readonly string _connectionString;
        public KlientasRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public Klientas GetById(int id)
        {
            Klientas result = new Klientas();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                result = connection.QueryFirst<Klientas>("SELECT * FROM Klientai WHERE Id = @id", new { id });
            }
            return result;
        }
        public List<Klientas> GetAll()
        {
            List<Klientas> result = new List<Klientas>();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                result = connection.Query<Klientas>("SELECT * FROM Klientai").ToList();
            }
            return result;
        }
        public void Add(Klientas client)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.Execute("INSERT INTO Klientai (Vardas, Pavarde, ElPastas, Telefonas) VALUES (@Vardas, @Pavarde, @ElPastas, @Telefonas)", client);
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.Execute("DELETE FROM Klientai WHERE Id = @id", new { id });
            }
        }

        public void Update(Klientas client)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.Execute("UPDATE Klientai (Vardas, Pavarde, ElPastas, Telefonas) VALUES (@Vardas, @Pavarde, @ElPastas, @Telefonas) WHERE Id = @id", client);
            }
        }
    }
}
