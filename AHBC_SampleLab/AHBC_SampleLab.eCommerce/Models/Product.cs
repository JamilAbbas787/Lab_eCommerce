using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AHBC_SampleLab.eCommerce.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string ItemId { get; set; }
        public string Name { get; set; }
        public string Descriptions { get; set; }
        public double Price { get; set; }

    }
}