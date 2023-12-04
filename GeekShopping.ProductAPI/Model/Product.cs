﻿using GeekShopping.ProductAPI.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.ProductAPI.Model
{
    [Table("Product")]
    public class Product : BaseEntity
    {

        
        [Required]
        [StringLength(150)]
        public string? Name { get; set; }

        
        [Required]
        public decimal Price{ get; set; }

        
        [StringLength(500)]
        public string? Description { get; set; }

        
        [StringLength(50)]
        public string? CategoryName { get; set; }

        
        [StringLength(300)]
        public string? ImageURL { get; set; }

    }
}
