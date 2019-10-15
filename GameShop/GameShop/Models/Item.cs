using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameShop.Models
{
    public enum ItemCategory { Health, Stamina, Magic};

    public class Item
    {
        public ItemCategory Category { get; set; }

        [DataType("decimal(18,2)")]
        public double Cost { get; set; }

        public string IconURL { get; set; }

        [Key]
        public int ID { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
    }
}