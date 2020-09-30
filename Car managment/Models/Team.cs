using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Car_managment.Models
{
    public class Team
    {
        [Key]
        public int IdTeam { get; set; }
        
        public string Name { get; set; }
        
        public ICollection<Car> cars { get; set; } 
    }
}
