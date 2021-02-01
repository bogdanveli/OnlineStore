using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineStore.Models
{
    public class Item
    {
        [Required]
        public string Name { get; set; }

        [Key]
        [Required]
        public int ItemId { get; set; }

        [Required]
        public int ProductId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public int Cart_ID { get; set; }
    }
}