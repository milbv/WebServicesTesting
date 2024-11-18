using Dapper;
using Microsoft.Data.SqlClient;
using WebApplication1.Core.Models;

namespace WebApplication1.Core.Repositories
{
    public class DarbuotojasRepository
    {
        private readonly string _connectionString;
        public DarbuotojasRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public Darbuotojas GetById(int id)
        {
            Darbuotojas result = new Darbuotojas();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                result = connection.QueryFirst<Darbuotojas>("SELECT * FROM Darbuotojai WHERE Id = @id", new { id });
            }
            return result;
        }
        public List<Darbuotojas> GetAll()
        {
            List<Darbuotojas> result = new List<Darbuotojas>();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                result = connection.Query<Darbuotojas>("SELECT * FROM Darbuotojai").ToList();
            }
            return result;
        }
        public void Add(Darbuotojas worker)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.Execute("INSERT INTO Darbuotojai (Vardas, Pavarde, Pareigos) VALUES (@Vardas, @Pavarde, @Pareigos)", worker);
            }
        }

        public void DeleteById(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.Execute("DELETE FROM Darbuotojai WHERE Id = @id", new { id });
            }
        }

        public void Update(Darbuotojas worker)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.Execute("UPDATE Darbuotojai(Vardas, Pavarde, Pareigos) VALUES (@Vardas, @Pavarde, @Pareigos) WHERE Id = @id", worker);
            }
        }
    }
}
