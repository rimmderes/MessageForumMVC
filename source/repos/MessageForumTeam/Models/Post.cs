using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MessageForumTeam.Models
{
    public class Post
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        [Display(Name = "User")]
        public string? Author { get; set; }
        [Display(Name = "Posted on")]
        [DataType(DataType.Date)]
        public DateTime DatePosted { get; set; }
        public string? Comments { get; set; }    
        public string? Likes { get; set; }
        public string? Tags { get; set; }

    }
}
