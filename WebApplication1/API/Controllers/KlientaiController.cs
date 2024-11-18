using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Core.Models;
using WebApplication1.Core.Services;

namespace WebApplication1.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KlientaiController : ControllerBase
    {
        private readonly OrderService _klientaiService;
        public KlientaiController(OrderService klientaiService)
        {
            _klientaiService = klientaiService;
        }
        [HttpGet("GetAllClients")]
        public List<Klientas> Index()
        {
            return _klientaiService.GetAllClients();
        }
        [HttpGet("GetClientById")]
        public Klientas GetWorkerById(int clientId)
        {
            return _klientaiService.GetByClientId(clientId);
        }
        [HttpPost("CreateClient")]
        public void AddWorker(Klientas client)
        {
            _klientaiService.AddClient(client);
        }
        [HttpDelete("DeleteClient")]
        public void DeleteWorker(int id)
        {
            _klientaiService.DeleteClientById(id);
        }
    }
}
