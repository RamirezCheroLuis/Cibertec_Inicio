using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDeveloper.Model
{
    public class Product
    {
        public int ID { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage = "This First Name is required")]
        public string Name { get; set; }
        [Display(Name = "Price")]
        [Required(ErrorMessage = "This Last Name is required")]
        public double Price { get; set; } = 1;
        public int Quantity { get; set; } = 1;
        public int Stock { get; set; } = 1;
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}",
        //ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "This ExperiredDate is required")]
        public string ExperiredDate { get; set; } = DateTime.Now.ToShortDateString();

    }
}
