﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class Coffee
    {
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]

        public string Title { get; set; }

        [MaxLength(50, ErrorMessage ="Bean Type way too loooooong")]
        [Required]
        public string BeanType { get; set; }
    }
}
