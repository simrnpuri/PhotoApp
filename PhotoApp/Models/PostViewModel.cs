using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoApp.Models
{
    public class PostViewModel
    {
        [StringLength(400, ErrorMessage = "Maximum 400 characters.")]
        public string Caption { get; set; }

        [Required]
        public IFormFile Image { get; set; }
    }
}
