﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Algebra_seminarski_rad__Pokemon_webshop_CMS.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1, 100)]
        public int DisplayOrder { get; set; }
    }
}
