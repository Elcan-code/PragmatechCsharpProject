﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogEntities.Dtos
{
     public class CategoryUpdateDto
    {
        [Required]
        public int Id { get; set; }

        [DisplayName("Category Name")]
        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(70, ErrorMessage = "{0} should not be larger than {1} characters. ")]
        [MinLength(3, ErrorMessage = "{0} must not be less than {1} characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(500, ErrorMessage = "{0} should not be larger than {1} characters. ")]
        [MinLength(3, ErrorMessage = "{0} must not be less than {1} characters.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(500, ErrorMessage = "{0} should not be larger than {1} characters. ")]
        [MinLength(3, ErrorMessage = "{0} must not be less than {1} characters.")]
        public string Note { get; set; }

        [DisplayName("Is active ?")]
        [Required(ErrorMessage = "{0} is required.")]
        public bool IsActive { get; set; }

        [DisplayName("Is deleted ?")]
        [Required(ErrorMessage = "{0} is required.")]
        public bool IsDeleted { get; set; }
    } }
