using System.ComponentModel.DataAnnotations;
using System;

namespace CRUDelicious.Models
{
    public class Dish
    {
        [Key]
        [Required]
        public int DishId {get;set;}
        [Required(ErrorMessage="Name is required.")]
        public string Name {get;set;}
        [Required(ErrorMessage="Chef is required.")]
        public string Chef {get;set;}
        [Required(ErrorMessage="Tastiness is required.")]
        [Range(1,6)]
        public int Tastiness {get;set;}
        [Required(ErrorMessage="Calories are required.")]
        [Range(0,99999)]
        public int Calories {get;set;}
        [Required(ErrorMessage="Description is required.")]
        public string Description {get;set;}
        [Required]
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        [Required]
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}