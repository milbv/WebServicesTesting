using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Core.Models;
using WebApplication1.Core.Services;

namespace WebApplication1.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DarbuotojaiController : ControllerBase
    {
        private readonly OrderService _darbuotojaiService;
        public DarbuotojaiController(OrderService darbuotojaiService)
        {
            _darbuotojaiService = darbuotojaiService;
        }
        [HttpGet("GetAllWorkers")]
        public List<Darbuotojas> Index()
        {
            return _darbuotojaiService.GetAllWorkers();
        }
        [HttpGet("GetWorkerById")]
        public Darbuotojas GetWorkerById(int workerId)
        {
            return _darbuotojaiService.GetWorkerById(workerId);
        }
        [HttpPost("CreateWorker")]
        public void AddWorker(Darbuotojas worker)
        {
            _darbuotojaiService.AddWorker(worker);
        }
        [HttpDelete("DeleteWorker")]
        public void DeleteWorker(int id)
        {
            _darbuotojaiService.DeleteWorkerById(id);
        }
    }
}
