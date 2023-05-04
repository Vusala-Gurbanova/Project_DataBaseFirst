using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Project_DataBaseFirst.Models;

namespace Project_DataBaseFirst.Controllers
{
    
    [ApiController]
    public class CarsSaleController : ControllerBase
    {
        DBGR96Context data = new DBGR96Context();

        [Route("api/[controller]")]
        [HttpGet]
        public List<CarsForSale> Get()
        {
            return data.CarsForSales.ToList();
        }

        [Route("api/[controller]/{id}")]
        [HttpGet]

        public CarsForSale Get(int id)
        {
            CarsForSale car = data.CarsForSales.Find(id);
            return car;
        }

        [Route("api/[controller]")]
        [HttpPost]

        public string Create(CarsForSale car)
        {
            string result = "";
            try
            {
                data.CarsForSales.Add(car);
                data.SaveChanges();
                return result;
            }
            catch (Exception ex)
            {
                result = ex.Message;
            }
            finally
            {
                data.Dispose();
            }
            return result;
        }

        [Route("api/[controller]/{id}")]
        [HttpPut]
        public string Update(int id, CarsForSale cars)
        {
            string result = "";
            try
            {
                var car = data.CarsForSales.Find(id);
                car.Brand = cars.Brand;
                car.Model = cars.Model;
                car.ProductionYear = cars.ProductionYear;
                car.EngineSize = cars.EngineSize;
                car.Color = car.Color;
                car.CarType = cars.CarType;
                car.Mileage = cars.Mileage;
                data.SaveChanges();
                result = "success";
            }
            catch (SqlException)
            {
                result = "error";
            }
            finally
            {
                data.Dispose();
            }
            return result;
        }

        [Route("api/[controller]/{id}")]
        [HttpDelete]

        public string Delete(int id)
        {
            var delete = data.CarsForSales.Find(id);
            string result = "";
            try
            {
                data.Remove(delete);
                data.SaveChanges();
                result = "success";

            }
            catch (SqlException)
            {
                result = "error";
                throw;
            }
            finally
            {
                data.Dispose();
            }
            return result;
        }
    }
}

