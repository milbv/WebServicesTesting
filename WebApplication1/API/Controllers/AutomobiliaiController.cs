using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Core.Models;
using WebApplication1.Core.Services;

namespace WebApplication1.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutomobiliaiController : ControllerBase
    {
        private readonly AutomobiliaiService _automobiliaiService;
        public AutomobiliaiController(AutomobiliaiService automobiliaiService)
        {
            _automobiliaiService = automobiliaiService;
        }
        [HttpGet("GetAllElectricCars")]
        public List<ElektrinisAutomobilis> IndexElectricCar ()
        {
            return _automobiliaiService.GetAllElectricCars();
        }
        [HttpGet("GetAllPetrolCars")]
        public List<NaftosAutomobilis> IndexPetrolCar()
        {
            return _automobiliaiService.GetAllPetrolCars();
        }
        [HttpGet("GetElectricCarById")]
        public ElektrinisAutomobilis GetElektrinisAutomobilisById(int id)
        {
            return _automobiliaiService.GetElectricCarById(id);
        }
        [HttpGet("GetPetrolCarById")]
        public NaftosAutomobilis GetNaftosAutomobilisById(int id)
        {
            return _automobiliaiService.GetPetrolCarById(id);
        }
        [HttpPost("CreateElectricCar")]
        public void AddElectricCar(ElektrinisAutomobilis elektrinisAutomobilis)
        {
            _automobiliaiService.AddElectricCar(elektrinisAutomobilis);
        }
        [HttpPost("CreatePetrolCar")]
        public void AddPetrolCar(NaftosAutomobilis naftosAutomobilis)
        {
            _automobiliaiService.AddPetrolCar(naftosAutomobilis);
        }
        [HttpDelete("DeleteElectricCar")]
        public void DeleteElectricCar(int id)
        {
            _automobiliaiService.DeleteElectricCar(id);
        }
        [HttpDelete("DeletePetrolCar")]
        public void DeletePetrolCar(int id)
        {
            _automobiliaiService.DeletePetrolCar(id);
        }
    }
}
