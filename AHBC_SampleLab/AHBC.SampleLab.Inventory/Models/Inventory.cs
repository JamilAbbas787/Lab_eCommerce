﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AHBC.SampleLab.Inventory.Models
{
    public class Inventory
    {
        [Key]
        public int ID { get; set; }
        public int Quantity { get; set; }



    }
}