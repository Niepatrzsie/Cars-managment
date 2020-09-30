using Car_managment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Car_managment.DAL
{
    public class SqlServerDbContext : IDbLayer
    {
        private readonly CarDbContext _context;
        public SqlServerDbContext(CarDbContext context)
        {
            _context = context;
        }
        public void AddNewCar(Car newCar)
        {
            _context.Cars.Add(newCar);
            _context.SaveChanges();
        }

        public IEnumerable<Car> GetCars()
        {
            return _context.Cars
                           .Include(c => c.Team)
                           .OrderBy(c => c.Brand)
                           .ToList();
        }

        public IEnumerable<Team> GetTeams()
        {
            return _context.Teams.OrderBy(t => t.Name).ToList();
        }

        public void UpdateCar(int IdCar, Car updatedCar)
        {
            _context.Cars.Attach(updatedCar);
            _context.Entry(updatedCar).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
