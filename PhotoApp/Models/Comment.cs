using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoApp.Models
{
    public class Comment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Post ID")]
        public int PostID { get; set; }

        [Required]
        [Display(Name = "Username")]
        public string UserID { get; set; }

        [Required]
        [StringLength(280, ErrorMessage = "Max 280 characters.")]
        public string Content { get; set; }

        [DataType(DataType.DateTime)]
        [Required]
        [Display(Name = "Created Time")]
        public DateTime CommentTime { get; set; }

        [Display(Name = "Comment Likes")]
        [DisplayFormat(NullDisplayText = "No Comment Likes")]
        public HashSet<CommentLike> CommentLikes { get; set; }

        public Post Post { get; set; }
        public User User { get; set; }
    }
}