using Microsoft.AspNetCore.Mvc.Rendering;

namespace MessageForumTeam.Models
{
    public class PostTagViewModel
    {
        public List<Post>? Posts { get; set; }
        public SelectList? Tags { get; set; }
        public string? PostTag { get; set; }
        public string? SearchString { get; set; }
    }
}
