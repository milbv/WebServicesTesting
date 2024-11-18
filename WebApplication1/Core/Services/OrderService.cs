using Dapper;
using Microsoft.Data.SqlClient;
using WebApplication1.Core.Models;
using WebApplication1.Core.Repositories;

namespace WebApplication1.Core.Services
{
    public class OrderService
    {
        private readonly DarbuotojasRepository _darbuotojasRepository;
        private readonly KlientasRepository _klientasRepository;
        private readonly NuomosUzsakymasRepository _nuomosUzsakymas;
        public OrderService(DarbuotojasRepository darbuotojasRepository, KlientasRepository klientasRepository, NuomosUzsakymasRepository nuomosUzsakymas)
        {
            _darbuotojasRepository = darbuotojasRepository;
            _klientasRepository = klientasRepository;
            _nuomosUzsakymas = nuomosUzsakymas;
        }
        public Darbuotojas GetWorkerById(int id)
        {
            return _darbuotojasRepository.GetById(id);
        }
        public List<Darbuotojas> GetAllWorkers()
        {
            return _darbuotojasRepository.GetAll();
        }
        public void AddWorker(Darbuotojas worker)
        {
            _darbuotojasRepository.Add(worker);
        }

        public void DeleteWorkerById(int id)
        {
            _darbuotojasRepository.DeleteById(id);
        }

        public void UpdateWorker(Darbuotojas worker)
        {
            _darbuotojasRepository.Update(worker);
        }

        public Klientas GetByClientId(int id)
        {
            return _klientasRepository.GetById(id);
        }
        public List<Klientas> GetAllClients()
        {
            return _klientasRepository.GetAll();
        }
        public void AddClient(Klientas client)
        {
            _klientasRepository.Add(client);
        }

        public void DeleteClientById(int id)
        {
            _klientasRepository.Delete(id);
        }

        public void UpdateClient(Klientas client)
        {
            _klientasRepository.Update(client);
        }

        public NuomosUzsakymas GetOrderById(int id)
        {
            return _nuomosUzsakymas.GetById(id);
        }
        public List<NuomosUzsakymas> GetAllOrders()
        {
            return _nuomosUzsakymas.GetAll();
        }
        public void AddOrder(NuomosUzsakymas order)
        {
            _nuomosUzsakymas.Add(order);
        }

        public void DeleteOrderById(int id)
        {
            _nuomosUzsakymas.Delete(id);
        }

        public void UpdateOrder(NuomosUzsakymas order)
        {
            _nuomosUzsakymas.Update(order);
        }
    }
}
