using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Core.Models;
using WebApplication1.Core.Services;

namespace WebApplication1.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NuomosUzsakymaiController : ControllerBase
    {
        private readonly OrderService _nuomosUzsakymai;
        public NuomosUzsakymaiController(OrderService nuomosUzsakymai)
        {
            _nuomosUzsakymai = nuomosUzsakymai;
        }
        [HttpGet("GetAllOrders")]
        public List<NuomosUzsakymas> Index()
        {
            return _nuomosUzsakymai.GetAllOrders();
        }
        [HttpGet("GetOrderById")]
        public NuomosUzsakymas GetOrderById(int orderId)
        {
            return _nuomosUzsakymai.GetOrderById(orderId);
        }
        [HttpPost("CreateOrder")]
        public void AddOrder(NuomosUzsakymas order)
        {
            _nuomosUzsakymai.AddOrder(order);
        }
        [HttpDelete("DeleteOrder")]
        public void DeleteOrder(int id)
        {
            _nuomosUzsakymai.DeleteOrderById(id);
        }
    }
}
