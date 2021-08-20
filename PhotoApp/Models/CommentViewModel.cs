using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoApp.Models
{
    public class CommentViewModel
    {
        [Required]
        [StringLength(300, ErrorMessage = "Max 300 characters.")]
        public string Content { get; set; }

        [Required]
        [Display(Name = "Post ID")]
        public int PostID { get; set; }
    }
}

