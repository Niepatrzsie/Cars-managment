using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Car_managment.Models
{
    public class Car
    {
        [Key]
        public int IdCar { get; set; }
        [Required, MaxLength(45)]
        [Display(Name ="Brand")]
        public string Brand { get; set; }
        
        [Required, MaxLength(45)]
        [Display(Name ="Model")]
        public string Model { get; set; }
        
        [Required, MaxLength(30)]
        [Display(Name ="Body")]
        public string Body { get; set; }
        
        [Required, MaxLength(30)]
        [Display(Name ="Engine")]
        public string Engine { get; set; }
        
        [Required, MaxLength(150)]
        [Display(Name ="Options")]
        public string Options { get; set; }
        [Display(Name ="Team")]
        public int IdTeam { get; set; }
        
        [ForeignKey("IdTeam")]
        public Team Team { get; set; }
    }
}
