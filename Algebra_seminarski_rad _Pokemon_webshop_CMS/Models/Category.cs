﻿using System.ComponentModel.DataAnnotations;

namespace Algebra_seminarski_rad__Pokemon_webshop_CMS.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}
