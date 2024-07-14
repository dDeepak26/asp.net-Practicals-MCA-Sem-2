using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Cars_Detail_Display.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the car make.")]
        public string Make { get; set; }

        [Required(ErrorMessage = "Please enter the car model.")]
        public string Model { get; set; }

        [Range(1900, 2100, ErrorMessage = "Please enter a valid year between 1900 and 2100.")]
        public int Year { get; set; }

        [Required(ErrorMessage = "Please enter the car color.")]
        public string Color { get; set; }
    }
}