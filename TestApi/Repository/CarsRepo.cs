using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApi.Models;

namespace TestApi.Repository
{
    public class CarsRepo : IRepository<CarModel>
    {
        private readonly WebApiCoreContext context;
        public IEnumerable<CarModel> All => context.CarModels.ToList();
        public CarsRepo(WebApiCoreContext context)
        {
            this.context = context;
        }
        public void Add(CarModel entity)
        {
            context.CarModels.Add(entity);
        }
        public void Delete(CarModel entity)
        {
            context.CarModels.Remove(entity);
            context.SaveChanges();
        }
        public CarModel FindById(string Id)
        {
            throw new System.NotImplementedException();
        }
        public void Update(CarModel entity)
        {
            context.CarModels.Update(entity);
            context.SaveChanges();
        }
        public CarModel FindById(int Id)
        {
            return context.CarModels.FirstOrDefault(e => e.Id == Id);
        }
    }
}
