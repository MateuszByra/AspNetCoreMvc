using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
namespace OdeToFood.Entities
{
    public enum CuisineType
    {
        None,
        Italian,
        French,
        Japanese,
        American
    }

    public class Restaurant
    {
        public int Id { get; set; }

        [Display(Name="Restaurant Name")]
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
