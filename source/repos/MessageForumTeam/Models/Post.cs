using System.ComponentModel.DataAnnotations;

namespace MessageForumTeam.Models
{
    public class Post
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Author { get; set; }
        [DataType(DataType.Date)]
        public DateTime DatePosted { get; set; }
        public List<string>? Comments { get; set; }

        public List<string>? Likes { get; set; }
        public string? Tags { get; set; }


    }
}
