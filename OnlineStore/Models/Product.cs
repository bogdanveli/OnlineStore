using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineStore.Models
{
    public class Product
    {
        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "The name must be between 3 and 30 chars")]
        public string name { get; set; }

        [Required]
        [Range(1.0,10000.0, ErrorMessage = "The price must be over 1 and less then 10,000")]
        public decimal price  { get; set; }
       
        public string photo { get; set; }
     
      
        [Required]
        [StringLength(300, MinimumLength = 10, ErrorMessage = "The description must be between 10 and 300 chars")]
        public string description { get; set; }
       
        [Required]
        public  string categories { get; set; }

        [Required]
        [Key]
        public int id { get; set; }

    }

}