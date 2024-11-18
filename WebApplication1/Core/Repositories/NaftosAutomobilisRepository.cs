using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Core.Models;
using static WebApplication1.Core.Repositories.NaftosAutomobilisRepository;
namespace WebApplication1.Core.Repositories

{
    public class NaftosAutomobilisRepository
    {
        private readonly string _connectionString;
        public NaftosAutomobilisRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public NaftosAutomobilis GetById(int id)
        {
            NaftosAutomobilis result = new NaftosAutomobilis();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                result = connection.QueryFirst<NaftosAutomobilis>("SELECT * FROM NaftosAutomobiliai WHERE Id = @id", new {id});
            }
            return result;
        }
        public List<NaftosAutomobilis> GetAll()
        {
            List<NaftosAutomobilis> result = new List<NaftosAutomobilis>();
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                result = connection.Query<NaftosAutomobilis>("SELECT * FROM NaftosAutomobiliai").ToList();
            }
            return result;
        }
        public void Add(NaftosAutomobilis car) 
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.Execute("INSERT INTO NaftosAutomobiliai (Pavadinimas, Metai, NuomosKaina, VariklioTuris, DegaluTipas, CO2Ismetimas) VALUES (@Pavadinimas, @Metai, @NuomosKaina, @VariklioTuris, @DegaluTipas, @CO2Ismetimas)", car);
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.Execute("DELETE FROM NaftosAutomobiliai WHERE Id = @id", new { id });
            }
        }

        public void Update(NaftosAutomobilis car)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.Execute("UPDATE NaftosAutomobiliai (Pavadinimas, Metai, NuomosKaina, VariklioTuris, DegaluTipas, CO2Ismetimas) VALUES (@Pavadinimas, @Metai, @NuomosKaina, @VariklioTuris, @DegaluTipas, @CO2Ismetimas) WHERE Id = @id", car);
            }
        }
    }
}
