using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MessageForumTeam.Models
{
    public class Post
    {
        public Guid Id { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Required]
        public string? Title { get; set; }
        public string? Description { get; set; }
        [Display(Name = "User")]
        public string? Author { get; set; }
        [Display(Name = "Posted on")]
        [DataType(DataType.Date)]
        public DateTime DatePosted { get; set; }

        [StringLength(200, MinimumLength = 1)]
        public string? Comments { get; set; }    
        public string? Likes { get; set; }
        public string? Tags { get; set; }



        public string MaxTitleLength()
        {
            //int length = this.Title.Length;
            int maxLength = 20;
            string newTitle = this.Title.Length > maxLength ? this.Title.Substring(0, maxLength) + "..." : this.Title;
            return newTitle;

        }

        public int LikesToInt()
        {
            if (this.Likes == null)
            {
                return 0;
            } else
            {
            string[] LikesArr = this.Likes.Split(" ");
                return LikesArr.Length;
            }
            
        }
    }
}
