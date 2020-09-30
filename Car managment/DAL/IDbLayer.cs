using Car_managment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_managment.DAL
{
    public interface IDbLayer
    {
        IEnumerable<Car> GetCars();
        IEnumerable<Team> GetTeams();

        void AddNewCar(Car newCar);

        void UpdateCar(int IdCar, Car newCar);
    }
}
