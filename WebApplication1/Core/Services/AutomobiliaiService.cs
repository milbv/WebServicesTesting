using Microsoft.Data.SqlClient;
using WebApplication1.Core.Models;
using WebApplication1.Core.Repositories;

namespace WebApplication1.Core.Services
{
    public class AutomobiliaiService
    {
        private readonly ElektrinisAutomobilisRepository _elektrinisAutomobilis;
        private readonly NaftosAutomobilisRepository _naftosAutomobilis;
        public AutomobiliaiService(ElektrinisAutomobilisRepository elektrinisAutomobilisRepository, NaftosAutomobilisRepository naftosAutomobilisRepository)
        {
            _elektrinisAutomobilis = elektrinisAutomobilisRepository;
            _naftosAutomobilis = naftosAutomobilisRepository;
        }
        #region elektriniaiAutomobiliai
        public ElektrinisAutomobilis GetElectricCarById(int id)
        {
            return _elektrinisAutomobilis.GetById(id);
        }
        public List<ElektrinisAutomobilis> GetAllElectricCars()
        {
            return _elektrinisAutomobilis.GetAll();
        }
        public void AddElectricCar(ElektrinisAutomobilis car)
        {
            _elektrinisAutomobilis.Add(car);
        }
        public void DeleteElectricCar(int id)
        {
            _elektrinisAutomobilis.Delete(id);
        }
        public void UpdateElectricCar(ElektrinisAutomobilis car)
        {
            _elektrinisAutomobilis.Update(car);
        }
        #endregion

        #region NaftosAutomobiliai
        public NaftosAutomobilis GetPetrolCarById(int id)
        {
            return _naftosAutomobilis.GetById(id);
        }
        public List<NaftosAutomobilis> GetAllPetrolCars()
        {
            return _naftosAutomobilis.GetAll();
        }
        public void AddPetrolCar(NaftosAutomobilis car)
        {
            _naftosAutomobilis.Add(car);
        }
        public void DeletePetrolCar(int id)
        {
            _naftosAutomobilis.Delete(id);
        }
        public void UpdatePetrolCar(NaftosAutomobilis car)
        {
            _naftosAutomobilis.Update(car);
        }
        #endregion
    }
}
