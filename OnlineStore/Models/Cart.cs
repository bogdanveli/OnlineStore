using OnlineStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OnlineStore.Models
{
    public class Cart
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        public virtual ICollection<Item> Items { get; set; }
        public Cart()
        {
            Items = new List<Item>();
        }
    }
}